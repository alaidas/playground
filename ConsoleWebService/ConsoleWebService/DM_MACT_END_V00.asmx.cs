using System.Web.Services;

namespace ConsoleWebService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [WebService(Namespace = "dk.danskebank.si")]
    [WebServiceBinding(Name = "DM_MACT_END_V00Soap", Namespace = "dk.danskebank.si")]
    public class DM_MACT_END_V00 : System.Web.Services.WebService, IDM_MACT_END_V00
    {

        [WebMethod]
        public InvokeResponseInvokeResult Invoke(string ActivityId, string AssigneeId, string EndDate)
        {
            return new InvokeResponseInvokeResult
            {
                DM_VC_CRE_OLI = new InvokeResponseInvokeResultDM_VC_CRE_OLI
                {
                    ReturnCode = 0,
                    ReturnText = "OK"
                }
            };
        }
    }
}
