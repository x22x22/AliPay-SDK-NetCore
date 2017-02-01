using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    ///     AOP API: alipay.ebpp.bill.pay
    /// </summary>
    public class AlipayEbppBillPayRequest : IAopRequest<AlipayEbppBillPayResponse>
    {
        /// <summary>
        ///     支付宝的业务订单号，具有唯一性。
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        ///     openapi的spanner上增加规则转发到pcimapi集群上
        /// </summary>
        public string DispatchClusterTarget { get; set; }

        /// <summary>
        ///     扩展字段
        /// </summary>
        public string Extend { get; set; }

        /// <summary>
        ///     输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        ///     支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        #region IAopRequest Members

        private bool needEncrypt;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AopObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ebpp.bill.pay";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AopDictionary();
            parameters.Add("alipay_order_no", AlipayOrderNo);
            parameters.Add("dispatch_cluster_target", DispatchClusterTarget);
            parameters.Add("extend", Extend);
            parameters.Add("merchant_order_no", MerchantOrderNo);
            parameters.Add("order_type", OrderType);
            return parameters;
        }

        public AopObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}