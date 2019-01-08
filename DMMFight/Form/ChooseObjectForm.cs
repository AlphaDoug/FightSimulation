using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private GroupBox groupBox = new GroupBox();

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
                var controls = GetControls(this, GlobalData.AttributesCSVs[i].key,1);
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

            CreatSimplePanel(player1.id);

            CreatSimplePanel(player2.id);
        }

        /// <summary>
        /// 递归获取父控件下所有指定名称的子控件
        /// </summary>
        /// <param name="fatherControl">父控件</param>
        /// <param name="name">子控件name</param>
        /// <param name="nameType">1为全字匹配,2为下划线前匹配</param>
        /// <returns></returns>
        public static List<Control> GetControls(Control fatherControl,string name,int nameType)
        {
            Control.ControlCollection sonControls = fatherControl.Controls;
            List<Control> controls = new List<Control>();

            if (nameType == 1)
            {
                //全字匹配
                //遍历所有控件
                foreach (Control control in sonControls)
                {
                    if (control.Name == name)
                    {
                        controls.Add(control);
                    }
                    if (control.Controls != null)
                    {
                        controls.AddRange(GetControls(control, name, nameType));
                    }
                }
            }
            else
            {
                //下划线前匹配
                foreach (Control control in sonControls)
                {
                    if (control.Name.Split('_').Length > 0 && control.Name.Split('_')[0] == name)
                    {
                        controls.Add(control);
                    }
                    if (control.Controls != null)
                    {
                        controls.AddRange(GetControls(control, name, nameType));
                    }
                }
            }

            return controls;
        }

        private void ValueChange(object sender, EventArgs e)
        {

            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.TextBox":
                    TextBoxValueChange((TextBox)sender, e);
                    break;

                case "System.Windows.Forms.ComboBox":
                    ComboBoxValueChange((ComboBox)sender, e);
                    break;
                default:
                    break;
            }
        }

        private void TextBoxValueChange(TextBox sender,EventArgs e)
        {
            string changedValueString = sender.Text;
            float changedValueFloat = 0;
            var fieldName = "";
            var tabPanelName = sender.Name;


            Debug.LogOut("属性值更改了");
            if (tabPanelName.Split('_').Length < 2)
            {
                changedValueString = sender.Text;
                try
                {
                    changedValueFloat = float.Parse(changedValueString);
                }
                catch (Exception a)
                {
                    Debug.LogOut(a.Message);
                    MessageBox.Show("请检查输入的数据格式");
                    return;
                    throw;
                }

                tabPanelName = sender.Parent.Parent.Parent.Parent.Name;
                fieldName = sender.Name;
            }
            else
            {
                tabPanelName = sender.Name;

                //更改名字
                fieldName = "name";

            }
            var id = tabPanelName.Split('_')[1];
            if (id == "0")
            {
                return;
            }
            else
            {
                if (fieldName == "name")
                {
                    for (int i = 0; i < GlobalData.Attributes.Count; i++)
                    {
                        if (GlobalData.Attributes[i].id == int.Parse(id))//若当前显示ID和对象池中的ID相同,则会更新对应的属性值
                        {
                            if (!CSVRead.SetModelValue(fieldName, changedValueString, GlobalData.Attributes[i]))
                            {
                                MessageBox.Show("属性值更新失败,请检查输入是否合法");
                            }

                            return;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < GlobalData.Attributes.Count; i++)
                    {
                        if (GlobalData.Attributes[i].id == int.Parse(id))//若当前显示ID和对象池中的ID相同,则会更新对应的属性值
                        {
                            if (!CSVRead.SetModelValue(fieldName, changedValueFloat, GlobalData.Attributes[i]))
                            {
                                MessageBox.Show("属性值更新失败,请检查输入是否合法");
                            }

                            return;
                        }
                    }
                }

            }
            MessageBox.Show("属性值更新失败,请检查输入是否合法");
        }
        /// <summary>
        /// 简要信息浏览框的勾选框点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SimpleInfoOnClick(object sender, EventArgs e)
        {
            int id = 0;

            RadioButton radioButton = sender as RadioButton;
            id = int.Parse(radioButton.Name.Split('_')[1]);
            if (radioButton.Checked)
            {
                return;
            }
            else
            {

                //遍历所有相同的radiobutton,设置为false
                var radiobtns = GetControls(this, "ShowRadioBtn", 2);
                for (int i = 0; i < radiobtns.Count; i++)
                {
                    if (((RadioButton)radiobtns[i]).Checked)
                    {
                        ((RadioButton)radiobtns[i]).Checked = false;
                    }
                }
                radioButton.Checked = true;
            }

            SetAttributesToRight(id);

        }

        private void ComboBoxValueChange(ComboBox sender, EventArgs e)
        {
            int changedValue = 0;
            var fieldName = "";
            var tabPanelName = sender.Name;


            Debug.LogOut("属性值更改了");

            tabPanelName = sender.Name;

            changedValue = sender.SelectedIndex;
            fieldName = "camp";


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
                        if (!CSVRead.SetModelValue(fieldName, changedValue, GlobalData.Attributes[i]))
                        {
                            MessageBox.Show("属性值更新失败,请检查输入是否合法");
                        }

                        return;
                    }
                }
            }
            MessageBox.Show("属性值更新失败,请检查输入是否合法");
        }
        /// <summary>
        /// 创建简要信息浏览控件
        /// </summary>
        /// <param name="id">对象的唯一标识符</param>
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
            textBox.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            textBox.Name = "ShowName_" + attributes.id;
            textBox.Text = attributes.name;
            textBox.LostFocus += ValueChange;
            //textBox.Click += SimpleInfoOnClick;

            ComboBox comboBox = new ComboBox();
            comboBox.Size = new Size(85, 30);
            comboBox.Location = new Point(110, 3);
            comboBox.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            comboBox.Items.Add("阵营A");
            comboBox.Items.Add("阵营B");
            comboBox.Items.Add("阵营C");
            comboBox.Items.Add("阵营D");
            comboBox.Items.Add("阵营E");
            comboBox.Items.Add("阵营F");
            comboBox.SelectedIndex = 0;
            comboBox.Name = "CampCombox_" + attributes.id;
            comboBox.SelectedIndexChanged += ValueChange;
            // comboBox.Click += SimpleInfoOnClick;

            Label label1 = new Label();
            label1.Size = new Size(108, 21);
            label1.Location = new Point(201, 10);
            label1.Name = "ShowHP_" + attributes.id;
            label1.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            label1.Text = "HP:" + attributes.hp.ToString();
            //label1.Click += SimpleInfoOnClick;

            Label label2 = new Label();
            label2.Size = new Size(141, 21);
            label2.Location = new Point(314, 10);
            label2.Name = "ShowMaxAtk" + attributes.id;
            label2.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            label2.Text = "最大攻击:" + attributes.atkMax.ToString();
            //label2.Click += SimpleInfoOnClick;

            Label label3 = new Label();
            label3.Size = new Size(109, 21);
            label3.Location = new Point(465, 10);
            label3.Name = "ShowDef" + attributes.id;
            label3.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            label3.Text = "防御:" + attributes.def.ToString();
            //label3.Click += SimpleInfoOnClick;

            RadioButton radioButton = new RadioButton();
            radioButton.Size = new Size(21, 21);
            radioButton.Location = new Point(600, 10);
            radioButton.Name = "ShowRadioBtn_" + attributes.id;
            radioButton.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            radioButton.Text = " ";
            radioButton.AutoSize = false;
            radioButton.AutoCheck = false;
            radioButton.Click += SimpleInfoOnClick;

            Panel templet = new Panel();
            templet.Size = new Size(650, 44);
            templet.Location = new Point(3, 3);
            templet.Name = "SimplePanel_" + attributes.id;
            //templet.Click += SimpleInfoOnClick;

           

            templet.Controls.Add(textBox);
            templet.Controls.Add(comboBox);
            templet.Controls.Add(label1);
            templet.Controls.Add(label2);
            templet.Controls.Add(label3);
            templet.Controls.Add(radioButton);

            SimpleInfoFlowLayoutPanel.Controls.Add(templet);
        }

        /// <summary>
        /// 根据ID,将属性值更新到右侧的分页栏中
        /// </summary>
        /// <param name="id">对象唯一标识符</param>
        private void SetAttributesToRight(int id)
        {
            Attributes attributes = new Attributes();

            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                if (GlobalData.Attributes[i].id == id)
                {
                    attributes = GlobalData.Attributes[i];
                }
            }

            Type type = typeof(Attributes);

            foreach (PropertyInfo property in type.GetProperties())
            {
                if (GetControls(this, property.Name,1).Count > 0)
                {
                    var player = GetControls(this, property.Name,1)[0];
                    player.Text = CSVRead.GetModelValue(property.Name, attributes);
                }

            }
            GetControls(this, "AttribatesShowTab", 2)[0].Name = "AttribatesShowTab_" + id;

        }
    }
}
