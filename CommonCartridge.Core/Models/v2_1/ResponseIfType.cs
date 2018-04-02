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
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ResponseIf.Type", Namespace="http://www.imsglobal.org/xsd/imsqti_v2p1")]
[System.Xml.Serialization.XmlRootAttribute("ResponseIfType")]
public partial class ResponseIfType
{
    
    #region Private fields
    private object _item;
    
    private ItemChoiceType14 _itemElementName;
    
    private List<object> _items;
    #endregion
    
    public ResponseIfType()
    {
        this._items = new List<object>();
    }
    
    [System.Xml.Serialization.XmlElementAttribute("and", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("anyN", typeof(AnyNType))]
    [System.Xml.Serialization.XmlElementAttribute("baseValue", typeof(BaseValueType))]
    [System.Xml.Serialization.XmlElementAttribute("containerSize", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("contains", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("correct", typeof(CorrectType))]
    [System.Xml.Serialization.XmlElementAttribute("customOperator", typeof(CustomOperatorType))]
    [System.Xml.Serialization.XmlElementAttribute("default", typeof(DefaultType))]
    [System.Xml.Serialization.XmlElementAttribute("delete", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("divide", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("durationGTE", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("durationLT", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("equal", typeof(EqualType))]
    [System.Xml.Serialization.XmlElementAttribute("equalRounded", typeof(EqualRoundedType))]
    [System.Xml.Serialization.XmlElementAttribute("fieldValue", typeof(FieldValueType))]
    [System.Xml.Serialization.XmlElementAttribute("gcd", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("gt", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("gte", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("index", typeof(IndexType))]
    [System.Xml.Serialization.XmlElementAttribute("inside", typeof(InsideType))]
    [System.Xml.Serialization.XmlElementAttribute("integerDivide", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("integerModulus", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("integerToFloat", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("isNull", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("lcm", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("lt", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("lte", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("mapResponse", typeof(MapResponseType))]
    [System.Xml.Serialization.XmlElementAttribute("mapResponsePoint", typeof(MapResponseType))]
    [System.Xml.Serialization.XmlElementAttribute("match", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("mathConstant", typeof(MathConstantType))]
    [System.Xml.Serialization.XmlElementAttribute("mathOperator", typeof(MathOperatorType))]
    [System.Xml.Serialization.XmlElementAttribute("max", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("member", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("min", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("multiple", typeof(Logic0toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("not", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("null", typeof(EmptyPrimitiveTypeType))]
    [System.Xml.Serialization.XmlElementAttribute("numberCorrect", typeof(NumberType))]
    [System.Xml.Serialization.XmlElementAttribute("numberIncorrect", typeof(NumberType))]
    [System.Xml.Serialization.XmlElementAttribute("numberPresented", typeof(NumberType))]
    [System.Xml.Serialization.XmlElementAttribute("numberResponded", typeof(NumberType))]
    [System.Xml.Serialization.XmlElementAttribute("numberSelected", typeof(NumberType))]
    [System.Xml.Serialization.XmlElementAttribute("or", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("ordered", typeof(Logic0toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("outcomeMaximum", typeof(OutcomeMinMaxType))]
    [System.Xml.Serialization.XmlElementAttribute("outcomeMinimum", typeof(OutcomeMinMaxType))]
    [System.Xml.Serialization.XmlElementAttribute("patternMatch", typeof(PatternMatchType))]
    [System.Xml.Serialization.XmlElementAttribute("power", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("product", typeof(Logic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("random", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("randomFloat", typeof(RandomFloatType))]
    [System.Xml.Serialization.XmlElementAttribute("randomInteger", typeof(RandomIntegerType))]
    [System.Xml.Serialization.XmlElementAttribute("repeat", typeof(RepeatType))]
    [System.Xml.Serialization.XmlElementAttribute("round", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("roundTo", typeof(RoundToType))]
    [System.Xml.Serialization.XmlElementAttribute("statsOperator", typeof(StatsOperatorType))]
    [System.Xml.Serialization.XmlElementAttribute("stringMatch", typeof(StringMatchType))]
    [System.Xml.Serialization.XmlElementAttribute("substring", typeof(SubstringType))]
    [System.Xml.Serialization.XmlElementAttribute("subtract", typeof(LogicPairType))]
    [System.Xml.Serialization.XmlElementAttribute("sum", typeof(NumericLogic1toManyType))]
    [System.Xml.Serialization.XmlElementAttribute("testVariables", typeof(TestVariablesType))]
    [System.Xml.Serialization.XmlElementAttribute("truncate", typeof(LogicSingleType))]
    [System.Xml.Serialization.XmlElementAttribute("variable", typeof(VariableType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
        get
        {
            return this._item;
        }
        set
        {
            this._item = value;
        }
    }
    
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType14 ItemElementName
    {
        get
        {
            return this._itemElementName;
        }
        set
        {
            this._itemElementName = value;
        }
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
}
}
#pragma warning restore
