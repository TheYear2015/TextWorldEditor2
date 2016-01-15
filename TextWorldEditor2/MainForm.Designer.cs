namespace TextWorldEditor2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.loadToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.testToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.contentTree = new System.Windows.Forms.TreeView();
            this.contentList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.waitingSecond = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chooseBtn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actionTypeCB = new System.Windows.Forms.ComboBox();
            this.stageSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripBtn,
            this.loadToolStripBtn,
            this.testToolStripBtn});
            this.toolStrip.Location = new System.Drawing.Point(3, 3);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(880, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // saveToolStripBtn
            // 
            this.saveToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripBtn.Image")));
            this.saveToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripBtn.Name = "saveToolStripBtn";
            this.saveToolStripBtn.Size = new System.Drawing.Size(55, 22);
            this.saveToolStripBtn.Text = "Save";
            this.saveToolStripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripBtn.Click += new System.EventHandler(this.saveToolStripBtn_Click);
            // 
            // loadToolStripBtn
            // 
            this.loadToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripBtn.Image")));
            this.loadToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadToolStripBtn.Name = "loadToolStripBtn";
            this.loadToolStripBtn.Size = new System.Drawing.Size(57, 22);
            this.loadToolStripBtn.Text = "Load";
            this.loadToolStripBtn.Click += new System.EventHandler(this.loadToolStripBtn_Click);
            // 
            // testToolStripBtn
            // 
            this.testToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripBtn.Image")));
            this.testToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testToolStripBtn.Name = "testToolStripBtn";
            this.testToolStripBtn.Size = new System.Drawing.Size(52, 22);
            this.testToolStripBtn.Text = "Test";
            this.testToolStripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testToolStripBtn.Click += new System.EventHandler(this.contentToolStripBtn_Click);
            // 
            // contentTree
            // 
            this.contentTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.contentTree.Location = new System.Drawing.Point(3, 28);
            this.contentTree.Name = "contentTree";
            this.contentTree.Size = new System.Drawing.Size(222, 361);
            this.contentTree.TabIndex = 1;
            // 
            // contentList
            // 
            this.contentList.Dock = System.Windows.Forms.DockStyle.Left;
            this.contentList.FullRowSelect = true;
            this.contentList.GridLines = true;
            this.contentList.Location = new System.Drawing.Point(225, 28);
            this.contentList.Margin = new System.Windows.Forms.Padding(5);
            this.contentList.Name = "contentList";
            this.contentList.Size = new System.Drawing.Size(394, 361);
            this.contentList.SmallImageList = this.stageSmallImageList;
            this.contentList.TabIndex = 2;
            this.contentList.UseCompatibleStateImageBehavior = false;
            this.contentList.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.actionTypeCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(627, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 361);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.waitingSecond);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 36);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "秒";
            // 
            // waitingSecond
            // 
            this.waitingSecond.DecimalPlaces = 1;
            this.waitingSecond.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.waitingSecond.Location = new System.Drawing.Point(46, 12);
            this.waitingSecond.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.waitingSecond.Name = "waitingSecond";
            this.waitingSecond.Size = new System.Drawing.Size(120, 21);
            this.waitingSecond.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "等待";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actionText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 100);
            this.panel2.TabIndex = 8;
            // 
            // actionText
            // 
            this.actionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionText.Location = new System.Drawing.Point(0, 12);
            this.actionText.Multiline = true;
            this.actionText.Name = "actionText";
            this.actionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionText.Size = new System.Drawing.Size(256, 88);
            this.actionText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文字内容";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chooseBtn1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chooseBtn2);
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 100);
            this.panel1.TabIndex = 7;
            // 
            // chooseBtn1
            // 
            this.chooseBtn1.Location = new System.Drawing.Point(0, 45);
            this.chooseBtn1.Name = "chooseBtn1";
            this.chooseBtn1.Size = new System.Drawing.Size(245, 23);
            this.chooseBtn1.TabIndex = 5;
            this.chooseBtn1.Text = "button1";
            this.chooseBtn1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分支";
            // 
            // chooseBtn2
            // 
            this.chooseBtn2.Location = new System.Drawing.Point(0, 74);
            this.chooseBtn2.Name = "chooseBtn2";
            this.chooseBtn2.Size = new System.Drawing.Size(245, 23);
            this.chooseBtn2.TabIndex = 6;
            this.chooseBtn2.Text = "button2";
            this.chooseBtn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型";
            // 
            // actionTypeCB
            // 
            this.actionTypeCB.FormattingEnabled = true;
            this.actionTypeCB.Location = new System.Drawing.Point(97, 20);
            this.actionTypeCB.Name = "actionTypeCB";
            this.actionTypeCB.Size = new System.Drawing.Size(153, 20);
            this.actionTypeCB.TabIndex = 0;
            // 
            // stageSmallImageList
            // 
            this.stageSmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.stageSmallImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.stageSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contentList);
            this.Controls.Add(this.contentTree);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripBtn;
        private System.Windows.Forms.ToolStripButton loadToolStripBtn;
        private System.Windows.Forms.ToolStripButton testToolStripBtn;
        private System.Windows.Forms.TreeView contentTree;
        private System.Windows.Forms.ListView contentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox actionTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox actionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseBtn2;
        private System.Windows.Forms.Button chooseBtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown waitingSecond;
        private System.Windows.Forms.ImageList stageSmallImageList;
    }
}

