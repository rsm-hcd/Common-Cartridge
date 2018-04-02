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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Table.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("table", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class TableType
{
    
    #region Private fields
    private CaptionType _caption;
    
    private List<ColType> _col;
    
    private List<ColGroupType> _colgroup;
    
    private TablePartType _thead;
    
    private TablePartType _tfoot;
    
    private List<TablePartType> _tbody;
    
    private string _id;
    
    private List<string> _class;
    
    private string _lang;
    
    private string _label;
    
    private string _base;
    
    private string _summary;
    #endregion
    
    public TableType()
    {
        this._class = new List<string>();
        this._tbody = new List<TablePartType>();
        this._tfoot = new TablePartType();
        this._thead = new TablePartType();
        this._colgroup = new List<ColGroupType>();
        this._col = new List<ColType>();
        this._caption = new CaptionType();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("caption")]
    public CaptionType Caption
    {
        get
        {
            return this._caption;
        }
        set
        {
            this._caption = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("col", ElementName="col")]
    public List<ColType> Col
    {
        get
        {
            return this._col;
        }
        set
        {
            this._col = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("colgroup", ElementName="colgroup")]
    public List<ColGroupType> Colgroup
    {
        get
        {
            return this._colgroup;
        }
        set
        {
            this._colgroup = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("thead")]
    public TablePartType Thead
    {
        get
        {
            return this._thead;
        }
        set
        {
            this._thead = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("tfoot")]
    public TablePartType Tfoot
    {
        get
        {
            return this._tfoot;
        }
        set
        {
            this._tfoot = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("tbody", ElementName="tbody")]
    public List<TablePartType> Tbody
    {
        get
        {
            return this._tbody;
        }
        set
        {
            this._tbody = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID", AttributeName="id")]
    public string Id
    {
        get
        {
            return this._id;
        }
        set
        {
            this._id = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="class")]
    public List<string> Class
    {
        get
        {
            return this._class;
        }
        set
        {
            this._class = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="lang")]
    public string Lang
    {
        get
        {
            return this._lang;
        }
        set
        {
            this._lang = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="label")]
    public string Label
    {
        get
        {
            return this._label;
        }
        set
        {
            this._label = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace", AttributeName="base")]
    public string Base
    {
        get
        {
            return this._base;
        }
        set
        {
            this._base = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="summary")]
    public string Summary
    {
        get
        {
            return this._summary;
        }
        set
        {
            this._summary = value;
        }
    }
}
}
#pragma warning restore
