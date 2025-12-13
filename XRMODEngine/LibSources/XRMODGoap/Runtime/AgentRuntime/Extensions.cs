using System;
using System.Linq;

namespace Goap.Agent.Runtime
{
    public static class Extensions
    {
        public static string GetGenericTypeName(this Type type)
        {
            var typeName = type.Name;

            if (type.IsGenericType)
            {
                var genericArguments = type.GetGenericArguments();
                var genericTypeName = typeName.Substring(0, typeName.IndexOf('`'));
                var typeArgumentNames = string.Join(",", genericArguments.Select(a => a.GetGenericTypeName()));
                typeName = $"{genericTypeName}<{typeArgumentNames}>";
            }

            return typeName;
        }
    }
}