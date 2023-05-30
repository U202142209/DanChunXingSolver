/// author:@我不是大佬
/// QQ    :2869210303
/// Email :2869210303@qq.com
/// wx    :safeseaa
/// CopyRight Protected

using System;

namespace DanChunXingWindow
{
    class Retional
    {
        private int num;        //分子
        private int den;        //分母
        // num = 0; den = 1;
        public Retional()
        {
            //这个是无参数的构造方法
            num = 0; den = 1;
        }
        public Retional(string sss)
        {
            string[] res = sss.Split('/');
            if (res.Length == 1)
            {
                this.num = Convert.ToInt32(res[0]);
                this.den = 1;
            }
            else if (res.Length == 2)
            {
                this.num = Convert.ToInt32(res[0]);
                this.den = Convert.ToInt32(res[1]);
            }
        }

        // 拷贝构造方法
        public Retional(Retional a)
        {
            this.num = a.num;       //将有理数a赋值过来
            this.den = a.den;
        }
        // 使用分子分母构造有理数
        public Retional(int a, int b)
        {
            //一直分子分母构造有理数
            this.num = a;
            this.den = b;
        }
        //这个方法用来获取this.den 
        public int GetDen()
        {
            return this.den;
        }
        //这个方法用来获取this.num 
        public int GetNum()
        {
            return this.num;
        }
        //约分方法
        public void Optimization()
        {
            if (num == 0)
            {
                den = 1;
                return;
            }
            int a = num, b = den;
            while (b != 0)
            {
                int mod = a % b;
                a = b;
                b = mod;
            }

            num /= a;
            den /= a;
        }
        //两个有理数相加
        public static Retional operatorplus(Retional rat1, Retional rat2)
        {
            Retional temp = new Retional(rat1.num * rat2.den + rat1.den * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        public static Retional operator +(Retional rat1, Retional rat2)
        {
            Retional temp = new Retional(rat1.num * rat2.den + rat1.den * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        //两个有理数相减
        public static Retional operatorsubstract(Retional rat1, Retional rat2)
        {
            if (rat2.num == 0)
                return rat1;
            Retional temp = new Retional(rat1.num * rat2.den - rat1.den * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        public static Retional operator -(Retional rat1, Retional rat2)
        {
            if (rat2.num == 0)
                return rat1;
            Retional temp = new Retional(rat1.num * rat2.den - rat1.den * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        //两个有理数相加*
        public static Retional operatormultiply(Retional rat1, Retional rat2)
        {
            Retional temp = new Retional(rat1.num * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        public static Retional operator *(Retional rat1, Retional rat2)
        {
            Retional temp = new Retional(rat1.num * rat2.num, rat1.den * rat2.den);
            temp.Optimization();
            return temp;
        }
        public static Retional operator *(int a, Retional rat2)
        {
            Retional temp = new Retional(a * rat2.num, rat2.den);
            temp.Optimization();
            return temp;
        }
        //两个有理数相/
        public static Retional operatordivide(Retional r1, Retional r2)
        {
            if (r2.num == 0)
                throw new Exception("除数为0了！");
            Retional temp = new Retional(r1.num * r2.den, r1.den * r2.num);
            temp.Optimization();
            return temp;
        }
        public static Retional operator /(Retional r1, Retional r2)
        {
            if (r2.num == 0)
                throw new Exception("除数为0了！");
            Retional temp = new Retional(r1.num * r2.den, r1.den * r2.num);
            temp.Optimization();
            return temp;
        }

        //同时获取分子和分母，返回形如2/5类似的形式
        public string GetResult()
        {
            string os = "";
            if (num == 0)
                return "0";
            else if (IsNegative())
            {
                if (Math.Abs(den) == 1)
                    os += "-" + Math.Abs(num);
                else
                    os += "-" + Math.Abs(num) + "/" + Math.Abs(den);
            }
            else
            {
                if (Math.Abs(den) == 1)
                    os += num.ToString();
                else
                    os += num.ToString() + "/" + den.ToString();
            }
            return os;
        }
        // 判断是否小于0
        public bool IsNegative()
        {
            return num * den < 0;
        }
        // 判断是否大于0
        public bool IsPositive()
        {
            return num * den > 0;
        }
        // 重载等于
        public static int Compare(Retional r1, Retional r2)
        {
            r1.Optimization();
            r2.Optimization();
            if (r1.num * r2.den == r2.num * r1.den)
                return 0;
            else if (r1.num * r2.den > r2.num * r1.den)
                return 1;
            else return -1;
        }
        // 格式化输出
        public string FormatPrint()
        {
            string res = this.GetResult();
            if (res == "1")
                return "";
            else if (res == "-1")
                return "-";
            else return res;
        }

    }       // 有理数类

    class matrix
    {
        private int rows, cols;//矩阵的行数,列数
        private Retional[,] elems;//矩阵的元素为有理数
        // 创建单位阵
        public matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.elems = new Retional[rows, cols];
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (i == j)
                        this.elems[i - 1, j - 1] = new Retional(1, 1);
                    else
                        this.elems[i - 1, j - 1] = new Retional(0, 1);
                }
            }
        }
        // 空的拷贝构造函数
        public matrix(matrix ob)
        {
            this.rows = ob.rows;
            this.cols = ob.cols;
            this.elems = new Retional[rows, cols];
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    this.elems[i - 1, j - 1] = ob.elems[i - 1, j - 1];
                }
            }
        }

        // 默认构造函数
        public matrix()
        {

        }
        // 使用二维有理数数组构造函数
        public matrix(int rows, int cols, Retional[,] elems)
        {
            this.rows = rows;
            this.cols = cols;
            this.elems = new Retional[rows, cols];
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    this.elems[i - 1, j - 1] = elems[i - 1, j - 1];
                }
            }
        }

        // 根据给定的字符串创建矩阵,构造函数
        public matrix(int m_rows, int m_cols, string m_input)
        {
            string[] res = m_input.Split(',');
            if (res.Length != m_rows * m_cols)
                throw new Exception($"在生成系数矩阵A时，给定的数据数量为{res.Length},无法生成行数:{m_rows},列数:{m_cols}的矩阵");
            this.rows = m_rows;
            this.cols = m_cols;
            this.elems = new Retional[rows, cols];
            short count = 0;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    this.elems[i - 1, j - 1] = new Retional(res[count++]);
                }
            }

        }
        // 属性与索引值GET /SET
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }
        // 如通过A[2,3]访问矩阵，访问索引从 1 开始
        public Retional this[int irow, int jcol]
        {
            get { return elems[irow - 1, jcol - 1]; }
            set { elems[irow - 1, jcol - 1] = value; }
        }

