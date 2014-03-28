using System;
using System.Drawing;
namespace _2048
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(191, 156);
            this.txt_length.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(116, 29);
            this.txt_length.TabIndex = 0;
            this.txt_length.Text = "4";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(191, 222);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(116, 29);
            this.txt_sum.TabIndex = 1;
            this.txt_sum.Text = "128";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info.Location = new System.Drawing.Point(14, 13);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(377, 126);
            this.lb_info.TabIndex = 2;
            this.lb_info.Text = "2048小游戏beta版(内部测试0.0.0.6)\r\n支持网站：http://www.ligelaige.com/developer/ \r\n说明：\r\n     请" +
    "输入矩阵长度和闯关数值\r\n提醒：\r\n     矩阵长度不宜过大，闯关数值只能是2的n次幂。\r\n";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(140, 300);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 30);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "矩阵长度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "闯关数值：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.txt_length);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048小游戏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponent_hello(int flag)//0 代表输了 1 代表赢了
        {
            int xlength = this.Width, ylength = this.Height;

            int num = 2;
            
            
            string[] info = new string[num];
            info[0] = "在刷" + sum.ToString() + "的路上\r\n你从来不是一个人在战斗";
            info[1] = "你赢了,是否接着挑战" + (sum * 2).ToString();

            this.lb_screen = new System.Windows.Forms.Label();
            this.lb_screen.BackColor = Color.Transparent;

            this.lb_screen.Location = new System.Drawing.Point(xlength/8, ylength / 4);
            this.lb_screen.Size = new System.Drawing.Size(xlength * 3 / 4, ylength / 4);
            this.lb_screen.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_screen.Text = info[flag];
            
            this.Controls.Add(this.lb_screen);
            this.lb_screen.Visible = true;


            this.btn_hello = new System.Windows.Forms.Button[num];
            for (int i = 0; i < num; i++)
            {
                this.btn_hello[i] = new System.Windows.Forms.Button();
                this.btn_hello[i].Location = new System.Drawing.Point(xlength / 8 + i * xlength / 2, ylength * 4 / 8);
                this.btn_hello[i].Size = new System.Drawing.Size(xlength / 4, ylength / 4);                
                this.btn_hello[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.btn_hello[i].Enabled = true;
                this.Controls.Add(this.btn_hello[i]);
                this.btn_hello[i].BringToFront();
            }
            this.lb_screen.BringToFront();
            btn_hello[1].Text = "退出";
            btn_hello[0].Text = flag == 1 ? "继续" : "重来";
            this.btn_hello[0].Click += new System.EventHandler(this.btn_hello0_Click);
            this.btn_hello[1].Click += new System.EventHandler(this.btn_hello1_Click);

            if (flag==1)
            {               
                this.btn_save = new System.Windows.Forms.Button();
                this.btn_save.Location = new System.Drawing.Point(xlength / 8 + xlength / 4, ylength * 4 / 8);
                this.btn_save.Size = new System.Drawing.Size(xlength / 4, ylength / 4);
                this.btn_save.Text = "保存*";
                this.btn_save.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.btn_save.Enabled = true;
                this.Controls.Add(this.btn_save);
                this.btn_save.BringToFront();
                this.btn_save.Click += btn_save_Click;
            }

        }

        

        private void InitializeComponent_after()
        {
            this.Controls.Remove(this.label2);
            this.Controls.Remove(this.label1);
            this.Controls.Remove(this.btn_start);
            this.Controls.Remove(this.lb_info);
            this.Controls.Remove(this.txt_sum);
            this.Controls.Remove(this.txt_length);

            d = Int16.Parse(txt_length.Text.ToString());
            sum = Int16.Parse(txt_sum.Text.ToString());

            int start = 3;
            int length = 100;

            this.ClientSize = new System.Drawing.Size(start * 2 + d * length, start * 2 + d * length);

            this.Text = sum.ToString() + " → 2048 , " + d.ToString() + "×" + d.ToString();

            btn_num = new System.Windows.Forms.Button[d, d];
            ope = new int[d, d];

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    this.btn_num[i, j] = new System.Windows.Forms.Button();
                    this.btn_num[i, j].Location = new System.Drawing.Point(start + j * length, start + i * length);
                    this.btn_num[i, j].Size = new System.Drawing.Size(length, length);
                    this.btn_num[i, j].Enabled = false;
                    this.btn_num[i, j].Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                    this.Controls.Add(this.btn_num[i, j]);
                }
            }
        }

        #endregion

        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label lb_info;

        private System.Windows.Forms.Button[,] btn_num;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button[] btn_hello;
        private System.Windows.Forms.Label lb_screen;

        private System.Windows.Forms.Button btn_gono;

        private bool issave=false;
    }
}

