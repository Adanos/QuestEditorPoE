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
	public class QuestDataNodesFlowChartNode
	{
		private string nodeIDField;
		private string commentsField;
		private string packageIDField;
		private string containerNodeIDField;
		private string onEnterScriptsField;
		private string onExitScriptsField;
		private string onUpdateScriptsField;
		private string isTempTextField;
		private string experienceWeightField;
		private string experienceTypeField;
		private string experienceLevelField;
		private List<QuestDataNodesFlowChartNodeLinksFlowChartLink> linksField;
		private ClassExtender classExtenderField;
		private QuestDataNodesFlowChartNodeConditionals conditionalsField;
		private List<int> addendumIDsField;
		private List<QuestDataNodesFlowChartNodeEndStatesQuestEndState> endStatesField;

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string NodeID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Comments { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string PackageID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ContainerNodeID { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string OnEnterScripts { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string OnExitScripts { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string OnUpdateScripts { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string IsTempText { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ExperienceWeight { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ExperienceType { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string ExperienceLevel { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("FlowChartLink", typeof(QuestDataNodesFlowChartNodeLinksFlowChartLink), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public List<QuestDataNodesFlowChartNodeLinksFlowChartLink> Links { get; set; }

		[System.Xml.Serialization.XmlElementAttribute("ClassExtender")]
		public ClassExtender ClassExtender { get; set; }

		[System.Xml.Serialization.XmlElementAttribute("Conditionals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public QuestDataNodesFlowChartNodeConditionals Conditionals { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("int", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public List<int> AddendumIDs { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("QuestEndState", typeof(QuestDataNodesFlowChartNodeEndStatesQuestEndState), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public List<QuestDataNodesFlowChartNodeEndStatesQuestEndState> EndStates { get; set; }
	}
}
