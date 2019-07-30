using System;

namespace SampleWebAPI
{
    /*[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.genomichealth.com/Internal/Esb/v1/ResultsAggregationDataMessage.xs" +
        "d")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.genomichealth.com/Internal/Esb/v1/ResultsAggregationDataMessage.xs" +
        "d", IsNullable = false)]*/
    public class Order

    {
        public Guid Id { get; set; }
        public string Item { get; set; }
        public int  Quantity { get; set; }
        public float Price { get; set; }
    }
}
