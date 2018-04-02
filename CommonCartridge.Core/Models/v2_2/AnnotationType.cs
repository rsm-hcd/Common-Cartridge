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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Annotation.Type", Namespace="http://ltsc.ieee.org/xsd/LOM")]
[System.Xml.Serialization.XmlRootAttribute("AnnotationType")]
public partial class AnnotationType
{
    
    #region Private fields
    private List<object> _items;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public AnnotationType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("date", typeof(DateTimeType))]
    [System.Xml.Serialization.XmlElementAttribute("description", typeof(LangStringType))]
    [System.Xml.Serialization.XmlElementAttribute("entity", typeof(CharacterStringType))]
    public List<object> Items
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
