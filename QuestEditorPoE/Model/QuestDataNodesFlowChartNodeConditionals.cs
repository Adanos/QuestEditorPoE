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
	public class QuestDataNodesFlowChartNodeConditionals
	{
		private string operatorField;
		private QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent componentsField;

		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Operator { get; set; }

		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("ExpressionComponent", typeof(QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent Components { get; set; }
	}
}
