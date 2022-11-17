namespace WindowsFormsApp1
{
    partial class campanyRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.campany_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(325, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "企业注册";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(97, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(132, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(97, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "企业名";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F);
            this.username.Location = new System.Drawing.Point(255, 202);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(413, 47);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F);
            this.password.Location = new System.Drawing.Point(255, 339);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(413, 47);
            this.password.TabIndex = 5;
            // 
            // campany_name
            // 
            this.campany_name.Font = new System.Drawing.Font("宋体", 15F);
            this.campany_name.Location = new System.Drawing.Point(255, 491);
            this.campany_name.Name = "campany_name";
            this.campany_name.Size = new System.Drawing.Size(413, 47);
            this.campany_name.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(169, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(501, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 74);
            this.button2.TabIndex = 8;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.reinput_Click);
            // 
            // campanyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 890);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.campany_name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "campanyRegister";
            this.Text = "campanyRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox campany_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}