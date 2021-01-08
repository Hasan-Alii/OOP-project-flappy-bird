namespace OOP_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeButtom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameMenu = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.gameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PeachPuff;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(0, 785);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(213, 69);
            this.scoreText.TabIndex = 1;
            this.scoreText.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.Image = global::OOP_Project.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-23, 759);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1095, 138);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipeButtom
            // 
            this.pipeButtom.Image = global::OOP_Project.Properties.Resources.pipe;
            this.pipeButtom.Location = new System.Drawing.Point(597, 498);
            this.pipeButtom.Margin = new System.Windows.Forms.Padding(4);
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(133, 286);
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 0;
            this.pipeButtom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::OOP_Project.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(121, 336);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(4);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(95, 74);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::OOP_Project.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(785, -20);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(133, 297);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameMenu
            // 
            this.gameMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.gameMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameMenu.BackgroundImage")));
            this.gameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gameMenu.Controls.Add(this.textBox1);
            this.gameMenu.Controls.Add(this.label2);
            this.gameMenu.Controls.Add(this.lbl_quit);
            this.gameMenu.Controls.Add(this.lbl_restart);
            this.gameMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.gameMenu.Location = new System.Drawing.Point(121, 88);
            this.gameMenu.Margin = new System.Windows.Forms.Padding(4);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Padding = new System.Windows.Forms.Padding(4);
            this.gameMenu.Size = new System.Drawing.Size(715, 475);
            this.gameMenu.TabIndex = 2;
            this.gameMenu.TabStop = false;
            this.gameMenu.Text = "Menu";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(205, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 62);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Over";
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_quit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_quit.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quit.ForeColor = System.Drawing.Color.White;
            this.lbl_quit.Location = new System.Drawing.Point(309, 373);
            this.lbl_quit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(106, 52);
            this.lbl_quit.TabIndex = 1;
            this.lbl_quit.Text = "Quit";
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_restart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.ForeColor = System.Drawing.Color.White;
            this.lbl_restart.Location = new System.Drawing.Point(283, 287);
            this.lbl_restart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(158, 52);
            this.lbl_restart.TabIndex = 1;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(997, 855);
            this.Controls.Add(this.gameMenu);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeButtom);
            this.Controls.Add(this.pipeTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpKey);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeButtom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox gameMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.TextBox textBox1;
    }
}

