using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbAdvertMissionSubject Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertMissionSubject : AopObject
    {
        /// <summary>
        /// 分佣条款信息
        /// </summary>
        [XmlArray("commission_clause_list")]
        [XmlArrayItem("kb_advert_commission_clause")]
        public List<KbAdvertCommissionClause> CommissionClauseList { get; set; }

        /// <summary>
        /// 标的对象的业务ID，如果标的为商品，则subject_biz_id为商品ID
        /// </summary>
        [XmlElement("subject_biz_id")]
		[JsonProperty("subject_biz_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectBizId { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [XmlElement("subject_type")]
		[JsonProperty("subject_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectType { get; set; }
    }
}
