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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="TextEntryInteraction.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("textEntryInteraction", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1", IsNullable=false)]
public partial class TextEntryInteractionType : EmptyPrimitiveTypeType
{
    
    #region Private fields
    private string _base;
    
    private string _id;
    
    private List<string> _class;
    
    private string _lang;
    
    private string _label;
    
    private string _responseIdentifier;
    
    private int _base1;
    
    private string _stringIdentifier;
    
    private int _expectedLength;
    
    private string _patternMask;
    
    private string _placeholderText;
    #endregion
    
    public TextEntryInteractionType()
    {
        this._class = new List<string>();
        this._base1 = 10;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF", AttributeName="responseIdentifier")]
    public string ResponseIdentifier
    {
        get
        {
            return this._responseIdentifier;
        }
        set
        {
            this._responseIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("base", AttributeName="base1")]
    [System.ComponentModel.DefaultValueAttribute(10)]
    public int Base1
    {
        get
        {
            return this._base1;
        }
        set
        {
            this._base1 = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF", AttributeName="stringIdentifier")]
    public string StringIdentifier
    {
        get
        {
            return this._stringIdentifier;
        }
        set
        {
            this._stringIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="expectedLength")]
    public int ExpectedLength
    {
        get
        {
            return this._expectedLength;
        }
        set
        {
            this._expectedLength = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="patternMask")]
    public string PatternMask
    {
        get
        {
            return this._patternMask;
        }
        set
        {
            this._patternMask = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="placeholderText")]
    public string PlaceholderText
    {
        get
        {
            return this._placeholderText;
        }
        set
        {
            this._placeholderText = value;
        }
    }
}
}
#pragma warning restore
