using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manual_PnP_WinFormsDotNet472
{
    public partial class MainForm
    {
        public FilterInfoCollection filterInfoCollection;
        public VideoCaptureDevice videoCaptureDevice;
        public Image img;

        public void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if(pbVIDEOOUT.Image != null) pbVIDEOOUT.Image.Dispose();
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pbVIDEOOUT.Image = bit;
        }

        public void setupVideoDevice()
        {
            cbVIDEODEVICE.Items.Clear();
            
            try
            {
                #region Devices
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cbVIDEODEVICE.Items.Add(filterInfo.Name);
                }
                cbVIDEODEVICE.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
                #endregion
            }
            catch (Exception ex)
            {
                log($"ERROR! No video device detected?\r\n{ex.Message}");
            }
        }

        public void connectToSelectedVideoDevice()
        {
            try
            {
                var cam = filterInfoCollection[cbVIDEODEVICE.SelectedIndex].MonikerString;
                videoCaptureDevice = new VideoCaptureDevice(cam);
                videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;

                VideoCapabilities[] videoCapabilities = videoCaptureDevice.VideoCapabilities;
                //log($"Total Capabilities: {videoCapabilities.Length}");
                //foreach (var c in videoCapabilities)
                //{
                //    log($"Video Capability - {c.FrameSize}, {c.AverageFrameRate}");
                //}

                videoCaptureDevice.VideoResolution = videoCapabilities[16];
                img = pbVIDEOOUT.Image;
                videoCaptureDevice.Start();
            }
            catch (Exception ex)
            {
                log($"ERROR! Could not connect to video device:\r\n{ex.Message}");
            }
        }

        public void disconnectFromVideoDevice()
        {
            videoCaptureDevice.SignalToStop();
            pbVIDEOOUT.Image = null;
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }
    }
}
