using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CplifeRoomDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CplifeRoomDetail : AopObject
    {
        /// <summary>
        /// 房间完整门牌地址
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 房屋所在楼栋名称。例如“1栋”，“1幢”等
        /// </summary>
        [XmlElement("building")]
		[JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        public string Building { get; set; }

        /// <summary>
        /// 房屋所在的组团名称。例如“一期”，“东区”，“香桂苑”等
        /// </summary>
        [XmlElement("group")]
		[JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 商户系统小区房屋唯一ID标示.
        /// </summary>
        [XmlElement("out_room_id")]
		[JsonProperty("out_room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 房屋所在房号。例如“1101室”，“11B室”等
        /// </summary>
        [XmlElement("room")]
		[JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string Room { get; set; }

        /// <summary>
        /// 支付宝系统房间唯一标示.
        /// </summary>
        [XmlElement("room_id")]
		[JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 房屋所在单元名称。例如“一单元”，“二单元”等
        /// </summary>
        [XmlElement("unit")]
		[JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}
