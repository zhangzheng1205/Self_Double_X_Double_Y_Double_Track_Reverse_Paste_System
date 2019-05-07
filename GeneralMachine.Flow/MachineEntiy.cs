using GeneralMachine.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow
{
    /// <summary>
    /// 5_3.机器模组实例
    /// </summary>
    public class MachineEntiy
    {
        /// <summary>
        /// 5_3A.机器模组构造函数
        /// </summary>
        /// <param name="module"></param>
        public MachineEntiy(Module module)
        {
            this.Module = module;
        }
        /// <summary>
        /// 5_3B.模组属性
        /// </summary>
        public Module Module
        {
            get;
            set;
        } = Module.Front;
    }
}
