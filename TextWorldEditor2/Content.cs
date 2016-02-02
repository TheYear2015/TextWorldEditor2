using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TextWorldEditor2
{
    [DataContract]
    public class ContentAction
    {
        private UInt32 m_type;
        [DataMember(Order = 0, IsRequired = true)]
        public UInt32 Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        private string m_text = "";
        [DataMember(Order = 10)]
        public string Text
        {
            get { return m_text; }
            set { m_text = value; }
        }
        private UInt32 m_duringMS = 0;
        [DataMember(Order = 4)]
        public System.UInt32 DuringMS
        {
            get { return m_duringMS; }
            set { m_duringMS = value; }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ContentStage
    {
        private UInt32 m_id = 0;
        [DataMember(Order = 0, IsRequired = true)]
        public System.UInt32 Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        
        private string m_name = "";
        [DataMember(Order = 1, IsRequired = true)]
        public string Name
        {
            get{ return m_name;}
            set{ m_name = value;}
        }
  
        private UInt32[] m_goId = new UInt32[2];
        [DataMember(Order = 2)]
        public UInt32[] GoId
        {
            get { return m_goId; }
            set { m_goId = value; }
        }

        private string[] m_goString = new string[2];
        [DataMember(Order = 3)]
        public string[] GoString
        {
            get { return m_goString; }
            set { m_goString = value; }
        }

        /// <summary>
        /// 自动进入下一个场景
        /// </summary>
        private bool m_isAutoGoto = false;
        [DataMember(Order = 4)]
        public bool AutoGoto
        {
            get { return m_isAutoGoto; }
            set { m_isAutoGoto = value; }
        }

        private string m_backMusic = "";
        [DataMember(Order = 5)]
        public string BackMusic
        {
            get { return m_backMusic; }
            set { m_backMusic = value; }
        }
        
        private List<ContentAction> m_contentList = new List<ContentAction>();
        [DataMember(Order = 6)]
        public List<ContentAction> ContentList
        {
            get { return m_contentList; }
            set { m_contentList = value; }
        }

        public ContentStage()
        {
            for (int i = 0; i < m_goString.Count(); ++i )
            {
                m_goString[i] = "";
            }
        }
    }

    /// <summary>
    /// 内容管理器
    /// </summary>
    [DataContract]
    public class Content
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
            this.m_stages.RemoveAll(i => i.Id == id);
        }

        public ContentStage GetStageById(UInt32 id)
        {
            try
            {
                var l = this.m_stages.First(m => m.Id == id);
                return l;
            }
            catch
            {
                return null;
            }
        }
    }

    /// <summary>
    /// 方便于查看的层次结构，和游戏逻辑无关
    /// </summary>
    class ContentStageFilter
    {

    }
}
