using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinanceYulibaoAccountQueryModel : AopObject
    {
        /// <summary>
        ///     基金代码，必填。目前默认填001529，代表余利宝
        /// </summary>
        [XmlElement("fund_code")]
        [JsonProperty("fund_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FundCode { get; set; }
    }
}