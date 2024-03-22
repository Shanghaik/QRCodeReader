using AForge.Video.DirectShow;
using ZXing;


namespace QRCodeReader
{
    public partial class Form1 : Form
    {
        // Tạo ra 2 đối tượng 
        FilterInfoCollection camCollection; // danh sách các cam của máy
        VideoCaptureDevice videoCaptureDevice;
        int done = 0; // kiểm tra khi quét thành công
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in camCollection)
            {
                cbb_Cam.Items.Add(item.Name);
            }
            cbb_Cam.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptb_Image.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Cho phép load tất cả các cam có thể lên trên Combobox
            videoCaptureDevice = new VideoCaptureDevice(camCollection[cbb_Cam.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start(); // Khởi chạy
            // Đọc QR code
            timer1.Start();
            if(done == 1)
            {
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            videoCaptureDevice = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ptb_Image.Image != null)
            {
                var reader = new BarcodeReader();
                // Anhr trên máy
                var image = Image.FromFile(@"C:\Users\Acer\Desktop\bao.png");
                var result = reader.Decode((Bitmap)ptb_Image.Image);
                // Lấy ảnh từ picturebox
                if(result != null)
                {
                    MessageBox.Show(result.ToString());
                    done = 1;
                    //ptb_Image = null;
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                    videoCaptureDevice = null;
                }
            }
        }
    }
}