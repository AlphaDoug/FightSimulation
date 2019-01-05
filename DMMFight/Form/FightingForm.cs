using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMMFight
{
    public partial class FightingForm : Form
    {


        /// <summary>
        /// 对象池中所有对象的实时战斗类
        /// </summary>
        private List<Fight> fights = new List<Fight>();

        public FightingForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 窗口加载完成之后开始模拟战斗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightingForm_Load(object sender, EventArgs e)
        {
            FightStart();
        }
        /// <summary>
        /// 战斗开始,开启对象池中所有玩家的战斗协程
        /// </summary>
        private void FightStart()
        {
            if (fights.Count != 0)
            {
                fights.Clear();
            }
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                Fight fight = new Fight(GlobalData.Attributes[i]);
                fight.FightStart();
                fight.OutputInfoEvent += Fight_OutputInfoEvent;
                fights.Add(fight);
            }
        }

        private void Fight_OutputInfoEvent(FightInfo fightInfo)
        {
            // Debug.LogOut(fightInfo.GetInfo());
            FightingInfoTextBox.Text += fightInfo.GetInfo() + Environment.NewLine;
        }


        /// <summary>
        /// 只剩一方,战斗结束
        /// </summary>
        private void FightStop()
        {
                
        }
        /// <summary>
        /// 战斗窗口关闭,需要停止所有战斗协程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < fights.Count; i++)
            {
                fights[i].FightStop();
                fights[i].OutputInfoEvent -= Fight_OutputInfoEvent;
            }
            //清空数组
            fights.Clear();
        }
    }
}
