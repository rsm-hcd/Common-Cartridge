// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v2_1
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Protractor.Type", Namespace="http://www.imsglobal.org/xsd/apip/apipv1p0/imsapip_qtiv1p0")]
[System.Xml.Serialization.XmlRootAttribute("ProtractorType")]
public partial class ProtractorType
{
    
    #region Private fields
    private string _description;
    
    private object _item;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", ElementName="description")]
    public string Description
    {
        get
        {
            return this._description;
        }
        set
        {
            this._description = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("incrementSI", typeof(IncrementSIType))]
    [System.Xml.Serialization.XmlElementAttribute("incrementUS", typeof(IncrementUSType))]
    public object Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
}
}
#pragma warning restore
