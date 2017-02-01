using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     YLBProfitDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBProfitDetailInfo : AopObject
    {
        /// <summary>
        ///     近1日收益，单位为元
        /// </summary>
        [XmlElement("day_profit")]
        [JsonProperty("day_profit", NullValueHandling = NullValueHandling.Ignore)]
        public string DayProfit { get; set; }

        /// <summary>
        ///     近1月收益，单位为元
        /// </summary>
        [XmlElement("month_profit")]
        [JsonProperty("month_profit", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthProfit { get; set; }

        /// <summary>
        ///     历史累计收益，单位为元
        /// </summary>
        [XmlElement("total_profit")]
        [JsonProperty("total_profit", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalProfit { get; set; }

        /// <summary>
        ///     近1周收益，单位为元
        /// </summary>
        [XmlElement("week_profit")]
        [JsonProperty("week_profit", NullValueHandling = NullValueHandling.Ignore)]
        public string WeekProfit { get; set; }
    }
}