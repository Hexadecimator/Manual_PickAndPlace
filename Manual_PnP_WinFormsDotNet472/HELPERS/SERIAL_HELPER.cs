using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Net.Sockets;

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
                log("Closed Serial Port");
            } 
            else
            {
                log("Serial port was not open.");
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
        }

        public bool move_plus_X(int distance_mm)
        {
            // G21G91G1X1F10
            string packet = "G21G91G1X0.1F10"; // hardcode 0.1mm for all axis for now
            try
            {
                _SP.WriteLine(packet.Trim());
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_X:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_X(int distance_mm)
        {
            // G21G91G1X-1F10
            string packet = "G21G91G1X-0.1F10";
            try
            {
                _SP.WriteLine(packet);
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_minus_X:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_plus_Y(int distance_mm)
        {
            // G21G91G1Y1F10
            string packet = "G21G91G1Y0.1F10";
            try
            {
                _SP.WriteLine(packet);
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_Y:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_Y(int distance_mm)
        {
            // G21G91G1Y-1F10
            string packet = "G21G91G1Y-0.1F10";
            try
            {
                _SP.WriteLine(packet);
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_minus_Y:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_plus_Z(int distance_mm)
        {
            // G21G91G1Z1F10
            string packet = "G21G91G1Z0.1F10";
            try
            {
                _SP.WriteLine(packet);
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot move_plus_Z:\r\n{ex.Message}");
                return false;
            }

            return true;
        }

        public bool move_minus_Z(int distance_mm)
        {
            // G21G91G1Z-1F10
            string packet = "G21G91G1Z-0.1F10";
            try
            {
                _SP.WriteLine(packet);
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
            _SP.WriteLine("$$");
        }

        public void sendManualSerialPacket()
        {
            try
            {
                _SP.WriteLine(txtSERIALINPUT.Text.Trim());
            }
            catch (Exception ex)
            {
                log($"[ERROR] Cannot write packet [{txtSERIALINPUT.Text.Trim()}]:\r\n{ex.Message}");
            }
            
        }
    }
}
