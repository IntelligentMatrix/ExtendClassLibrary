using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmguCVLibrary.Theories
{
    public partial class FloodFill : ProjectBaseMethod
    {
        #region 构造函数
        public FloodFill()
        {
            InitializeComponent();
        }

        public FloodFill(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

    }
}
