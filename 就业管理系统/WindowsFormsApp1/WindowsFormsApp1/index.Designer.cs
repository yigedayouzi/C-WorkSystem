namespace WindowsFormsApp1
{
    partial class index
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
            this.studentlogin = new System.Windows.Forms.Button();
            this.campanylogin = new System.Windows.Forms.Button();
            this.adminlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentlogin
            // 
            this.studentlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentlogin.Font = new System.Drawing.Font("宋体", 15F);
            this.studentlogin.Location = new System.Drawing.Point(630, 66);
            this.studentlogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.studentlogin.Name = "studentlogin";
            this.studentlogin.Size = new System.Drawing.Size(240, 82);
            this.studentlogin.TabIndex = 0;
            this.studentlogin.Text = "学生";
            this.studentlogin.UseVisualStyleBackColor = false;
            this.studentlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // campanylogin
            // 
            this.campanylogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.campanylogin.Font = new System.Drawing.Font("宋体", 15F);
            this.campanylogin.Location = new System.Drawing.Point(630, 212);
            this.campanylogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.campanylogin.Name = "campanylogin";
            this.campanylogin.Size = new System.Drawing.Size(240, 82);
            this.campanylogin.TabIndex = 1;
            this.campanylogin.Text = "企业";
            this.campanylogin.UseVisualStyleBackColor = false;
            this.campanylogin.Click += new System.EventHandler(this.campanylogin_Click);
            // 
            // adminlogin
            // 
            this.adminlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminlogin.Font = new System.Drawing.Font("宋体", 15F);
            this.adminlogin.Location = new System.Drawing.Point(630, 374);
            this.adminlogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(240, 82);
            this.adminlogin.TabIndex = 2;
            this.adminlogin.Text = "管理员";
            this.adminlogin.UseVisualStyleBackColor = false;
            this.adminlogin.Click += new System.EventHandler(this.adminlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(181, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择登录身份：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.campanylogin);
            this.Controls.Add(this.studentlogin);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "index";
            this.Text = "index";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 学生登录，企业登录以及管理员登录
        /// </summary>
        private System.Windows.Forms.Button studentlogin;
        private System.Windows.Forms.Button campanylogin;
        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.Label label1;
    }
}