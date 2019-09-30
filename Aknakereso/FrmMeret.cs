using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aknakereso
{
    public partial class FrmMeret : Form
    {
        FrmMain fm;

        public FrmMeret(FrmMain mainForm)
        {
            InitializeComponent();
            fm = mainForm;
        }

        private void FrmMeret_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm.palyaX = int.Parse(tbx.Text);
            fm.palyaY = int.Parse(tby.Text);
        }
    }
}
