using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TextWorldEditor2
{
    [DataContract]
    class ContentAction
    {
        private UInt32 m_type;
        [DataMember(Order = 0, IsRequired = true)]
        public UInt32 Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        private string m_text = "";
        [DataMember(Order = 1)]
        public string Text
        {
            get { return m_text; }
            set { m_text = value; }
        }
        private UInt32[] m_goId = new UInt32[2];
         [DataMember(Order = 2)]
        public UInt32[] GoId
        {
            get { return m_goId; }
            set { m_goId = value; }
        }
        private string [] m_goString = new string[2];
        [DataMember(Order = 3)]
        public string[] GoString
        {
            get { return m_goString; }
            set { m_goString = value; }
        }
        private UInt32 m_waitingMS = 0;
        [DataMember(Order = 4)]
        public System.UInt32 WaitingMS
        {
            get { return m_waitingMS; }
            set { m_waitingMS = value; }
        }

        public ContentAction()
        {
            for (int i = 0; i < m_goString.Count(); ++i )
            {
                m_goString[i] = "";
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    class ContentStage
    {
        private UInt32 m_id = 0;
        [DataMember(Order = 0, IsRequired = true)]
        public System.UInt32 Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        [DataMember(Order = 1, IsRequired = true)]
        public string Name
        {
            get
            {
                return m_name;
            }
        
            set
            {
                m_name = value;
            }
        }

        private string m_name="";
        private List<ContentAction> m_contentList = new List<ContentAction>();
        [DataMember(Order = 2)]
        public List<ContentAction> ContentList
        {
            get { return m_contentList; }
            set { m_contentList = value; }
        }
    }

    /// <summary>
    /// 内容管理器
    /// </summary>
    [DataContract]
    class Content
    {
        private UInt32 m_baseId = 0;
        [DataMember(Order = 0)]
        public System.UInt32 BaseId
        {
            get { return m_baseId; }
            set { m_baseId = value; }
        }

        private List<ContentStage> m_stages = new List<ContentStage>();
        [DataMember(Order = 1)]
        public List<ContentStage> Stages
        {
            get { return m_stages; }
            set { m_stages = value; }
        }


        public ContentStage NewStage()
        {
            var stage = new ContentStage();
            this.m_baseId++;
            stage.Id = this.m_baseId;
            this.m_stages.Add(stage);
            return stage;
        }

        public void DelStageById(UInt32 id)
        {
            foreach (ContentStage x in this.m_stages.Where(m => m.Id == id))
                this.m_stages.Remove(x);
        }

        public ContentStage GetStageById(UInt32 id)
        {
            var l = this.m_stages.Where(m => m.Id == id);
            return l.Count() > 0 ? l.ElementAt(0) : null;
        }
    }

    /// <summary>
    /// 方便于查看的层次结构，和游戏逻辑无关
    /// </summary>
    class ContentStageFilter
    {

    }
}
