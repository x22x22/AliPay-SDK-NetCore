using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api
{
    [Serializable]
    public abstract class AopResponse
    {
        private string body;
        private string code;
        private string msg;
        private string subCode;
        private string subMsg;

        /// <summary>
        ///     错误码
        ///     对应 ErrCode
        /// </summary>
        [XmlElement("code")]
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        ///     错误信息
        ///     对应 ErrMsg
        /// </summary>
        [XmlElement("msg")]
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        /// <summary>
        ///     子错误码
        ///     对应 SubErrCode
        /// </summary>
        [XmlElement("sub_code")]
        [JsonProperty("sub_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCode
        {
            get { return subCode; }
            set { subCode = value; }
        }

        /// <summary>
        ///     子错误信息
        ///     对应 SubErrMsg
        /// </summary>
        [XmlElement("sub_msg")]
        [JsonProperty("sub_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string SubMsg
        {
            get { return subMsg; }
            set { subMsg = value; }
        }

        /// <summary>
        ///     响应原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        /// <summary>
        ///     响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get { return !string.IsNullOrEmpty(SubCode); }
        }
    }
}