namespace WindowsFormsApp1
{
    partial class admin_control
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
            this.adminlogin = new System.Windows.Forms.Button();
            this.campanylogin = new System.Windows.Forms.Button();
            this.studentlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminlogin
            // 
            this.adminlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminlogin.Font = new System.Drawing.Font("宋体", 15F);
            this.adminlogin.Location = new System.Drawing.Point(418, 395);
            this.adminlogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(240, 82);
            this.adminlogin.TabIndex = 5;
            this.adminlogin.Text = "数据管理";
            this.adminlogin.UseVisualStyleBackColor = false;
            this.adminlogin.Click += new System.EventHandler(this.adminlogin_Click);
            // 
            // campanylogin
            // 
            this.campanylogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.campanylogin.Font = new System.Drawing.Font("宋体", 15F);
            this.campanylogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.campanylogin.Location = new System.Drawing.Point(418, 227);
            this.campanylogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.campanylogin.Name = "campanylogin";
            this.campanylogin.Size = new System.Drawing.Size(240, 82);
            this.campanylogin.TabIndex = 4;
            this.campanylogin.Text = "企业审核";
            this.campanylogin.UseVisualStyleBackColor = false;
            this.campanylogin.Click += new System.EventHandler(this.campanylogin_Click);
            // 
            // studentlogin
            // 
            this.studentlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentlogin.Font = new System.Drawing.Font("宋体", 15F);
            this.studentlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentlogin.Location = new System.Drawing.Point(418, 71);
            this.studentlogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.studentlogin.Name = "studentlogin";
            this.studentlogin.Size = new System.Drawing.Size(240, 82);
            this.studentlogin.TabIndex = 3;
            this.studentlogin.Text = "学生审核";
            this.studentlogin.UseVisualStyleBackColor = false;
            this.studentlogin.Click += new System.EventHandler(this.studentlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "功能选择：";
            // 
            // admin_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.campanylogin);
            this.Controls.Add(this.studentlogin);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "admin_control";
            this.Text = "admin_control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.Button campanylogin;
        private System.Windows.Forms.Button studentlogin;
        private System.Windows.Forms.Label label1;
    }
}