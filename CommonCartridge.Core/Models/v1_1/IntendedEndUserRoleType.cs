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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="IntendedEndUserRole.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("IntendedEndUserRoleType")]
public partial class IntendedEndUserRoleType
{
    
    #region Private fields
    private IntendedEndUserRoleTypeSource _source;
    
    private IntendedEndUserRoleTypeValue _value;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("source")]
    public IntendedEndUserRoleTypeSource Source
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
    public IntendedEndUserRoleTypeValue Value
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
