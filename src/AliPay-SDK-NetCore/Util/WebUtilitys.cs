using System.Net;
using System.Text;

namespace Aop.Api.Util
{
    public class WebUtilitys
    {
        public static string UrlEncode(string str, Encoding e)
        {
            if (str == null)
                return null;
            var strByte = Encoding.Convert(Encoding.GetEncoding(0), e, Encoding.GetEncoding(0).GetBytes(str));
            return Encoding.ASCII.GetString(WebUtility.UrlEncodeToBytes(strByte, 0, strByte.Length));
        }
    }
}