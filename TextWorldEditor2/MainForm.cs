using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
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
            RefreshAllContent();
        }

        private void contentToolStripBtn_Click(object sender, EventArgs e)
        {
        }

        private Content m_content = new Content();

        private void saveToolStripBtn_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Content));
            byte[] byteArr;
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, m_content);

                byteArr = ms.ToArray();
            }
            string tt = (Encoding.UTF8.GetString(byteArr));

            var utf8 = new System.Text.UTF8Encoding(false);
            File.WriteAllText("ContentStage.pck", tt, utf8);

        }

        private void loadToolStripBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tt = File.ReadAllText("ContentStage.pck");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Content));
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(tt)))     //构造函数能够接受Stream参数，因此你可以用内存流，文件流等等创建
                {
                    this.m_content = serializer.ReadObject(ms) as Content;
                    RefreshAllContent();
                }

            }
            catch
            {

            }
        }

        private void RefreshAllContent()
        {
            this.contentTree.Nodes.Clear();

            //root

            var root = new TreeNode("场景");
            this.contentTree.Nodes.Add(root);

            foreach (var s in this.m_content.Stages)
            {
                var node = new TreeNode("场景");
                root.Nodes.Add(node);
                node.Tag = s;
                if(this.contentTree.SelectedNode == null)
                {
                    this.contentTree.SelectedNode = node;
                }
            }
            if (this.m_content.Stages.Count() == 0)
            {
                SetEditContentStage(null);
            }
        }

        private ContentStage m_editingStage = null;

        private void SetEditContentStage(ContentStage stage)
        {
            m_editingStage = stage;
            SetEditContentAction(null);
            this.contentList.BeginUpdate();
            this.contentList.Items.Clear();

            if(stage != null)
            {
                for (int i = 0; i < stage.ContentList.Count(); i++)
                {
                    var lvi = new ListViewItem();
                    SetListViewItemActionInfo(i, stage.ContentList[i], lvi);
                    this.contentList.Items.Add(lvi);
                }
            }
            this.contentList.EndUpdate();
       }

        private void SetEditContentAction(ContentAction action)
        {
            if(action != null)
            {
                this.actionType.Text = action.Type.ToString();
                this.actionText.Text = action.Text;
            }
            else
            {
                this.actionType.Text = "";
                this.actionText.Text = "";
            }
        }

        private void contentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(this.contentTree.SelectedNode != null)
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

        private void setActionData_Click(object sender, EventArgs e)
        {
            if (this.contentList.SelectedIndices.Count > 0)
            {
                var index = this.contentList.SelectedIndices[0];
                var action = (ContentAction)this.contentList.Items[index].Tag;
                action.Type = 0;
                try
                {
                    action.Type = UInt32.Parse(this.actionType.Text);
                    action.Text = this.actionText.Text;

                    SetListViewItemActionInfo(index, action, this.contentList.Items[index]);
                }
                catch 
                {
                }
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
            info.Text = this.m_editingStage.ContentList[index].Text;
            lvi.SubItems.Add(info);

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
            else
            {
                SetEditContentAction(null);
            }
        }

        private void newStageMI_Click(object sender, EventArgs e)
        {
            var stage = this.m_content.NewStage();
            //刷新界面

            var root = this.contentTree.Nodes[0];
            var node = new TreeNode("场景");
            root.Nodes.Add(node);
            node.Tag = stage;
        }

        private void delStageMI_Click(object sender, EventArgs e)
        {

        }

    }
}
