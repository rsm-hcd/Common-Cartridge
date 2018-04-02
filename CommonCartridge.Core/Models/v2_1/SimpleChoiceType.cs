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

[System.Xml.Serialization.XmlRootAttribute("SimpleChoiceType")]
public partial class SimpleChoiceType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType20[] _itemsElementName;
    
    private List<string> _text;
    
    private string _id;
    
    private List<string> _class;
    
    private string _lang;
    
    private string _label;
    
    private string _identifier;
    
    private bool _fixed;
    
    private string _templateIdentifier;
    
    private SimpleChoiceTypeShowHide _showHide;
    #endregion
    
    public SimpleChoiceType()
    {
        this._class = new List<string>();
        this._text = new List<string>();
        this._fixed = false;
        this._showHide = SimpleChoiceTypeShowHide.show;
    }
    
    [System.Xml.Serialization.XmlElementAttribute("a", typeof(AType))]
    [System.Xml.Serialization.XmlElementAttribute("abbr", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("acronym", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("address", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("b", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("big", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("blockquote", typeof(BlockQuoteType))]
    [System.Xml.Serialization.XmlElementAttribute("br", typeof(BRType))]
    [System.Xml.Serialization.XmlElementAttribute("cite", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("code", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("dfn", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("div", typeof(DivType))]
    [System.Xml.Serialization.XmlElementAttribute("dl", typeof(DLType))]
    [System.Xml.Serialization.XmlElementAttribute("em", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("feedbackBlock", typeof(FeedbackBlockType))]
    [System.Xml.Serialization.XmlElementAttribute("feedbackInline", typeof(FeedbackInlineType))]
    [System.Xml.Serialization.XmlElementAttribute("h1", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h2", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h3", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h4", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h5", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("h6", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("hr", typeof(HRType))]
    [System.Xml.Serialization.XmlElementAttribute("i", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("img", typeof(ImgType))]
    [System.Xml.Serialization.XmlElementAttribute("kbd", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("object", typeof(ObjectType))]
    [System.Xml.Serialization.XmlElementAttribute("ol", typeof(OULType))]
    [System.Xml.Serialization.XmlElementAttribute("p", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("pre", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("printedVariable", typeof(PrintedVariableType))]
    [System.Xml.Serialization.XmlElementAttribute("q", typeof(QType))]
    [System.Xml.Serialization.XmlElementAttribute("samp", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("small", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("span", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("strong", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("sub", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("sup", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("table", typeof(TableType))]
    [System.Xml.Serialization.XmlElementAttribute("templateBlock", typeof(TemplateBlockType))]
    [System.Xml.Serialization.XmlElementAttribute("templateInline", typeof(TemplateInlineType))]
    [System.Xml.Serialization.XmlElementAttribute("tt", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("ul", typeof(OULType))]
    [System.Xml.Serialization.XmlElementAttribute("var", typeof(HTMLTextType))]
    [System.Xml.Serialization.XmlElementAttribute("math", typeof(Mathtype), Namespace="http://www.w3.org/1998/Math/MathML")]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(IncludeType), Namespace="http://www.w3.org/2001/XInclude")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
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
    
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType20[] ItemsElementName
    {
        get
        {
            return this._itemsElementName;
        }
        set
        {
            this._itemsElementName = value;
        }
    }
    
    [System.Xml.Serialization.XmlTextAttribute()]
    public List<string> Text
    {
        get
        {
            return this._text;
        }
        set
        {
            this._text = value;
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="identifier")]
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
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="fixed")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Fixed
    {
        get
        {
            return this._fixed;
        }
        set
        {
            this._fixed = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName", AttributeName="templateIdentifier")]
    public string TemplateIdentifier
    {
        get
        {
            return this._templateIdentifier;
        }
        set
        {
            this._templateIdentifier = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="showHide")]
    [System.ComponentModel.DefaultValueAttribute(SimpleChoiceTypeShowHide.show)]
    public SimpleChoiceTypeShowHide ShowHide
    {
        get
        {
            return this._showHide;
        }
        set
        {
            this._showHide = value;
        }
    }
}
}
#pragma warning restore
