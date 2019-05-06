using GeneralMachine.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow
{
    /// <summary>
    /// 机器模组实例
    /// </summary>
    public class MachineEntiy
    {
        public MachineEntiy(Module module)
        {
            this.Module = module;
        }

        public Module Module
        {
            get;
            set;
        } = Module.Front;
    }
}
