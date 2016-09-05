
namespace Reflection1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class Program
    {
        static void Main(string[] args)
        {
            ListGenerator generator = new ListGenerator();
            IList instance = generator.ListInstance(typeof(string));
            instance.Add("abc");
            instance.Add("");
        }
    }
}
