namespace Blackjack_New
{
    partial class Register
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password1 = new System.Windows.Forms.TextBox();
            this.txt_Password2 = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_Username.Location = new System.Drawing.Point(187, 71);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(127, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Please enter a username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(187, 206);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(154, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Please enter a password twice:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(377, 71);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(189, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password1
            // 
            this.txt_Password1.Location = new System.Drawing.Point(377, 206);
            this.txt_Password1.Name = "txt_Password1";
            this.txt_Password1.Size = new System.Drawing.Size(189, 20);
            this.txt_Password1.TabIndex = 4;
            this.txt_Password1.UseSystemPasswordChar = true;
            // 
            // txt_Password2
            // 
            this.txt_Password2.Location = new System.Drawing.Point(377, 245);
            this.txt_Password2.Name = "txt_Password2";
            this.txt_Password2.Size = new System.Drawing.Size(189, 20);
            this.txt_Password2.TabIndex = 5;
            this.txt_Password2.UseSystemPasswordChar = true;
            this.txt_Password2.TextChanged += new System.EventHandler(this.txt_Password2_TextChanged);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(213, 323);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(129, 70);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(397, 323);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(128, 70);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Password2);
            this.Controls.Add(this.txt_Password1);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password1;
        private System.Windows.Forms.TextBox txt_Password2;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Back;
    }
}