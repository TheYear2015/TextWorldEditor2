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
        }

        private void contentToolStripBtn_Click(object sender, EventArgs e)
        {
        }

        private ContentStage m_contentStage = new ContentStage();

        private void saveToolStripBtn_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ContentStage));
            byte[] byteArr;
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, m_contentStage);

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
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ContentStage));
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(tt)))     //构造函数能够接受Stream参数，因此你可以用内存流，文件流等等创建
                {
                    m_contentStage = serializer.ReadObject(ms) as ContentStage;
                }

            }
            catch
            {

            }
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
            lvi.Text = string.Format("action{0:D2}", index);
            var info = new ListViewItem.ListViewSubItem();
            info.Text = m_contentStage.ContentList[index].Text;
            lvi.SubItems.Add(info);

            lvi.Tag = m_contentStage.ContentList[index];
        }

        private void newAcitonMI_Click(object sender, EventArgs e)
        {
            var action = new ContentAction();

            m_contentStage.ContentList.Add(action);

            this.contentList.BeginUpdate();
            this.contentList.Items.Clear();

            for (int i = 0; i < m_contentStage.ContentList.Count(); i++)
            {
                var lvi = new ListViewItem();
                SetListViewItemActionInfo(i, m_contentStage.ContentList[i], lvi);
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
                    m_contentStage.ContentList.RemoveAt(index);
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

    }
}
