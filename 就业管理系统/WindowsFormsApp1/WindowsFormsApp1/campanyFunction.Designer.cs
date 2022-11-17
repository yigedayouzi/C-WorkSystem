namespace WindowsFormsApp1
{
    partial class campanyFunction
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(60, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能选择：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(374, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "员工管理";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.studentChoose);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(374, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "发送招聘信息";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.putMessage);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(374, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "与学生沟通";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // campanyFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "campanyFunction";
            this.Text = "campanyFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}