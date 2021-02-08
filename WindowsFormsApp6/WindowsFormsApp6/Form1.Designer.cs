namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mPointScroller = new System.Windows.Forms.TrackBar();
            this.rPointScroller = new System.Windows.Forms.TrackBar();
            this.yPointScroller = new System.Windows.Forms.TrackBar();
            this.gPointScroller = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rColorChangeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yColorChangeBtn = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gColorChangeBtn = new System.Windows.Forms.Button();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mColorChangeBtn = new System.Windows.Forms.Button();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.Generation_rate = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPointScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPointScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPointScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPointScroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Generation_rate)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(-1, -22);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 371);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mPointScroller
            // 
            this.mPointScroller.Location = new System.Drawing.Point(9, 19);
            this.mPointScroller.Maximum = 128;
            this.mPointScroller.Minimum = 1;
            this.mPointScroller.Name = "mPointScroller";
            this.mPointScroller.Size = new System.Drawing.Size(125, 45);
            this.mPointScroller.TabIndex = 3;
            this.mPointScroller.TickFrequency = 5;
            this.mPointScroller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mPointScroller.Value = 100;
            this.mPointScroller.Scroll += new System.EventHandler(this.mPointScroller_Scroll);
            // 
            // rPointScroller
            // 
            this.rPointScroller.Location = new System.Drawing.Point(52, 19);
            this.rPointScroller.Maximum = 128;
            this.rPointScroller.Minimum = 1;
            this.rPointScroller.Name = "rPointScroller";
            this.rPointScroller.Size = new System.Drawing.Size(125, 45);
            this.rPointScroller.TabIndex = 4;
            this.rPointScroller.TickFrequency = 5;
            this.rPointScroller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rPointScroller.Value = 100;
            this.rPointScroller.Scroll += new System.EventHandler(this.rPointScroller_Scroll);
            // 
            // yPointScroller
            // 
            this.yPointScroller.Location = new System.Drawing.Point(52, 18);
            this.yPointScroller.Maximum = 128;
            this.yPointScroller.Minimum = 1;
            this.yPointScroller.Name = "yPointScroller";
            this.yPointScroller.Size = new System.Drawing.Size(132, 45);
            this.yPointScroller.TabIndex = 5;
            this.yPointScroller.TickFrequency = 5;
            this.yPointScroller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yPointScroller.Value = 100;
            this.yPointScroller.Scroll += new System.EventHandler(this.yPointScroller_Scroll);
            // 
            // gPointScroller
            // 
            this.gPointScroller.Location = new System.Drawing.Point(52, 18);
            this.gPointScroller.Maximum = 128;
            this.gPointScroller.Minimum = 1;
            this.gPointScroller.Name = "gPointScroller";
            this.gPointScroller.Size = new System.Drawing.Size(125, 45);
            this.gPointScroller.TabIndex = 6;
            this.gPointScroller.TickFrequency = 5;
            this.gPointScroller.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gPointScroller.Value = 100;
            this.gPointScroller.Scroll += new System.EventHandler(this.gPointScroller_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 84);
            this.trackBar1.Maximum = 776;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(90, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 132;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rColorChangeBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rPointScroller);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Red Point";
            // 
            // rColorChangeBtn
            // 
            this.rColorChangeBtn.Location = new System.Drawing.Point(7, 135);
            this.rColorChangeBtn.Name = "rColorChangeBtn";
            this.rColorChangeBtn.Size = new System.Drawing.Size(183, 23);
            this.rColorChangeBtn.TabIndex = 12;
            this.rColorChangeBtn.Text = "Change Point Color";
            this.rColorChangeBtn.UseVisualStyleBackColor = true;
            this.rColorChangeBtn.Click += new System.EventHandler(this.rColorChangeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(150, 55);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar2.Maximum = 400;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(45, 74);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 168;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Radius";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yColorChangeBtn);
            this.groupBox2.Controls.Add(this.trackBar4);
            this.groupBox2.Controls.Add(this.trackBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.yPointScroller);
            this.groupBox2.Location = new System.Drawing.Point(216, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 169);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yellow Point";
            // 
            // yColorChangeBtn
            // 
            this.yColorChangeBtn.Location = new System.Drawing.Point(6, 131);
            this.yColorChangeBtn.Name = "yColorChangeBtn";
            this.yColorChangeBtn.Size = new System.Drawing.Size(183, 23);
            this.yColorChangeBtn.TabIndex = 15;
            this.yColorChangeBtn.Text = "Change Point Color";
            this.yColorChangeBtn.UseVisualStyleBackColor = true;
            this.yColorChangeBtn.Click += new System.EventHandler(this.yColorChangeBtn_Click);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(152, 54);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar4.Maximum = 400;
            this.trackBar4.Minimum = 1;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar4.Size = new System.Drawing.Size(45, 74);
            this.trackBar4.TabIndex = 14;
            this.trackBar4.TickFrequency = 5;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Value = 168;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(60, 83);
            this.trackBar3.Maximum = 776;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(90, 45);
            this.trackBar3.TabIndex = 13;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Value = 132;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Radius";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gColorChangeBtn);
            this.groupBox3.Controls.Add(this.trackBar6);
            this.groupBox3.Controls.Add(this.trackBar5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.gPointScroller);
            this.groupBox3.Location = new System.Drawing.Point(422, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 169);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Green Point";
            // 
            // gColorChangeBtn
            // 
            this.gColorChangeBtn.Location = new System.Drawing.Point(11, 131);
            this.gColorChangeBtn.Name = "gColorChangeBtn";
            this.gColorChangeBtn.Size = new System.Drawing.Size(183, 23);
            this.gColorChangeBtn.TabIndex = 16;
            this.gColorChangeBtn.Text = "Change Point Color";
            this.gColorChangeBtn.UseVisualStyleBackColor = true;
            this.gColorChangeBtn.Click += new System.EventHandler(this.gColorChangeBtn_Click);
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(149, 54);
            this.trackBar6.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar6.Maximum = 400;
            this.trackBar6.Minimum = 1;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar6.Size = new System.Drawing.Size(45, 74);
            this.trackBar6.TabIndex = 15;
            this.trackBar6.TickFrequency = 5;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.Value = 168;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(60, 83);
            this.trackBar5.Maximum = 776;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(90, 45);
            this.trackBar5.TabIndex = 14;
            this.trackBar5.TickFrequency = 5;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.Value = 132;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Radius";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mColorChangeBtn);
            this.groupBox4.Controls.Add(this.trackBar8);
            this.groupBox4.Controls.Add(this.trackBar7);
            this.groupBox4.Controls.Add(this.mPointScroller);
            this.groupBox4.Location = new System.Drawing.Point(628, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 169);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Magenta Point";
            // 
            // mColorChangeBtn
            // 
            this.mColorChangeBtn.Location = new System.Drawing.Point(0, 131);
            this.mColorChangeBtn.Name = "mColorChangeBtn";
            this.mColorChangeBtn.Size = new System.Drawing.Size(137, 23);
            this.mColorChangeBtn.TabIndex = 17;
            this.mColorChangeBtn.Text = "Change Point Color";
            this.mColorChangeBtn.UseVisualStyleBackColor = true;
            this.mColorChangeBtn.Click += new System.EventHandler(this.mColorChangeBtn_Click);
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(93, 54);
            this.trackBar8.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar8.Maximum = 400;
            this.trackBar8.Minimum = 1;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar8.Size = new System.Drawing.Size(45, 74);
            this.trackBar8.TabIndex = 16;
            this.trackBar8.TickFrequency = 5;
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.Value = 168;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(0, 83);
            this.trackBar7.Maximum = 776;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(90, 45);
            this.trackBar7.TabIndex = 15;
            this.trackBar7.TickFrequency = 5;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.Value = 132;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // Generation_rate
            // 
            this.Generation_rate.Location = new System.Drawing.Point(340, 355);
            this.Generation_rate.Minimum = 1;
            this.Generation_rate.Name = "Generation_rate";
            this.Generation_rate.Size = new System.Drawing.Size(128, 45);
            this.Generation_rate.TabIndex = 13;
            this.Generation_rate.Value = 1;
            this.Generation_rate.Scroll += new System.EventHandler(this.Generation_rate_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Generation rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Generation_rate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(790, 625);
            this.MinimumSize = new System.Drawing.Size(790, 625);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPointScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPointScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPointScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPointScroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Generation_rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar mPointScroller;
        private System.Windows.Forms.TrackBar rPointScroller;
        private System.Windows.Forms.TrackBar yPointScroller;
        private System.Windows.Forms.TrackBar gPointScroller;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rColorChangeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button yColorChangeBtn;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button gColorChangeBtn;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Button mColorChangeBtn;
        private System.Windows.Forms.TrackBar Generation_rate;
        private System.Windows.Forms.Label label7;
    }
}

