﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Aop.Api.Parser
{
    /// <summary>
    ///     AOP JSON响应通用读取器。
    /// </summary>
    public class AopJsonReader : IAopReader
    {
        private readonly IDictionary json;

        public AopJsonReader(IDictionary json)
        {
            this.json = json;
        }

        public bool HasReturnField(object name)
        {
            return json.Contains(name);
        }

        public object GetPrimitiveObject(object name)
        {
            return json[name];
        }

        public object GetReferenceObject(object name, Type type, DAopConvert convert)
        {
            var dict = json[name] as IDictionary;
            if (dict != null && dict.Count > 0)
                return convert(new AopJsonReader(dict), type);
            return null;
        }

        public IList GetListObjects(string listName, string itemName, Type type, DAopConvert convert)
        {
            IList listObjs = null;

            var jsonObject = json[listName];


            IList jsonList = null;
            if (jsonObject is IList)
            {
                jsonList = jsonObject as IList;
            }
            else if (jsonObject is IDictionary)
            {
                var jsonMap = jsonObject as IDictionary;

                if (jsonMap != null && jsonMap.Count > 0)
                {
                    var itemTmp = jsonMap[itemName];

                    if (itemTmp == null && listName != null)
                        itemTmp = jsonMap[listName.Substring(0, listName.Length - 1)];

                    if (itemTmp is IList)
                        jsonList = itemTmp as IList;
                }
            }

            if (jsonList != null && jsonList.Count > 0)
            {
                var listType = typeof(List<>).MakeGenericType(type);
                listObjs = Activator.CreateInstance(listType) as IList;
                foreach (var item in jsonList)
                    if (typeof(IDictionary).IsAssignableFrom(item.GetType())) // object
                    {
                        var subMap = item as IDictionary;
                        var subObj = convert(new AopJsonReader(subMap), type);
                        if (subObj != null)
                            listObjs.Add(subObj);
                    }
                    else if (typeof(IList).IsAssignableFrom(item.GetType())) // list/array
                    {
                        // TODO not support yet
                    }
                    //临时
                    //未知JsonNumber含义
                    //else if (typeof(JsonNumber).IsAssignableFrom(item.GetType())) // list/array
                    //{
                    //    JsonNumber jsonNumber = (JsonNumber)item;
                    //    if (typeof(long).IsAssignableFrom(type))
                    //    {
                    //        listObjs.Add(jsonNumber.ToInt64());
                    //    }
                    //    else if (typeof(int).IsAssignableFrom(type))
                    //    {
                    //        listObjs.Add(jsonNumber.ToInt32());
                    //    }
                    //    else if (typeof(double).IsAssignableFrom(type))
                    //    {
                    //        listObjs.Add(jsonNumber.ToDouble());
                    //    }
                    //}
                    else // boolean, string, null
                    {
                        listObjs.Add(item);
                    }
            }

            return listObjs;
        }
    }
}