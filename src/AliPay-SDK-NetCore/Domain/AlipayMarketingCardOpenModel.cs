using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayMarketingCardOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardOpenModel : AopObject
    {
        /// <summary>
        ///     外部卡信息(biz_card_no无需填写)
        /// </summary>
        [XmlElement("card_ext_info")]
        [JsonProperty("card_ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantCard CardExtInfo { get; set; }

        /// <summary>
        ///     支付宝分配的卡模板Id（卡模板创建接口返回的模板ID）
        /// </summary>
        [XmlElement("card_template_id")]
        [JsonProperty("card_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardTemplateId { get; set; }

        /// <summary>
        ///     发卡用户信息
        /// </summary>
        [XmlElement("card_user_info")]
        [JsonProperty("card_user_info", NullValueHandling = NullValueHandling.Ignore)]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        ///     商户会员信息
        /// </summary>
        [XmlElement("member_ext_info")]
        [JsonProperty("member_ext_info", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantMenber MemberExtInfo { get; set; }

        /// <summary>
        ///     外部商户流水号（商户需要确保唯一性控制，类似request_id唯一请求标识）
        /// </summary>
        [XmlElement("out_serial_no")]
        [JsonProperty("out_serial_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutSerialNo { get; set; }
    }
}