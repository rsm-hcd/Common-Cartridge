// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_3
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="General.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("GeneralType")]
public partial class GeneralType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType3[] _itemsElementName;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public GeneralType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("aggregationLevel", typeof(AggregationLevelType))]
    [System.Xml.Serialization.XmlElementAttribute("coverage", typeof(LangStringType))]
    [System.Xml.Serialization.XmlElementAttribute("description", typeof(LangStringType))]
    [System.Xml.Serialization.XmlElementAttribute("identifier", typeof(IdentifierType))]
    [System.Xml.Serialization.XmlElementAttribute("keyword", typeof(LangStringType))]
    [System.Xml.Serialization.XmlElementAttribute("language", typeof(CharacterStringType))]
    [System.Xml.Serialization.XmlElementAttribute("structure", typeof(StructureType))]
    [System.Xml.Serialization.XmlElementAttribute("title", typeof(LangStringType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType3[] ItemsElementName
    {
        get
        {
            return this._itemsElementName;
        }
        set
        {
            this._itemsElementName = value;
        }
    }
    
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public List<System.Xml.XmlAttribute> AnyAttr
    {
        get
        {
            return this._anyAttr;
        }
        set
        {
            this._anyAttr = value;
        }
    }
}
}
#pragma warning restore
