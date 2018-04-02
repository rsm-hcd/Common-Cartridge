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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ResponseCondition.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("responseCondition", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class ResponseConditionType
{
    
    #region Private fields
    private ResponseIfType _responseIf;
    
    private List<ResponseIfType> _responseElseIf;
    
    private ResponseElseType _responseElse;
    #endregion
    
    public ResponseConditionType()
    {
        this._responseElse = new ResponseElseType();
        this._responseElseIf = new List<ResponseIfType>();
        this._responseIf = new ResponseIfType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("responseIf")]
    public ResponseIfType ResponseIf
    {
        get
        {
            return this._responseIf;
        }
        set
        {
            this._responseIf = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("responseElseIf", ElementName="responseElseIf")]
    public List<ResponseIfType> ResponseElseIf
    {
        get
        {
            return this._responseElseIf;
        }
        set
        {
            this._responseElseIf = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("responseElse")]
    public ResponseElseType ResponseElse
    {
        get
        {
            return this._responseElse;
        }
        set
        {
            this._responseElse = value;
        }
    }
}
}
#pragma warning restore
