using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Reflection;

namespace Manual_PnP_WinFormsDotNet472
{
    public partial class MainForm
    {
        public static SerialPort _SP = new SerialPort();
        public bool serial_port_initialized = false;

        public void initSerial()
        {
            cbSERIALPORTS.Items.Clear();
            
            _SP.BaudRate = 38400;
            _SP.DataBits = 8;
            _SP.Parity = System.IO.Ports.Parity.None;
            _SP.Encoding = System.Text.Encoding.Default;
            _SP.StopBits = StopBits.One;
            _SP.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Populate a list of active serial ports:
            string[] COMports = SerialPort.GetPortNames();
            Array.Sort(COMports);

            foreach (string s in COMports)
            {
                cbSERIALPORTS.Items.Add(s);
            }

            cbSERIALPORTS.SelectedIndex = 0;
            serial_port_initialized = true;
        }

        public delegate void SetTextDelegate(string text);
        private void si_DataReceived(string data)
        {
            logSerial(data);
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string inSerialData = _SP.ReadLine();
                inSerialData.Trim('\r', '\n');
                this.BeginInvoke(new SetTextDelegate(si_DataReceived), new object[] { inSerialData });
            }
            catch (Exception ex)
            {
                // Probably killed the COM port in the middle of a read operation
                log($"Error in Serial Read Function: {ex.Message}");
            }
        }

        public void disconnectSerial()
        {
            if (_SP.IsOpen)
            {
                _SP.Close();
                //log("Closed Serial Port"); // cross thread errors from this
            } 
            else
            {
                log("Serial port was not open.");
            }
        }

        /*
         * Example of GRBL Settings Output:
            $0=50.000 (x, step/mm)
            $1=50.000 (y, step/mm)
            $2=50.000 (z, step/mm)
            $3=10 (step pulse, usec)
            $4=250.000 (default feed, mm/min)
            $5=500.000 (default seek, mm/min)
            $6=192 (step port invert mask, int:11000000)
            $7=25 (step idle delay, msec)
            $8=10.000 (acceleration, mm/sec^2)
            $9=0.050 (junction deviation, mm)
            $10=0.100 (arc, mm/segment)
            $11=25 (n-arc correction, int)
            $12=3 (n-decimals, int)
            $13=0 (report inches, bool)
            $14=1 (auto start, bool)
            $15=0 (invert step enable, bool)
            $16=0 (hard limits, bool)
            $17=0 (homing cycle, bool)
            $18=0 (homing dir invert mask, int:00000000)
            $19=25.000 (homing feed, mm/min)
            $20=250.000 (homing seek, mm/min)
            $21=100 (homing debounce, msec)
            $22=1.000 (homing pull-off, mm)
        */
        public void sendGRBRSettings()
        {
            double x_s, y_s, z_s, us;

            if(!double.TryParse(txtXSTEPPERMM.Text, out x_s) ||
               !double.TryParse(txtYSTEPPERMM.Text, out y_s) ||
               !double.TryParse(txtZSTEPPERMM.Text, out z_s) ||
               !double.TryParse(txtGRBLSETTINGPULSEWIDTH.Text, out us))
            {
                log($"GRBL settings wrong format. Check settings.");
                return;
            }

            
            string packet = $"$0={x_s}{_SP.NewLine}$1={y_s}{_SP.NewLine}$2={z_s}{_SP.NewLine}$3={us}{_SP.NewLine}"; 


            logSerial($"Initializing Stepper Motor Settings:\r\n{packet}");

            try
            {
                _SP.WriteLine(packet);
                _SP.WriteLine("$$");
            }
            catch (Exception ex)
            {
                log($"Error, could not send GRBL settings to microcontroller:\r\n{ex.Message}");
            }
        }

        public void connectToSelectedSerialPort()
        {
            if (!serial_port_initialized) initSerial();

            string port = cbSERIALPORTS.SelectedItem.ToString();

            if (_SP.IsOpen)
            {
                log($"Closed connection to serial port: {_SP.PortName}");
                _SP.Close();
                return;
            } 

            _SP.PortName = port;
            try
            {
                _SP.Open();
            }
            catch
            {
                log($"ERROR OPENING {_SP.PortName} Serial Communication Port.\r\n");
                return;
            }
            log($"Connected to serial port: {_SP.PortName}");
            _SP.WriteLine("\n");
        }

        public void toggleSelectedSerialPort()
        {
            if (!serial_port_initialized) initSerial();

            if (_SP.IsOpen)
            {
                log($"Closed {_SP.PortName} Serial Communication Port.\r\n");
                _SP.Close();
                return;
            } 
            else
            {
                try
                {
                    string port = cbSERIALPORTS.SelectedItem.ToString();
                    _SP.PortName = port;
                    _SP.Open();
                }
                catch
                {
                    log($"ERROR OPENING {_SP.PortName} Serial Communication Port.\r\n");
                    return;
                }
            }
            log($"OPENED {_SP.PortName} Serial Communication Port.\r\n");
            _SP.WriteLine("\n");
        }

        public bool move_plus_X(double distance_mm)
        {
            // G21G91G1X1F10;
            if(!double.TryParse(txtXFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1X{Math.Abs(Math.Round(distance_mm, 2))}F{fr}";
            try
            {
                _SP.WriteLine(packet.Trim());
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_X:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_X(double distance_mm)
        {
            // G21G91G1X-1F10
            if (!double.TryParse(txtXFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1X{Math.Abs(Math.Round(distance_mm, 2)) * -1}F{fr}";
            try
            {
                _SP.WriteLine(packet);
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_minus_X:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_plus_Y(double distance_mm)
        {
            // G21G91G1Y1F10
            if (!double.TryParse(txtYFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1Y{Math.Abs(Math.Round(distance_mm, 2))}F{fr}";
            try
            {
                _SP.WriteLine(packet);
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_Y:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_Y(double distance_mm)
        {
            // G21G91G1Y-1F10
            if (!double.TryParse(txtYFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1Y{Math.Abs(Math.Round(distance_mm, 2)) * -1}F{fr}";
            try
            {
                _SP.WriteLine(packet);
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_minus_Y:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_plus_Z(double distance_mm)
        {
            // G21G91G1Z1F10
            if (!double.TryParse(txtZFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1Z{Math.Abs(Math.Round(distance_mm, 2))}F{fr}";
            try
            {
                _SP.WriteLine(packet);
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_Z:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_Z(double distance_mm)
        {
            // G21G91G1Z-1F10
            if (!double.TryParse(txtZFEEDRATE.Text, out double fr))
            {
                log("Error, cannnot interpret feed rate value. Check options.");
                return false;
            }
            string packet = $"G21G91G1Z{Math.Abs(Math.Round(distance_mm, 2)) * -1}F{fr}";
            try
            {
                _SP.WriteLine(packet);
                logSerial($"Sent Packet [{packet}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_minus_Z:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public void gCODEOPTIONS()
        {
            try
            {
                _SP.WriteLine("$$");
                logSerial($"Sent Packet [$$]");
            }
            catch (Exception ex)
            {
                log($"Error communicating with serial:\r\n{ex.Message}");
            }  
        }

        public void sendManualSerialPacket()
        {
            try
            {
                _SP.WriteLine(txtSERIALINPUT.Text.Trim());
                logSerial($"Sent Packet [{txtSERIALINPUT.Text.Trim()}]");
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot write packet [{txtSERIALINPUT.Text.Trim()}]:\r\n{ex.Message}");
            }
            
        }
    }
}
