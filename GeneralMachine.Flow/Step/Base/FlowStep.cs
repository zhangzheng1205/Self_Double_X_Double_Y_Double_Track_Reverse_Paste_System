using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow.Step.Base
{
    public abstract class FlowStep
    {
        /// <summary>
        /// 5_1_A1_1.字段属性枚举区
        /// </summary>
        //5_1_A1_1A.定义模组实例字段
        public MachineEntiy entiy = null;
        //5_1_A1_1B.定义状态机字段
        public StateMachine machine = null;

        /// <summary>
        /// 5_1_A_1.流程步序基类
        /// </summary>
        /// <param name="machine">状态机</param>
        /// <param name="entiy">机器模组实例</param>
        public FlowStep (StateMachine machine,MachineEntiy entiy)
        {
            //5_1_A1_1A.模组实例赋值
            this.entiy = entiy;
            //5_1_A1_1B.状态机赋值
            this.machine = machine;
        }
        /// <summary>
        /// 5_1_A1_2.当前步骤的状态
        /// </summary>
        public enum State
        {
            Idle,//等待
            Enter,//进板
            CheckContinue,//检查是否继续
            CheckTrun,//检查是否需要翻转
            TrunGoXY,//翻转轴去XY
            Trun,//旋转轴
            StartMoveXYR,//开始移动XYR
            MoveXYR,//移动XYR
            MoveXYRFinished,//移动XYR结束
            MoveZ,//移动Z轴
            MoveZFinsished,//移动Z轴结束
            ZMoveSafe,//Z轴到安全位
            ZMoveSafeFinished,//Z轴到安全位完成
            Exit,//退出
        }
        /// <summary>
        /// 5_1_A1_3.当前状态
        /// </summary>
        public State CurState
        {
            get;
            set;
        } = State.Idle;
        /// <summary>
        /// 5_1_A1_4.步骤计时器
        /// </summary>
        private Stopwatch sw = new Stopwatch();

        /// <summary>
        /// 5_1_A1_5.移动参数实例化
        /// </summary>
        public MoveParam MoveParam = new MoveParam();

        /// <summary>
        /// 5_1_A1_6.根据当前状态执行相应动作
        /// </summary>
        public void Handler()
        {
            switch (CurState)
            {
                case State.Enter:
                    this.OnEnter();
                    break;
            }
        }

        #region 5_1_A1_7.方法区
        /// <summary>
        /// 
        /// </summary>
        public virtual void OnEnter()
        {
            MsgHelper
        } 
        #endregion
    }
}
