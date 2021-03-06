using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    ///     KoubeiCraftsmanDataWorkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCraftsmanDataWorkCreateModel : AopObject
    {
        /// <summary>
        ///     服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，默认有效期24小时；isv自身角色操作的时候，无需传该参数
        /// </summary>
        [XmlElement("auth_code")]
        [JsonProperty("auth_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthCode { get; set; }

        /// <summary>
        ///     口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [XmlElement("craftsman_id")]
        [JsonProperty("craftsman_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CraftsmanId { get; set; }

        /// <summary>
        ///     作品所属门店id列表。可通过批量查询手艺人信息接口koubei.craftsman.data.provider.batchquery，查询手艺人所属的门店的shop_id。
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        ///     作品列表
        /// </summary>
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_create_open_model")]
        public List<CraftsmanWorkCreateOpenModel> Works { get; set; }
    }
}