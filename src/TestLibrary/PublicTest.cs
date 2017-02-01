#region

using System;
using System.Collections.Generic;
using System.IO;
using Aop.Api.Util;

#endregion

namespace Aop.Api.Test
{
    internal class PublicTest
    {
        [STAThread]
        //static void Main()
        //{
        //    // 公众号菜单查询
        //    //MenuGet();

        //    // 公众号通知消息签名验证
        //    //CheckSign();

        //    // 公众号验签&解密
        //    CheckSignAndDecrypt();

        //    // 公众号加密&加签
        //    EncryptAndSign();
        //}
        private static void CheckSign()
        {
            IDictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("appId", "2013092500031084");
            var privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            var sign = AlipaySignature.RSASign(paramsMap, privateKeyPem, null, "RSA2");
            paramsMap.Add("sign", sign);
            var publicKey = GetCurrentPath() + "public-key.pem";
            var checkSign = AlipaySignature.RSACheckV2(paramsMap, publicKey);
            Console.Write("---------公众号通知消息签名验证--------" + "\n\r");
            Console.Write("checkSign:" + checkSign + "\n\r");
        }

        private static void MenuGet()
        {
            var client = GetAlipayClient();
            //AlipayMobilePublicMenuGetRequest req = new AlipayMobilePublicMenuGetRequest();
            //AlipayMobilePublicMenuGetResponse res = client.Execute(req);
            Console.Write("-------------公众号菜单查询-------------" + "\n\r");
            // System.Console.Write("Body:" + res.Body + "\n\r");
        }

        private static IAopClient GetAlipayClient()
        {
            //支付宝网关地址
            // -----沙箱地址-----
            var serverUrl = "http://openapi.alipaydev.com/gateway.do";
            // -----线上地址-----
            // string serverUrl = "https://openapi.alipay.com/gateway.do";
            //应用ID
            var appId = "2013092500031084";
            //商户私钥
            var privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";

            IAopClient client = new DefaultAopClient(serverUrl, appId, privateKeyPem);

            return client;
        }

        private static string GetCurrentPath()
        {
            var basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return basePath + "/Test/";
        }

        public static void CheckSignAndDecrypt()
        {
            // 参数构建
            var charset = "UTF-8";
            var bizContent =
                "<XML><AppId><![CDATA[2013082200024893]]></AppId><FromUserId><![CDATA[2088102122485786]]></FromUserId><CreateTime>1377228401913</CreateTime><MsgType><![CDATA[click]]></MsgType><EventType><![CDATA[event]]></EventType><ActionParam><![CDATA[authentication]]></ActionParam><AgreementId><![CDATA[201308220000000994]]></AgreementId><AccountNo><![CDATA[null]]></AccountNo><UserInfo><![CDATA[{\"logon_id\":\"15858179811\",\"user_name\":\"许旦辉\"}]]></UserInfo></XML>";
            var publicKeyPem = GetCurrentPath() + "public-key.pem";
            var privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            IDictionary<string, string> paramsMap = new Dictionary<string, string>();
            paramsMap.Add("biz_content", AlipaySignature.RSAEncrypt(bizContent, publicKeyPem, charset));
            paramsMap.Add("charset", charset);
            paramsMap.Add("service", "alipay.mobile.public.message.notify");
            paramsMap.Add("sign_type", "RSA2");
            paramsMap.Add("sign", AlipaySignature.RSASign(paramsMap, privateKeyPem, null, "RSA2"));

            // 验签&解密
            var resultContent = AlipaySignature.CheckSignAndDecrypt(paramsMap, publicKeyPem, privateKeyPem, true, true);
            Console.Write("resultContent=" + resultContent + "\n\r");
        }

        public static void EncryptAndSign()
        {
            // 参数构建
            var bizContent = "<XML><ToUserId><![CDATA[2088102122494786]]></ToUserId><AppId><![CDATA[2013111100036093]]></AppId><AgreementId><![CDATA[20131111000001895078]]></AgreementId>"
                             + "<CreateTime>12334349884</CreateTime>"
                             + "<MsgType><![CDATA[image-text]]></MsgType>"
                             + "<ArticleCount>1</ArticleCount>"
                             + "<Articles>"
                             + "<Item>"
                             + "<Title><![CDATA[[回复测试加密解密]]></Title>"
                             + "<Desc><![CDATA[测试加密解密]]></Desc>"
                             + "<Url><![CDATA[http://m.taobao.com]]></Url>"
                             + "<ActionName><![CDATA[立即前往]]></ActionName>"
                             + "</Item>"
                             + "</Articles>" + "<Push><![CDATA[false]]></Push>" + "</XML>";
            var publicKeyPem = GetCurrentPath() + "public-key.pem";
            var privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
            var responseContent = AlipaySignature.encryptAndSign(bizContent, publicKeyPem, privateKeyPem, "UTF-8", true,
                true);
            Console.Write("resultContent=" + responseContent + "\n\r");
        }
    }
}