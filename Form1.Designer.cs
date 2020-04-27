namespace Twitch_to_Facebook
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.streamlink_test = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.ffmpeg_test = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.facebook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.twitch = new System.Windows.Forms.TextBox();
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.samplingrate = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // streamlink_test
            // 
            this.streamlink_test.AutoSize = true;
            this.streamlink_test.Location = new System.Drawing.Point(52, 86);
            this.streamlink_test.Name = "streamlink_test";
            this.streamlink_test.Size = new System.Drawing.Size(31, 13);
            this.streamlink_test.TabIndex = 2;
            this.streamlink_test.Text = "- na -";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.streamlink_test);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streamlink";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "unset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.ffmpeg_test);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FFMPEG";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "unset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(101, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "set";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 29);
            this.button7.TabIndex = 1;
            this.button7.Text = "download";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ffmpeg_test
            // 
            this.ffmpeg_test.AutoSize = true;
            this.ffmpeg_test.Location = new System.Drawing.Point(71, 86);
            this.ffmpeg_test.Name = "ffmpeg_test";
            this.ffmpeg_test.Size = new System.Drawing.Size(31, 13);
            this.ffmpeg_test.TabIndex = 2;
            this.ffmpeg_test.Text = "- na -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Facebook key:";
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(95, 134);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(301, 20);
            this.facebook.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Twitch:";
            // 
            // twitch
            // 
            this.twitch.Location = new System.Drawing.Point(60, 164);
            this.twitch.Name = "twitch";
            this.twitch.Size = new System.Drawing.Size(336, 20);
            this.twitch.TabIndex = 11;
            // 
            // fileOpen
            // 
            this.fileOpen.FileName = "openFileDialog1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 29);
            this.button8.TabIndex = 12;
            this.button8.Text = "Get help";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sampling rate:";
            // 
            // samplingrate
            // 
            this.samplingrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplingrate.FormattingEnabled = true;
            this.samplingrate.Items.AddRange(new object[] {
            "44100",
            "48000",
            "22050"});
            this.samplingrate.Location = new System.Drawing.Point(95, 195);
            this.samplingrate.Name = "samplingrate";
            this.samplingrate.Size = new System.Drawing.Size(301, 21);
            this.samplingrate.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 279);
            this.Controls.Add(this.samplingrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.twitch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Twitch to Facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label streamlink_test;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label ffmpeg_test;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox facebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox twitch;
        private System.Windows.Forms.OpenFileDialog fileOpen;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox samplingrate;
    }
}

