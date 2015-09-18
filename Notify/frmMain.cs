using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Notify
{
    public partial class frmMain : Form
    {
        private DateTime _endTime;

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
            lblMessage.Text = "";

            var args = Environment.GetCommandLineArgs();
            var msg = string.Join(" ", args.Skip(1));
            var data = msg.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            switch (data.Length)
            {
                case 2:
                    Text = data[0];
                    msg = HandleTimer(data[1]);
                    break;
                case 1:
                    msg = HandleTimer(data[0]);
                    break;
            }

            lblMessage.Text = msg;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var remaining = _endTime - DateTime.Now;
            lblMessage.Text = remaining.ToString(@"hh\:mm\:ss");
            if (remaining < TimeSpan.Zero)
            {
                lblMessage.ForeColor = Color.Red;
            }
        }

        private string HandleTimer(string msg)
        {
            TimeSpan countdown;
            if (!TimeSpan.TryParse(msg, out countdown)) return msg;
            _endTime = DateTime.Now + countdown;
            timer.Enabled = true;
            return "";
        }
    }
}
