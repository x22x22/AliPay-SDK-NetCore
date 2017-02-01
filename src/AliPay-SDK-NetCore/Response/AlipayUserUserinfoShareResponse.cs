using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;
using Newtonsoft.Json;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserUserinfoShareResponse.
    /// </summary>
    public class AlipayUserUserinfoShareResponse : AopResponse
    {
        /// <summary>
        /// 详细地址。
        /// </summary>
        [XmlElement("address")]
		[JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码，暂时不返回值
        /// </summary>
        [XmlElement("address_code")]
		[JsonProperty("address_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressCode { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
		[JsonProperty("alipay_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 区县名称。
        /// </summary>
        [XmlElement("area")]
		[JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [XmlElement("avatar")]
		[JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public string Avatar { get; set; }

        /// <summary>
        /// 【注意】当is_balance_frozen为“F”时，改字段不会返回.  CTU ---- CTU冻结，允许用户开启  ALIBABA ---- ALIBABA冻结，允许用户开启  SERVER ---- 后台冻结，允许用户开启  USER ----  用户冻结   CTU_N---- CTU冻结，不允许用户开启  ALIBABA_N ---- ALIBABA冻结，不允许用户开启  SERVER_N ---- 后台冻结，不允许用户开启  UNKNOWN ---- 降级、或查询超时
        /// </summary>
        [XmlElement("balance_freeze_type")]
		[JsonProperty("balance_freeze_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceFreezeType { get; set; }

        /// <summary>
        /// 用户生日
        /// </summary>
        [XmlElement("birthday")]
		[JsonProperty("birthday", NullValueHandling = NullValueHandling.Ignore)]
        public string Birthday { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
		[JsonProperty("cert_no", NullValueHandling = NullValueHandling.Ignore)]
        public string CertNo { get; set; }

        /// <summary>
        /// 0:身份证  1:护照  2:军官证  3:士兵证  4:回乡证  5:临时身份证  6:户口簿  7:警官证  8:台胞证  9:营业执照  10其它证件
        /// </summary>
        [XmlElement("cert_type_value")]
		[JsonProperty("cert_type_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CertTypeValue { get; set; }

        /// <summary>
        /// 市名称。
        /// </summary>
        [XmlElement("city")]
		[JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 是否默认收货地址，暂时不返回值
        /// </summary>
        [XmlElement("default_deliver_address")]
		[JsonProperty("default_deliver_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultDeliverAddress { get; set; }

        /// <summary>
        /// 收货人地址列表
        /// </summary>
        [XmlArray("deliver_address_list")]
        [XmlArrayItem("deliver_address")]
        public List<DeliverAddress> DeliverAddressList { get; set; }

        /// <summary>
        /// 收货人所在区县
        /// </summary>
        [XmlElement("deliver_area")]
		[JsonProperty("deliver_area", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverArea { get; set; }

        /// <summary>
        /// 收货人所在城市
        /// </summary>
        [XmlElement("deliver_city")]
		[JsonProperty("deliver_city", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverCity { get; set; }

        /// <summary>
        /// 收货人全称
        /// </summary>
        [XmlElement("deliver_fullname")]
		[JsonProperty("deliver_fullname", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverFullname { get; set; }

        /// <summary>
        /// 收货地址的联系人移动电话。
        /// </summary>
        [XmlElement("deliver_mobile")]
		[JsonProperty("deliver_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverMobile { get; set; }

        /// <summary>
        /// 收货地址的联系人固定电话。
        /// </summary>
        [XmlElement("deliver_phone")]
		[JsonProperty("deliver_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverPhone { get; set; }

        /// <summary>
        /// 收货人所在省份
        /// </summary>
        [XmlElement("deliver_province")]
		[JsonProperty("deliver_province", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliverProvince { get; set; }

        /// <summary>
        /// 用户支付宝账号绑定的邮箱地址
        /// </summary>
        [XmlElement("email")]
		[JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 姓氏，取的是realName中的首个字符，对非中文、中文复姓支持较差。
        /// </summary>
        [XmlElement("family_name")]
		[JsonProperty("family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyName { get; set; }

        /// <summary>
        /// 公司名称（用户类型是公司类型时公司名称才有此字段）。
        /// </summary>
        [XmlElement("firm_name")]
		[JsonProperty("firm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirmName { get; set; }

        /// <summary>
        /// 性别（F：女性；M：男性）
        /// </summary>
        [XmlElement("gender")]
		[JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// T--被冻结；F--未冻结
        /// </summary>
        [XmlElement("is_balance_frozen")]
		[JsonProperty("is_balance_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public string IsBalanceFrozen { get; set; }

        /// <summary>
        /// T为是银行卡认证，F为非银行卡认证。
        /// </summary>
        [XmlElement("is_bank_auth")]
		[JsonProperty("is_bank_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string IsBankAuth { get; set; }

        /// <summary>
        /// 是否通过实名认证。T是通过 F是没有实名认证
        /// </summary>
        [XmlElement("is_certified")]
		[JsonProperty("is_certified", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCertified { get; set; }

        /// <summary>
        /// T：表示A类实名认证；F：表示非A类实名认证
        /// </summary>
        [XmlElement("is_certify_grade_a")]
		[JsonProperty("is_certify_grade_a", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCertifyGradeA { get; set; }

        /// <summary>
        /// T为是身份证认证，F为非身份证认证。
        /// </summary>
        [XmlElement("is_id_auth")]
		[JsonProperty("is_id_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string IsIdAuth { get; set; }

        /// <summary>
        /// T为通过营业执照认证，F为没有通过
        /// </summary>
        [XmlElement("is_licence_auth")]
		[JsonProperty("is_licence_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string IsLicenceAuth { get; set; }

        /// <summary>
        /// T为是手机认证，F为非手机认证。
        /// </summary>
        [XmlElement("is_mobile_auth")]
		[JsonProperty("is_mobile_auth", NullValueHandling = NullValueHandling.Ignore)]
        public string IsMobileAuth { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [XmlElement("is_student_certified")]
		[JsonProperty("is_student_certified", NullValueHandling = NullValueHandling.Ignore)]
        public string IsStudentCertified { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [XmlElement("mobile")]
		[JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick_name")]
		[JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 电话号码。
        /// </summary>
        [XmlElement("phone")]
		[JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 省份名称。
        /// </summary>
        [XmlElement("province")]
		[JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 用户的真实姓名。
        /// </summary>
        [XmlElement("real_name")]
		[JsonProperty("real_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RealName { get; set; }

        /// <summary>
        /// 生日的月和日，MMdd格式
        /// </summary>
        [XmlElement("reduced_birthday")]
		[JsonProperty("reduced_birthday", NullValueHandling = NullValueHandling.Ignore)]
        public string ReducedBirthday { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        [XmlElement("user_id")]
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户状态（Q/T/B/W）。  Q代表快速注册用户  T代表已认证用户  B代表被冻结账户  W代表已注册，未激活的账户
        /// </summary>
        [XmlElement("user_status")]
		[JsonProperty("user_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型（1/2）  1代表公司账户2代表个人账户
        /// </summary>
        [XmlElement("user_type_value")]
		[JsonProperty("user_type_value", NullValueHandling = NullValueHandling.Ignore)]
        public string UserTypeValue { get; set; }

        /// <summary>
        /// 邮政编码。
        /// </summary>
        [XmlElement("zip")]
		[JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }
    }
}
