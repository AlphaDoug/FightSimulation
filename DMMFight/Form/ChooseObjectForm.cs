using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMMFight
{
    public partial class ChooseObjectForm : Form
    {
        /// <summary>
        /// 阵营数量
        /// </summary>
        private int campNum = 2;

        private Form lastForm = null;
        /// <summary>
        /// 当前对象池中的玩家属性集合
        /// </summary>
        private List<Attributes> players = new List<Attributes>();



        public ChooseObjectForm(int campNum, Form form)
        {
            InitializeComponent();
            InitializeData(campNum, form);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitializeData(int campNum, Form form)
        {
            this.campNum = campNum;
            lastForm = form;
        }
        /// <summary>
        /// 开始模拟,打开另一个窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartFight_Click(object sender, EventArgs e)
        {
            if (GlobalData.Attributes.Count < 2)
            {
                MessageBox.Show("当前对象池中对象数量小于两个,请检查");
                return;
            }

            var newForm = new FightingForm();
            newForm.ShowDialog();
        }
        /// <summary>
        /// 将当前玩家的属性保存到配置文件
        /// </summary>
        /// <param name="sender"></param>1
        /// <param name="e"></param>
        private void SaveData_Click(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// 从配置文件读取玩家属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadData_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 将右侧更改的属性刷新到左侧,并更新到实体类中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshObj_Click(object sender, EventArgs e)
        {
            Attributes player1 = new Attributes();
            //将右侧的属性更新到一个新的属性类中
            for (int i = 0; i < GlobalData.AttributesCSVs.Count; i++)
            {
                var controls = GetControls(this, GlobalData.AttributesCSVs[i].key);
                if (controls != null && controls.Count > 0)
                {
                    CSVRead.SetModelValue(GlobalData.AttributesCSVs[i].key, float.Parse(controls[0].Text), player1);
                }            
            }
            GlobalData.Attributes.Add(player1);
        }
        /// <summary>
        /// 窗口加载完成回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseObjectForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalData.AttributesCSVs.Count; i++)
            {
                var a = new GlobalType.AttributesShow();
                a.name = GlobalData.AttributesCSVs[i].name;
                a.value = 0;
                var label = new Label();
                label.Text = a.name;
                label.AutoSize = false;
                label.Size = new Size(150, 39);
                label.Location = new Point(3, 0);
                label.Font = new Font("宋体", 16.0f, FontStyle.Regular);

                var b = new TextBox();
                b.Text = "0";
                b.Size = new Size(110, 31);
                b.Location = new Point(164, 3);
                b.Font = new Font("宋体", 16.0f, FontStyle.Regular);
                b.Name = GlobalData.AttributesCSVs[i].key;
                //注册属性值更改事件
                b.LostFocus += new EventHandler(ValueChange);

                var c = new Panel();
                c.Size = new Size(284, 39);
                c.Controls.Add(label);
                c.Controls.Add(b);

                if (GlobalData.AttributesCSVs[i].group == 1)
                {
                    flowLayoutPanel1.Controls.Add(c);
                }

                
                if (GlobalData.AttributesCSVs[i].group == 2)
                {
                    //是进阶属性
                    flowLayoutPanel2.Controls.Add(c);
                }
                if (GlobalData.AttributesCSVs[i].group == 3)
                {
                    //是特殊属性
                    flowLayoutPanel3.Controls.Add(c);
                }
            }

            //读取两个预设的玩家属性进入对象池中
            Attributes player1 = new Attributes();
            Attributes player2 = new Attributes();
            player1 = CSVRead.ReadData(GlobalData.presetPlayer1);
            player2 = CSVRead.ReadData(GlobalData.presetPlayer2);
            GlobalData.Attributes.Clear();
            GlobalData.Attributes.Add(player1);
            GlobalData.Attributes.Add(player2);

            

        }

        /// <summary>
        /// 获取父控件下所有指定名称的子控件
        /// </summary>
        /// <param name="fatherControl"></param>
        /// <returns></returns>
        private List<Control> GetControls(Control fatherControl,string name)
        {
            Control.ControlCollection sonControls = fatherControl.Controls;
            List<Control> controls = new List<Control>();
            //遍历所有控件
            foreach (Control control in sonControls)
            {
                //Debug.LogOut(control.Name);
                if (control.Name == name)
                {
                    controls.Add(control);
                }
                if (control.Controls != null)
                {
                    controls.AddRange(GetControls(control, name));
                }
            }
            return controls;
        }

        private void ValueChange(object sender, EventArgs e)
        {
            var box = (Control)sender;
            var changedValue = box.Text;
            var fieldName = box.Name;
            Debug.LogOut("属性值更改了");
            var tabPanelName = box.Parent.Parent.Parent.Parent.Name;
            var id = tabPanelName.Split('_')[1];
            if (id == "0")
            {
                return;
            }
            else
            {
                for (int i = 0; i < GlobalData.Attributes.Count; i++)
                {
                    if (GlobalData.Attributes[i].id == int.Parse(id))//若当前显示ID和对象池中的ID相同,则会更新对应的属性值
                    {
                        if (!CSVRead.SetModelValue(fieldName, float.Parse(changedValue), GlobalData.Attributes[i]))
                        {
                            MessageBox.Show("属性值更新失败,请检查输入是否合法");
                        }
                       
                        return;
                    }
                }
            }
            MessageBox.Show("属性值更新失败,请检查输入是否合法");
        }

        private void CreatSimplePanel(int id)
        {
            Attributes attributes = new Attributes();

            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                if (GlobalData.Attributes[i].id == id)
                {
                    attributes = GlobalData.Attributes[i];
                }
            }

            TextBox textBox = new TextBox();
            textBox.Size = new Size(100, 29);
            textBox.Location = new Point(5, 4);
            textBox.Name = "ShowName_" + attributes.id;

            ComboBox comboBox = new ComboBox();
            comboBox.Size = new Size(85, 30);
            comboBox.Location = new Point(110, 3);
            comboBox.Font = new Font("微软雅黑", 12, FontStyle.Bold);
            comboBox.Name = "CampCombox_" + attributes.id;

            Label label1 = new Label();
            label1.Size = new Size(108, 21);
            label1.Location = new Point(201, 10);
            label1.Name = "ShowHP_" + attributes.id;

            Label label2 = new Label();
            label2.Size = new Size(141, 21);
            label2.Location = new Point(314, 10);
            label2.Name = "ShowMaxAtk" + attributes.id;

            Label label3 = new Label();
            label3.Size = new Size(109, 21);
            label3.Location = new Point(465, 10);
            label3.Name = "ShowDef" + attributes.id;

            Panel templet = new Panel();
            templet.Size = new Size(587, 44);
            templet.Location = new Point(3, 3);
            templet.Name = "SimplePanel_" + attributes.id;

        }
    }
}
