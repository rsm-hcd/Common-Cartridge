// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_1
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Technical.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("TechnicalType")]
public partial class TechnicalType
{
    
    #region Private fields
    private List<string> _format;
    #endregion
    
    public TechnicalType()
    {
        this._format = new List<string>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("format", ElementName="format")]
    public List<string> Format
    {
        get
        {
            return this._format;
        }
        set
        {
            this._format = value;
        }
    }
}
}
#pragma warning restore