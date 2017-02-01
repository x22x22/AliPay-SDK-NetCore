using System.Collections.Generic;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    ///     AlipayCommerceCityfacilitatorCityQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorCityQueryResponse : AopResponse
    {
        /// <summary>
        ///     城市列表
        /// </summary>
        [XmlArray("citys")]
        [XmlArrayItem("city_function")]
        public List<CityFunction> Citys { get; set; }
    }
}