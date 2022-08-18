using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.DirectInput;

namespace Manual_PnP_WinFormsDotNet472
{
    public partial class MainForm : Form
    {
        public Joystick gamepad;
        public Timer timer1;

        public MainForm()
        {
            InitializeComponent();

            if(initializeGamepad()) startInputTimer();

            initSerial();
        }

        public void startInputTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 30; // Hz
            timer1.Tick += (s, e) =>
            {
                try
                {
                    gamepad.Poll();
                    var lastState = gamepad.GetBufferedData(); //only show the last state
                    foreach (var state in lastState)
                    {
                        if (state.Offset == JoystickOffset.X || state.Offset == JoystickOffset.Y)
                        {
                            if(state.Value == 0xFFFF) // 65535 (XR pressed / YD pressed)
                            {
                                if(state.Offset == JoystickOffset.X)
                                {
                                    log("RIGHT Pressed");
                                    move_plus_X(1);
                                    //log($"{state}");
                                }
                                else if(state.Offset == JoystickOffset.Y)
                                {
                                    log("DOWN Pressed");
                                    move_minus_Y(1);
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
                                    log("LEFT Pressed");
                                    move_minus_X(1);
                                    //log($"{state}");
                                }
                                else if (state.Offset == JoystickOffset.Y)
                                {
                                    log("UP Pressed");
                                    move_plus_Y(1);
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
                                        log("BTN-A Pressed");
                                        break;
                                    case (JoystickOffset.Buttons1):
                                        log("BTN-B Pressed");
                                        move_minus_Z(1);
                                        break;
                                    case (JoystickOffset.Buttons2):
                                        log("BTN-X Pressed");
                                        move_plus_Z(1);
                                        break;
                                    case (JoystickOffset.Buttons3):
                                        log("BTN-Y Pressed");
                                        break;
                                    case (JoystickOffset.Buttons4):
                                        log("BTN-TL Pressed");
                                        break;
                                    case (JoystickOffset.Buttons5):
                                        log("BTN-TR Pressed");
                                        break;
                                    case (JoystickOffset.Buttons6):
                                        log("BTN-SELECT Pressed");
                                        break;
                                    case (JoystickOffset.Buttons7):
                                        log("BTN-START Pressed");
                                        break;
                                    default:
                                        break;
                                }
                                //log($"{state}");
                            }
                            else if(state.Value == 0x0)
                            {
                                //log($"{state}");
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
    }
}
