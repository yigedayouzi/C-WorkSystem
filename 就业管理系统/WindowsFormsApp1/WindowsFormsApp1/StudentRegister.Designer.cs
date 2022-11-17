namespace WindowsFormsApp1
{
    partial class StudentRegister
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
            this.label3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.regbutton = new System.Windows.Forms.Button();
            this.reinput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(264, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "学生注册";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l1.Location = new System.Drawing.Point(121, 192);
            this.l1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(128, 37);
            this.l1.TabIndex = 6;
            this.l1.Text = "用户名";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(304, 187);
            this.username.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(341, 49);
            this.username.TabIndex = 7;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(304, 299);
            this.password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(341, 49);
            this.password.TabIndex = 9;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l2.Location = new System.Drawing.Point(121, 304);
            this.l2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(129, 37);
            this.l2.TabIndex = 8;
            this.l2.Text = "密  码";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.Location = new System.Drawing.Point(304, 418);
            this.email.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(341, 49);
            this.email.TabIndex = 11;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l3.Location = new System.Drawing.Point(121, 424);
            this.l3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(129, 37);
            this.l3.TabIndex = 10;
            this.l3.Text = "邮  箱";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(304, 534);
            this.phone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(341, 49);
            this.phone.TabIndex = 13;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l4.Location = new System.Drawing.Point(121, 539);
            this.l4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(129, 37);
            this.l4.TabIndex = 12;
            this.l4.Text = "手  机";
            this.l4.Click += new System.EventHandler(this.phone_Click);
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.Color.Yellow;
            this.regbutton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regbutton.Location = new System.Drawing.Point(434, 710);
            this.regbutton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(224, 68);
            this.regbutton.TabIndex = 14;
            this.regbutton.Text = "确认";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // reinput
            // 
            this.reinput.BackColor = System.Drawing.Color.Blue;
            this.reinput.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reinput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reinput.Location = new System.Drawing.Point(161, 710);
            this.reinput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.reinput.Name = "reinput";
            this.reinput.Size = new System.Drawing.Size(224, 68);
            this.reinput.TabIndex = 15;
            this.reinput.Text = "重置";
            this.reinput.UseVisualStyleBackColor = false;
            this.reinput.Click += new System.EventHandler(this.reinput_Click);
            // 
            // StudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 945);
            this.Controls.Add(this.reinput);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StudentRegister";
            this.Text = "StudentRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Button reinput;
    }
}