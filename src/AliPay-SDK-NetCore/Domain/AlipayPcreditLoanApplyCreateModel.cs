using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanApplyCreateModel : AopObject
    {
        /// <summary>
        /// 申贷金额，单位为元
        /// </summary>
        [XmlElement("apply_amt")]
		[JsonProperty("apply_amt", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 用户身份证后4位
        /// </summary>
        [XmlElement("cert_no")]
		[JsonProperty("cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
		[JsonProperty("out_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户贴息率，0~1的小数
        /// </summary>
        [XmlElement("ratio")]
		[JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public long Ratio { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene")]
		[JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }
    }
}
