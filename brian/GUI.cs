using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace cam_aforge1
{
    public partial class GUI : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        GUIElements myCanvas;

        int tickCount = 0;
        public int x_start_coord;
        public int y_start_coord;
        public int begin_r;
        public int begin_r_2;
        public int begin_G;
        public int begin_G_2;
        public int begin_b;
        public int begin_b_2;
        public int start_pixel_color_flag = 0;
        public int bluesquareflag = 1;

        //Constructs the gui
        public GUI()
        {
            myCanvas = new GUIElements(this);
            InitializeComponent();
            //Add custom events here, ie
            viewFinder.MouseDown += new MouseEventHandler(viewFinder_MouseDown);
        }

        public void viewFinder_MouseDown(object sender, MouseEventArgs e)
        {
            x_start_coord = e.X;
            y_start_coord = e.Y;
            start_pixel_color_flag = 1;
        }

        //public int First_tracked_color(int coord_x, int coord_y)
        //{

        //    return 1;
        //}

        //Generally don't have to change this
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                vidSrc.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    vidSrc.Items.Add(device.Name);
                }
                vidSrc.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                vidSrc.Items.Add("No capture device on your system");
            }
        }

        //Generally don't have to change this
        private void rfsh_Click(object sender, EventArgs e)
        {
            getCamList();
        }

        //Generally don't have to change this
        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "&Start")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[vidSrc.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    CloseVideoSource();
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    //videoSource.DesiredFrameRate = 10;
                    videoSource.Start();
                    label2.Text = "Device running...";
                    start.Text = "&Stop";
                    timer1.Enabled = true;
                    
                }
                else
                {
                    label2.Text = "Error: No Device selected.";
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    timer1.Enabled = false;
                    CloseVideoSource();
                    label2.Text = "Device stopped.";
                    start.Text = "&Start";                    
                }
            }
        }

        //Generally don't have to change this
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
          
            int r = myCanvas.change_panel_color(img, 1);
            int G = myCanvas.change_panel_color(img, 2);
            int b = myCanvas.change_panel_color(img, 3);

            if (start_pixel_color_flag == 1)
            {
                if (bluesquareflag == 1)
                {
                    begin_r = get_first_color(img, 1);
                    begin_G = get_first_color(img, 2);
                    begin_b = get_first_color(img, 3);
                }
                else
                {
                    begin_r_2 = get_first_color(img, 1);
                    begin_G_2 = get_first_color(img, 2);
                    begin_b_2 = get_first_color(img, 3);
                }
                //Console.WriteLine(begin_r_2 + " " + begin_G_2 + " " + begin_b_2);
                start_pixel_color_flag = 0;
                panel1.BackColor = Color.FromArgb(begin_r, begin_G, begin_b);
                panel2.BackColor = Color.FromArgb(begin_r_2, begin_G_2, begin_b_2);
            }

            //Console.WriteLine(start_pixel_color_flag);
            myCanvas.g = Graphics.FromImage(img);
            myCanvas.Run(r, G, b, img, begin_r, begin_r_2, begin_G, begin_G_2, begin_b, begin_b_2);

            viewFinder.Image = img;
            myCanvas.g.Dispose();
        }

        //Generally don't have to change this
        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        //Generally don't have to change this
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Device running... " + videoSource.FramesReceived.ToString() + " FPS";
        }

        //Generally don't have to change this
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }
        
        //Button for changing camera control
        private void ctrl_Click(object sender, EventArgs e)
        {
            CamControl.show_Controls();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Step 7: Let's activate this button. Uncomment lines 143-144 to add functionality
            //to the button.
            tickCount++;
            countDisp.Text = tickCount.ToString();

            //Step 8: The button_Click method can be used to call a method that you wrote
            //on the GUIElements Class. Uncomment line 149 to call the ButtonWasClicked method
            //from GUIElements.
            myCanvas.ButtonWasClicked();

            //Note that the syntax for calling methods in the GUIElements class is always in the form of
            //`myCanvas.NameOfMethod();`.
        }

        public int get_first_color (Bitmap img, int start_sel)
        {
            Color pixelColor = img.GetPixel(x_start_coord+5, y_start_coord+5);
            int starting_begin_r = pixelColor.R;
            int starting_begin_G = pixelColor.G;
            int starting_begin_b = pixelColor.B;

            if (start_sel == 1)
            {
                return starting_begin_r;
            }
            else if (start_sel == 2)
            {
                return starting_begin_G;
            }
            else if (start_sel == 3)
            {
                return starting_begin_b;
            }
            else
            {
                return 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bluesquareflag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bluesquareflag = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}