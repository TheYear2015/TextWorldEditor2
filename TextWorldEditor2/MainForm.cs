using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TextWorldEditor2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.contentTree.Nodes.Add(new TreeNode("游戏"));
        }

        private void contentToolStripBtn_Click(object sender, EventArgs e)
        {
        }

        private Content m_content = new Content();

        private void InsertChildTreeNodeToData(TreeNode tN, StageTreeNode data)
        {
            var sn = new StageTreeNode();
            sn.Id = ((ContentStage)tN.Tag).Id;
            foreach (TreeNode n in tN.Nodes)
            {
                InsertChildTreeNodeToData(n, sn);
            }
            data.Nodes.Add(sn);
        }

        private void saveToolStripBtn_Click(object sender, EventArgs e)
        {
            var tt = JsonConvert.SerializeObject(m_content, Formatting.Indented);
            var utf8 = new System.Text.UTF8Encoding(false);
            File.WriteAllText("ContentStage.pck", tt, utf8);

            //保存编辑树的结构
            StageTreeNode root = new StageTreeNode();
            foreach (TreeNode n in this.contentTree.Nodes[0].Nodes)
            {
                InsertChildTreeNodeToData(n, root);
            }
            var ss = JsonConvert.SerializeObject(root, Formatting.Indented);
            File.WriteAllText("ContentStage.edt", ss, utf8);

        }

        private void SetTreeNodeByData(TreeNode node, StageTreeNode data)
        {
            if (data.Id > 0)
            {
                var stage = this.m_content.GetStageById(data.Id);
                if (stage != null)
                {
                    node.Text = stage.Name;
                    node.Tag = stage;
                }
            }
            foreach (var cc in data.Nodes)
            {
                var stage = this.m_content.GetStageById(cc.Id);
                if (stage != null)
                {
                    var cN = new TreeNode();
                    SetTreeNodeByData(cN, cc);
                    node.Nodes.Add(cN);
                }
            }
        }


        private void loadToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tt = File.ReadAllText("ContentStage.pck");
                this.m_content = JsonConvert.DeserializeObject<Content>(tt);

                string ss = File.ReadAllText("ContentStage.edt");
                StageTreeNode rootD = JsonConvert.DeserializeObject<StageTreeNode>(ss);

                var root = this.contentTree.Nodes[0];
                root.Nodes.Clear();

                SetTreeNodeByData(root, rootD);

                var idList = rootD.GetAllId();
                foreach (var s in this.m_content.Stages)
                {
                    bool have = false;
                    foreach (var dd in idList)
                    {
                        if (dd == s.Id)
                        {
                            have = true;
                            break;
                        }
                    }
                    if (!have)
                    {
                        var node = new TreeNode(s.Name);
                        root.Nodes.Add(node);
                        node.Text = s.Name;
                        node.Tag = s;
                        if (this.contentTree.SelectedNode == null)
                        {
                            this.contentTree.SelectedNode = node;
                        }
                    }

                }

            }
            catch
            {

            }
        }

        private ContentStage m_editingStage = null;

        private void SetEditContentStage(ContentStage stage)
        {
            m_editingStage = stage;

            if (stage != null)
            {
                this.stageId.Text = stage.Id.ToString();
                this.stageName.Text = stage.Name;
            }
            else
            {
                this.stageId.Text = "";
                this.stageName.Text = "";
            }

            SetEditContentAction(null);
            this.contentList.BeginUpdate();
            this.contentList.Items.Clear();

            if (stage != null)
            {
                for (int i = 0; i < stage.ContentList.Count(); i++)
                {
                    var lvi = new ListViewItem();
                    SetListViewItemActionInfo(i, stage.ContentList[i], lvi);
                    this.contentList.Items.Add(lvi);
                    if (i == 0)
                    {
                        this.contentList.SelectedIndices.Clear();
                        this.contentList.SelectedIndices.Add(0);
                    }
                }
            }
            this.contentList.EndUpdate();
        }

        private void SetEditContentAction(ContentAction action)
        {
            if (action != null)
            {
                this.actionType.Text = action.Type.ToString();
                this.actionText.Text = action.Text;
                this.waitingSecond.Value = (decimal)(action.DuringMS * 0.001);
                this.chooseBtn1.Text = action.GoId[0] != 0 ? action.GoString[0] : "--";
                this.chooseBtn2.Text = action.GoId[1] != 0 ? action.GoString[1] : "--";
            }
            else
            {
                this.actionType.Text = "";
                this.actionText.Text = "";
                this.waitingSecond.Value = 0;
                this.chooseBtn1.Text = "--";
                this.chooseBtn2.Text = "--";
            }
        }

        private void contentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.contentTree.SelectedNode != null)
            {
                SetEditContentStage((ContentStage)this.contentTree.SelectedNode.Tag);
            }
            else
            {
                SetEditContentStage(null);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetActionTextClick(object sender, EventArgs e)
        {
            int index = -1;
            var action = GetEditingAction(out index);
            if (action != null)
            {
                action.Type = 0;
                action.Text = this.actionText.Text;
                SetListViewItemActionInfo(index, action, this.contentList.Items[index]);
            }
        }

        private void contentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.contentList.SelectedIndices.Count > 0)
            {
                var index = this.contentList.SelectedIndices[0];
                SetEditContentAction((ContentAction)this.contentList.Items[index].Tag);

            }
            else
            {
                SetEditContentAction(null);
            }
        }

        private void SetListViewItemActionInfo(int index, ContentAction action, ListViewItem lvi)
        {
            lvi.SubItems.Clear();
            lvi.ImageIndex = 0;
            lvi.Text = string.Format("Action{0:D2}", index);

            var info = new ListViewItem.ListViewSubItem();
            info.Text = action.Text;
            lvi.SubItems.Add(info);

            var waittingSec = new ListViewItem.ListViewSubItem();
            waittingSec.Text = (action.DuringMS * 0.001).ToString();
            lvi.SubItems.Add(waittingSec);

            var go1 = new ListViewItem.ListViewSubItem();
            if (action.GoId[0] != 0)
                go1.Text = action.GoString[0];
            lvi.SubItems.Add(go1);

            var go2 = new ListViewItem.ListViewSubItem();
            if (action.GoId[1] != 0)
                go2.Text = action.GoString[1];
            lvi.SubItems.Add(go2);


            lvi.Tag = this.m_editingStage.ContentList[index];
        }

        private void newAcitonMI_Click(object sender, EventArgs e)
        {
            var action = new ContentAction();

            this.m_editingStage.ContentList.Add(action);

            this.contentList.BeginUpdate();
            this.contentList.Items.Clear();

            for (int i = 0; i < this.m_editingStage.ContentList.Count(); i++)
            {
                var lvi = new ListViewItem();
                SetListViewItemActionInfo(i, this.m_editingStage.ContentList[i], lvi);
                this.contentList.Items.Add(lvi);
            }
            this.contentList.EndUpdate();
        }

        private void delActionMI_Click(object sender, EventArgs e)
        {
            if (this.contentList.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("确定要删除该动画", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    var index = this.contentList.SelectedIndices[0];
                    try
                    {
                        this.contentList.Items.RemoveAt(index);
                        this.m_editingStage.ContentList.RemoveAt(index);
                        SetEditContentAction(null);
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                SetEditContentAction(null);
            }
        }

        private void newStageMI_Click(object sender, EventArgs e)
        {
            var stage = this.m_content.NewStage();
            stage.Name = "场景" + stage.Id.ToString();
            //刷新界面
            var root = this.contentTree.SelectedNode;

            var node = new TreeNode(stage.Name);

            root.Nodes.Add(node);

            node.Tag = stage;

            this.contentTree.SelectedNode = node;
        }

        private List<UInt32> GetTreeNodeStagesId(TreeNode tN)
        {
            List<UInt32> r = new List<UInt32>();
            var s = tN.Tag as ContentStage;
            if (s != null)
                r.Add(s.Id);
            foreach (var c in tN.Nodes)
            {
                r.AddRange(GetTreeNodeStagesId(c as TreeNode));
            }
            return r;
        }

        private void delStageMI_Click(object sender, EventArgs e)
        {
            if (this.contentTree.SelectedNode != null
                && this.contentTree.SelectedNode.Parent != null)
            {
                var stage = this.contentTree.SelectedNode.Tag as ContentStage;
                if (stage != null)
                {
                    if (MessageBox.Show(string.Format("确定要删除场景\"{0}\"及其子场景", stage.Name), "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {

                        var stageIdList = GetTreeNodeStagesId(this.contentTree.SelectedNode);
                        foreach (var id in stageIdList)
                            this.m_content.DelStageById(id);
                        this.contentTree.SelectedNode.Parent.Nodes.Remove(this.contentTree.SelectedNode);
                    }

                }
            }
        }

        private void stageName_Leave(object sender, EventArgs e)
        {
            if (m_editingStage != null)
            {
                m_editingStage.Name = this.stageName.Text;
                if (this.contentTree.SelectedNode != null
                    && this.contentTree.SelectedNode.Tag == m_editingStage)
                {
                    this.contentTree.SelectedNode.Text = m_editingStage.Name;
                }
            }
        }

        private void chooseBtn1_Click(object sender, EventArgs e)
        {
            EditGoToStageInfo(0);
        }

        private void chooseBtn2_Click(object sender, EventArgs e)
        {
            EditGoToStageInfo(1);
        }

        private void EditGoToStageInfo(int i)
        {
            int index = -1;
            var action = GetEditingAction(out index);
            if (action != null)
            {
                var dlg = new ChooseStageDlg();
                dlg.SetStageTree(this.contentTree);
                dlg.ChooseStage = m_content.GetStageById(action.GoId[i]);
                dlg.ChooseText = action.GoString[i];
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (dlg.ChooseStage != null)
                    {
                        action.GoId[i] = dlg.ChooseStage.Id;
                        action.GoString[i] = dlg.ChooseText;

                    }
                    else
                    {
                        action.GoId[i] = 0;
                        action.GoString[i] = "";

                    }
                    SetListViewItemActionInfo(index, action, this.contentList.Items[index]);
                }
                else
                {
                }
            }
        }

        private void waitingSecond_Leave(object sender, EventArgs e)
        {
            int index = -1;
            var action = GetEditingAction(out index);
            if (action != null)
            {
                action.DuringMS = (UInt32)(this.waitingSecond.Value * 1000);
                SetListViewItemActionInfo(index, action, this.contentList.Items[index]);
            }

        }

        private ContentAction GetEditingAction(out int index)
        {
            if (this.contentList.SelectedIndices.Count > 0)
            {
                index = this.contentList.SelectedIndices[0];
                return this.contentList.Items[index].Tag as ContentAction;
            }
            index = -1;
            return null;
        }

        private void actionType_Leave(object sender, EventArgs e)
        {
            int index = -1;
            var action = GetEditingAction(out index);
            if (action != null)
            {
                try
                {
                    action.Type = UInt32.Parse(this.actionType.Text);
                    SetListViewItemActionInfo(index, action, this.contentList.Items[index]);

                }
                catch
                {

                }
            }
        }

        TreeNode dragDropTreeNode = null;

        private void contentTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode tn = e.Item as TreeNode;
            if ((e.Button == MouseButtons.Left) && (tn != null) && (tn.Parent != null)) //根节点不允许拖放操作。 
            {
                dragDropTreeNode = tn;
                this.contentTree.DoDragDrop(tn, DragDropEffects.Move);
            }
        }

        private void contentTree_DragOver(object sender, DragEventArgs e)
        {
            //当光标悬停在 TreeView 控件上时，展开该控件中的 TreeNode 
            Point p = this.contentTree.PointToClient(Control.MousePosition);
            TreeNode tn = this.contentTree.GetNodeAt(p);
            if (tn != null)
            {
                if (this.dragDropTreeNode != tn) //移动到新的节点 
                {
                    if (tn.Nodes.Count > 0 && tn.IsExpanded == false)
                    {
                        //this.startTime = DateTime.Now;//设置新的起始时间 
                    }
                }
                else
                {
                    if (tn.Nodes.Count > 0 && tn.IsExpanded == false/* && this.startTime != DateTime.MinValue*/)
                    {
                        // TimeSpan ts = DateTime.Now - this.startTime;
                        // if (ts.TotalMilliseconds >= 1000) //一秒 
                        {
                            tn.Expand();
                            //this.startTime = DateTime.MinValue;
                        }
                    }
                }

            }
            //设置拖放标签Effect状态 
            if (tn != null)//&& (tn != this.treeView.SelectedNode)) //当控件移动到空白处时，设置不可用。 
            {
                if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                {
                    e.Effect = DragDropEffects.Move;
                }
                if (((e.AllowedEffect & DragDropEffects.Copy) != 0) && ((e.KeyState & 0x08) != 0))//Ctrl key 
                {
                    e.Effect = DragDropEffects.Copy;
                }
                if (((e.AllowedEffect & DragDropEffects.Link) != 0) && ((e.KeyState & 0x08) != 0) && ((e.KeyState & 0x04) != 0))//Ctrl key + Shift key 
                {
                    e.Effect = DragDropEffects.Link;
                }
                if (e.Data.GetDataPresent(typeof(TreeNode)))//拖动的是TreeNode 
                {

                    TreeNode parND = tn;//判断是否拖到了子项 
                    bool isChildNode = false;
                    while (parND.Parent != null)
                    {
                        parND = parND.Parent;
                        if (parND == this.contentTree.SelectedNode)
                        {
                            isChildNode = true;
                            break;
                        }
                    }
                    if (isChildNode)
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
                else if (e.Data.GetDataPresent(typeof(ListViewItem)))//拖动的是ListViewItem 
                {
                    if (tn.Parent == null)
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

            //设置拖放目标TreeNode的背景色 
            if (e.Effect == DragDropEffects.None)
            {
                if (this.dragDropTreeNode != null) //取消被放置的节点高亮显示 
                {
                    this.dragDropTreeNode.BackColor = SystemColors.Window;
                    this.dragDropTreeNode.ForeColor = SystemColors.WindowText;
                    this.dragDropTreeNode = null;
                }
            }
            else
            {
                if (tn != null)
                {
                    if (this.dragDropTreeNode != null)
                    {
                        if (this.dragDropTreeNode != tn)
                        {
                            this.dragDropTreeNode.BackColor = SystemColors.Window;//取消上一个被放置的节点高亮显示 
                            this.dragDropTreeNode.ForeColor = SystemColors.WindowText;
                            this.dragDropTreeNode = tn;//设置为新的节点 
                            this.dragDropTreeNode.BackColor = SystemColors.Highlight;
                            this.dragDropTreeNode.ForeColor = SystemColors.HighlightText;
                        }
                    }
                    else
                    {
                        this.dragDropTreeNode = tn;//设置为新的节点 
                        this.dragDropTreeNode.BackColor = SystemColors.Highlight;
                        this.dragDropTreeNode.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
        }

        private void contentTree_DragDrop(object sender, DragEventArgs e)
        {
            if (this.dragDropTreeNode != null)
            {
                if (e.Data.GetDataPresent(typeof(TreeNode)))
                {

                    TreeNode tn = (TreeNode)e.Data.GetData(typeof(TreeNode));
                    tn.Remove();//从原父节点移除被拖得节点 
                    this.dragDropTreeNode.Nodes.Add(tn);//添加被拖得节点到新节点下面 

                    if (this.dragDropTreeNode.IsExpanded == false)
                    {
                        this.dragDropTreeNode.Expand();//展开节点 
                    }

                }
                else if (e.Data.GetDataPresent(typeof(ListViewItem)))
                {
                    if (this.dragDropTreeNode.Parent != null)
                    {

                        ListViewItem listViewItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                        listViewItem.Remove();
                    }
                }
                //取消被放置的节点高亮显示 
                this.dragDropTreeNode.BackColor = SystemColors.Window;
                this.dragDropTreeNode.ForeColor = SystemColors.WindowText;
                this.dragDropTreeNode = null;
            }
        }

        private void contentTree_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void contentTree_DragLeave(object sender, EventArgs e)
        {
            if (this.dragDropTreeNode != null) //在按下{ESC}，取消被放置的节点高亮显示 
            {
                this.dragDropTreeNode.BackColor = SystemColors.Window;
                this.dragDropTreeNode.ForeColor = SystemColors.WindowText;
                this.dragDropTreeNode = null;
            }
        }
    }

    [DataContract]
    class StageTreeNode
    {
        UInt32 m_Id = 0;
        [DataMember]
        public UInt32 Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        List<StageTreeNode> m_nodes = new List<StageTreeNode>();
        [DataMember]
        public List<StageTreeNode> Nodes
        {
            get { return m_nodes; }
            set { m_nodes = value; }
        }


        public List<UInt32> GetAllId()
        {
            var r = new List<UInt32>();
            r.Add(this.Id);
            foreach (var c in this.Nodes)
            {
                r.AddRange(c.GetAllId());
            }

            return r;

        }

    };


}
