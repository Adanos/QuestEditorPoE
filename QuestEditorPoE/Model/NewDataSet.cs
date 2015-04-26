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
	public class NewDataSet
	{
		private StringTableFile[] itemsField;

		[System.Xml.Serialization.XmlElementAttribute("StringTableFile")]
		[System.Xml.Serialization.XmlElementAttribute("ClassExtender", typeof(ClassExtender))]
		[System.Xml.Serialization.XmlElementAttribute("QuestData", typeof(QuestData))]
		public StringTableFile[] Items { get; set; }
	}
}
