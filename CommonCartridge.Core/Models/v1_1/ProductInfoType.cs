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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProductInfo.Type", Namespace = "http://www.imsglobal.org/xsd/imslticp_v1p0")]
    [System.Xml.Serialization.XmlRootAttribute("ProductInfoType")]
    public partial class ProductInfoType
    {

        #region Private fields
        private string _code;

        private LocalizedStringType _name;

        private string _version;

        private LocalizedStringType _description;

        private LocalizedStringType _technical_description;
        #endregion

        public ProductInfoType()
        {
            this._technical_description = new LocalizedStringType();
            this._description = new LocalizedStringType();
            this._name = new LocalizedStringType();
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "Name", ElementName = "code")]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("name")]
        public LocalizedStringType Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", ElementName = "version")]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("description")]
        public LocalizedStringType Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("technical_description")]
        public LocalizedStringType Technical_description
        {
            get
            {
                return this._technical_description;
            }
            set
            {
                this._technical_description = value;
            }
        }
    }
}
#pragma warning restore
