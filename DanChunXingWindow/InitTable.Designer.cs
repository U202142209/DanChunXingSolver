
namespace DanChunXingWindow
{
    partial class InitTable
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
            this.tbrow = new System.Windows.Forms.TextBox();
            this.tbcol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "自定义线性规划问题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入系数矩阵A的行数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入系数矩阵A的列数:";
            // 
            // tbrow
            // 
            this.tbrow.Font = new System.Drawing.Font("宋体", 12F);
            this.tbrow.Location = new System.Drawing.Point(224, 59);
            this.tbrow.Name = "tbrow";
            this.tbrow.Size = new System.Drawing.Size(69, 30);
            this.tbrow.TabIndex = 3;
            this.tbrow.Text = "2";
            this.tbrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbcol
            // 
            this.tbcol.Font = new System.Drawing.Font("宋体", 12F);
            this.tbcol.Location = new System.Drawing.Point(224, 98);
            this.tbcol.Name = "tbcol";
            this.tbcol.Size = new System.Drawing.Size(69, 30);
            this.tbcol.TabIndex = 4;
            this.tbcol.Text = "5";
            this.tbcol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "请输入系数矩阵A中的元素，请注意\r\n（1）不同元素之间以英文逗号（,）分割\r\n（2）请用分数代替小数输入，例如，用 5/2 代替2.5";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(34, 197);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(402, 96);
            this.tbA.TabIndex = 6;
            this.tbA.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "请输入限制条件 b 中的元素，请注意\r\n（1）不同元素之间以英文逗号（,）分割\r\n（2）请用分数代替小数输入，例如，用 5/2 代替2.5";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("宋体", 12F);
            this.tbB.Location = new System.Drawing.Point(37, 378);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(399, 30);
            this.tbB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "请输入系数 C 中的元素，请注意\r\n（1）不同元素之间以英文逗号（,）分割\r\n（2）请用分数代替小数输入，例如，用 5/2 代替2.5";
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("宋体", 12F);
            this.tbC.Location = new System.Drawing.Point(34, 490);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(399, 30);
            this.tbC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 90);
            this.label7.TabIndex = 11;
            this.label7.Text = "请注意：\r\n（1）系数矩阵 A 的列数与系数 C 中的元素个数相同。\r\n（2）稀疏矩阵 A 的行数与限制条件 b 中的元素个数相同\r\n（3）使用分数代替小数输入\r" +
    "\n（3）请确保以上的输入条件，否则程序将出错\r\n（5）如有疑问，可点击下方按钮查看输入示例";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "查看示例输入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InitTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 765);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcol);
            this.Controls.Add(this.tbrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "InitTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "自定义线性规划问题";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbrow;
        private System.Windows.Forms.TextBox tbcol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}