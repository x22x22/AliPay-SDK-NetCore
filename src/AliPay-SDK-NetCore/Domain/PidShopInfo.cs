using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PidShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PidShopInfo : AopObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
		[JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public string Pid { get; set; }

        /// <summary>
        /// pid下的门店列表
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
