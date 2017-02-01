using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayPointBudgetGetResponse.
    /// </summary>
    public class AlipayPointBudgetGetResponse : AopResponse
    {
        /// <summary>
        ///     还可以发放的集分宝个数
        /// </summary>
        [XmlElement("budget_amount")]
        [JsonProperty("budget_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long BudgetAmount { get; set; }
    }
}