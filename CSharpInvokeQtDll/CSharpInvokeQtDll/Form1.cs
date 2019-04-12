using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInvokeQtDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowQtCtrl_Click(object sender, EventArgs e)
        {
            this.pnlQtCtrl.Width = 300;
            this.pnlQtCtrl.Height = 300;
            QtDllInvoke.showDialog(this.pnlQtCtrl.Handle);
        }

        private void btnShowWind_Click(object sender, EventArgs e)
        {
            this.pnlQtWind.Width = 450;
            this.pnlQtWind.Height = 300;
            QtDllInvoke.showWind(this.pnlQtWind.Handle);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            QtDllInvoke.destoryWin();
        }
    }
}
