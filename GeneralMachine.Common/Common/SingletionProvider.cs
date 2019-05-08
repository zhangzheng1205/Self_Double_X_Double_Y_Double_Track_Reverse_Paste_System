using System;

namespace GeneralMachine.Common.Message
{
    /// <summary>
    /// SingletionProvider类定义
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class SingletionProvider<T> where T : new()
    {
        /// <summary>
        /// 3_2B1.初始化一个新的实例<see cref = "SingletionProvider{T}"/>class.
        /// </summary>
        public SingletionProvider()
        {
        }
        /// <summary>
        /// Singleton Class
        /// </summary>
        public static T Instance
        {
            get
            {
                return SingletonCreator.Instance;
            }
            set
            {
                SingletonCreator.Instance = value;
            }
        }
        /// <summary>
        /// 创新创建
        /// </summary>
        public static void ReCreate()
        {
            SingletonCreator.ReCreate();
        }

        /// <summary>
        /// Singleton类Creator
        /// </summary>
        internal class SingletonCreator
        {
            /// <summary>
            /// T instance
            /// </summary>
            internal static T Instance
            {
                get;
                set;
            } = new T();
            /// <summary>
            /// 创新创建
            /// </summary>
            internal static void ReCreate()
            {
                SingletonCreator.Instance = new T();
            }

        }

    }
}