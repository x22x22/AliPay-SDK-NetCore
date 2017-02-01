using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     AlipayBossCsChannelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCsChannelQueryModel : AopObject
    {
        /// <summary>
        ///     平均通话时长的qualifier
        /// </summary>
        [XmlElement("att")]
        [JsonProperty("att", NullValueHandling = NullValueHandling.Ignore)]
        public string Att { get; set; }

        /// <summary>
        ///     总接通率的qualifier
        /// </summary>
        [XmlElement("connectionrate")]
        [JsonProperty("connectionrate", NullValueHandling = NullValueHandling.Ignore)]
        public string Connectionrate { get; set; }

        /// <summary>
        ///     在线小二人数的qualifier
        /// </summary>
        [XmlElement("curragentsloggedin")]
        [JsonProperty("curragentsloggedin", NullValueHandling = NullValueHandling.Ignore)]
        public string Curragentsloggedin { get; set; }

        /// <summary>
        ///     通话中人数的qualifier
        /// </summary>
        [XmlElement("curragenttalking")]
        [JsonProperty("curragenttalking", NullValueHandling = NullValueHandling.Ignore)]
        public string Curragenttalking { get; set; }

        /// <summary>
        ///     小休人数的qualifier
        /// </summary>
        [XmlElement("currentnotreadyagents")]
        [JsonProperty("currentnotreadyagents", NullValueHandling = NullValueHandling.Ignore)]
        public string Currentnotreadyagents { get; set; }

        /// <summary>
        ///     等待人数的qualifier
        /// </summary>
        [XmlElement("currentreadyagents")]
        [JsonProperty("currentreadyagents", NullValueHandling = NullValueHandling.Ignore)]
        public string Currentreadyagents { get; set; }

        /// <summary>
        ///     总排队数的Qualifier
        /// </summary>
        [XmlElement("currnumberwaitingcalls")]
        [JsonProperty("currnumberwaitingcalls", NullValueHandling = NullValueHandling.Ignore)]
        public string Currnumberwaitingcalls { get; set; }

        /// <summary>
        ///     查询hbase的rowkey
        /// </summary>
        [XmlElement("endkey")]
        [JsonProperty("endkey", NullValueHandling = NullValueHandling.Ignore)]
        public string Endkey { get; set; }

        /// <summary>
        ///     查询hbase的rowkey
        /// </summary>
        [XmlElement("startkey")]
        [JsonProperty("startkey", NullValueHandling = NullValueHandling.Ignore)]
        public string Startkey { get; set; }

        /// <summary>
        ///     总流入量的qualifier
        /// </summary>
        [XmlElement("visitorinflow")]
        [JsonProperty("visitorinflow", NullValueHandling = NullValueHandling.Ignore)]
        public string Visitorinflow { get; set; }

        /// <summary>
        ///     总应答量的qualifier
        /// </summary>
        [XmlElement("visitorresponse")]
        [JsonProperty("visitorresponse", NullValueHandling = NullValueHandling.Ignore)]
        public string Visitorresponse { get; set; }

        /// <summary>
        ///     应答量[转接] 的qualifier
        /// </summary>
        [XmlElement("visitorresponsetransfer")]
        [JsonProperty("visitorresponsetransfer", NullValueHandling = NullValueHandling.Ignore)]
        public string Visitorresponsetransfer { get; set; }
    }
}