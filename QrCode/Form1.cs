using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.IO;

namespace QrCode
{
    public partial class Baseform : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        public Baseform()
        {
            InitializeComponent();
        }

        private void Baseform_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                Camerabox.Items.Add(Device.Name);
            Camerabox.SelectedIndex = 0;
        }

        private void Capture_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Camerabox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            Timer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Qrpicbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void Timer_tick(object sender, EventArgs e)
        {
            if (Qrpicbox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)Qrpicbox.Image);

                if (result != null)
                {
                    StreamWriter Decode;
                    Decode = File.AppendText("QRCODE FILE.txt");
                    Decode.WriteLine("QRCODE INFORMATION");
                    Decode.WriteLine(" ");
                    Decode.WriteLine("Date:" + " " + DateTime.Now.ToString("MM/dd/yyyy"));
                    Decode.WriteLine("Time:" + " " + DateTime.Now.ToString("h:mm:ss tt"));
                    Decode.WriteLine(" ");
                    Decode.WriteLine(result.Text);
                    Decode.WriteLine(" ");
                    Decode.WriteLine(" ");
                    Decode.Close();
                    MessageBox.Show("Information Saved.");
                }
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "QRCODE SCANNER",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

                else if (iExit == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QRCODE SCANNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
