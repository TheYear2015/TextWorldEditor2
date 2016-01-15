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
            this.stageSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.waitingSecond = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.actionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseBtn1 = new System.Windows.Forms.Button();
            this.chooseBtn2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.actionType = new System.Windows.Forms.TextBox();
            this.setActionData = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(1286, 26);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // saveToolStripBtn
            // 
            this.saveToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripBtn.Image")));
            this.saveToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripBtn.Name = "saveToolStripBtn";
            this.saveToolStripBtn.Size = new System.Drawing.Size(58, 23);
            this.saveToolStripBtn.Text = "Save";
            this.saveToolStripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveToolStripBtn.Click += new System.EventHandler(this.saveToolStripBtn_Click);
            // 
            // loadToolStripBtn
            // 
            this.loadToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripBtn.Image")));
            this.loadToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadToolStripBtn.Name = "loadToolStripBtn";
            this.loadToolStripBtn.Size = new System.Drawing.Size(59, 23);
            this.loadToolStripBtn.Text = "Load";
            this.loadToolStripBtn.Click += new System.EventHandler(this.loadToolStripBtn_Click);
            // 
            // testToolStripBtn
            // 
            this.testToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripBtn.Image")));
            this.testToolStripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testToolStripBtn.Name = "testToolStripBtn";
            this.testToolStripBtn.Size = new System.Drawing.Size(54, 23);
            this.testToolStripBtn.Text = "Test";
            this.testToolStripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.testToolStripBtn.Click += new System.EventHandler(this.contentToolStripBtn_Click);
            // 
            // contentTree
            // 
            this.contentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTree.Location = new System.Drawing.Point(3, 3);
            this.contentTree.Name = "contentTree";
            this.contentTree.Size = new System.Drawing.Size(519, 498);
            this.contentTree.TabIndex = 1;
            this.contentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.contentTree_AfterSelect);
            // 
            // contentList
            // 
            this.contentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentList.FullRowSelect = true;
            this.contentList.GridLines = true;
            this.contentList.Location = new System.Drawing.Point(528, 3);
            this.contentList.Name = "contentList";
            this.contentList.Size = new System.Drawing.Size(480, 498);
            this.contentList.SmallImageList = this.stageSmallImageList;
            this.contentList.TabIndex = 2;
            this.contentList.UseCompatibleStateImageBehavior = false;
            this.contentList.View = System.Windows.Forms.View.List;
            this.contentList.SelectedIndexChanged += new System.EventHandler(this.contentList_SelectedIndexChanged);
            // 
            // stageSmallImageList
            // 
            this.stageSmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.stageSmallImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.stageSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 486F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 504);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "秒";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.actionText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.actionType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.setActionData, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1014, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 498);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // waitingSecond
            // 
            this.waitingSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waitingSecond.DecimalPlaces = 1;
            this.waitingSecond.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.waitingSecond.Location = new System.Drawing.Point(19, 4);
            this.waitingSecond.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.waitingSecond.Name = "waitingSecond";
            this.waitingSecond.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.waitingSecond.Size = new System.Drawing.Size(120, 21);
            this.waitingSecond.TabIndex = 1;
            this.waitingSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文字内容";
            // 
            // actionText
            // 
            this.actionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionText.Location = new System.Drawing.Point(63, 38);
            this.actionText.Multiline = true;
            this.actionText.Name = "actionText";
            this.actionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionText.Size = new System.Drawing.Size(203, 317);
            this.actionText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分支";
            // 
            // chooseBtn1
            // 
            this.chooseBtn1.Location = new System.Drawing.Point(3, 3);
            this.chooseBtn1.Name = "chooseBtn1";
            this.chooseBtn1.Size = new System.Drawing.Size(197, 26);
            this.chooseBtn1.TabIndex = 5;
            this.chooseBtn1.Text = "button1";
            this.chooseBtn1.UseVisualStyleBackColor = true;
            // 
            // chooseBtn2
            // 
            this.chooseBtn2.Location = new System.Drawing.Point(3, 35);
            this.chooseBtn2.Name = "chooseBtn2";
            this.chooseBtn2.Size = new System.Drawing.Size(197, 26);
            this.chooseBtn2.TabIndex = 6;
            this.chooseBtn2.Text = "button2";
            this.chooseBtn2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "等待";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.39699F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.60302F));
            this.tableLayoutPanel3.Controls.Add(this.waitingSecond, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(63, 361);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 29);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chooseBtn1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chooseBtn2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(63, 396);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(203, 64);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // actionType
            // 
            this.actionType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actionType.Location = new System.Drawing.Point(96, 7);
            this.actionType.Name = "actionType";
            this.actionType.Size = new System.Drawing.Size(136, 21);
            this.actionType.TabIndex = 6;
            this.actionType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setActionData
            // 
            this.setActionData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setActionData.Location = new System.Drawing.Point(63, 469);
            this.setActionData.Name = "setActionData";
            this.setActionData.Size = new System.Drawing.Size(156, 23);
            this.setActionData.TabIndex = 7;
            this.setActionData.Text = "设置";
            this.setActionData.UseVisualStyleBackColor = true;
            this.setActionData.Click += new System.EventHandler(this.setActionData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList stageSmallImageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chooseBtn2;
        private System.Windows.Forms.Button chooseBtn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown waitingSecond;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox actionType;
        private System.Windows.Forms.Button setActionData;
    }
}

