using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWorldEditor2
{
    public partial class ChooseStageDlg : Form
    {
        public ChooseStageDlg()
        {
            InitializeComponent();
        }

        public void SetStageTree(TreeView tree)
        {
            this.stageTree.Nodes.Clear();
            for (int i = 0; i < tree.Nodes.Count; ++i)
            {
                var node = tree.Nodes[i].Clone() as TreeNode;
                this.stageTree.Nodes.Add(node);
            }
        }

        private TreeNode FindStageNode(TreeNode tnParent, ContentStage stage)
        {

            if (tnParent == null) return null;

            if (tnParent.Tag == stage) return tnParent;

            else if (tnParent.Nodes.Count == 0) return null;

            TreeNode tnCurrent, tnCurrentPar;

            //Init node

            tnCurrentPar = tnParent;

            tnCurrent = tnCurrentPar.FirstNode;

            while (tnCurrent != null && tnCurrent != tnParent)
            {

                while (tnCurrent != null)
                {

                    if (tnCurrent.Tag == stage) return tnCurrent;

                    else if (tnCurrent.Nodes.Count > 0)
                    {

                        //Go into the deepest node in current sub-path

                        tnCurrentPar = tnCurrent;

                        tnCurrent = tnCurrent.FirstNode;

                    }

                    else if (tnCurrent != tnCurrentPar.LastNode)
                    {

                        //Goto next sible node

                        tnCurrent = tnCurrent.NextNode;

                    }

                    else

                        break;

                }



                //Go back to parent node till its has next sible node

                while (tnCurrent != tnParent && tnCurrent == tnCurrentPar.LastNode)
                {

                    tnCurrent = tnCurrentPar;

                    tnCurrentPar = tnCurrentPar.Parent;

                }

                //Goto next sible node

                if (tnCurrent != tnParent)

                    tnCurrent = tnCurrent.NextNode;

            }
            return null;

        }

        private void ChooseStageDlg_Load(object sender, EventArgs e)
        {
            this.chooseText.Text = m_chooseText;

            TreeNode tnRet = null;
            foreach (TreeNode tn in this.stageTree.Nodes)
            {
                tnRet = FindStageNode(tn, m_chooseStage);
                if (tnRet != null)
                    break;
            }
            this.stageTree.SelectedNode = tnRet;
        }

        private string m_chooseText = "";
        public string ChooseText
        {
            get { return m_chooseText; }
            set { m_chooseText = value; }
        }
        private ContentStage m_chooseStage = null;
        public TextWorldEditor2.ContentStage ChooseStage
        {
            get { return m_chooseStage; }
            set { m_chooseStage = value; }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            m_chooseStage = null;
            m_chooseText = "";
            if (this.stageTree.SelectedNode != null)
            {
                m_chooseStage = this.stageTree.SelectedNode.Tag as ContentStage;
                m_chooseText = this.chooseText.Text;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }


    }
}
