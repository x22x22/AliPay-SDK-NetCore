using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Aop.Api.Parser
{
    public class AopAttribute
    {
        public string ItemName { get; set; }
        public Type ItemType { get; set; }
        public string ListName { get; set; }
        public Type ListType { get; set; }
        public MethodInfo Method { get; set; }
    }
}
