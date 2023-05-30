/// author:@我不是大佬
/// QQ    :2869210303
/// Email :2869210303@qq.com
/// wx    :safeseaa
/// CopyRight Protected

using System;
using System.Windows.Forms;

namespace DanChunXingWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private matrix X;
        private string out_string;

        private void Form1_Load(object sender, EventArgs e)
        {
            使用单纯形法求解ToolStripMenuItem.Enabled = false;
            保存求解过程ToolStripMenuItem.Enabled = false;
        }

        private void 使用默认的线性规划例题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.dcx = new DanChunXingSolver(
                new matrix(3, 6,
                "1,6,0,1,0,0," +
                "3,2,-4,0,1,0," +
                "1,2,3,0,0,1"),
                new matrix(3, 1, "9,2,6"),
                new matrix(1, 6, "1,-1,1,1,-1,1")
                );
            richTextBox1.Text = Config.dcx.showproblem();
            使用单纯形法求解ToolStripMenuItem.Enabled = true;
            richTextBox2.Text = "";
            保存求解过程ToolStripMenuItem.Enabled = false;
        }

        private void 保存求解过程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择文件需要保存的文件夹";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = dialog.SelectedPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt";
                    System.IO.File.WriteAllText(savePath, richTextBox2.Text + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"));
                    MessageBox.Show("求解过程已保存至：\n：" + savePath);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void 使用单纯形法求解ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Config.dcx.Solve(out X, out out_string);
                richTextBox2.Text = out_string + "\n\n\tmade by:@我不是大佬\tQQ:2869210303 \n\n";
                保存求解过程ToolStripMenuItem.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("发生了错误：\n" + error.Message);
            }
        }

        private void 自定义线性规划问题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InitTable f = new InitTable();
                f.ShowDialog();
                if (Config.dcx != null)
                {
                    richTextBox1.Text = Config.dcx.showproblem();
                    使用单纯形法求解ToolStripMenuItem.Enabled = true;
                    richTextBox2.Text = "";
                    保存求解过程ToolStripMenuItem.Enabled = false;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("初始化线性规划问题失败：\n" + error.Message);
            }

        }

        private void 获取帮助ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void 获取帮助ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void 给作者打赏ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void 给作者打赏ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/V123456789987654/article/details/130673477?spm=1001.2014.3001.5502");
        }
    }
}
