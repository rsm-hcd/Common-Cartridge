// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_2_1
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.imsglobal.org/xsd/ims_qtilitev1p2", TypeName="itemType")]
[System.Xml.Serialization.XmlRootAttribute("item", Namespace="http://www.imsglobal.org/xsd/ims_qtilitev1p2", IsNullable=false, ElementName="itemType")]
public partial class ItemType
{
    
    #region Private fields
    private List<ObjectivesType> _objectives;
    
    private List<RubricType> _rubric;
    
    private PresentationType _presentation;
    
    private List<ResprocessingType> _resprocessing;
    
    private List<ItemfeedbackType> _itemfeedback;
    
    private string _label;
    
    private string _ident;
    
    private string _title;
    #endregion
    
    public ItemType()
    {
        this._itemfeedback = new List<ItemfeedbackType>();
        this._resprocessing = new List<ResprocessingType>();
        this._presentation = new PresentationType();
        this._rubric = new List<RubricType>();
        this._objectives = new List<ObjectivesType>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("objectives", ElementName="objectives")]
    public List<ObjectivesType> Objectives
    {
        get
        {
            return this._objectives;
        }
        set
        {
            this._objectives = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("rubric", ElementName="rubric")]
    public List<RubricType> Rubric
    {
        get
        {
            return this._rubric;
        }
        set
        {
            this._rubric = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("presentation")]
    public PresentationType Presentation
    {
        get
        {
            return this._presentation;
        }
        set
        {
            this._presentation = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("resprocessing", ElementName="resprocessing")]
    public List<ResprocessingType> Resprocessing
    {
        get
        {
            return this._resprocessing;
        }
        set
        {
            this._resprocessing = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("itemfeedback", ElementName="itemfeedback")]
    public List<ItemfeedbackType> Itemfeedback
    {
        get
        {
            return this._itemfeedback;
        }
        set
        {
            this._itemfeedback = value;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="ident")]
    public string Ident
    {
        get
        {
            return this._ident;
        }
        set
        {
            this._ident = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="title")]
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
}
}
#pragma warning restore
