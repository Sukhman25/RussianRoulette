namespace RussianRoulette
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadBtn = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GamePoints = new System.Windows.Forms.TextBox();
            this.ShootheadBtn = new System.Windows.Forms.Button();
            this.ShootawayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadgunPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayAgainbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadgunPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.Info;
            this.LoadBtn.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(523, 68);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(140, 41);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "LOAD BULLET";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.SystemColors.Info;
            this.EXIT.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(523, 396);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(140, 49);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.PlayAgainBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SpinBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.Location = new System.Drawing.Point(523, 126);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(140, 46);
            this.SpinBtn.TabIndex = 3;
            this.SpinBtn.Text = "SPIN CHAMBERS";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 158);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GamePoints
            // 
            this.GamePoints.BackColor = System.Drawing.SystemColors.Info;
            this.GamePoints.Location = new System.Drawing.Point(27, 134);
            this.GamePoints.Multiline = true;
            this.GamePoints.Name = "GamePoints";
            this.GamePoints.Size = new System.Drawing.Size(247, 38);
            this.GamePoints.TabIndex = 5;
            // 
            // ShootheadBtn
            // 
            this.ShootheadBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ShootheadBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootheadBtn.Location = new System.Drawing.Point(523, 178);
            this.ShootheadBtn.Name = "ShootheadBtn";
            this.ShootheadBtn.Size = new System.Drawing.Size(140, 51);
            this.ShootheadBtn.TabIndex = 6;
            this.ShootheadBtn.Text = "SHOOT AT HEAD";
            this.ShootheadBtn.UseVisualStyleBackColor = false;
            this.ShootheadBtn.Click += new System.EventHandler(this.ShootheadBtn_Click);
            // 
            // ShootawayBtn
            // 
            this.ShootawayBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ShootawayBtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootawayBtn.Location = new System.Drawing.Point(523, 235);
            this.ShootawayBtn.Name = "ShootawayBtn";
            this.ShootawayBtn.Size = new System.Drawing.Size(140, 51);
            this.ShootawayBtn.TabIndex = 7;
            this.ShootawayBtn.Text = "SHOOT AWAY";
            this.ShootawayBtn.UseVisualStyleBackColor = false;
            this.ShootawayBtn.Click += new System.EventHandler(this.ShootawayBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "RUSSIAN ROULETTE GAME";
            // 
            // LoadgunPicture
            // 
            this.LoadgunPicture.BackColor = System.Drawing.SystemColors.Info;
            this.LoadgunPicture.Location = new System.Drawing.Point(27, 202);
            this.LoadgunPicture.Name = "LoadgunPicture";
            this.LoadgunPicture.Size = new System.Drawing.Size(247, 99);
            this.LoadgunPicture.TabIndex = 9;
            this.LoadgunPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Game Points";
            // 
            // PlayAgainbtn
            // 
            this.PlayAgainbtn.BackColor = System.Drawing.SystemColors.Info;
            this.PlayAgainbtn.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainbtn.Location = new System.Drawing.Point(523, 339);
            this.PlayAgainbtn.Name = "PlayAgainbtn";
            this.PlayAgainbtn.Size = new System.Drawing.Size(140, 51);
            this.PlayAgainbtn.TabIndex = 13;
            this.PlayAgainbtn.Text = "PLAY AGAIN";
            this.PlayAgainbtn.UseVisualStyleBackColor = false;
            this.PlayAgainbtn.Click += new System.EventHandler(this.PlayAgainbtn_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulette.Resource1.backgroundimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 487);
            this.Controls.Add(this.PlayAgainbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadgunPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShootawayBtn);
            this.Controls.Add(this.ShootheadBtn);
            this.Controls.Add(this.GamePoints);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.LoadBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadgunPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox GamePoints;
        private System.Windows.Forms.Button ShootheadBtn;
        private System.Windows.Forms.Button ShootawayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LoadgunPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlayAgainbtn;
    }
}

