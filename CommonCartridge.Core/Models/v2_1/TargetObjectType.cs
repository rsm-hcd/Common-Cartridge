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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="TargetObject.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_usagedata_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("TargetObjectType")]
public partial class TargetObjectType : EmptyPrimitiveTypeType
{
    
    #region Private fields
    private string _identifier;
    
    private string _partIdentifier;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="identifier")]
    public string Identifier
    {
        get
        {
            return this._identifier;
        }
        set
        {
            this._identifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="partIdentifier")]
    public string PartIdentifier
    {
        get
        {
            return this._partIdentifier;
        }
        set
        {
            this._partIdentifier = value;
        }
    }
}
}
#pragma warning restore
