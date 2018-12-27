using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DMMFight
{
    class Fight
    {
        /// <summary>
        /// 停止战斗
        /// </summary>
        public void FightStop()
        {
            
            
        }
        /// <summary>
        /// 击打一次的过程
        /// </summary>
        /// <param name="own">伤害发起者</param>
        /// <param name="target">被击打着</param>
        /// <returns></returns>
        IEnumerator<bool> Fighting(Attributes own,Attributes target)
        {
            Thread.Sleep(200);



            yield return true;

        }
    }
}
