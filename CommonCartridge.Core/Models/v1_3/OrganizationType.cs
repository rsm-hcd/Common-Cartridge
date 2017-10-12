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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Organization.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("OrganizationType")]
public partial class OrganizationType
{
    
    #region Private fields
    private string _title;
    
    private ItemOrgType _item;
    
    private MetadataType _metadata;
    
    private string _identifier;
    
    private string _structure;
    #endregion
    
    public OrganizationType()
    {
        this._metadata = new MetadataType();
        this._item = new ItemOrgType();
        this._structure = "rooted-hierarchy";
    }
    
    [System.Xml.Serialization.XmlElementAttribute("title")]
    public string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public ItemOrgType Item
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
    
    [System.Xml.Serialization.XmlElementAttribute("metadata")]
    public MetadataType Metadata
    {
        get
        {
            return this._metadata;
        }
        set
        {
            this._metadata = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="identifier")]
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="structure")]
    public string Structure
    {
        get
        {
            return this._structure;
        }
        set
        {
            this._structure = value;
        }
    }
}
}
#pragma warning restore
