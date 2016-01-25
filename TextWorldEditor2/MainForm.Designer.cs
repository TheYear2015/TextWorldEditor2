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
            this.stageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newStageMI = new System.Windows.Forms.ToolStripMenuItem();
            this.delStageMI = new System.Windows.Forms.ToolStripMenuItem();
            this.contentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newAcitonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.delActionMI = new System.Windows.Forms.ToolStripMenuItem();
            this.stageSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.waitingSecond = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actionType = new System.Windows.Forms.TextBox();
            this.setActionText = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseBtn1 = new System.Windows.Forms.Button();
            this.chooseBtn2 = new System.Windows.Forms.Button();
            this.StageAutoNext = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stageId = new System.Windows.Forms.Label();
            this.stageName = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.stageContextMenu.SuspendLayout();
            this.actionContentMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(887, 25);
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
            this.contentTree.AllowDrop = true;
            this.contentTree.ContextMenuStrip = this.stageContextMenu;
            this.contentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTree.FullRowSelect = true;
            this.contentTree.HideSelection = false;
            this.contentTree.Location = new System.Drawing.Point(3, 3);
            this.contentTree.Name = "contentTree";
            this.contentTree.Size = new System.Drawing.Size(269, 429);
            this.contentTree.TabIndex = 1;
            this.contentTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.contentTree_ItemDrag);
            this.contentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.contentTree_AfterSelect);
            this.contentTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.contentTree_DragDrop);
            this.contentTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.contentTree_DragEnter);
            this.contentTree.DragOver += new System.Windows.Forms.DragEventHandler(this.contentTree_DragOver);
            this.contentTree.DragLeave += new System.EventHandler(this.contentTree_DragLeave);
            // 
            // stageContextMenu
            // 
            this.stageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStageMI,
            this.delStageMI});
            this.stageContextMenu.Name = "stageContextMenu";
            this.stageContextMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // newStageMI
            // 
            this.newStageMI.Name = "newStageMI";
            this.newStageMI.Size = new System.Drawing.Size(100, 22);
            this.newStageMI.Text = "添加";
            this.newStageMI.Click += new System.EventHandler(this.newStageMI_Click);
            // 
            // delStageMI
            // 
            this.delStageMI.Name = "delStageMI";
            this.delStageMI.Size = new System.Drawing.Size(100, 22);
            this.delStageMI.Text = "删除";
            this.delStageMI.Click += new System.EventHandler(this.delStageMI_Click);
            // 
            // contentList
            // 
            this.contentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.contentList.ContextMenuStrip = this.actionContentMenu;
            this.contentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentList.FullRowSelect = true;
            this.contentList.GridLines = true;
            this.contentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contentList.HideSelection = false;
            this.contentList.LabelWrap = false;
            this.contentList.Location = new System.Drawing.Point(3, 76);
            this.contentList.MultiSelect = false;
            this.contentList.Name = "contentList";
            this.contentList.Size = new System.Drawing.Size(269, 280);
            this.contentList.SmallImageList = this.stageSmallImageList;
            this.contentList.TabIndex = 2;
            this.contentList.UseCompatibleStateImageBehavior = false;
            this.contentList.View = System.Windows.Forms.View.Details;
            this.contentList.SelectedIndexChanged += new System.EventHandler(this.contentList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文本";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "触发延迟";
            this.columnHeader3.Width = 100;
            // 
            // actionContentMenu
            // 
            this.actionContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAcitonMI,
            this.delActionMI});
            this.actionContentMenu.Name = "actionContentMenu";
            this.actionContentMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // newAcitonMI
            // 
            this.newAcitonMI.Name = "newAcitonMI";
            this.newAcitonMI.Size = new System.Drawing.Size(100, 22);
            this.newAcitonMI.Text = "新建";
            this.newAcitonMI.Click += new System.EventHandler(this.newAcitonMI_Click);
            // 
            // delActionMI
            // 
            this.delActionMI.Name = "delActionMI";
            this.delActionMI.Size = new System.Drawing.Size(100, 22);
            this.delActionMI.Text = "删除";
            this.delActionMI.Click += new System.EventHandler(this.delActionMI_Click);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentTree, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 435);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.actionText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.actionType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.setActionText, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(553, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 429);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.39699F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.60302F));
            this.tableLayoutPanel3.Controls.Add(this.waitingSecond, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(63, 397);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 29);
            this.tableLayoutPanel3.TabIndex = 5;
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
            this.waitingSecond.Leave += new System.EventHandler(this.waitingSecond_Leave);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "持续时间";
            // 
            // actionText
            // 
            this.actionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionText.Location = new System.Drawing.Point(63, 38);
            this.actionText.Multiline = true;
            this.actionText.Name = "actionText";
            this.actionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionText.Size = new System.Drawing.Size(265, 323);
            this.actionText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文字内容";
            // 
            // actionType
            // 
            this.actionType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actionType.Location = new System.Drawing.Point(127, 7);
            this.actionType.Name = "actionType";
            this.actionType.Size = new System.Drawing.Size(136, 21);
            this.actionType.TabIndex = 6;
            this.actionType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actionType.Leave += new System.EventHandler(this.actionType_Leave);
            // 
            // setActionText
            // 
            this.setActionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setActionText.Location = new System.Drawing.Point(141, 368);
            this.setActionText.Name = "setActionText";
            this.setActionText.Size = new System.Drawing.Size(187, 23);
            this.setActionText.TabIndex = 7;
            this.setActionText.Text = "设置文字内容";
            this.setActionText.UseVisualStyleBackColor = true;
            this.setActionText.Click += new System.EventHandler(this.SetActionTextClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.contentList, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(275, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(275, 435);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 362);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(269, 70);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64384F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.StageAutoNext, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(46, 6);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(223, 64);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chooseBtn1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chooseBtn2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(131, 58);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // chooseBtn1
            // 
            this.chooseBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseBtn1.Location = new System.Drawing.Point(3, 3);
            this.chooseBtn1.Name = "chooseBtn1";
            this.chooseBtn1.Size = new System.Drawing.Size(125, 23);
            this.chooseBtn1.TabIndex = 5;
            this.chooseBtn1.Text = "button1";
            this.chooseBtn1.UseVisualStyleBackColor = true;
            this.chooseBtn1.Click += new System.EventHandler(this.chooseBtn1_Click);
            // 
            // chooseBtn2
            // 
            this.chooseBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseBtn2.Location = new System.Drawing.Point(3, 32);
            this.chooseBtn2.Name = "chooseBtn2";
            this.chooseBtn2.Size = new System.Drawing.Size(125, 23);
            this.chooseBtn2.TabIndex = 6;
            this.chooseBtn2.Text = "button2";
            this.chooseBtn2.UseVisualStyleBackColor = true;
            this.chooseBtn2.Click += new System.EventHandler(this.chooseBtn2_Click);
            // 
            // StageAutoNext
            // 
            this.StageAutoNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StageAutoNext.AutoSize = true;
            this.StageAutoNext.Location = new System.Drawing.Point(140, 3);
            this.StageAutoNext.Name = "StageAutoNext";
            this.StageAutoNext.Size = new System.Drawing.Size(80, 58);
            this.StageAutoNext.TabIndex = 6;
            this.StageAutoNext.Text = "自动进入下一个场景";
            this.StageAutoNext.UseVisualStyleBackColor = true;
            this.StageAutoNext.CheckedChanged += new System.EventHandler(this.StageAutoNext_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分支";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.stageId, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.stageName, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(269, 67);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // stageId
            // 
            this.stageId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stageId.AutoSize = true;
            this.stageId.Location = new System.Drawing.Point(62, 10);
            this.stageId.Name = "stageId";
            this.stageId.Size = new System.Drawing.Size(0, 12);
            this.stageId.TabIndex = 2;
            // 
            // stageName
            // 
            this.stageName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stageName.Location = new System.Drawing.Point(62, 39);
            this.stageName.Name = "stageName";
            this.stageName.Size = new System.Drawing.Size(173, 21);
            this.stageName.TabIndex = 3;
            this.stageName.Leave += new System.EventHandler(this.stageName_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text World Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.stageContextMenu.ResumeLayout(false);
            this.actionContentMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingSecond)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.Button setActionText;
        private System.Windows.Forms.ContextMenuStrip actionContentMenu;
        private System.Windows.Forms.ToolStripMenuItem newAcitonMI;
        private System.Windows.Forms.ToolStripMenuItem delActionMI;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip stageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newStageMI;
        private System.Windows.Forms.ToolStripMenuItem delStageMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label stageId;
        private System.Windows.Forms.TextBox stageName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.CheckBox StageAutoNext;
    }
}

