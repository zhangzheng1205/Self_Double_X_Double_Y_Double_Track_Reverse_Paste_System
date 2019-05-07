using GeneralMachine.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow
{
    /// <summary>
    /// 5_2.状态机类
    /// </summary>
    public class StateMachine
    {
        /// <summary>
        /// 5_2A.状态机构造函数
        /// </summary>
        /// <param name="module"></param>
        public StateMachine(Module module)
        {
            this.Module = module;
        }
        /// <summary>
        /// 5_2B.模组属性
        /// </summary>
        public Module Module
        {
            get;
            set;
        } = Module.Front;
    }
}
