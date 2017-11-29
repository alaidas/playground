using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleWebService
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IDM_MACT_END_V00
    {
        [OperationContract]
        [WebInvoke]
        InvokeResponseInvokeResult Invoke(string ActivityId, string AssigneeId, string EndDate);
    }
}
