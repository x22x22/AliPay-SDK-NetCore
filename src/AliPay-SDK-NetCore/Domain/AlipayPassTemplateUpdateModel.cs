using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPassTemplateUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassTemplateUpdateModel : AopObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=193&articleId=105249&docType=1#tpl_content">tpl_content参数说明</a>
        /// </summary>
        [XmlElement("tpl_content")]
		[JsonProperty("tpl_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TplContent { get; set; }

        /// <summary>
        /// 更新的模板ID
        /// </summary>
        [XmlElement("tpl_id")]
		[JsonProperty("tpl_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TplId { get; set; }
    }
}
