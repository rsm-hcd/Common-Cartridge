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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ManifestMetadata.Type", Namespace="http://www.imsglobal.org/xsd/imsccv1p1/imscp_v1p1")]
[System.Xml.Serialization.XmlRootAttribute("ManifestMetadataType")]
public partial class ManifestMetadataType
{
    
    #region Private fields
    private ManifestMetadataTypeSchema _schema;
    
    private ManifestMetadataTypeSchemaversion _schemaversion;
    
    private LOMType _lom;
    #endregion
    
    public ManifestMetadataType()
    {
        this._lom = new LOMType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("schema")]
    public ManifestMetadataTypeSchema Schema
    {
        get
        {
            return this._schema;
        }
        set
        {
            this._schema = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("schemaversion")]
    public ManifestMetadataTypeSchemaversion Schemaversion
    {
        get
        {
            return this._schemaversion;
        }
        set
        {
            this._schemaversion = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ltsc.ieee.org/xsd/imsccv1p1/LOM/manifest", ElementName="lom")]
    public LOMType Lom
    {
        get
        {
            return this._lom;
        }
        set
        {
            this._lom = value;
        }
    }
}
}
#pragma warning restore
