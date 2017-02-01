using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCplifeRoominfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCplifeRoominfoQueryModel : AopObject
    {
        /// <summary>
        /// 传入该小区在支付宝社区物业平台中的唯一编号，通过小区创建和查询接口获取。
        /// </summary>
        [XmlElement("community_id")]
		[JsonProperty("community_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommunityId { get; set; }

        /// <summary>
        /// 分页查询的页码数，分页从1开始计数。该参数不传入的时候，默认为1
        /// </summary>
        [XmlElement("page_num")]
		[JsonProperty("page_num", NullValueHandling = NullValueHandling.Ignore)]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询的每页最大数据条数。默认为200
        /// </summary>
        [XmlElement("page_size")]
		[JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public long PageSize { get; set; }
    }
}
