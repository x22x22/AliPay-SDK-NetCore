using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantTestPracticeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantTestPracticeModel : AopObject
    {
        /// <summary>
        /// a d
        /// </summary>
        [XmlArray("add")]
        [XmlArrayItem("string")]
        public List<string> Add { get; set; }

        /// <summary>
        /// zzz
        /// </summary>
        [XmlElement("xxxx")]
		[JsonProperty("xxxx", NullValueHandling = NullValueHandling.Ignore)]
        public XXXXsdasdasd Xxxx { get; set; }
    }
}
