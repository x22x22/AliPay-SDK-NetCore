using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopEquipmentBindInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopEquipmentBindInfo : AopObject
    {
        /// <summary>
        /// 机具绑定信息
        /// </summary>
        [XmlArray("equipments")]
        [XmlArrayItem("equipment_bind_info")]
        public List<EquipmentBindInfo> Equipments { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
		[JsonProperty("shop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
		[JsonProperty("shop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShopName { get; set; }
    }
}
