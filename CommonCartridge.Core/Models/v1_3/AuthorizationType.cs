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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Authorization.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imsccauth_v1p3")]
[System.Xml.Serialization.XmlRootAttribute("AuthorizationType")]
public partial class AuthorizationType
{
    
    #region Private fields
    private string _cartridgeId;
    
    private string _webservice;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", ElementName="cartridgeId")]
    public string CartridgeId
    {
        get
        {
            return this._cartridgeId;
        }
        set
        {
            this._cartridgeId = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString", ElementName="webservice")]
    public string Webservice
    {
        get
        {
            return this._webservice;
        }
        set
        {
            this._webservice = value;
        }
    }
}
}
#pragma warning restore
