namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CustomsImportClassifiedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class CustomsImportClassifiedIndicatorType : IndicatorType
    {
		public static implicit operator CustomsImportClassifiedIndicatorType(bool val)
		{
			return new CustomsImportClassifiedIndicatorType
			{
				Value = val
			};
		}
	}
}