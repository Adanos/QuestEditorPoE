﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.18444
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ClassExtender {
    
    private string extendedPropertiesField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExtendedProperties {
        get {
            return this.extendedPropertiesField;
        }
        set {
            this.extendedPropertiesField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class QuestData {
    
    private string nextNodeIDField;
    
    private string nextEventIDField;
    
    private string nextEndStateIDField;
    
    private string nextAddendumIDField;
    
    private string questTypeField;
    
    private QuestDataNodesFlowChartNode[][] nodesField;
    
    private QuestDataBookmarksBookmark[][] bookmarksField;
    
    private ClassExtender[] classExtenderField;
    
    private QuestDataEventsQuestEvent[][] eventsField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NextNodeID {
        get {
            return this.nextNodeIDField;
        }
        set {
            this.nextNodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NextEventID {
        get {
            return this.nextEventIDField;
        }
        set {
            this.nextEventIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NextEndStateID {
        get {
            return this.nextEndStateIDField;
        }
        set {
            this.nextEndStateIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NextAddendumID {
        get {
            return this.nextAddendumIDField;
        }
        set {
            this.nextAddendumIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string QuestType {
        get {
            return this.questTypeField;
        }
        set {
            this.questTypeField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FlowChartNode", typeof(QuestDataNodesFlowChartNode), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataNodesFlowChartNode[][] Nodes {
        get {
            return this.nodesField;
        }
        set {
            this.nodesField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Bookmark", typeof(QuestDataBookmarksBookmark), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataBookmarksBookmark[][] Bookmarks {
        get {
            return this.bookmarksField;
        }
        set {
            this.bookmarksField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("ClassExtender")]
    public ClassExtender[] ClassExtender {
        get {
            return this.classExtenderField;
        }
        set {
            this.classExtenderField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("QuestEvent", typeof(QuestDataEventsQuestEvent), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataEventsQuestEvent[][] Events {
        get {
            return this.eventsField;
        }
        set {
            this.eventsField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNode {
    
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
    
    private QuestDataNodesFlowChartNodeLinksFlowChartLink[][] linksField;
    
    private ClassExtender[] classExtenderField;
    
    private QuestDataNodesFlowChartNodeConditionals[] conditionalsField;
    
    private QuestDataNodesFlowChartNodeAddendumIDsInt[][] addendumIDsField;
    
    private QuestDataNodesFlowChartNodeEndStatesQuestEndState[][] endStatesField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NodeID {
        get {
            return this.nodeIDField;
        }
        set {
            this.nodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Comments {
        get {
            return this.commentsField;
        }
        set {
            this.commentsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PackageID {
        get {
            return this.packageIDField;
        }
        set {
            this.packageIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ContainerNodeID {
        get {
            return this.containerNodeIDField;
        }
        set {
            this.containerNodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OnEnterScripts {
        get {
            return this.onEnterScriptsField;
        }
        set {
            this.onEnterScriptsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OnExitScripts {
        get {
            return this.onExitScriptsField;
        }
        set {
            this.onExitScriptsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string OnUpdateScripts {
        get {
            return this.onUpdateScriptsField;
        }
        set {
            this.onUpdateScriptsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string IsTempText {
        get {
            return this.isTempTextField;
        }
        set {
            this.isTempTextField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExperienceWeight {
        get {
            return this.experienceWeightField;
        }
        set {
            this.experienceWeightField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExperienceType {
        get {
            return this.experienceTypeField;
        }
        set {
            this.experienceTypeField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ExperienceLevel {
        get {
            return this.experienceLevelField;
        }
        set {
            this.experienceLevelField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FlowChartLink", typeof(QuestDataNodesFlowChartNodeLinksFlowChartLink), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataNodesFlowChartNodeLinksFlowChartLink[][] Links {
        get {
            return this.linksField;
        }
        set {
            this.linksField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("ClassExtender")]
    public ClassExtender[] ClassExtender {
        get {
            return this.classExtenderField;
        }
        set {
            this.classExtenderField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("Conditionals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public QuestDataNodesFlowChartNodeConditionals[] Conditionals {
        get {
            return this.conditionalsField;
        }
        set {
            this.conditionalsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("int", typeof(QuestDataNodesFlowChartNodeAddendumIDsInt), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public QuestDataNodesFlowChartNodeAddendumIDsInt[][] AddendumIDs {
        get {
            return this.addendumIDsField;
        }
        set {
            this.addendumIDsField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("QuestEndState", typeof(QuestDataNodesFlowChartNodeEndStatesQuestEndState), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataNodesFlowChartNodeEndStatesQuestEndState[][] EndStates {
        get {
            return this.endStatesField;
        }
        set {
            this.endStatesField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeLinksFlowChartLink {
    
    private string fromNodeIDField;
    
    private string toNodeIDField;
    
    private string pointsToGhostField;
    
    private string requiredToExitObjectiveField;
    
    private ClassExtender[] classExtenderField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FromNodeID {
        get {
            return this.fromNodeIDField;
        }
        set {
            this.fromNodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ToNodeID {
        get {
            return this.toNodeIDField;
        }
        set {
            this.toNodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PointsToGhost {
        get {
            return this.pointsToGhostField;
        }
        set {
            this.pointsToGhostField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RequiredToExitObjective {
        get {
            return this.requiredToExitObjectiveField;
        }
        set {
            this.requiredToExitObjectiveField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("ClassExtender")]
    public ClassExtender[] ClassExtender {
        get {
            return this.classExtenderField;
        }
        set {
            this.classExtenderField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeConditionals {
    
    private string operatorField;
    
    private QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent[][] componentsField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Operator {
        get {
            return this.operatorField;
        }
        set {
            this.operatorField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ExpressionComponent", typeof(QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent[][] Components {
        get {
            return this.componentsField;
        }
        set {
            this.componentsField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponent {
    
    private string notField;
    
    private string operatorField;
    
    private QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentData[] dataField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Not {
        get {
            return this.notField;
        }
        set {
            this.notField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Operator {
        get {
            return this.operatorField;
        }
        set {
            this.operatorField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("Data", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentData[] Data {
        get {
            return this.dataField;
        }
        set {
            this.dataField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentData {
    
    private string fullNameField;
    
    private QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentDataParametersString[][] parametersField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FullName {
        get {
            return this.fullNameField;
        }
        set {
            this.fullNameField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("string", typeof(QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentDataParametersString), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentDataParametersString[][] Parameters {
        get {
            return this.parametersField;
        }
        set {
            this.parametersField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeConditionalsComponentsExpressionComponentDataParametersString {
    
    private string valueField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeAddendumIDsInt {
    
    private string valueField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataNodesFlowChartNodeEndStatesQuestEndState {
    
    private string endStateIDField;
    
    private string displayNameField;
    
    private string packageIDField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EndStateID {
        get {
            return this.endStateIDField;
        }
        set {
            this.endStateIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DisplayName {
        get {
            return this.displayNameField;
        }
        set {
            this.displayNameField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PackageID {
        get {
            return this.packageIDField;
        }
        set {
            this.packageIDField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataBookmarksBookmark {
    
    private string typeField;
    
    private string nameField;
    
    private string nodeIDField;
    
    private string ghostNodeParentIDField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NodeID {
        get {
            return this.nodeIDField;
        }
        set {
            this.nodeIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string GhostNodeParentID {
        get {
            return this.ghostNodeParentIDField;
        }
        set {
            this.ghostNodeParentIDField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class QuestDataEventsQuestEvent {
    
    private string eventIDField;
    
    private string displayNameField;
    
    private string variableNameField;
    
    private string variableValueField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string EventID {
        get {
            return this.eventIDField;
        }
        set {
            this.eventIDField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DisplayName {
        get {
            return this.displayNameField;
        }
        set {
            this.displayNameField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VariableName {
        get {
            return this.variableNameField;
        }
        set {
            this.variableNameField = value;
        }
    }
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VariableValue {
        get {
            return this.variableValueField;
        }
        set {
            this.variableValueField = value;
        }
    }
}

/// <uwagi/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <uwagi/>
    [System.Xml.Serialization.XmlElementAttribute("ClassExtender", typeof(ClassExtender))]
    [System.Xml.Serialization.XmlElementAttribute("QuestData", typeof(QuestData))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}