using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayEbppPdeductSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppPdeductSignQueryModel : AopObject
    {
        /// <summary>
        ///     支付宝代扣协议Id。若协议id不传递，则需要保证业务类型、子业务类型、出账机构、户号必传
        /// </summary>
        [XmlElement("agreement_id")]
        [JsonProperty("agreement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementId { get; set; }

        /// <summary>
        ///     户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        [XmlElement("bill_key")]
        [JsonProperty("bill_key", NullValueHandling = NullValueHandling.Ignore)]
        public string BillKey { get; set; }

        /// <summary>
        ///     业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值
        /// </summary>
        [XmlElement("biz_type")]
        [JsonProperty("biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BizType { get; set; }

        /// <summary>
        ///     支付宝缴费系统中的出账机构ID
        /// </summary>
        [XmlElement("charge_inst")]
        [JsonProperty("charge_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInst { get; set; }

        /// <summary>
        ///     业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值
        /// </summary>
        [XmlElement("sub_biz_type")]
        [JsonProperty("sub_biz_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubBizType { get; set; }

        /// <summary>
        ///     用户ID
        /// </summary>
        [XmlElement("user_id")]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
    }
}