// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_2
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Context.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p2/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("ContextType")]
public partial class ContextType
{
    
    #region Private fields
    private ContextTypeSource _source;
    
    private ContextTypeValue _value;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("source")]
    public ContextTypeSource Source
    {
        get
        {
            return this._source;
        }
        set
        {
            this._source = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public ContextTypeValue Value
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = value;
        }
    }
}
}
#pragma warning restore
