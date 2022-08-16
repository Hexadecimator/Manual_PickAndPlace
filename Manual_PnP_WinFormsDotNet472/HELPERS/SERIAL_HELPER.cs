using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manual_PnP_WinFormsDotNet472
{
    public partial class MainForm
    {
        public static SerialPort _SP = new SerialPort();
        public bool serial_port_initialized = false;

        public void initSerial()
        {
            cbSERIALPORTS.Items.Clear();
            
            _SP.BaudRate = 115200;
            _SP.DataBits = 8;
            _SP.Parity = System.IO.Ports.Parity.None;
            _SP.Encoding = System.Text.Encoding.Default;
            _SP.StopBits = StopBits.One;

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

            if (_SP.IsOpen) _SP.Close();

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
        }

        public void toggleSelectedSerialPort()
        {
            if (!serial_port_initialized) initSerial();

            if (_SP.IsOpen)
            {
                log($"Closed {_SP.PortName} Serial Communication Port.\r\n");
                _SP.Close();
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
    }
}
