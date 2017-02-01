using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiRoyaltyDetailInfoPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiRoyaltyDetailInfoPojo : AopObject
    {
        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        [XmlElement("amount")]
		[JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long Amount { get; set; }

        /// <summary>
        /// 分账信息中分账百分比。取值范围为大于0，少于或等于100的整数。
        /// </summary>
        [XmlElement("amount_percentage")]
		[JsonProperty("amount_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public long AmountPercentage { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [XmlElement("desc")]
		[JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 分账收入方账户，类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [XmlElement("trans_in")]
		[JsonProperty("trans_in", NullValueHandling = NullValueHandling.Ignore)]
        public string TransIn { get; set; }

        /// <summary>
        /// 分账支出方账户，类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [XmlElement("trans_out")]
		[JsonProperty("trans_out", NullValueHandling = NullValueHandling.Ignore)]
        public string TransOut { get; set; }
    }
}
