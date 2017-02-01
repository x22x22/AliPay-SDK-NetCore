using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     InsClaim Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaim : AopObject
    {
        /// <summary>
        ///     理赔因子;标准json 格式
        /// </summary>
        [XmlElement("biz_data")]
        [JsonProperty("biz_data", NullValueHandling = NullValueHandling.Ignore)]
        public string BizData { get; set; }

        /// <summary>
        ///     实际赔付金额 ;单位分
        /// </summary>
        [XmlElement("claim_fee")]
        [JsonProperty("claim_fee", NullValueHandling = NullValueHandling.Ignore)]
        public long ClaimFee { get; set; }

        /// <summary>
        ///     赔案号
        /// </summary>
        [XmlElement("claim_no")]
        [JsonProperty("claim_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimNo { get; set; }

        /// <summary>
        ///     赔付时间
        /// </summary>
        [XmlElement("claim_pay_time")]
        [JsonProperty("claim_pay_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimPayTime { get; set; }

        /// <summary>
        ///     赔案进度;根据更新时间倒序
        /// </summary>
        [XmlArray("claim_progress")]
        [XmlArrayItem("claim_progress")]
        public List<ClaimProgress> ClaimProgress { get; set; }

        /// <summary>
        ///     赔案状态.ACCEPTED:已受理;REJECTED:已拒赔;PAID:已赔付
        /// </summary>
        [XmlElement("claim_status")]
        [JsonProperty("claim_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ClaimStatus { get; set; }

        /// <summary>
        ///     商户生成的外部理赔请求单号
        /// </summary>
        [XmlElement("out_request_no")]
        [JsonProperty("out_request_no", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRequestNo { get; set; }
    }
}