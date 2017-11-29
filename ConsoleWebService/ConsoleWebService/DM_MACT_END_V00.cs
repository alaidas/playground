namespace ConsoleWebService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "dk.danskebank.si")]
    public class InvokeResponseInvokeResult
    {

        private InvokeResponseInvokeResultDM_VC_CRE_OLI dM_VC_CRE_OLIField;

        /// <remarks/>
        public InvokeResponseInvokeResultDM_VC_CRE_OLI DM_VC_CRE_OLI
        {
            get
            {
                return dM_VC_CRE_OLIField;
            }
            set
            {
                dM_VC_CRE_OLIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "dk.danskebank.si")]
    public class InvokeResponseInvokeResultDM_VC_CRE_OLI
    {

        private int returnCodeField;

        private string returnTextField;

        /// <remarks/>
        public int ReturnCode
        {
            get
            {
                return returnCodeField;
            }
            set
            {
                returnCodeField = value;
            }
        }

        /// <remarks/>
        public string ReturnText
        {
            get
            {
                return returnTextField;
            }
            set
            {
                returnTextField = value;
            }
        }
    }
}