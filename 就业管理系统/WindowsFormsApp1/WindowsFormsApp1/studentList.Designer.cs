namespace WindowsFormsApp1
{
    partial class studentList
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.school = new System.Windows.Forms.TextBox();
            this.tech = new System.Windows.Forms.TextBox();
            this.awa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(197, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(197, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(151, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "毕业学校：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(151, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "职业技能：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(151, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "获得奖项：";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 15F);
            this.name.Location = new System.Drawing.Point(347, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 47);
            this.name.TabIndex = 6;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("宋体", 15F);
            this.age.Location = new System.Drawing.Point(347, 139);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(189, 47);
            this.age.TabIndex = 7;
            // 
            // school
            // 
            this.school.Font = new System.Drawing.Font("宋体", 15F);
            this.school.Location = new System.Drawing.Point(347, 237);
            this.school.Name = "school";
            this.school.Size = new System.Drawing.Size(327, 47);
            this.school.TabIndex = 8;
            // 
            // tech
            // 
            this.tech.Font = new System.Drawing.Font("宋体", 15F);
            this.tech.Location = new System.Drawing.Point(347, 325);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(509, 47);
            this.tech.TabIndex = 9;
            // 
            // awa
            // 
            this.awa.Font = new System.Drawing.Font("宋体", 15F);
            this.awa.Location = new System.Drawing.Point(347, 419);
            this.awa.Name = "awa";
            this.awa.Size = new System.Drawing.Size(385, 47);
            this.awa.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(744, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 90);
            this.button1.TabIndex = 11;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(42, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 88);
            this.button2.TabIndex = 12;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(387, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 93);
            this.button3.TabIndex = 13;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.reinput_Click);
            // 
            // studentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 634);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.awa);
            this.Controls.Add(this.tech);
            this.Controls.Add(this.school);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "studentList";
            this.Text = "studentList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox school;
        private System.Windows.Forms.TextBox tech;
        private System.Windows.Forms.TextBox awa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}