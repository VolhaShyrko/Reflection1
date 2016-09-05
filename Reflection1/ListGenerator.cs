using System;
using System.Collections.Generic;
using System.Collections;

namespace Reflection1
{
    public class ListGenerator
    {
        public IList ListInstance(Type t)
        {
            Type listType = typeof(List<>);
            Type constructedListType = listType.MakeGenericType(t);
            var instance = (IList)Activator.CreateInstance(constructedListType);
   
            return instance;
        }
    }
}
