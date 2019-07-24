using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLibrary.FormAndUser
{
    public partial class ConfigForm : Form
    {
        #region 
        public ConfigForm(string host)
        {
            InitializeComponent();
            SolutionName = host;

        }
        public ConfigForm():this(Environment.MachineName)
        {
            InitializeComponent();

        }
        #endregion

        public string SolutionName { get; set; }//主机名
        /// <summary>
        /// 页面加载
        /// 1、加载主机名
        /// 2、加载各选项/组件名
        /// 3、加载默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            DataEFEntity DB = new DataEFEntity();
            
            comboBox_Option.Items.AddRange(DB.GetOptionType().ToArray());
        }
    }
}
