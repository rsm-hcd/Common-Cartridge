// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v2_2
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="InteractivityLevel.Type", Namespace="http://ltsc.ieee.org/xsd/LOM")]
[System.Xml.Serialization.XmlRootAttribute("InteractivityLevelType")]
public partial class InteractivityLevelType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType14[] _itemsElementName;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public InteractivityLevelType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("source", typeof(CharacterStringType))]
    [System.Xml.Serialization.XmlElementAttribute("value", typeof(CharacterStringType))]
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
    public ItemsChoiceType14[] ItemsElementName
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
