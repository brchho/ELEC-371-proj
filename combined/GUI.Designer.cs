namespace cam_aforge1
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.viewFinder = new System.Windows.Forms.PictureBox();
            this.vidSrc = new System.Windows.Forms.ComboBox();
            this.vidSrcLabel = new System.Windows.Forms.Label();
            this.rfsh = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.fps = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ctrl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.countDisp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blue = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minDisp = new System.Windows.Forms.Label();
            this.secDisp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.stop_time = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinder)).BeginInit();
            this.fps.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewFinder
            // 
            this.viewFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFinder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewFinder.Location = new System.Drawing.Point(294, 14);
            this.viewFinder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewFinder.Name = "viewFinder";
            this.viewFinder.Size = new System.Drawing.Size(1037, 731);
            this.viewFinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewFinder.TabIndex = 0;
            this.viewFinder.TabStop = false;
            // 
            // vidSrc
            // 
            this.vidSrc.FormattingEnabled = true;
            this.vidSrc.Location = new System.Drawing.Point(18, 40);
            this.vidSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vidSrc.Name = "vidSrc";
            this.vidSrc.Size = new System.Drawing.Size(234, 28);
            this.vidSrc.TabIndex = 1;
            // 
            // vidSrcLabel
            // 
            this.vidSrcLabel.AutoSize = true;
            this.vidSrcLabel.Location = new System.Drawing.Point(14, 14);
            this.vidSrcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vidSrcLabel.Name = "vidSrcLabel";
            this.vidSrcLabel.Size = new System.Drawing.Size(147, 20);
            this.vidSrcLabel.TabIndex = 2;
            this.vidSrcLabel.Text = "Select video source";
            // 
            // rfsh
            // 
            this.rfsh.Location = new System.Drawing.Point(20, 95);
            this.rfsh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rfsh.Name = "rfsh";
            this.rfsh.Size = new System.Drawing.Size(102, 48);
            this.rfsh.TabIndex = 3;
            this.rfsh.Text = "&Refresh";
            this.rfsh.UseVisualStyleBackColor = true;
            this.rfsh.Click += new System.EventHandler(this.rfsh_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(152, 95);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 48);
            this.start.TabIndex = 4;
            this.start.Text = "&Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // fps
            // 
            this.fps.Controls.Add(this.label2);
            this.fps.Location = new System.Drawing.Point(18, 222);
            this.fps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fps.Name = "fps";
            this.fps.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fps.Size = new System.Drawing.Size(232, 42);
            this.fps.TabIndex = 6;
            this.fps.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device ready..";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrl
            // 
            this.ctrl.Location = new System.Drawing.Point(18, 152);
            this.ctrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(102, 48);
            this.ctrl.TabIndex = 7;
            this.ctrl.Text = "&Control";
            this.ctrl.UseVisualStyleBackColor = true;
            this.ctrl.Click += new System.EventHandler(this.ctrl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 291);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(10, 360);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(112, 37);
            this.countLabel.TabIndex = 11;
            this.countLabel.Text = "Count:";
            // 
            // countDisp
            // 
            this.countDisp.AutoSize = true;
            this.countDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDisp.Location = new System.Drawing.Point(126, 360);
            this.countDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countDisp.Name = "countDisp";
            this.countDisp.Size = new System.Drawing.Size(35, 37);
            this.countDisp.TabIndex = 12;
            this.countDisp.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 401);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 38);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blue.Location = new System.Drawing.Point(140, 294);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(66, 49);
            this.blue.TabIndex = 14;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.red.Location = new System.Drawing.Point(212, 294);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(64, 51);
            this.red.TabIndex = 15;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(17, 458);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 38);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 514);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Timer:";
            // 
            // minDisp
            // 
            this.minDisp.AutoSize = true;
            this.minDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDisp.Location = new System.Drawing.Point(114, 514);
            this.minDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minDisp.Name = "minDisp";
            this.minDisp.Size = new System.Drawing.Size(35, 37);
            this.minDisp.TabIndex = 17;
            this.minDisp.Text = "0";
            this.minDisp.Click += new System.EventHandler(this.minDisp_Click);
            // 
            // secDisp
            // 
            this.secDisp.AutoSize = true;
            this.secDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secDisp.Location = new System.Drawing.Point(173, 514);
            this.secDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secDisp.Name = "secDisp";
            this.secDisp.Size = new System.Drawing.Size(35, 37);
            this.secDisp.TabIndex = 18;
            this.secDisp.Text = "0";
            this.secDisp.Click += new System.EventHandler(this.secDisp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(14, 572);
            this.start_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(84, 29);
            this.start_time.TabIndex = 20;
            this.start_time.Text = "Start";
            this.start_time.UseVisualStyleBackColor = true;
            this.start_time.Click += new System.EventHandler(this.start_time_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(196, 572);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(84, 29);
            this.reset.TabIndex = 21;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stop_time
            // 
            this.stop_time.Location = new System.Drawing.Point(105, 572);
            this.stop_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stop_time.Name = "stop_time";
            this.stop_time.Size = new System.Drawing.Size(84, 29);
            this.stop_time.TabIndex = 22;
            this.stop_time.Text = "Stop";
            this.stop_time.UseVisualStyleBackColor = true;
            this.stop_time.Click += new System.EventHandler(this.stop_time_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 765);
            this.Controls.Add(this.stop_time);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secDisp);
            this.Controls.Add(this.minDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countDisp);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rfsh);
            this.Controls.Add(this.vidSrcLabel);
            this.Controls.Add(this.vidSrc);
            this.Controls.Add(this.viewFinder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI";
            this.Text = "Orthoscope/Arthroscope Camera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.viewFinder)).EndInit();
            this.fps.ResumeLayout(false);
            this.fps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox viewFinder;
        private System.Windows.Forms.ComboBox vidSrc;
        private System.Windows.Forms.Label vidSrcLabel;
        private System.Windows.Forms.Button rfsh;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox fps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ctrl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countDisp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minDisp;
        private System.Windows.Forms.Label secDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button start_time;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button stop_time;
    }
}