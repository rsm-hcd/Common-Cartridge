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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ResponseProcessing.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("responseProcessing", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class ResponseProcessingType
{
    
    #region Private fields
    private List<object> _items;
    
    private string _template;
    
    private string _templateLocation;
    #endregion
    
    public ResponseProcessingType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("exitResponse", typeof(EmptyPrimitiveTypeType))]
    [System.Xml.Serialization.XmlElementAttribute("lookupOutcomeValue", typeof(LookupOutcomeValueType))]
    [System.Xml.Serialization.XmlElementAttribute("responseCondition", typeof(ResponseConditionType))]
    [System.Xml.Serialization.XmlElementAttribute("responseProcessingFragment", typeof(ResponseProcessingFragmentType))]
    [System.Xml.Serialization.XmlElementAttribute("setOutcomeValue", typeof(SetValueType))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(IncludeType), Namespace="http://www.w3.org/2001/XInclude")]
    public List<object> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            this._items = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI", AttributeName="template")]
    public string Template
    {
        get
        {
            return this._template;
        }
        set
        {
            this._template = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI", AttributeName="templateLocation")]
    public string TemplateLocation
    {
        get
        {
            return this._templateLocation;
        }
        set
        {
            this._templateLocation = value;
        }
    }
}
}
#pragma warning restore
