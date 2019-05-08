using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMachine.Common.Message
{
    /// <summary>
    /// 3_2A.机器字符加载
    /// </summary>
    public class MsgHelper:SingletionProvider<MsgHelper>
    {
        private log4net.ILog basicLog = null;

        /// <summary>
        /// 3_2A1.初始化
        /// </summary>
        public void Initialize()
        {
            //3_2A1A.调用初始化log信息
            this.InitializeLog();
        }

        private void InitializeLog()
        {
            //3_2C1A.基本信息log
            basicLog = log4net.
        }
    }
}
