using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorScriptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorScriptQueryModel : AopObject
    {
        /// <summary>
        /// 卡类型，智能卡中心的内部编码规则
        /// </summary>
        [XmlElement("card_type")]
		[JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        /// <summary>
        /// 脚本类型，目前支持两种  readCardType：判定卡是什么城市的交通卡  readCardInfo：读取卡中的余额等信息
        /// </summary>
        [XmlElement("script_type")]
		[JsonProperty("script_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptType { get; set; }
    }
}
