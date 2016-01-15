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
        private int m_type;
        [DataMember(Order = 0, IsRequired = true)]
        public int Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        private string [] m_text = new string[2];
        [DataMember(Order = 1)]
        public string[] Text
        {
            get { return m_text; }
            set { m_text = value; }
        }
        private string [] m_param = new string[2];
        [DataMember(Order = 2)]
        public string[] Param
        {
            get { return m_param; }
            set { m_param = value; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    class ContentStage
    {
        [DataMember(Order = 0, IsRequired = true)]
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
        [DataMember(Order = 1)]
        public List<ContentAction> ContentList
        {
            get { return m_contentList; }
            set { m_contentList = value; }
        }
    }

    /// <summary>
    /// 内容管理器
    /// </summary>
    class Content
    {
    }
}
