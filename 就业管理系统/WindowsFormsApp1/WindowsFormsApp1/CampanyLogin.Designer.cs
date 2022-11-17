namespace WindowsFormsApp1
{
    partial class CampanyLogin
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
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login.Font = new System.Drawing.Font("宋体", 15F);
            this.login.Location = new System.Drawing.Point(108, 474);
            this.login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(200, 79);
            this.login.TabIndex = 12;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(245, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "企业登陆";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F);
            this.password.Location = new System.Drawing.Point(253, 318);
            this.password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(291, 47);
            this.password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(101, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "密  码：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F);
            this.username.Location = new System.Drawing.Point(253, 174);
            this.username.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(291, 47);
            this.username.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(101, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(424, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 80);
            this.button1.TabIndex = 13;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.register_Click);
            // 
            // CampanyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CampanyLogin";
            this.Text = "CampanyLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}