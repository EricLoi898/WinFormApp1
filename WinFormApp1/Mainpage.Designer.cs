namespace WinFormApp1
{
    partial class Mainpage
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
            this.button_login = new System.Windows.Forms.Button();
            this.input_userID = new System.Windows.Forms.TextBox();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Black;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(256, 378);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(278, 63);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // input_userID
            // 
            this.input_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_userID.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_userID.Location = new System.Drawing.Point(244, 148);
            this.input_userID.Name = "input_userID";
            this.input_userID.Size = new System.Drawing.Size(365, 34);
            this.input_userID.TabIndex = 1;
            // 
            // input_pwd
            // 
            this.input_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_pwd.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_pwd.Location = new System.Drawing.Point(244, 221);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '*';
            this.input_pwd.Size = new System.Drawing.Size(365, 34);
            this.input_pwd.TabIndex = 2;
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.BackColor = System.Drawing.Color.Transparent;
            this.label_userID.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userID.ForeColor = System.Drawing.Color.White;
            this.label_userID.Location = new System.Drawing.Point(114, 148);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(85, 27);
            this.label_userID.TabIndex = 3;
            this.label_userID.Text = "user ID";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.BackColor = System.Drawing.Color.Transparent;
            this.label_pwd.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pwd.ForeColor = System.Drawing.Color.White;
            this.label_pwd.Location = new System.Drawing.Point(114, 224);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(112, 27);
            this.label_pwd.TabIndex = 4;
            this.label_pwd.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label_pwd);
            this.groupBox1.Controls.Add(this.input_pwd);
            this.groupBox1.Controls.Add(this.label_userID);
            this.groupBox1.Controls.Add(this.input_userID);
            this.groupBox1.Font = new System.Drawing.Font("timemachine wa", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 537);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mainpage";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormApp1.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainpage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox input_userID;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

