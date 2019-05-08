using GeneralMachine.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Flow.Step.Base
{
    /// <summary>
    /// 5_1_A2.移动参数类
    /// </summary>
    public class MoveParam
    {
        #region 5_1_A2_2.字段属性枚举区
        /// <summary>
        /// 5_1_A2_2A.初始定义4个Z轴位置
        /// </summary>
        public double[] ZPos = new double[4] { 0, 0, 0, 0 };

        /// <summary>
        /// 5_1_A2_2B.初始定义4个R轴角度位置
        /// </summary>
        public double[] RPos = new double[4] { 0, 0, 0, 0 };

        /// <summary>
        /// 5_1_A2_2C.初始定义4个Z轴哪个在使用
        /// </summary>
        public bool[] NzUsed = new bool[4] { false, false, false, false };

        /// <summary>
        /// 5_1_A2_2D.是否需要移动Z轴
        /// </summary>
        public bool IsMoveZ = false;

        /// <summary>
        /// 5_1_A2_2E.是否需要移动R轴角度
        /// </summary>
        public bool IsMoveR = false;

        /// <summary>
        /// 5_1_A2_2F.定义翻转轴的角度
        /// </summary>
        public double TurnAngle = 0;

        /// <summary>
        /// 5_1_A2_2G.定义XY的位置
        /// </summary>
        public PointF XYPos = new PointF();
        #endregion

        #region 5_1_A2_3.贴附信息
        /// <summary>
        /// 5_1_A2_3A.定义贴附板号
        /// </summary>
        public int PastePcbIndex = 0;

        /// <summary>
        /// 5_1_A2_3B.定义贴附小板号
        /// </summary>
        public int PastePcsIndex = 0;

        /// <summary>
        /// 5_1_A2_3C.定义辅料名称
        /// </summary>
        public string LabelName = string.Empty;

        /// <summary>
        /// 5_1_A2_3D.定义使用哪个Feeder
        /// </summary>
        public Feeder feeder = Feeder.Left;

        /// <summary>
        /// 5_1_A2_3E.定义使用哪个吸嘴贴附
        /// </summary>
        public Nozzle nozzle = Nozzle.Nz1;
        #endregion

        /// <summary>
        /// 5_1_A2_1.移动参数构造函数
        /// </summary>
        public MoveParam()
        {
            //5_1_A2_1A.初始化4个Z轴位置数组
            ZPos = new double[4];
            //5_1_A2_1B.初始化4个R轴角度位置数组
            RPos = new double[4];
            //5_1_A2_1C.初始化4个Z轴使用哪个数组
            NzUsed = new bool[4];
        }
        /// <summary>
        /// 5_1_A2_4.吸贴继承移动参数类
        /// </summary>
        public class PasteAndSuckParam:MoveParam
        {

        }
    }
}
