namespace Blackjack_New
{
    partial class AskBet
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
            this.lbl_AskBet = new System.Windows.Forms.Label();
            this.num_AskBet = new System.Windows.Forms.NumericUpDown();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_AskBet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AskBet
            // 
            this.lbl_AskBet.AutoSize = true;
            this.lbl_AskBet.Location = new System.Drawing.Point(142, 149);
            this.lbl_AskBet.Name = "lbl_AskBet";
            this.lbl_AskBet.Size = new System.Drawing.Size(255, 13);
            this.lbl_AskBet.TabIndex = 1;
            this.lbl_AskBet.Text = "Please enter how much money you would like to bet:";
            // 
            // num_AskBet
            // 
            this.num_AskBet.Location = new System.Drawing.Point(451, 149);
            this.num_AskBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_AskBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_AskBet.Name = "num_AskBet";
            this.num_AskBet.ReadOnly = true;
            this.num_AskBet.Size = new System.Drawing.Size(70, 20);
            this.num_AskBet.TabIndex = 2;
            this.num_AskBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(210, 300);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(108, 56);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(413, 300);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(108, 56);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AskBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.num_AskBet);
            this.Controls.Add(this.lbl_AskBet);
            this.Name = "AskBet";
            this.Text = "AskBet";
            ((System.ComponentModel.ISupportInitialize)(this.num_AskBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_AskBet;
        private System.Windows.Forms.NumericUpDown num_AskBet;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Back;
    }
}