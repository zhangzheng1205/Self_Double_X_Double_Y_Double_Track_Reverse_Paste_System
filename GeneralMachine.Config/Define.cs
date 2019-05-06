using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeneralMachine.Common.CommonHelper;

namespace GeneralMachine.Config
{
    /// <summary>
    /// 定义模组枚举类型
    /// </summary>
    public enum Module
    {
        [EnumDescription("前模组")]
        Front = 0,
        [EnumDescription("后模组")]
        After = 1,
    }
}
