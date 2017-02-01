using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundUnfreezeResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundUnfreezeResult : AopObject
    {
        /// <summary>
        /// 冻结单号
        /// </summary>
        [XmlElement("freeze_no")]
		[JsonProperty("freeze_no", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 解冻结果码
        /// </summary>
        [XmlElement("result_code")]
		[JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 解冻状态。S成功，F失败。
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 解冻金额
        /// </summary>
        [XmlElement("unfreeze_amount")]
		[JsonProperty("unfreeze_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻单号
        /// </summary>
        [XmlElement("unfreeze_no")]
		[JsonProperty("unfreeze_no", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfreezeNo { get; set; }

        /// <summary>
        /// 解冻时间
        /// </summary>
        [XmlElement("unfreeze_time")]
		[JsonProperty("unfreeze_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfreezeTime { get; set; }
    }
}
