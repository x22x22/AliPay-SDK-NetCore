using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChargeInstMode Data Structure.
    /// </summary>
    [Serializable]
    public class ChargeInstMode : AopObject
    {
        /// <summary>
        /// 机构简称(英文名称)
        /// </summary>
        [XmlElement("charge_inst")]
		[JsonProperty("charge_inst", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 机构中文名称
        /// </summary>
        [XmlElement("charge_inst_name")]
		[JsonProperty("charge_inst_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
		[JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
		[JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }
    }
}
