namespace QRCodeReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptb_Image = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.cbb_Cam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Image
            // 
            this.ptb_Image.Location = new System.Drawing.Point(12, 12);
            this.ptb_Image.Name = "ptb_Image";
            this.ptb_Image.Size = new System.Drawing.Size(522, 508);
            this.ptb_Image.TabIndex = 0;
            this.ptb_Image.TabStop = false;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(560, 117);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(194, 48);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Bật cam";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cbb_Cam
            // 
            this.cbb_Cam.FormattingEnabled = true;
            this.cbb_Cam.Location = new System.Drawing.Point(559, 59);
            this.cbb_Cam.Name = "cbb_Cam";
            this.cbb_Cam.Size = new System.Drawing.Size(280, 28);
            this.cbb_Cam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn camera";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Cam);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.ptb_Image);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptb_Image;
        private Button btn_Start;
        private ComboBox cbb_Cam;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}