using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayBossCsChannelQueryResponse.
    /// </summary>
    public class AlipayBossCsChannelQueryResponse : AopResponse
    {
        /// <summary>
        ///     平均通话时长
        /// </summary>
        [XmlElement("att")]
        [JsonProperty("att", NullValueHandling = NullValueHandling.Ignore)]
        public string Att { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [XmlElement("comment")]
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        ///     接通率
        /// </summary>
        [XmlElement("connection_rate")]
        [JsonProperty("connection_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionRate { get; set; }

        /// <summary>
        ///     通话中人数
        /// </summary>
        [XmlElement("curr_agent_talking")]
        [JsonProperty("curr_agent_talking", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrAgentTalking { get; set; }

        /// <summary>
        ///     在线小二数
        /// </summary>
        [XmlElement("curr_agents_logged_in")]
        [JsonProperty("curr_agents_logged_in", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrAgentsLoggedIn { get; set; }

        /// <summary>
        ///     排队数
        /// </summary>
        [XmlElement("curr_number_waiting_calls")]
        [JsonProperty("curr_number_waiting_calls", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrNumberWaitingCalls { get; set; }

        /// <summary>
        ///     小休人数
        /// </summary>
        [XmlElement("current_not_ready_agents")]
        [JsonProperty("current_not_ready_agents", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentNotReadyAgents { get; set; }

        /// <summary>
        ///     等待人数
        /// </summary>
        [XmlElement("current_ready_agents")]
        [JsonProperty("current_ready_agents", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentReadyAgents { get; set; }

        /// <summary>
        ///     主键
        /// </summary>
        [XmlElement("row_key")]
        [JsonProperty("row_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RowKey { get; set; }

        /// <summary>
        ///     流入量
        /// </summary>
        [XmlElement("visitor_inflow")]
        [JsonProperty("visitor_inflow", NullValueHandling = NullValueHandling.Ignore)]
        public string VisitorInflow { get; set; }

        /// <summary>
        ///     应答量
        /// </summary>
        [XmlElement("visitor_response")]
        [JsonProperty("visitor_response", NullValueHandling = NullValueHandling.Ignore)]
        public string VisitorResponse { get; set; }

        /// <summary>
        ///     应答量[转接]
        /// </summary>
        [XmlElement("visitor_response_transfer")]
        [JsonProperty("visitor_response_transfer", NullValueHandling = NullValueHandling.Ignore)]
        public string VisitorResponseTransfer { get; set; }
    }
}