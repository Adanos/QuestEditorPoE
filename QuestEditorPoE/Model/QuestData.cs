using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestEditorPoE.Model
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public class QuestData
	{
		private string nextNodeIDField;
		private string nextEventIDField;
		private string nextEndStateIDField;
		private string nextAddendumIDField;
		private string questTypeField;
		private List<QuestDataNodesFlowChartNode> nodesField;
		private List<QuestDataBookmarksBookmark> bookmarksField;
		private ClassExtender classExtenderField;
		private List<QuestDataEventsQuestEvent> eventsField;

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string NextNodeID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string NextEventID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string NextEndStateID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string NextAddendumID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string QuestType { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("FlowChartNode", typeof(QuestDataNodesFlowChartNode), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public List<QuestDataNodesFlowChartNode> Nodes { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("Bookmark", typeof(QuestDataBookmarksBookmark), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public List<QuestDataBookmarksBookmark> Bookmarks { get; set; }

		[System.Xml.Serialization.XmlElementAttribute("ClassExtender")]
		public ClassExtender ClassExtender { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("QuestEvent", typeof(QuestDataEventsQuestEvent), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public List<QuestDataEventsQuestEvent> Events { get; set; }
	}
}
