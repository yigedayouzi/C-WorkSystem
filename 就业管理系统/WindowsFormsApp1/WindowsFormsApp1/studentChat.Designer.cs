namespace WindowsFormsApp1
{
    partial class studentChat
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.say = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.campanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(28, 964);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 106);
            this.button2.TabIndex = 24;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1230, 761);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 116);
            this.button1.TabIndex = 23;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // say
            // 
            this.say.Font = new System.Drawing.Font("宋体", 20F);
            this.say.Location = new System.Drawing.Point(646, 816);
            this.say.Name = "say";
            this.say.Size = new System.Drawing.Size(532, 61);
            this.say.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 466);
            this.dataGridView1.TabIndex = 21;
            // 
            // campanyName
            // 
            this.campanyName.Font = new System.Drawing.Font("宋体", 20F);
            this.campanyName.Location = new System.Drawing.Point(383, 816);
            this.campanyName.Name = "campanyName";
            this.campanyName.Size = new System.Drawing.Size(236, 61);
            this.campanyName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(169, 830);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 47);
            this.label1.TabIndex = 26;
            this.label1.Text = "企业名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 47);
            this.label2.TabIndex = 27;
            this.label2.Text = "当前账号：";
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("宋体", 20F);
            this.studentName.Location = new System.Drawing.Point(325, 43);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(252, 61);
            this.studentName.TabIndex = 28;
            // 
            // studentChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 1097);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campanyName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.say);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentChat";
            this.Text = "studentChat";
            this.Load += new System.EventHandler(this.campanyChat);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox say;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox campanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentName;
    }
}