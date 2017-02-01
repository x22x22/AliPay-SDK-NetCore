using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoWelfareCodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoWelfareCodeSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝账户USERID，和福利账户ID而选一，可以通过支付宝钱包用户信息共享接口获取支付宝账户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
		[JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 条码码值
        /// </summary>
        [XmlElement("code")]
		[JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 条码可使用超时时间  格式为yyyy-MM-dd HH:mm:ss   备注：超时时间不允许比启动时间小
        /// </summary>
        [XmlElement("code_expire_date")]
		[JsonProperty("code_expire_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeExpireDate { get; set; }

        /// <summary>
        /// 条码数量
        /// </summary>
        [XmlElement("code_num")]
		[JsonProperty("code_num", NullValueHandling = NullValueHandling.Ignore)]
        public long CodeNum { get; set; }

        /// <summary>
        /// 条码图片url
        /// </summary>
        [XmlElement("code_pic_url")]
		[JsonProperty("code_pic_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CodePicUrl { get; set; }

        /// <summary>
        /// 条码可使用开发时间  格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("code_start_date")]
		[JsonProperty("code_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeStartDate { get; set; }

        /// <summary>
        /// 条码状态  CREATE 创建  NOT_USED 没有使用  USED 已经被使用  INVALID 码无效  EXPIRED 码过期  DISABLED 码冻结  NOT_EXIST 码不存在
        /// </summary>
        [XmlElement("code_status")]
		[JsonProperty("code_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 条码状态变更时间  格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("code_status_date")]
		[JsonProperty("code_status_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeStatusDate { get; set; }

        /// <summary>
        /// 条码业务类型  商品品类码：goods  用户商品条码：barcode
        /// </summary>
        [XmlElement("code_type")]
		[JsonProperty("code_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeType { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("extend_params")]
		[JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// ISV代码，唯一确定ISV身份由福利平台分配
        /// </summary>
        [XmlElement("isv_code")]
		[JsonProperty("isv_code", NullValueHandling = NullValueHandling.Ignore)]
        public string IsvCode { get; set; }

        /// <summary>
        /// 核销门店详细信息
        /// </summary>
        [XmlElement("store_info")]
		[JsonProperty("store_info", NullValueHandling = NullValueHandling.Ignore)]
        public WelfareEcoStoreInfo StoreInfo { get; set; }

        /// <summary>
        /// 同步数据时间 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("sync_date")]
		[JsonProperty("sync_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncDate { get; set; }

        /// <summary>
        /// 福利平台订单对应的用户ID，和支付宝用户ID而选一
        /// </summary>
        [XmlElement("welfare_user_id")]
		[JsonProperty("welfare_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WelfareUserId { get; set; }
    }
}
