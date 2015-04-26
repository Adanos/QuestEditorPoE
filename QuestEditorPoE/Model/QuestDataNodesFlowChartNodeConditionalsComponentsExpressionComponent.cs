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
	public class QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent
	{
		private string notField;
		private string operatorField;
		private QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentData dataField;

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Not { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Operator { get; set; }

		[System.Xml.Serialization.XmlElementAttribute("Data", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentData Data { get; set; }
	}
}
