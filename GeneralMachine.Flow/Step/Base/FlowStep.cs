using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow.Step.Base
{
    public abstract class FlowStep
    {
        /// <summary>
        /// 5_1_A_2.字段属性枚举区
        /// </summary>
        //5_1_A_1A_A.定义模组实例字段
        public MachineEntiy entiy = null;
        //5_1_A_1B_A.定义状态机字段
        public StateMachine machine = null;

        /// <summary>
        /// 5_1_A_1.流程步序基类
        /// </summary>
        /// <param name="machine">状态机</param>
        /// <param name="entiy">机器模组实例</param>
        public FlowStep (StateMachine machine,MachineEntiy entiy)
        {
            //5_1_A_1A.模组实例赋值
            this.entiy = entiy;
            //5_1_A_1B.状态机赋值
            this.machine = machine;
        }


    }
}
