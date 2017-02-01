using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayUserAccountFreezeGetResponse.
    /// </summary>
    public class AlipayUserAccountFreezeGetResponse : AopResponse
    {
        /// <summary>
        ///     冻结金额列表
        /// </summary>
        [XmlArray("freeze_items")]
        [XmlArrayItem("account_freeze")]
        public List<AccountFreeze> FreezeItems { get; set; }

        /// <summary>
        ///     冻结总条数
        /// </summary>
        [XmlElement("total_results")]
        [JsonProperty("total_results", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalResults { get; set; }
    }
}