// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.72
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace CommonCartridge.Core.Models.v1_2
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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="LOM.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p2/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("LOMType")]
public partial class LOMType
{
    
    #region Private fields
    private object[] _items;
    
    private ItemsChoiceType3[] _itemsElementName;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("classification", typeof(ClassificationType))]
    [System.Xml.Serialization.XmlElementAttribute("educational", typeof(EducationalType))]
    [System.Xml.Serialization.XmlElementAttribute("general", typeof(GeneralType))]
    [System.Xml.Serialization.XmlElementAttribute("lifeCycle", typeof(LifeCycleType))]
    [System.Xml.Serialization.XmlElementAttribute("relation", typeof(RelationType))]
    [System.Xml.Serialization.XmlElementAttribute("rights", typeof(RightsType))]
    [System.Xml.Serialization.XmlElementAttribute("technical", typeof(TechnicalType))]
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
    public ItemsChoiceType3[] ItemsElementName
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
}
}
#pragma warning restore
