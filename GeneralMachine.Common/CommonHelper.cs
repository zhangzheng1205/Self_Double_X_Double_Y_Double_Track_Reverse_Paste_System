using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Common
{
    /// <summary>
    /// 公共助手静态类
    /// </summary>
    public static class CommonHelper
    {
        #region 枚举注释属性类:?
        /// <summary>
        /// 枚举注释自定义属性类
        /// </summary>
        public class EnumDescriptionAttribute : Attribute
        {
            private string m_strDescription;
            public EnumDescriptionAttribute(string strPrinterName)
            {
                m_strDescription = strPrinterName;
            }

            public string Description
            {
                get { return m_strDescription; }
            }
        }

        public class EnumValueAttribute : Attribute
        {
            private int m_Value;
            public EnumValueAttribute(int value)
            {
                m_Value = value;
            }

            public int Value
            {
                get { return m_Value; }
            }
        }

        /// <summary>
        /// 获取枚举描述静态方法
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumDescription(Type type, object value)
        {
            FieldInfo fieldInfo = type.GetField(value.ToString());
            object[] attribArray = fieldInfo.GetCustomAttributes(false);
            foreach (var obj in attribArray)
            {
                if (obj.GetType() == typeof(EnumDescriptionAttribute))
                {
                    return ((EnumDescriptionAttribute)obj).Description;
                }
            }
            return string.Empty;
        }

        public static int GetEnumValue(Type type, object value)
        {
            FieldInfo fieldInfo = type.GetField(value.ToString());
            object[] attribArray = fieldInfo.GetCustomAttributes(false);

            foreach (var obj in attribArray)
            {
                if (obj.GetType() == typeof(EnumValueAttribute))
                {
                    return ((EnumValueAttribute)obj).Value;
                }
            }
            return 0;
        } 
        #endregion
    }
}
