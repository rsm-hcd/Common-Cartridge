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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Vendor.Type", Namespace="http://www.imsglobal.org/xsd/imslticp_v1p0")]
[System.Xml.Serialization.XmlRootAttribute("VendorType")]
public partial class VendorType
{
    
    #region Private fields
    private string _code;
    
    private LocalizedStringType _name;
    
    private LocalizedStringType _description;
    
    private string _url;
    
    private ContactType _contact;
    #endregion
    
    public VendorType()
    {
        this._contact = new ContactType();
        this._description = new LocalizedStringType();
        this._name = new LocalizedStringType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute(DataType="Name", ElementName="code")]
    public string Code
    {
        get
        {
            return this._code;
        }
        set
        {
            this._code = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("name")]
    public LocalizedStringType Name
    {
        get
        {
            return this._name;
        }
        set
        {
            this._name = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("description")]
    public LocalizedStringType Description
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
    
    [System.Xml.Serialization.XmlElementAttribute("url")]
    public string Url
    {
        get
        {
            return this._url;
        }
        set
        {
            this._url = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("contact")]
    public ContactType Contact
    {
        get
        {
            return this._contact;
        }
        set
        {
            this._contact = value;
        }
    }
}
}
#pragma warning restore
