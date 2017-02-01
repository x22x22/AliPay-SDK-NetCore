using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankFinanceYulibaoCapitalRansomResponse.
    /// </summary>
    public class MybankFinanceYulibaoCapitalRansomResponse : AopResponse
    {
        /// <summary>
        /// 余利宝内部的交易流水号
        /// </summary>
        [XmlElement("inner_biz_no")]
		[JsonProperty("inner_biz_no", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerBizNo { get; set; }

        /// <summary>
        /// 交易结果备注信息
        /// </summary>
        [XmlElement("remark")]
		[JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 交易结果，目前会有3种状态值，1：success，表示交易成功、2：fail，表示交易失败:、3：inprocess，表示交易处理中。其中交易处理中的状态可以使用回查交易历史的方式查看其处理结果。
        /// </summary>
        [XmlElement("trans_result")]
		[JsonProperty("trans_result", NullValueHandling = NullValueHandling.Ignore)]
        public string TransResult { get; set; }
    }
}
