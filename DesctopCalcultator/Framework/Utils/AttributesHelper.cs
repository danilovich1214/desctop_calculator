using System;
using System.ComponentModel;

namespace Framework.Utils
{
    public static class AttributesHelper
    {
        /// <summary>
        /// get enum string description value
        /// </summary>
        /// <param name="value">enum value</param>
        /// <returns>string enum value</returns>
        public static string ToDescription(this Enum value)
        {
            var descrAttr = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descrAttr.Length > 0 ? descrAttr[0].Description : value.ToString();
        }
    }
}
