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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="LifeCycle.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p3/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("LifeCycleType")]
public partial class LifeCycleType
{
    
    #region Private fields
    private List<object> _items;
    
    private List<System.Xml.XmlAttribute> _anyAttr;
    #endregion
    
    public LifeCycleType()
    {
        this._anyAttr = new List<System.Xml.XmlAttribute>();
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("contribute", typeof(ContributeLifeCycleType))]
    [System.Xml.Serialization.XmlElementAttribute("status", typeof(StatusType))]
    [System.Xml.Serialization.XmlElementAttribute("version", typeof(LangStringType))]
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
