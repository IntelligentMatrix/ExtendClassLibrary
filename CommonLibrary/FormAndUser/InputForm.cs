using System;
using System.Windows.Forms;

namespace CommonLibrary.FormAndUser
{
    public delegate bool ConfirmData(string name); //确认数据委托
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }
        public event ConfirmData Confirm;//确认数据事件
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("输入框不能为空！");
                return;
            }
            bool reuslt = (bool)Confirm?.Invoke(name);//获取委托执行结果 
            //关闭界面
            if (reuslt)
            {
                this.Close();
            }
        }
    }
}
