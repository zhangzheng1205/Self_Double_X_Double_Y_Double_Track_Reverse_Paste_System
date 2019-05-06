using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow.Step.Base
{
    public abstract class FlowStep
    {
        public MachineEntiy entiy = null;
        public StateMachine machine = null;

        /// <summary>
        /// 5_1_A_1.流程步序基类
        /// </summary>
        /// <param name="machine">状态机</param>
        /// <param name="entiy">机器模组实例</param>
        public FlowStep (StateMachine machine,MachineEntiy entiy)
        {
            this.entiy = entiy;
            this.machine = machine;
        }


    }
}
