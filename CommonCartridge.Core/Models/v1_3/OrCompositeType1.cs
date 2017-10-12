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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="OrComposite.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/resource")]
[System.Xml.Serialization.XmlRootAttribute("OrCompositeType1")]
public partial class OrCompositeType1
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType35[] _itemsElementName;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public OrCompositeType1()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("maximumVersion", typeof(CharacterStringType1))]
    [System.Xml.Serialization.XmlElementAttribute("minimumVersion", typeof(CharacterStringType1))]
    [System.Xml.Serialization.XmlElementAttribute("name", typeof(NameType1))]
    [System.Xml.Serialization.XmlElementAttribute("type", typeof(TypeType1))]
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
    public ItemsChoiceType35[] ItemsElementName
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
