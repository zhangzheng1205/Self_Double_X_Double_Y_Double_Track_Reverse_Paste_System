using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeneralMachine.Common.CommonHelper;

namespace GeneralMachine.Config
{
    /// <summary>
    /// 4_1A.定义模组枚举类型
    /// </summary>
    public enum Module
    {
        [EnumDescription("前模组")]
        Front = 0,
        [EnumDescription("后模组")]
        After = 1,
    }

    /// <summary>
    /// 4_1B.定义Feeder枚举类型
    /// </summary>
    public enum Feeder
    {
        [EnumDescription("左Feeder")]
        Left = 0,
        [EnumDescription("右FFeeder")]
        Right = 1,
    }
    /// <summary>
    /// 4_1C.定义吸嘴枚举类型
    /// </summary>
    public enum Nozzle
    {
        [EnumDescription("吸嘴1")]
        Nz1 = 0,
        [EnumDescription("吸嘴2")]
        Nz2 = 1,
        [EnumDescription("吸嘴3")]
        Nz3 = 2,
        [EnumDescription("吸嘴4")]
        Nz4 = 3,
    }
}
