using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();
            var msg = string.Join(" ", args.Skip(1));
            var data = msg.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            if (data.Length == 2)
            {
                this.Text = data[0];
                msg = data[1];
            }
            else if (data.Length == 1)
            {
                msg = data[0];
            }

            lblMessage.Text = msg;
        }
    }
}
