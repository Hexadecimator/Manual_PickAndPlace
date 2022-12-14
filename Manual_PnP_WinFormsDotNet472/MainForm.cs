using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Manual_PnP_WinFormsDotNet472.Properties;
using SharpDX;
using SharpDX.DirectInput;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manual_PnP_WinFormsDotNet472
{
    public partial class MainForm : Form
    {
        public Joystick gamepad;
        public Timer timer1;
        double x_step = 0;
        double y_step = 0;
        double z_step = 0;

        enum CURRENT_BTN
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
            LEFT_TRIGGER,
            RIGHT_TRIGGER,
            SELECT,
            START,
            A,
            B,
            X,
            Y,
            NONE
        };

        CURRENT_BTN current_btn = CURRENT_BTN.NONE;

        bool LEFT_TRIGGER_PRESSED = false; // not implemented yet
        bool ENABLE_MICRO_STEPPING = false; // controlled by right trigger

        public MainForm()
        {
            InitializeComponent();

            if(initializeGamepad()) startInputTimer();

            initSerial();

            setupVideoDevice();

            initGRBLSettings();
        }

        public void initGRBLSettings()
        {
            // TODO: move this stuff to JSON
            txtXSTEPSIZE.Text = "0.3";
            txtYSTEPSIZE.Text = "0.3";
            txtZSTEPSIZE.Text = "0.3";

            txtXFEEDRATE.Text = "600";
            txtYFEEDRATE.Text = "600";
            txtZFEEDRATE.Text = "600";

            txtXSTEPPERMM.Text = "50";
            txtXSTEPPERMM.Text = "50";
            txtXSTEPPERMM.Text = "50";

            txtGRBLSETTINGPULSEWIDTH.Text = "10";

            tbFOCUSSLIDER.Value = 125;

            pbENABLEMICROSTEPPING.Image = null;
            ENABLE_MICRO_STEPPING = false;
        }

        public void startInputTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 20; // 15Hz = 66ms
                                  // 20Hz = 50ms
                                  // 30Hz = 33ms
                                  // 45Hz = 22ms
                                  // 60Hz = 16ms
            timer1.Tick += (s, e) =>
            {
                try
                {
                    // capture current step values:
                    if(!double.TryParse(txtXSTEPSIZE.Text, out x_step) ||
                       !double.TryParse(txtYSTEPSIZE.Text, out y_step) || 
                       !double.TryParse(txtZSTEPSIZE.Text, out z_step))
                    {
                        log($"Error, unusable value in X/Y/Z step value, aborting movement.");
                        return;
                    }

                    gamepad.Poll();
                    var lastState = gamepad.GetBufferedData(); //only show the last state
                    foreach (var state in lastState)
                    {
                        txtCONTROLLERRAWOUTPUT.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}]: S.V:{state.Value} -- S.O:{state.Offset}\r\n");
                        
                        // while a direction button is held down, the 
                        // offset stays static to the axis of movement (stays X or Y unchanging)
                        // we can skip a lot of processing by determining up-front if the user is
                        // holding down a direction button
                        switch(current_btn)
                        {
                            case (CURRENT_BTN.NONE):
                                break;
                            case (CURRENT_BTN.UP):
                                if (state.Offset == JoystickOffset.X && !ENABLE_MICRO_STEPPING) // right trigger will control micro stepping
                                {
                                    move_minus_Y(y_step);
                                    return;
                                }
                                current_btn = CURRENT_BTN.NONE;
                                break;
                            case (CURRENT_BTN.DOWN):
                                if (state.Offset == JoystickOffset.X && !ENABLE_MICRO_STEPPING)
                                {
                                    move_plus_Y(y_step);
                                    return;
                                }
                                current_btn = CURRENT_BTN.NONE;
                                break;
                            case (CURRENT_BTN.LEFT):
                                if (state.Offset == JoystickOffset.Y && !ENABLE_MICRO_STEPPING)
                                {
                                    move_plus_X(x_step);
                                    return;
                                }
                                current_btn = CURRENT_BTN.NONE;
                                break;
                            case (CURRENT_BTN.RIGHT):
                                if (state.Offset == JoystickOffset.Y && !ENABLE_MICRO_STEPPING)
                                {
                                    move_minus_X(x_step);
                                    return;
                                }
                                current_btn = CURRENT_BTN.NONE;
                                break;
                        }

                        if (state.Offset == JoystickOffset.X || state.Offset == JoystickOffset.Y)
                        {
                            if(state.Value == 0xFFFF) // 65535 (XR pressed / YD pressed)
                            {
                                if(state.Offset == JoystickOffset.X)
                                {
                                    current_btn = CURRENT_BTN.RIGHT;
                                    log("RIGHT Pressed");
                                    move_minus_X(x_step);
                                    //log($"{state}");
                                }
                                else if(state.Offset == JoystickOffset.Y)
                                {
                                    current_btn = CURRENT_BTN.DOWN;
                                    log("DOWN Pressed");
                                    move_plus_Y(y_step);
                                }
                            }
                            else if(state.Value == 0x7FFF) //  32767
                            {
                                //log($"{state}");
                                // the controller spams this code like crazy all the time
                            }
                            else if(state.Value == 0x0000) // YU pressed / XL pressed
                            {
                                if (state.Offset == JoystickOffset.X)
                                {
                                    current_btn = CURRENT_BTN.LEFT;
                                    log("LEFT Pressed");
                                    move_plus_X(x_step);
                                    //log($"{state}");
                                }
                                else if (state.Offset == JoystickOffset.Y)
                                {
                                    current_btn = CURRENT_BTN.UP;
                                    log("UP Pressed");
                                    move_minus_Y(y_step);
                                }
                            }
                        }
                        else if (state.Offset == JoystickOffset.Buttons0 ||
                                 state.Offset == JoystickOffset.Buttons1 ||
                                 state.Offset == JoystickOffset.Buttons2 ||
                                 state.Offset == JoystickOffset.Buttons3 ||
                                 state.Offset == JoystickOffset.Buttons4 ||
                                 state.Offset == JoystickOffset.Buttons5 ||
                                 state.Offset == JoystickOffset.Buttons6 ||
                                 state.Offset == JoystickOffset.Buttons7)
                        {
                            if(state.Value == 0x80) // 128 --> Button PRESSED
                            {
                                switch(state.Offset)
                                {
                                    case (JoystickOffset.Buttons0):
                                        current_btn = CURRENT_BTN.A;
                                        log("BTN-A Pressed");
                                        break;
                                    case (JoystickOffset.Buttons1):
                                        current_btn = CURRENT_BTN.B;
                                        log("BTN-B Pressed");
                                        move_plus_Z(z_step);
                                        break;
                                    case (JoystickOffset.Buttons2):
                                        current_btn = CURRENT_BTN.X;
                                        log("BTN-X Pressed");
                                        move_minus_Z(z_step);
                                        break;
                                    case (JoystickOffset.Buttons3):
                                        current_btn = CURRENT_BTN.Y;
                                        log("BTN-Y Pressed");
                                        break;
                                    case (JoystickOffset.Buttons4):
                                        current_btn = CURRENT_BTN.LEFT_TRIGGER;
                                        LEFT_TRIGGER_PRESSED = !LEFT_TRIGGER_PRESSED;
                                        log($"BTN-TL Pressed: {LEFT_TRIGGER_PRESSED}");
                                        break;
                                    case (JoystickOffset.Buttons5):
                                        current_btn = CURRENT_BTN.RIGHT_TRIGGER;
                                        ENABLE_MICRO_STEPPING = !ENABLE_MICRO_STEPPING;
                                        if (ENABLE_MICRO_STEPPING) pbENABLEMICROSTEPPING.Image = Resources.micro_stepping_enabled;
                                        else pbENABLEMICROSTEPPING.Image = null;
                                        log($"BTN-TR Pressed: {ENABLE_MICRO_STEPPING}");
                                        break;
                                    case (JoystickOffset.Buttons6):
                                        current_btn = CURRENT_BTN.SELECT;
                                        log("BTN-SELECT Pressed");
                                        break;
                                    case (JoystickOffset.Buttons7):
                                        current_btn = CURRENT_BTN.START;
                                        log("BTN-START Pressed");
                                        break;
                                    default:
                                        current_btn = CURRENT_BTN.NONE;
                                        break;
                                }
                            }
                            else if(state.Value == 0x0)
                            {
                                //log($"{state}");
                                // idk
                            }
                        }
                    }   
                }
                catch (Exception ex)
                {
                    log($"[Error] Gamepad disconnected? Stopping timer..\r\n{ex.Message}");
                    timer1.Stop();
                    gamepad.Dispose();
                }
            };
            timer1.Enabled = true;
        }

        public void log(string output)
        {
            string op = $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}]: {output}"; 
            txtCONTROLLEROUTPUT.AppendText($"{op}\r\n");
        }

        public void logSerial(string output)
        {
            string op = $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}]: {output}";
            txtSERIALOUT.AppendText($"{op}\r\n");
        }

        public bool initializeGamepad()
        {
            var directInput = new DirectInput();
            var gamepadGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                        DeviceEnumerationFlags.AllDevices))
                gamepadGuid = deviceInstance.InstanceGuid;

            if (gamepadGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    gamepadGuid = deviceInstance.InstanceGuid;

            if (gamepadGuid == Guid.Empty)
            {
                txtCONTROLLEROUTPUT.AppendText("");
                log("[ERROR] No Gamepad found!");
                return false;
            }
            gamepad = new Joystick(directInput, gamepadGuid);
            log($"Found Gamepad with GUID: {gamepadGuid}");
            gamepad.Properties.BufferSize = 128;
            gamepad.Acquire();
            return true;
        }

        private void rECONNECTCONTROLLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (initializeGamepad()) startInputTimer();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: SAVE SETTINGS TO JSON HERE
            Environment.Exit(69);
        }

        private void btnTOGGLE_Click(object sender, EventArgs e)
        {
            connectToSelectedSerialPort();
        }

        private void btnDISCONNECTSERIAL_Click(object sender, EventArgs e)
        {
            disconnectSerial();
        }

        private void btnRESCANSERIAL_Click(object sender, EventArgs e)
        {
            initSerial();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gCODEOPTIONS();
        }

        private void btnSENDSERIAL_Click(object sender, EventArgs e)
        {
            sendManualSerialPacket();
        }

        private void txtSERIALINPUT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) sendManualSerialPacket();
        }

        private void btnVIDEODISCONNECT_Click(object sender, EventArgs e)
        {
            disconnectFromVideoDevice();
        }

        private void btnVIDEOCONNECT_Click(object sender, EventArgs e)
        {
            connectToSelectedVideoDevice();
        }

        private void btnRESCANVIDEODEVICES_Click(object sender, EventArgs e)
        {
            setupVideoDevice();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: SAVE SETTINGS TO JSON HERE
            disconnectFromVideoDevice();
            disconnectSerial();
        }

        private void tbFOCUSSLIDER_ValueChanged(object sender, EventArgs e)
        {
            changeVideoCameraFocus();
        }

        private void chkAUTOFOCUS_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAUTOFOCUS.Checked)
            {
                changeVideoCameraFocus(true);
            }
            else
            {
                changeVideoCameraFocus(); // will take current value of slider bar
            }
        }

        private void txtXSTEPSIZE_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtXSTEPSIZE.Text, out double x))
            {
                txtXSTEPSIZE.Text = "0.3";
                MessageBox.Show("Enter a reasonable step size in millimeters.\r\nTODO: Define \"reasonable\"");
            }
        }

        private void txtYSTEPSIZE_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtYSTEPSIZE.Text, out double x))
            {
                txtYSTEPSIZE.Text = "0.3";
                MessageBox.Show("Enter a reasonable step size in millimeters.\r\nTODO: Define \"reasonable\"");
            }
        }

        private void txtZSTEPSIZE_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtZSTEPSIZE.Text, out double x))
            {
                txtZSTEPSIZE.Text = "0.3";
                MessageBox.Show("Enter a reasonable step size in millimeters.\r\nTODO: Define \"reasonable\"");
            }
        }

        private void btnJOGXPLUS_Click(object sender, EventArgs e)
        {
            move_plus_X(x_step);
        }

        private void btnJOGXMINUS_Click(object sender, EventArgs e)
        {
            move_minus_X(x_step);
        }

        private void btnJOGYPLUS_Click(object sender, EventArgs e)
        {
            move_plus_Y(y_step);
        }

        private void btnJOGYMINUS_Click(object sender, EventArgs e)
        {
            move_minus_Y(y_step);
        }

        private void btnJOGZPLUS_Click(object sender, EventArgs e)
        {
            move_plus_Z(z_step);
        }

        private void btnJOGZMINUS_Click(object sender, EventArgs e)
        {
            move_minus_Z(z_step);
        }

        private void btnSENDGRBLSETTINGSTOMICROCONTROLLER_Click(object sender, EventArgs e)
        {
            sendGRBRSettings();
        }

        private void btnCLEARLOGS_Click(object sender, EventArgs e)
        {
            txtCONTROLLEROUTPUT.Clear();
            txtSERIALOUT.Clear();   
        }
    }
}
