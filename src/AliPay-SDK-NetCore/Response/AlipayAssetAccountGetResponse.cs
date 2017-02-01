using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayAssetAccountGetResponse.
    /// </summary>
    public class AlipayAssetAccountGetResponse : AopResponse
    {
        /// <summary>
        ///     账户绑定关系列表
        /// </summary>
        [XmlArray("asset_list")]
        [XmlArrayItem("asset_account_result")]
        public List<AssetAccountResult> AssetList { get; set; }
    }
}