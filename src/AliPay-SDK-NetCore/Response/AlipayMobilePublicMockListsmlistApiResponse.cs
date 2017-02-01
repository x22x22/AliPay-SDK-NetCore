using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayMobilePublicMockListsmlistApiResponse.
    /// </summary>
    public class AlipayMobilePublicMockListsmlistApiResponse : AopResponse
    {
        /// <summary>
        ///     简单模型嵌套list
        /// </summary>
        [XmlArray("list_sm_model_list")]
        [XmlArrayItem("list_list_sm_mock_model")]
        public List<ListListSmMockModel> ListSmModelList { get; set; }
    }
}