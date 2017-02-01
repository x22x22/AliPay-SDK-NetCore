using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArrangementBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementBaseVO : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("app_id")]
		[JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 签约机构编码
        /// </summary>
        [XmlElement("arrangement_institution_code")]
		[JsonProperty("arrangement_institution_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrangementInstitutionCode { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [XmlElement("arrangement_name")]
		[JsonProperty("arrangement_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrangementName { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("arrangement_no")]
		[JsonProperty("arrangement_no", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [XmlElement("arrangement_type")]
		[JsonProperty("arrangement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrangementType { get; set; }

        /// <summary>
        /// 合约版
        /// </summary>
        [XmlElement("arrangement_version")]
		[JsonProperty("arrangement_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrangementVersion { get; set; }

        /// <summary>
        /// 签约渠道来源
        /// </summary>
        [XmlElement("channel_code")]
		[JsonProperty("channel_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 合约失效时间
        /// </summary>
        [XmlElement("gmt_end")]
		[JsonProperty("gmt_end", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [XmlElement("gmt_expired")]
		[JsonProperty("gmt_expired", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 预计合约失效时间
        /// </summary>
        [XmlElement("gmt_invalid_due")]
		[JsonProperty("gmt_invalid_due", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtInvalidDue { get; set; }

        /// <summary>
        /// 合约签署时间
        /// </summary>
        [XmlElement("gmt_sign")]
		[JsonProperty("gmt_sign", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtSign { get; set; }

        /// <summary>
        /// 预计合约生效时间
        /// </summary>
        [XmlElement("gmt_vald_due")]
		[JsonProperty("gmt_vald_due", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtValdDue { get; set; }

        /// <summary>
        /// 合约版本时间
        /// </summary>
        [XmlElement("gmt_vrsn")]
		[JsonProperty("gmt_vrsn", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtVrsn { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [XmlElement("ip_role_id")]
		[JsonProperty("ip_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("last_moder")]
		[JsonProperty("last_moder", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModer { get; set; }

        /// <summary>
        /// 外标类型
        /// </summary>
        [XmlElement("mark_type")]
		[JsonProperty("mark_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MarkType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
		[JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人类型
        /// </summary>
        [XmlElement("moder_type")]
		[JsonProperty("moder_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ModerType { get; set; }

        /// <summary>
        /// 签约产品外标
        /// </summary>
        [XmlElement("pd_mark")]
		[JsonProperty("pd_mark", NullValueHandling = NullValueHandling.Ignore)]
        public string PdMark { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("prod_code")]
		[JsonProperty("prod_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
		[JsonProperty("prod_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [XmlElement("prod_version")]
		[JsonProperty("prod_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProdVersion { get; set; }

        /// <summary>
        /// ps(产品销售)编码
        /// </summary>
        [XmlElement("ps_code")]
		[JsonProperty("ps_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PsCode { get; set; }

        /// <summary>
        /// ps(产品销售)id
        /// </summary>
        [XmlElement("ps_id")]
		[JsonProperty("ps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PsId { get; set; }

        /// <summary>
        /// 产品销售名称
        /// </summary>
        [XmlElement("ps_name")]
		[JsonProperty("ps_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PsName { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 签约模板产品编码
        /// </summary>
        [XmlElement("template_prod_code")]
		[JsonProperty("template_prod_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateProdCode { get; set; }

        /// <summary>
        /// 签约模板产品版本
        /// </summary>
        [XmlElement("template_prod_version")]
		[JsonProperty("template_prod_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateProdVersion { get; set; }
    }
}
