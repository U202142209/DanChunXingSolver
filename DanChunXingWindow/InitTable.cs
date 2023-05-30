/// author:@我不是大佬
/// QQ    :2869210303
/// Email :2869210303@qq.com
/// wx    :safeseaa
/// CopyRight Protected

using System;
using System.Windows.Forms;

namespace DanChunXingWindow
{
    public partial class InitTable : Form
    {
        public InitTable()
        {
            InitializeComponent();
            tbA.Text = Config.ma_string;
            tbB.Text = Config.mb_string;
            tbC.Text = Config.mc_string;
            tbrow.Text = Config.mrow;
            tbcol.Text = Config.mcol;
        }
        // defalut
        private void button1_Click(object sender, EventArgs e)
        {
            Config.dcx = new DanChunXingSolver(
                new matrix(3, 6,
                "1,6,0,1,0,0," +
                "3,2,-4,0,1,0," +
                "1,2,3,0,0,1"),
                new matrix(3, 1, "9,2,6"),
                new matrix(1, 6, "1,-1,1,1,-1,1"));
            string sss = "例如，" + Config.dcx.showproblem() + "\t\t其中，系数矩阵 A 的行数为 3 ，列数为 6 ，需要在 A 的输入框中输入：" +
                "\n\t\t1,6,0,1,0,0,\n\t\t3,2,-4,0,1,0,\n\t\t1,2,3,0,0,1\n在 b 的输入框中输入：\n\t\t9,2,6\n在 C 的输入框中输入：\n\t\t1,-1,1,1,-1,1\n\n当 C的元素个数不足时，用 0 补充";
            tbcol.Text = "6"; tbrow.Text = "3";
            tbA.Text = "\t\t1,6,0,1,0,0,\n\t\t3,2,-4,0,1,0,\n\t\t1,2,3,0,0,1";
            tbB.Text = "9,2,6";
            tbC.Text = "1,-1,1,1,-1,1";
            MessageBox.Show(sss);
        }
        // 确定
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                matrix C = new matrix(1, Convert.ToInt32(tbcol.Text), tbC.Text);
                matrix A = new matrix(
                    Convert.ToInt32(tbrow.Text),
                    Convert.ToInt32(tbcol.Text),
                    tbA.Text);
                matrix B = new matrix(Convert.ToInt32(tbrow.Text), 1, tbB.Text);
                Config.dcx = new DanChunXingSolver(A,B,C);
                Config.ma_string = tbA.Text;
                Config.mb_string = tbB.Text;
                Config.mc_string = tbC.Text;
                Config.mrow = tbrow.Text;
                Config.mcol = tbcol.Text;
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
