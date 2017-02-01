using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AopResponse
    {
        /// <summary>
        ///     受理的还款申请单号
        /// </summary>
        [XmlElement("loan_repay_no")]
        [JsonProperty("loan_repay_no", NullValueHandling = NullValueHandling.Ignore)]
        public string LoanRepayNo { get; set; }
    }
}