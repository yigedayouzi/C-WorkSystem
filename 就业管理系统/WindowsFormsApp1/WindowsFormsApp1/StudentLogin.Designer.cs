namespace WindowsFormsApp1
{
    partial class StudentLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(163, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(343, 136);
            this.username.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(279, 49);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(343, 236);
            this.password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(279, 49);
            this.password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(163, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(273, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "学生登陆";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login.Font = new System.Drawing.Font("宋体", 15F);
            this.login.Location = new System.Drawing.Point(160, 350);
            this.login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(196, 79);
            this.login.TabIndex = 5;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.register.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register.Location = new System.Drawing.Point(436, 350);
            this.register.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(196, 79);
            this.register.TabIndex = 6;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 557);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
    }
}