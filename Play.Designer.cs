namespace Blackjack_New
{
    partial class Play
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
            this.btn_Stand = new System.Windows.Forms.Button();
            this.btn_Hit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DealerPictureBox1 = new System.Windows.Forms.PictureBox();
            this.DealerPictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayerPictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerPictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_YourHand = new System.Windows.Forms.Label();
            this.lbl_DealerHand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Stand
            // 
            this.btn_Stand.Location = new System.Drawing.Point(664, 256);
            this.btn_Stand.Name = "btn_Stand";
            this.btn_Stand.Size = new System.Drawing.Size(88, 46);
            this.btn_Stand.TabIndex = 2;
            this.btn_Stand.Text = "Stand";
            this.btn_Stand.UseVisualStyleBackColor = true;
            this.btn_Stand.Click += new System.EventHandler(this.btn_Stand_Click);
            // 
            // btn_Hit
            // 
            this.btn_Hit.Location = new System.Drawing.Point(549, 256);
            this.btn_Hit.Name = "btn_Hit";
            this.btn_Hit.Size = new System.Drawing.Size(88, 46);
            this.btn_Hit.TabIndex = 5;
            this.btn_Hit.Text = "Hit";
            this.btn_Hit.UseVisualStyleBackColor = true;
            this.btn_Hit.Click += new System.EventHandler(this.btn_Hit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(604, 117);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(88, 46);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blackjack_New.Properties.Resources.Back_of_card;
            this.pictureBox1.Location = new System.Drawing.Point(78, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DealerPictureBox1
            // 
            this.DealerPictureBox1.Location = new System.Drawing.Point(193, 48);
            this.DealerPictureBox1.Name = "DealerPictureBox1";
            this.DealerPictureBox1.Size = new System.Drawing.Size(70, 98);
            this.DealerPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerPictureBox1.TabIndex = 8;
            this.DealerPictureBox1.TabStop = false;
            // 
            // DealerPictureBox2
            // 
            this.DealerPictureBox2.Location = new System.Drawing.Point(235, 48);
            this.DealerPictureBox2.Name = "DealerPictureBox2";
            this.DealerPictureBox2.Size = new System.Drawing.Size(70, 98);
            this.DealerPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerPictureBox2.TabIndex = 9;
            this.DealerPictureBox2.TabStop = false;
            // 
            // PlayerPictureBox1
            // 
            this.PlayerPictureBox1.Location = new System.Drawing.Point(193, 294);
            this.PlayerPictureBox1.Name = "PlayerPictureBox1";
            this.PlayerPictureBox1.Size = new System.Drawing.Size(70, 98);
            this.PlayerPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox1.TabIndex = 10;
            this.PlayerPictureBox1.TabStop = false;
            // 
            // PlayerPictureBox2
            // 
            this.PlayerPictureBox2.Location = new System.Drawing.Point(235, 294);
            this.PlayerPictureBox2.Name = "PlayerPictureBox2";
            this.PlayerPictureBox2.Size = new System.Drawing.Size(70, 98);
            this.PlayerPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox2.TabIndex = 11;
            this.PlayerPictureBox2.TabStop = false;
            // 
            // lbl_YourHand
            // 
            this.lbl_YourHand.AutoSize = true;
            this.lbl_YourHand.Location = new System.Drawing.Point(190, 265);
            this.lbl_YourHand.Name = "lbl_YourHand";
            this.lbl_YourHand.Size = new System.Drawing.Size(56, 13);
            this.lbl_YourHand.TabIndex = 12;
            this.lbl_YourHand.Text = "Your hand";
            // 
            // lbl_DealerHand
            // 
            this.lbl_DealerHand.AutoSize = true;
            this.lbl_DealerHand.Location = new System.Drawing.Point(190, 22);
            this.lbl_DealerHand.Name = "lbl_DealerHand";
            this.lbl_DealerHand.Size = new System.Drawing.Size(72, 13);
            this.lbl_DealerHand.TabIndex = 13;
            this.lbl_DealerHand.Text = "Dealer\'s hand";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_DealerHand);
            this.Controls.Add(this.lbl_YourHand);
            this.Controls.Add(this.PlayerPictureBox2);
            this.Controls.Add(this.PlayerPictureBox1);
            this.Controls.Add(this.DealerPictureBox2);
            this.Controls.Add(this.DealerPictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Hit);
            this.Controls.Add(this.btn_Stand);
            this.Name = "Play";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Stand;
        private System.Windows.Forms.Button btn_Hit;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox DealerPictureBox1;
        private System.Windows.Forms.PictureBox DealerPictureBox2;
        private System.Windows.Forms.PictureBox PlayerPictureBox1;
        private System.Windows.Forms.PictureBox PlayerPictureBox2;
        private System.Windows.Forms.Label lbl_YourHand;
        private System.Windows.Forms.Label lbl_DealerHand;
    }
}