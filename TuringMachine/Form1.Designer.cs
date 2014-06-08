namespace TuringMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatues = new System.Windows.Forms.TextBox();
            this.txtInputChars = new System.Windows.Forms.TextBox();
            this.txtSignChars = new System.Windows.Forms.TextBox();
            this.txtStartStatue = new System.Windows.Forms.TextBox();
            this.txtBlackChar = new System.Windows.Forms.TextBox();
            this.txtEndStatues = new System.Windows.Forms.TextBox();
            this.txtJmpFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStringDetection = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnGetDetectinonString = new System.Windows.Forms.Button();
            this.picArror = new System.Windows.Forms.PictureBox();
            this.labShowStatue = new System.Windows.Forms.Label();
            this.picPoint = new System.Windows.Forms.PictureBox();
            this.openFileTM = new System.Windows.Forms.OpenFileDialog();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnRecover = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInit.Location = new System.Drawing.Point(472, 69);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "状态集合(K)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入字符集合(∑)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "符号集合(T)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "初始状态集合(q0)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(51, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "空白字符(B)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(27, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "终止状态集合(F)：";
            // 
            // txtStatues
            // 
            this.txtStatues.Location = new System.Drawing.Point(138, 66);
            this.txtStatues.Name = "txtStatues";
            this.txtStatues.Size = new System.Drawing.Size(135, 21);
            this.txtStatues.TabIndex = 7;
            // 
            // txtInputChars
            // 
            this.txtInputChars.Location = new System.Drawing.Point(138, 100);
            this.txtInputChars.Name = "txtInputChars";
            this.txtInputChars.Size = new System.Drawing.Size(135, 21);
            this.txtInputChars.TabIndex = 8;
            // 
            // txtSignChars
            // 
            this.txtSignChars.Location = new System.Drawing.Point(138, 132);
            this.txtSignChars.Name = "txtSignChars";
            this.txtSignChars.Size = new System.Drawing.Size(135, 21);
            this.txtSignChars.TabIndex = 9;
            // 
            // txtStartStatue
            // 
            this.txtStartStatue.Location = new System.Drawing.Point(138, 160);
            this.txtStartStatue.Name = "txtStartStatue";
            this.txtStartStatue.Size = new System.Drawing.Size(135, 21);
            this.txtStartStatue.TabIndex = 10;
            // 
            // txtBlackChar
            // 
            this.txtBlackChar.Location = new System.Drawing.Point(138, 193);
            this.txtBlackChar.Name = "txtBlackChar";
            this.txtBlackChar.Size = new System.Drawing.Size(135, 21);
            this.txtBlackChar.TabIndex = 11;
            // 
            // txtEndStatues
            // 
            this.txtEndStatues.Location = new System.Drawing.Point(138, 224);
            this.txtEndStatues.Name = "txtEndStatues";
            this.txtEndStatues.Size = new System.Drawing.Size(135, 21);
            this.txtEndStatues.TabIndex = 12;
            // 
            // txtJmpFunc
            // 
            this.txtJmpFunc.AcceptsReturn = true;
            this.txtJmpFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJmpFunc.Location = new System.Drawing.Point(292, 70);
            this.txtJmpFunc.Multiline = true;
            this.txtJmpFunc.Name = "txtJmpFunc";
            this.txtJmpFunc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJmpFunc.Size = new System.Drawing.Size(159, 175);
            this.txtJmpFunc.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "状态转移函数";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(215, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Turing machine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "纸带字符：";
            // 
            // txtStringDetection
            // 
            this.txtStringDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStringDetection.Location = new System.Drawing.Point(103, 261);
            this.txtStringDetection.Name = "txtStringDetection";
            this.txtStringDetection.Size = new System.Drawing.Size(348, 21);
            this.txtStringDetection.TabIndex = 17;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(472, 107);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuto.Location = new System.Drawing.Point(472, 145);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 19;
            this.btnAuto.Text = "自动";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnGetDetectinonString
            // 
            this.btnGetDetectinonString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDetectinonString.Location = new System.Drawing.Point(472, 259);
            this.btnGetDetectinonString.Name = "btnGetDetectinonString";
            this.btnGetDetectinonString.Size = new System.Drawing.Size(75, 23);
            this.btnGetDetectinonString.TabIndex = 21;
            this.btnGetDetectinonString.Text = "识别字符";
            this.btnGetDetectinonString.UseVisualStyleBackColor = true;
            this.btnGetDetectinonString.Click += new System.EventHandler(this.btnGetDetectinonString_Click);
            // 
            // picArror
            // 
            this.picArror.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArror.BackgroundImage")));
            this.picArror.Location = new System.Drawing.Point(20, 305);
            this.picArror.Name = "picArror";
            this.picArror.Size = new System.Drawing.Size(20, 25);
            this.picArror.TabIndex = 22;
            this.picArror.TabStop = false;
            // 
            // labShowStatue
            // 
            this.labShowStatue.AutoSize = true;
            this.labShowStatue.Location = new System.Drawing.Point(23, 290);
            this.labShowStatue.Name = "labShowStatue";
            this.labShowStatue.Size = new System.Drawing.Size(17, 12);
            this.labShowStatue.TabIndex = 23;
            this.labShowStatue.Text = "q0";
            // 
            // picPoint
            // 
            this.picPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picPoint.Location = new System.Drawing.Point(12, 336);
            this.picPoint.Name = "picPoint";
            this.picPoint.Size = new System.Drawing.Size(540, 33);
            this.picPoint.TabIndex = 25;
            this.picPoint.TabStop = false;
            this.picPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPoint_MouseDown);
            this.picPoint.MouseLeave += new System.EventHandler(this.picPoint_MouseLeave);
            this.picPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPoint_MouseMove);
            this.picPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPoint_MouseUp);
            // 
            // openFileTM
            // 
            this.openFileTM.FileName = "TM FILE";
            this.openFileTM.Filter = "TM FILE|*.TM";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(568, 383);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 338);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(536, 28);
            this.rectangleShape1.Paint += new System.Windows.Forms.PaintEventHandler(this.rectangleShape1_Paint);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.Location = new System.Drawing.Point(472, 183);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(75, 23);
            this.btnRecover.TabIndex = 20;
            this.btnRecover.Text = "恢复字符";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(472, 221);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 383);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picPoint);
            this.Controls.Add(this.labShowStatue);
            this.Controls.Add(this.picArror);
            this.Controls.Add(this.btnGetDetectinonString);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtStringDetection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJmpFunc);
            this.Controls.Add(this.txtEndStatues);
            this.Controls.Add(this.txtBlackChar);
            this.Controls.Add(this.txtStartStatue);
            this.Controls.Add(this.txtSignChars);
            this.Controls.Add(this.txtInputChars);
            this.Controls.Add(this.txtStatues);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(584, 421);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatues;
        private System.Windows.Forms.TextBox txtInputChars;
        private System.Windows.Forms.TextBox txtSignChars;
        private System.Windows.Forms.TextBox txtStartStatue;
        private System.Windows.Forms.TextBox txtBlackChar;
        private System.Windows.Forms.TextBox txtEndStatues;
        private System.Windows.Forms.TextBox txtJmpFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStringDetection;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnGetDetectinonString;
        private System.Windows.Forms.PictureBox picArror;
        private System.Windows.Forms.Label labShowStatue;
        private System.Windows.Forms.PictureBox picPoint;
        private System.Windows.Forms.OpenFileDialog openFileTM;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHelp;
    }
}

