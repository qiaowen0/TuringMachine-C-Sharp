using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        private int readHeadX;
        private int paperX;
        private int writeCharX;
        Point endPos;
        int width;

        TabClass tab;
        int tabResult;
        int currentStatue;
        int paperReadOrder;

        string stringDection2;
        string stringHelp;

        public Form1()
        {
            InitializeComponent();

            width = 30;
            endPos = new Point(picPoint.Size.Width, width);

            readHeadX = width;
            paperX = 0;
            writeCharX = 0;

            tab = new TabClass();
            tabResult = -1;
            currentStatue = -1;
            paperReadOrder = -1;
        }

        bool onInit = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileTM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileTM.FileName);
                string str = streamReader.ReadLine();
                if (str[0] != '*')
                {
                    streamReader.Dispose();
                    return;
                }
                txtStatues.Text = streamReader.ReadLine();
                txtInputChars.Text = streamReader.ReadLine();
                txtSignChars.Text = streamReader.ReadLine();
                txtStartStatue.Text = streamReader.ReadLine();
                txtBlackChar.Text = streamReader.ReadLine();
                txtEndStatues.Text = streamReader.ReadLine();
                txtJmpFunc.Text = "";
                while (!streamReader.EndOfStream)
                {
                    str = streamReader.ReadLine();
                    if (str[0] == '#') break;
                    txtJmpFunc.Text += str + "\r\n";
                }

                stringHelp = "Nothing";
                while (!streamReader.EndOfStream)
                {
                    str = streamReader.ReadLine();
                    if (str == "Help")
                    {
                        stringHelp = "";
                        while (!streamReader.EndOfStream)
                        {
                            stringHelp += streamReader.ReadLine() + "\r\n";
                        }
                    }
                }
                streamReader.Dispose();
                txtStringDetection.Text = "";
                tabResult = tab.Init(txtStatues.Text, txtEndStatues.Text, txtJmpFunc.Text);
                if (tabResult == 0)
                {
                    txtStatues.ReadOnly = true;
                    txtInputChars.ReadOnly = true;
                    txtSignChars.ReadOnly = true;
                    txtStartStatue.ReadOnly = true;
                    txtBlackChar.ReadOnly = true;
                    txtEndStatues.ReadOnly = true;
                    txtJmpFunc.ReadOnly = true;
                    paperReadOrder = 1;
                    currentStatue = tab.GetOrder(txtStartStatue.Text);
                }
                onInit = true;
                
            }

        }


        
        private int printPaper(int direction, int headDirection)
        {
            Graphics graphics1 = Graphics.FromHwnd(this.picPoint.Handle);
            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new System.Drawing.Font(this.Font.Name, 18);
            
            Bitmap bufferBmp = new Bitmap(picPoint.Size.Width, picPoint.Size.Height);
            Graphics buf_g = Graphics.FromImage(bufferBmp);

            //picPoint.Invalidate();
            //picPoint.Update();

            //Invalidate(); 
            //Update();
            //改变显示区元件信息
            paperX += direction;
            writeCharX += direction;
            readHeadX += direction;
            if (headDirection > 0) readHeadX += width;
            else if (headDirection < 0) readHeadX -= width;

            //边框显示
            buf_g.DrawLine(blackPen, 0, 1, endPos.X, 1);
            buf_g.DrawLine(blackPen, 0, endPos.Y, endPos.X, endPos.Y);
            //graphics.DrawLine(blackPen, 0, 0, 0, endPos.Y);
            //graphics.DrawLine(blackPen, endPos.X-1, 0, endPos.X-1, endPos.Y);

            //竖线显示
            int x = paperX % width;
            if (x < 0) x = width + x;
            for (int i = 0 + x; i < endPos.X; i += width)
            {
                buf_g.DrawLine(blackPen, i, 0, i, endPos.Y);
            }
            
            
            //字符串显示
            int y = writeCharX;
            int z = 0;
            if (y < 0)
            {
                z = -y / 30;
                y = y % 30;
            }
            for (int i = 0 + y; i < endPos.X; i += width)
            {
                if (z >= txtStringDetection.Text.Length) break;
                buf_g.DrawString(txtStringDetection.Text[z++].ToString(), font, brush, i + 5, 2);
            }

            //读头状态显示
            int w = 0;
            if (readHeadX < -15)
            {
                w = -15;
            }
            else if (readHeadX > endPos.X - 5)
            {
                w = endPos.X - 5;
            }
            else
            {
                w = readHeadX;
            }
            picArror.Location = new Point(picPoint.Location.X + 3 + w, picPoint.Location.Y - 30);
            labShowStatue.Location = new Point(picPoint.Location.X + 3 + w, picPoint.Location.Y - 45);

            picPoint.Invalidate();
            picPoint.Update();
            graphics1.DrawImage(bufferBmp, 0, 0);
           
            blackPen.Dispose();
            brush.Dispose();
            font.Dispose();
            graphics1.Dispose();

            buf_g.Dispose();
            bufferBmp.Dispose();

            return 0;
        }

        private void recPint_Paint(object sender, PaintEventArgs e)
        {
            printPaper(0, 0);
        }


        Point mouseDownPos = new Point(0, 0);
        bool isMouseDown = false;
        private void picPoint_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPos = e.Location;
            isMouseDown = true;
        }

        private void picPoint_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            printPaper(e.Location.X - mouseDownPos.X, 0);
        }

        private void picPoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                printPaper(e.Location.X - mouseDownPos.X, 0);
                mouseDownPos = e.Location;
            }
        }

        private void picPoint_MouseLeave(object sender, EventArgs e)
        {
            isMouseDown = false;
        }

        private void rectangleShape1_Paint(object sender, PaintEventArgs e)
        {
            endPos.X = picPoint.Size.Width;
            printPaper(0, 0);
        }

        bool isbtn = false;
        private void btnGetDetectinonString_Click(object sender, EventArgs e)
        {
            if (!onInit) return;
            if (tabResult == 0)
            {
                if (!isbtn)
                {
                    txtStringDetection.ReadOnly = true;
                    stringDection2 = txtStringDetection.Text;
                    btnGetDetectinonString.Text = "输入字符";
                   
                    if (txtStringDetection.Text[0] != 'B')
                    {
                        txtStringDetection.Text = txtStringDetection.Text.Insert(0, "B");
                    }
                    if (txtStringDetection.Text[txtStringDetection.Text.Length-1] != 'B')
                    {
                        txtStringDetection.Text = txtStringDetection.Text.Insert(txtStringDetection.Text.Length, "B");
                    }
                    readHeadX = width;
                    paperX = 0;
                    writeCharX = 0;
                    tabResult = tab.Init(txtStatues.Text, txtEndStatues.Text, txtJmpFunc.Text);
                    if (tabResult == 0)
                    {
                        paperReadOrder = 1;
                        currentStatue = tab.GetOrder(txtStartStatue.Text);
                    }
                    printPaper(0, 0);
                }
                else
                {
                    txtStringDetection.ReadOnly = false;
                    btnGetDetectinonString.Text = "识别字符";
                }
                isbtn = !isbtn;

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            char write = ' ';
            int direction = 0;
            int nextStatue = 0;
            if (!onInit) return;
            if (!isbtn) return;
            if (txtStringDetection.Text == "") return;

            int x = tab.GetJmpInfo(currentStatue, txtStringDetection.Text[paperReadOrder], ref write, ref direction, ref nextStatue);
            if (x == 0)
            {
                txtStringDetection.Text = txtStringDetection.Text.Remove(paperReadOrder, 1);
                txtStringDetection.Text = txtStringDetection.Text.Insert(paperReadOrder, write.ToString());
                currentStatue = nextStatue;
                paperReadOrder += direction;
                printPaper(0, direction);
            }
            else
            {
                if (tab.IsEndStatue(currentStatue) == 1) MessageBox.Show("正常终止！" + stringDection2);
                else MessageBox.Show("无法识别该串！ " + stringDection2);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (!onInit) return;
            if (!isbtn) return;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            char write = ' ';
            int direction = 0;
            int nextStatue = 0;

            if (!onInit) return;
            if (!isbtn) return;
            if (txtStringDetection.Text == "") return;

            int x = tab.GetJmpInfo(currentStatue, txtStringDetection.Text[paperReadOrder], ref write, ref direction, ref nextStatue);
            if (x == 0)
            {
                txtStringDetection.Text = txtStringDetection.Text.Remove(paperReadOrder, 1);
                txtStringDetection.Text = txtStringDetection.Text.Insert(paperReadOrder, write.ToString());
                currentStatue = nextStatue;
                paperReadOrder += direction;
                printPaper(0, direction);
            }
            else
            {
                timer1.Enabled = false;
                if (tab.IsEndStatue(currentStatue) == 1) MessageBox.Show("正常终止！" + stringDection2);
                else MessageBox.Show("无法识别该串！" + stringDection2);
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            txtStringDetection.Text = stringDection2;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (!onInit)
            {
                MessageBox.Show("请先初始化！");
                return;
            }
            MessageBox.Show(stringHelp);
        }
      

       
    }
}
