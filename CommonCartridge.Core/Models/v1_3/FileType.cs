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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="File.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p3/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("FileType")]
public partial class FileType
{
    
    #region Private fields
    private MetadataType _metadata;
    
    private string _href;
    #endregion
    
    public FileType()
    {
        this._metadata = new MetadataType();
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI", AttributeName="href")]
    public string Href
    {
        get
        {
            return this._href;
        }
        set
        {
            this._href = value;
        }
    }
}
}
#pragma warning restore
