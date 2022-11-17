namespace WindowsFormsApp1
{
    partial class studentFunction
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(77, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能选择：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(417, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "岗位投递";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(417, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 94);
            this.button2.TabIndex = 2;
            this.button2.Text = "简历创建";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.Location = new System.Drawing.Point(417, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "与企业沟通";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("宋体", 15F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(417, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 90);
            this.button4.TabIndex = 4;
            this.button4.Text = "简历查看";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("宋体", 15F);
            this.button5.Location = new System.Drawing.Point(417, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "简历编辑";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // studentFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 840);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "studentFunction";
            this.Text = "studentFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}