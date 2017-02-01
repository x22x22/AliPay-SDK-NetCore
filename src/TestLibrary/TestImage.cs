#region

using System;
using System.IO;
using Aop.Api.Request;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Aop.Api
{
    [TestClass]
    public class TestImage
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = GetAlipayClient();
            var req = new AlipayMobilePublicMultiMediaDownloadRequest();

            var path = "c:/1.jpg";
            if (File.Exists(path)) File.Delete(path);
            var fs = new FileStream(path, FileMode.CreateNew);
            req.stream = fs;

            var mediaId =
                "L21pZnMvVDFQV3hYWGJKWFhYYUNucHJYP3Q9YW13ZiZ4c2lnPTU0MzRhYjg1ZTZjNWJmZTMxZGJiNjIzNDdjMzFkNzkw575";
            req.BizContent = "{\"mediaId\":\"" + mediaId + "\"}";

            var res = client.Execute(req);
            Console.WriteLine("-------------公众号菜单查询-------------");

            Console.WriteLine("Body:" + res.Body);
            Console.ReadLine();
        }

        private IAopClient GetAlipayClient()
        {
            //支付宝网关地址
            // -----开发环境地址-----
            var serverUrl = "https://openfile.alipay.com/chat/multimedia.do";

            // -----沙箱地址-----
            // string serverUrl = "http://openapi.alipaydev.com/gateway.do";

            // -----线上地址-----
            // string serverUrl = "https://openapi.alipay.com/gateway.do";

            //应用ID
            var appId = "2013092500031084";

            //商户私钥
            var privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";

            IAopClient client = new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, "json", "GBK");

            return client;
        }

        private static string GetCurrentPath()
        {
            var basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return basePath + "/Test/";
        }
    }
}