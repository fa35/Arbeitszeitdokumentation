using Arbeitszeitdokumentation.Container;
using System;
using System.Windows.Forms;

namespace Arbeitszeitdokumentation_v0._1.view
{
    public partial class Arbeitszeiten : Form
    {

        public Worklog Wworklog { get; set; }

        public Arbeitszeiten()
        {
            InitializeComponent();
            this.Wworklog = new Worklog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            int neueId;
            if(int.TryParse(tB1.Text, out neueId ))
                this.Wworklog.EmployeeId=neueId;
            this.Wworklog.Start = tB2.Text;
            this.Wworklog.End = tB3.Text;
            int projektId;
            if (int.TryParse(tB4.Text, out projektId))
                this.Wworklog.ProjectId = projektId;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
