using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_Requirements_Specification.hu.yonghuguanli;
using Soft_Requirements_Specification.lzm;
using Soft_Requirements_Specification.pjm;

namespace Soft_Requirements_Specification
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new zhuti());
        }
    }
}
