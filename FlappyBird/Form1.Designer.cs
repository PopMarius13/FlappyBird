namespace FlappyBird
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.butonstart = new System.Windows.Forms.Button();
            this.scorbird = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            this.listaimagini = new System.Windows.Forms.ImageList(this.components);
            this.timer3 = new System.Timers.Timer();
            this.textendgame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).BeginInit();
            this.SuspendLayout();
            // 
            // butonstart
            // 
            this.butonstart.BackColor = System.Drawing.Color.Yellow;
            this.butonstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonstart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.butonstart.Location = new System.Drawing.Point(213, 296);
            this.butonstart.Name = "butonstart";
            this.butonstart.Size = new System.Drawing.Size(158, 57);
            this.butonstart.TabIndex = 0;
            this.butonstart.Text = "Start";
            this.butonstart.UseVisualStyleBackColor = false;
            this.butonstart.Click += new System.EventHandler(this.butonstart_Click);
            // 
            // scorbird
            // 
            this.scorbird.AutoSize = true;
            this.scorbird.BackColor = System.Drawing.Color.Transparent;
            this.scorbird.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorbird.ForeColor = System.Drawing.Color.Blue;
            this.scorbird.Location = new System.Drawing.Point(269, 9);
            this.scorbird.Name = "scorbird";
            this.scorbird.Size = new System.Drawing.Size(47, 59);
            this.scorbird.TabIndex = 1;
            this.scorbird.Text = "0";
            this.scorbird.Click += new System.EventHandler(this.scorbird_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImage = global::FlappyBird.Properties.Resources.bird_straight;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Location = new System.Drawing.Point(260, 297);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(65, 55);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            this.bird.Visible = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 38D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timer2
            // 
            this.timer2.Interval = 150D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // listaimagini
            // 
            this.listaimagini.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaimagini.ImageStream")));
            this.listaimagini.TransparentColor = System.Drawing.Color.Transparent;
            this.listaimagini.Images.SetKeyName(0, "birdcade.png");
            this.listaimagini.Images.SetKeyName(1, "birdzboara.png");
            // 
            // timer3
            // 
            this.timer3.Interval = 1D;
            this.timer3.SynchronizingObject = this;
            this.timer3.Elapsed += new System.Timers.ElapsedEventHandler(this.timer3_Elapsed);
            // 
            // textendgame
            // 
            this.textendgame.AutoSize = true;
            this.textendgame.BackColor = System.Drawing.Color.Transparent;
            this.textendgame.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textendgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textendgame.Location = new System.Drawing.Point(25, 170);
            this.textendgame.Name = "textendgame";
            this.textendgame.Size = new System.Drawing.Size(86, 29);
            this.textendgame.TabIndex = 3;
            this.textendgame.Text = "label1";
            this.textendgame.Visible = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 650);
            this.Controls.Add(this.textendgame);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scorbird);
            this.Controls.Add(this.butonstart);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.butonstart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonstart;
        private System.Windows.Forms.Label scorbird;
        private System.Windows.Forms.PictureBox bird;
        private System.Timers.Timer timer1;
        private System.Timers.Timer timer2;
        private System.Windows.Forms.ImageList listaimagini;
        private System.Timers.Timer timer3;
        private System.Windows.Forms.Label textendgame;
    }
}

