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
            //test
            this.contentList.BeginUpdate();

            for (int i = 0; i < 10; i++)
            {
                var lvi = new ListViewItem();

                lvi.ImageIndex = i;
 
                lvi.Text = "item asdasdasdadasdada" + i;

                //lvi.SubItems.Add("sdasdasdasdadasdada");

                this.contentList.Items.Add(lvi);
            }
            this.contentList.EndUpdate();
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

    }
}
