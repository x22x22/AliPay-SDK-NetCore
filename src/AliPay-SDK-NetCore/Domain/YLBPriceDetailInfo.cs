using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     YLBPriceDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBPriceDetailInfo : AopObject
    {
        /// <summary>
        ///     余利宝行情日期，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("price_date")]
        [JsonProperty("price_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceDate { get; set; }

        /// <summary>
        ///     七日年化收益率（%），精确到小数点后4位
        /// </summary>
        [XmlElement("sevendays_yeild_rate")]
        [JsonProperty("sevendays_yeild_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string SevendaysYeildRate { get; set; }

        /// <summary>
        ///     万份收益金额，单位为元
        /// </summary>
        [XmlElement("tenthousand_income")]
        [JsonProperty("tenthousand_income", NullValueHandling = NullValueHandling.Ignore)]
        public string TenthousandIncome { get; set; }
    }
}