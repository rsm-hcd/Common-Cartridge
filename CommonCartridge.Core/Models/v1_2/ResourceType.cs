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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="Resource.Type", Namespace="http://ltsc.ieee.org/xsd/imsccv1p2/LOM/manifest")]
[System.Xml.Serialization.XmlRootAttribute("ResourceType")]
public partial class ResourceType
{
    
    #region Private fields
    private List<object> _items;
    #endregion
    
    public ResourceType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("description", typeof(LangStringType))]
    [System.Xml.Serialization.XmlElementAttribute("identifier", typeof(IdentifierType))]
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
}
}
#pragma warning restore
