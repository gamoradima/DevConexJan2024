namespace Terrasoft.Configuration
{
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;
    using Terrasoft.Core.DB;
    using Terrasoft.Web.Common;
    using System;
    using System.Web.SessionState;
    using Terrasoft.Core;

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class RealtyService : BaseService, IReadOnlySessionState
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

        public decimal GetTotalAmountByTypeId(string realtyTypeId, string realtyOfferTypeId)
        {
            if (string.IsNullOrEmpty(realtyTypeId) || string.IsNullOrEmpty(realtyOfferTypeId))
            {
                return -1;
            }
			UserConnection my_uc;
			if (this.UserConnection != null)
            {
				my_uc = this.UserConnection; // in a normal web service call (authenticated request)
			} else
            {
				my_uc = this.AppConnection.SystemUserConnection; // in case of an anonymous request
            }

			Select select = new Select(my_uc)
                .Column(Func.Sum("UsrPriceGBP"))
                .From("UsrRealtyClassic")
                .Where("UsrTypeId").IsEqual(Column.Parameter(new Guid(realtyTypeId)))
                .And("UsrOfferTypeId").IsEqual(Column.Parameter(new Guid(realtyOfferTypeId)))
                as Select;
            decimal result = select.ExecuteScalar<decimal>();
            return result;
        }
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

        public string GetExample()
        {
            return "OK!";
        }

    }

}