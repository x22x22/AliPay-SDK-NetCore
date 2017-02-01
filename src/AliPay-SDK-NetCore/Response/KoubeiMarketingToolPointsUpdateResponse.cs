using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsUpdateResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsUpdateResponse : AopResponse
    {
        /// <summary>
        /// 集点变更流水号
        /// </summary>
        [XmlElement("point_log_no")]
		[JsonProperty("point_log_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PointLogNo { get; set; }
    }
}
