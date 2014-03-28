using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists(filename))
            {
                //存在
                this.btn_start.Location = new System.Drawing.Point(80, 300);
                
                btn_gono = new Button();

                this.btn_gono.Location = new System.Drawing.Point(220, 300);
                this.btn_gono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
                this.btn_gono.Name = "btn_gono";
                this.btn_gono.Size = new System.Drawing.Size(90, 30);
                this.btn_gono.TabIndex = 3;
                this.btn_gono.Text = "继续";
                this.btn_gono.UseVisualStyleBackColor = true;
                this.btn_gono.Click += new System.EventHandler(this.btn_gono_Click);
                this.Controls.Add(this.btn_gono);
            }

            d = Int16.Parse(txt_length.Text.ToString());
            sum = Int16.Parse(txt_sum.Text.ToString());
        }
        public int d;
        public static int[,] ope;
        private static  string filename = "out.xml";
        public static int sum = 2048;

        public void cd(int d)//判断状态，并输出状态
        {
            int t = 0;
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (ope[i, j] > t)
                    {
                        t = ope[i, j];
                    }
                }
            }//计算最大值t

            for (int i = 0; i < d; i++)//输出
            {
                for (int j = 0; j < d; j++)
                {
                    this.btn_num[i, j].Text = ope[i, j] == 0 ? "" : ope[i, j].ToString();
                }
            }

            if (t == sum)
            {
                InitializeComponent_hello(1);
                //MessageBox.Show("你赢了,是否继续挑战"+(sum*2).ToString());                
                sum *= 2;

            }
            if (judge(d) == 0)
            {
                //MessageBox.Show("在刷"+sum.ToString()+"的路上\r\n你从来不是一个人在战斗");
                InitializeComponent_hello(0);

                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        ope[i, j] = 0;
                        this.btn_num[i, j].Text = "";
                    }
                }
                add(d);

                cd(d);

                btn_backcolor(d);
            }
        }

        public int judge(int d)
        {
            int u = 0;
            int[,] te = new int[d, d];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    te[i, j] = ope[i, j];
                }
            }
            op(d);
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (te[i, j] != ope[i, j])
                    {
                        u = 1;
                        break;
                    }
                }
                if (u == 1)
                {
                    break;
                }
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    ope[i, j] = te[i, j];
                }
            }
            if (u != 0)
            {
                return u;
            }
            else
            {
                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        te[i, j] = ope[i, j];
                    }
                }
                rtol(d);
                op(d);
                rtol(d);
                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        if (te[i, j] != ope[i, j])
                        {
                            u = 1;
                            break;
                        }
                    }
                    if (u == 1)
                    {
                        break;
                    }
                }
                for (int i = 0; i < d; i++)
                {
                    for (int j = 0; j < d; j++)
                    {
                        ope[i, j] = te[i, j];
                    }
                }
                if (u != 0)
                {
                    return u;
                }
                else
                {
                    for (int i = 0; i < d; i++)
                    {
                        for (int j = 0; j < d; j++)
                        {
                            te[i, j] = ope[i, j];
                        }
                    }
                    utod(d);
                    utol(d);
                    op(d);
                    utol(d);
                    utod(d);
                    for (int i = 0; i < d; i++)
                    {
                        for (int j = 0; j < d; j++)
                        {
                            if (te[i, j] != ope[i, j])
                            {
                                u = 1;
                                break;
                            }
                        }
                        if (u == 1)
                        {
                            break;
                        }
                    }
                    for (int i = 0; i < d; i++)
                    {
                        for (int j = 0; j < d; j++)
                        {
                            ope[i, j] = te[i, j];
                        }
                    }
                    if (u != 0)
                    {
                        return u;
                    }
                    else
                    {
                        for (int i = 0; i < d; i++)
                        {
                            for (int j = 0; j < d; j++)
                            {
                                te[i, j] = ope[i, j];
                            }
                        }
                        utol(d);
                        op(d);
                        utol(d);
                        for (int i = 0; i < d; i++)
                        {
                            for (int j = 0; j < d; j++)
                            {
                                if (te[i, j] != ope[i, j])
                                {
                                    u = 1;
                                    break;
                                }
                            }
                            if (u == 1)
                            {
                                break;
                            }
                        }
                        for (int i = 0; i < d; i++)
                        {
                            for (int j = 0; j < d; j++)
                            {
                                ope[i, j] = te[i, j];
                            }
                        }
                        return u;
                    }
                }
            }
        }

        public void op(int d)
        {
            int[,] temp = new int[d, d];
            int[,] tem = new int[d, d];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tem[i, j] = ope[i, j];
                    temp[i, j] = ope[i, j];
                }
            }
            //将 temp=tem=ope; 

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    int r = 0;

                    for (int k = 0; k < d; k++)
                    {
                        if (tem[i, k] != 0)
                        {
                            int s = 0;
                            int y = 0;
                            for (int e = k + 1; e < d; e++)
                            {
                                if (tem[i, e] != 0)
                                {
                                    s = tem[i, e];
                                    y = e;
                                    break;
                                }
                            }
                            if (tem[i, k] == s)
                            {
                                r = 2 * s;
                                tem[i, k] = 0;
                                tem[i, y] = 0;
                                break;
                            }
                            else
                            {
                                r = tem[i, k];
                                tem[i, k] = 0;
                                break;
                            }
                        }
                    }
                    ope[i, j] = r;
                }
            }
            int r1 = 0;

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (ope[i, j] != temp[i, j])
                    {
                        r1 = 1;
                        break;
                    }
                }
                if (r1 == 1)
                {
                    break;
                }
            }
            if (r1 != 0)
            {
                this.add(d);
            }
        }

        public void add(int d)//随机在空缺位置（newaddi，newaddj）添数 2 或 4,并将填补的位置记录在 （newaddi，newaddj）
        {
            int s = 0;
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (ope[i, j] == 0)
                    {
                        s++;
                    }
                }
            }//计算0的个数

            Random rnd = new Random();

            int r = rnd.Next(0, s);//[0,s)
            s = 0;

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (ope[i, j] == 0)
                    {
                        if (s == r)
                        {
                            ope[i, j] = rnd.Next(1, 3) * 2;// 随机产生 2 或者 4                            
                            
                            return;
                        }
                        s++;
                    }
                }
            }
        }

        public static void rtol(int d)
        {
            int[,] tem = new int[d, d];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tem[i, j] = ope[i, j];
                }
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    ope[i, j] = tem[i, d - 1 - j];
                }
            }
        }

        public static void utod(int d)
        {
            int[,] tem = new int[d, d];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tem[i, j] = ope[i, j];
                }
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    ope[i, j] = tem[d - 1 - i, j];
                }
            }
        }

        public static void utol(int d)
        {
            int[,] tem = new int[d, d];
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    tem[i, j] = ope[i, j];
                }
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    ope[i, j] = tem[j, i];
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //a:left d:right s:down w:up
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W: //上 
                    utol(d);
                    op(d);
                    utol(d);

                    break;

                case Keys.S:
                case Keys.Down://下
                    utod(d);
                    utol(d);
                    op(d);
                    utol(d);
                    utod(d);

                    break;
                case Keys.A:
                case Keys.Left://左
                    op(d);
                    break;

                case Keys.D:
                case Keys.Right://右
                    rtol(d);
                    op(d);
                    rtol(d);
                    break;
            }
            cd(d);

            btn_backcolor(d);

            this.Text = sum.ToString() + " → 2048 , " + d.ToString() + "×" + d.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            if (File.Exists(filename))
            {
                this.Controls.Remove(this.btn_gono);
            }

            InitializeComponent_after();
            
            add(d);

            cd(d);
            btn_backcolor(d);
        }

        private void btn_gono_Click(object sender, EventArgs e)
        {            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Controls.Remove(this.btn_gono);
            InitializeComponent_after();

            ope = ReaderXml(filename);            

            cd(d);
            btn_backcolor(d);
        }

        private void btn_hello1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hello0_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.btn_hello[0]);
            this.Controls.Remove(this.btn_hello[1]);
            this.Controls.Remove(this.lb_screen);
            this.Controls.Remove(this.btn_save);
        }

        void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.Text = "保存";
            issave = !issave;

            
            WriterXml(filename, sum, ope);
        }
        private void btn_backcolor(int d)
        {
            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    int n = 0;
                    int r = 255, g = 255, b = 255;
                    if (btn_num[i, j].Text.ToString() != "")
                    {
                        n = int.Parse(btn_num[i, j].Text);
                        n = (int)(Math.Log(2, n) / Math.Log(2, 2048) * 256 * 256) - 1;

                        b = n % 256;
                        n /= 256;
                        g = n % 256;
                        n /= 256;
                        r = n % 256;
                    }

                    btn_num[i, j].BackColor = Color.FromArgb(b, g, r);
                    btn_num[i, j].ForeColor = Color.FromArgb(r, g, b);                    
                }
            }
        }

        private static void WriterXml(string filename, int edge, int[,] matrix)//文件 等级 矩阵
        {
            int length = (int)Math.Sqrt(matrix.Length);
            XmlDocument xd = new XmlDocument();

            XmlElement egame = xd.CreateElement("game");
            egame.SetAttribute("edge", "" + edge);

            for (int i = 0; i < length; ++i)
            {
                XmlElement eline = xd.CreateElement("line");
                eline.SetAttribute("row", "" + i);

                for (int j = 0; j < length; ++j)
                {
                    XmlElement ecell = xd.CreateElement("cell");
                    ecell.SetAttribute("col", "" + j);
                    ecell.SetAttribute("value", "" + matrix[i, j]);
                    eline.AppendChild(ecell);
                }
                egame.AppendChild(eline);
            }
            xd.AppendChild(egame);

            XmlTextWriter xtw = new XmlTextWriter(filename, Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;

            xd.WriteTo(xtw);
            xtw.Flush();
            xtw.Close();
        }

        private static int[,] ReaderXml(string filename)//文件 等级 矩阵
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);

            XmlNode egame = xmlDoc.SelectSingleNode("game");
            sum = Int32.Parse(((XmlElement)egame).GetAttribute("edge"));

            XmlNodeList elines = egame.ChildNodes;
            int length = elines.Count;
            int[,] matrix = new int[length, length];

            foreach (XmlNode line in elines)
            {
                int i = Int32.Parse(((XmlElement)line).GetAttribute("row"));

                XmlNodeList ecells = line.ChildNodes;
                foreach (XmlNode cell in ecells)
                {
                    int j = Int32.Parse(((XmlElement)cell).GetAttribute("col"));
                    matrix[i, j] = Int32.Parse(((XmlElement)cell).GetAttribute("value"));
                }
            }

            return matrix;
        }
    }
}