        // 转化为字符串√
        public override string ToString()
        {
            string m_output = "";
            for (int i = 1; i <= this.rows; i++)
            {
                for (int j = 1; j <= this.cols; j++)
                {
                    //调用有理数显示成字符串的方法
                    m_output += "\t" + elems[i - 1, j - 1].GetResult();
                }
                m_output += "\r\n";
            }
            return m_output;
        }

        // 矩阵的加法运算√
        public static matrix operator +(matrix m1, matrix m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
                throw new Exception("矩阵加法运算的行列必须相同");
            matrix mt = new matrix(m1.rows, m1.cols);
            for (int i = 1; i <= m1.rows; i++)
            {
                for (int j = 1; j <= m1.cols; j++)
                {
                    //调用有理数的加法运算方法
                    mt.elems[i - 1, j - 1] = Retional.operatorplus(m1.elems[i - 1, j - 1], m2.elems[i - 1, j - 1]);
                }
            }
            return mt;
        }
        // 矩阵的减法运算√
        public static matrix operator -(matrix m1, matrix m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
                throw new Exception("矩阵减法运算的行列必须相同");
            matrix mt = new matrix(m1.rows, m1.cols);
            for (int i = 1; i <= m1.rows; i++)
            {
                for (int j = 1; j <= m1.cols; j++)
                {
                    mt.elems[i - 1, j - 1] = m1.elems[i - 1, j - 1] - m2.elems[i - 1, j - 1];
                }
            }
            return mt;
        }
        // 矩阵的乘法运算√
        public static matrix operator *(matrix m1, matrix m2)
        {
            if (m1.cols != m2.rows)
                throw new Exception("乘法：第二个矩阵的行数和第一个矩阵的列数不同，无法计算");
            else
            {
                matrix mt = new matrix(m1.rows, m2.cols);  //创建单位矩阵
                for (int i = 1; i <= mt.rows; i++)
                {
                    for (int j = 1; j <= mt.cols; j++)
                    {
                        mt[i, j] = new Retional(0, 1);
                        for (int k = 1; k <= m1.cols; k++)
                        {
                            mt[i, j] = mt[i, j] + m1[i, k] * m2[k, j];
                        }
                    }
                }
                return mt;
            }
        }
        // 矩阵合并√
        public static matrix Merge(matrix m1, matrix m2)
        {
            if (m1.rows != m2.rows)
                throw new Exception("两个矩阵的行数不相同，无法合并");
            matrix mt = new matrix(m1.rows, m1.cols + m2.cols);
            for (int i = 1; i <= m1.rows; i++)
            {
                for (int j1 = 1; j1 <= m1.cols; j1++)
                {
                    mt[i, j1] = m1[i, j1];
                }
                for (int j2 = 1; j2 <= m2.cols; j2++)
                {
                    mt[i, m1.cols + j2] = m2[i, j2];
                }
            }
            return mt;
        }
        // 获取行列式
        public Retional[,] getElems()
        {
            return this.elems;
        }
        // 获取修改行列式
        public Retional[,] ELEMS
        {
            get { return elems; }
            set { elems = value; }
        }
        //求矩阵的行列式
        public Retional det()//矩阵运算行列式
        {
            int num = 1;
            Retional rational = new Retional(1, 1);
            Retional rational2 = new Retional(0, 1);
            Retional rational3 = new Retional(0, 1);
            matrix matrix = new matrix(rows, cols);
            int i; int j;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= cols; j++)
                {
                    matrix.elems[i - 1, j - 1] = elems[i - 1, j - 1];
                }
            }
            i = 1;
            j = 1;
            Retional result;
            while (i <= rows && j <= cols)
            {
                bool flag = false;
                for (int k = i; k <= rows; k++)
                {
                    if (matrix.elems[k - 1, j - 1].GetNum() != 0)
                    {
                        flag = true;
                        if (k != i)
                        {
                            num = -num;
                            for (int l = j; l <= cols; l++)
                            {
                                rational3 = matrix.elems[k - 1, l - 1];
                                matrix.elems[k - 1, l - 1] = matrix.elems[i - 1, l - 1];
                                matrix.elems[i - 1, l - 1] = rational3;
                            }
                        }
                        break;
                    }
                }
                if (!flag)
                {
                    result = rational2;
                    return result;
                }
                //rtional *= matrix.elems[i - 1, j - 1];
                rational = Retional.operatormultiply(rational, matrix.elems[i - 1, j - 1]);
                for (int l = j + 1; l <= cols; l++)
                {
                    matrix.elems[i - 1, l - 1] = Retional.operatordivide(matrix.elems[i - 1, l - 1], matrix.elems[i - 1, j - 1]);
                }
                matrix.elems[i - 1, j - 1] = new Retional(1, 1);
                for (int m = 1; m <= rows; m++)
                {
                    if (m != i)
                    {
                        rational3 = matrix.elems[m - 1, j - 1];
                        for (int l = j; l <= cols; l++)
                        {
                            Retional r中间值 = Retional.operatormultiply(rational3, matrix.elems[i - 1, l - 1]);
                            matrix.elems[m - 1, l - 1] = Retional.operatordivide(matrix.elems[m - 1, l - 1], r中间值);
                        }
                    }
                }
                i++;
                j++;
            }
            rational = new Retional(rational.GetNum() * num, rational.GetDen());
            result = rational;
            return result;
        }

        //矩阵化标准型
        static bool bb;
        static int i, j;
        public matrix rowt(out int rm, out string strout)
        {
            // 返回的矩阵“matrix rowt”为原矩阵的行标准型矩阵
            // 返回整数值“out int rm”为原矩阵的秩
            // 返回的字符串“out string strout ”为行标准型变换过程字符串
            Retional tem = new Retional(0, 1);//临时有理数
            matrix mt = new matrix(rows, cols);//临时矩阵
            strout = "";
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= cols; j++)
                {
                    mt.elems[i - 1, j - 1] = elems[i - 1, j - 1];
                }
            }
            i = 1; j = 1;
            rm = 0;
            string str;
            while (i <= mt.rows && j <= mt.cols)
            {
                strout = strout + (j - 1) + "--------------------\r\n";
                str = mt.ToString();
                strout += str;
                bb = false;
                for (int k = i; k <= mt.rows; k++)
                {
                    if (mt.elems[k - 1, j - 1].GetNum() != 0)
                    {
                        bb = true;
                        if (k != i)
                        {
                            for (int l = j; l <= mt.cols; l++)
                            {
                                tem = mt.elems[k - 1, l - 1];
                                mt.elems[k - 1, l - 1] = mt.elems[i - 1, l - 1];
                                mt.elems[i - 1, l - 1] = tem;
                            }
                        }
                        break;
                    }
                }
                if (bb == true)
                {
                    rm++;
                    for (int l = j; l <= mt.cols; l++)
                    {
                        mt.elems[i - 1, l - 1] = Retional.operatordivide(mt.elems[i - 1, l - 1], mt.elems[i - 1, j - 1]);
                    }
                    for (int m = 1; m <= mt.rows; m++)
                    {
                        if (m != i)
                        {
                            tem = mt.elems[m - 1, j - 1];
                            for (int l = j; l <= mt.cols; l++)
                            {
                                Retional t中间值 = Retional.operatormultiply(tem, mt.elems[i - 1, l - 1]);
                                mt.elems[m - 1, l - 1] = Retional.operatorsubstract(mt.elems[m - 1, l - 1], t中间值);
                            }
                        }
                    }
                    i++;
                    j++;
                }
                else
                    j++;
            }
            strout = strout + (j - 1) + "--------------------\r\n";
            str = mt.ToString();
            strout += str;
            strout += "End--------------------\r\n";
            return mt;
        }
        //求矩阵的逆 return new matrix(rows, rows); //逆矩阵
        public matrix mat_inv(out string strout)
        {
            matrix mt = new matrix(this.rows, this.cols);//临时矩阵
            Retional temp = new Retional(0, 1);//临时有理数
            int i, j, i1, j1, k; strout = "";
            mt.rows = this.rows; mt.cols = this.cols;
            for (i = 0; i < this.rows; i++)//把当前矩阵this赋给临时矩阵mt 
            {
                for (j = 0; j < this.cols; j++)
                {
                    mt.elems[i, j] = this.elems[i, j];
                }
            }
            i = 0; j = 0;
            strout += Convert.ToString(j) + "----------------------------------\n";
            strout += mt.ToString();

            for (i = 0; i < mt.rows; i++)
            {
                for (k = i; k < mt.rows; k++)//找到第一个第[i,i]位置往下第一个不为零元素，并交换行
                {
                    if (mt.elems[k, i].GetNum() != 0)
                    {
                        for (j1 = 0; j1 < mt.cols; j1++)
                        {
                            temp = mt.elems[k, j1];
                            mt.elems[k, j1] = mt.elems[i, j1];
                            mt.elems[i, j1] = temp;
                        }
                        break;
                    }
                }

                if (mt.elems[i, i].GetNum() != 0)//找到非零的 否则报错->0没有倒数
                {
                    temp = new Retional(mt.elems[i, i].GetDen(), mt.elems[i, i].GetNum());
                    for (j = 0; j < mt.cols; j++)
                    {
                        mt.elems[i, j] = Retional.operatormultiply(mt.elems[i, j], temp);
                    }

                    for (i1 = 0; i1 < mt.rows; i1++)
                    {
                        temp = new Retional(mt.elems[i1, i].GetNum(), mt.elems[i1, i].GetDen());
                        if (mt.elems[i1, i].GetNum() == 0 || i1 == i) continue;
                        else
                        {
                            for (j1 = 0; j1 < mt.cols; j1++)
                            {
                                Retional 中间值 = Retional.operatormultiply(temp, mt.elems[i, j1]);
                                mt.elems[i1, j1] = Retional.operatorsubstract(mt.elems[i1, j1], 中间值);
                            }
                        }
                    }
                }
                strout += Convert.ToString(i + 1) + "----------------------------------\n";
                strout += mt.ToString();

            }
            strout += "End----------------------------------\n";
            matrix mr = new matrix(rows, rows); //逆矩阵
            for (i = 0; i < mt.rows; i++)
            {
                for (j = mt.rows; j < mt.cols; j++)
                {
                    mr.elems[i, j - mt.rows] = mt.elems[i, j];
                }
            }
            return mr;//返回逆矩阵
        }
        // 归零
        public void Zeros()
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    this.elems[i - 1, j - 1] = new Retional(0, 1);
                }
            }
        }
    }         // 基于有理数的矩阵类
    /// 解决标准的单纯性表问题
    /// minS= c1X1 + c2X2 + ~~~ + cnXn
    /// AX=B , B>=0.
    /// A必须为（N,E）的形式，其中E为单位矩阵,需要自己添加变量成为等式v
    class DanChunXingSolver
    {
        private matrix m_C;     // C
        private matrix m_B;     // B
        private matrix m_A;     // A
        private matrix m_table; // 单纯形表
        private int[] xj;       // 基变量
        private int q;          // 离基变量索引
        private int p;          // 进基变量索引
        private int r;          // 系数矩阵A的行数
        private int c;          // 系数矩阵A的列数
        private bool IsBestTable = false;
        public DanChunXingSolver() {
            throw new Exception("class DanChunXingSolver could only be constructed with parameters init function.");
        }
        public DanChunXingSolver(matrix A, matrix B, matrix C)
        {
            matrix CB;      // CB
            matrix CN;      // CN
            matrix N;       // 非基变量对应的矩阵
                            // 判断是否是合法的输入 A必须为（N,E）的形式，其中E为单位矩阵
            r = A.Rows;
            c = A.Cols;
            if (r == c)
                throw new Exception("系数矩阵无效，行数与列数不能相同。");
            for (int i = 1; i <= r; i++)
            {
                if (A[i, c - r + i].GetNum() != 1)
                    throw new Exception("输入错误，系数矩阵A必须为（N,E）的形式，其中E为单位矩阵");
            }
            for (int i = 1; i <= r; i++)
                if (B[i, 1].IsNegative())
                    throw new Exception("矩阵 b 存在小于零的数，无法进行单纯形表的操作");

            this.m_A = new matrix(A);
            this.m_B = new matrix(B);
            this.m_C = new matrix(C);
            xj = new int[r];
            // 定义单纯性表
            m_table = new matrix(r + 1, c + 1);
            CB = new matrix(1, r);
            for (int i = 1; i <= r; i++)
                CB[1, i] = m_C[1, c - r + i];
            CN = new matrix(1, c - r);
            for (int i = 1; i <= c - r; i++)
                CN[1, i] = m_C[1, i];
            N = new matrix(r, c - r);
            for (int i = 1; i <= r; i++)
                for (int j = 1; j <= c - r; j++)
                    N[i, j] = m_A[i, j];
            B = new matrix(r, r);        // 单位阵
            Retional S = (CB * m_B)[1, 1];
            matrix Y0 = CN - (CB * N);

            // 构架tablee
            m_table[1, 1] = -1 * S;
            for (int i = 0; i < c - r; i++)
                m_table.ELEMS[0, i + 1] = Y0[1, i + 1];
            for (int i = c - r; i < c; i++)
                m_table.ELEMS[0, i + 1] = new Retional(0, 1);
            for (int i = 1; i <= r; i++)
                m_table[i + 1, 1] = m_B[i, 1];
            for (int i = 1; i <= r; i++)
                for (int j = 1; j <= c; j++)
                    m_table.ELEMS[i, j] = m_A[i, j];
            // 初始化进基，离基变量
            for (int i = c - r + 1; i <= c; i++)
                xj[i - (c - r) - 1] = i;

        }
        private string PrintTable()
        {
            string res = "\t";
            for (int i = 1; i <= c; i++)
            {
                res += $"\tx{i}";
            }
            res += "\r\n\t" + m_table[1, 1].GetResult();
            for (int i = 1; i <= c; i++)
                res += "\t" + m_table[1, i + 1].GetResult();
            for (int i = 1; i <= r; i++)
            {
                res += "\r\nx" + xj[i - 1] + "\t" + m_table[i + 1, 1].GetResult();
                for (int j = 1; j <= c; j++)
                    if (!IsBestTable && p == i && q == j)
                        res += "\t【" + m_table.ELEMS[i, j].GetResult() + "】";
                    else
                        res += "\t" + m_table.ELEMS[i, j].GetResult();
            }
            return res;

        }        // 打印单纯形表
        private bool IsBest()
        {
            for (int i = 1; i <= c; i++)
                if (m_table.ELEMS[0, i].IsNegative())
                {
                    q = i;
                    // 寻找p
                    bool flag = false; p = 1;
                    Retional temp = new Retional(999999, 1);
                    for (int m = 1; m <= r; m++)
                    {
                        if (m_table.ELEMS[m, q].IsPositive())
                        {
                            flag = true;
                            Retional T = m_table.ELEMS[m, 0] / m_table.ELEMS[m, q];
                            if (Retional.Compare(temp, T) > 0)
                            {
                                temp = new Retional(T);
                                p = m;
                            }
                        }
                    }
                    if (!flag)
                        throw new Exception("\n单纯性表没有有限最优解。\n-----------------");
                    // 进基，离基
                    JinJI(p, q);
                    // Console.WriteLine($"p={p},q={q}");
                    return false;
                }
            IsBestTable = true;
            return true;
        }              // 判断是否最优 
        private void JinJI(int pp, int qq)
        {
            xj[pp - 1] = qq;
        } // 调整进基变量，离基变量
        public string showproblem()
        {
            string res = "解线性规划问题：\n\tminS = ";
            for (int i = 1; i <= m_C.Cols; i++)
            {
                if (m_C[1, i].IsPositive())
                    if (i == 1)
                        res += $" {m_C[1, i].FormatPrint()}x{i} ";
                    else
                        res += $"+{m_C[1, i].FormatPrint()}x{i} ";
                else if (m_C[1, i].IsNegative())
                    res += $" {m_C[1, i].FormatPrint()}x{i} ";
                else res += "\t";
            }
            for (int i = 1; i <= m_A.Rows; i++)
            {
                res += $"\n\t{m_table[i + 1, 1].FormatPrint()}\t=";
                for (int j = 1; j <= m_A.Cols; j++)
                {
                    if (m_A[i, j].IsPositive())
                        if (j == 1)
                            res += $"{m_A[i, j].FormatPrint()}x{j} ";
                        else
                            res += $"+ {m_A[i, j].FormatPrint()}x{j} ";
                    else if (m_A[i, j].IsNegative())
                        res += $" {m_A[i, j].FormatPrint()}x{j} ";
                    else res += "\t";
                }
            }
            return res;
        }       // 以方程组的形式输出线性规划的问题
        public Retional Solve(out matrix X, out string out_string)
        {
            out_string = showproblem(); ;
            X = new matrix(1, c);
            X.Zeros();
            short count = 1;
            out_string += $"\n初始化单纯形表:";
            while (!IsBest())
            {
                // 输出操作内容    
                out_string += $"\n分表：{count++}\n" + PrintTable() + "\n------------------------------------------------------------------";
                // 此时不是最优的单纯形表
                // 进行行变换
                Retional temp = m_table.ELEMS[p, q];
                for (int m = 0; m <= c; m++)
                    m_table.ELEMS[p, m] = m_table.ELEMS[p, m] / temp;
                // 进行初等行变换
                for (int i = 0; i <= r; i++)
                {
                    if (i != p)
                    {
                        temp = m_table.ELEMS[i, q];
                        for (int j = 0; j <= c; j++)
                            m_table.ELEMS[i, j] = m_table.ELEMS[i, j] - temp * m_table.ELEMS[p, j];
                    }
                }
            }
            out_string += $"\n分表：{count++}\n" + PrintTable() + "\n------------------------------------------------------------------";
            // 给X赋值
            for (int i = 0; i < xj.Length; i++)
            {
                X[1, xj[i]] = m_table.ELEMS[i + 1, 0];
            }
            out_string += $"\n求解的结果：min S=" + (-1 * m_table[1, 1]).GetResult() + "\n X=( " + X[1, 1].GetResult();
            for (int i = 2; i <= X.Cols; i++)
                out_string += $",{X[1, i].GetResult()}";
            out_string += " )T";
            return -1 * m_table[1, 1];
        }   //求解
    }

    class Config
    {
        public static DanChunXingSolver dcx;
        public static string ma_string = "";
        public static string mb_string = "";
        public static string mc_string = "";
        public static string mrow = "2";
        public static string mcol = "5";
    }
}
