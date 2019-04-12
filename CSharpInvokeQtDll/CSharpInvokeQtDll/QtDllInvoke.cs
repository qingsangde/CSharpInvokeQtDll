using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInvokeQtDll
{
    public  class QtDllInvoke
    {
        [DllImport("qtdialog.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool showDialog(IntPtr hwnd);
        [DllImport("qtdll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool showWind(IntPtr hwnd);
        [DllImport("qtdll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destoryWin();
    }
}
