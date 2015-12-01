using Arbeitszeitdokumentation.Container;
using System;
using System.Windows.Forms;

namespace Arbeitszeitdokumentation_v0._1.view
{
    public partial class Mitarbeiter : Form
    {

        public Employee Memployee { get; set; }

        public Mitarbeiter()
        {
            InitializeComponent();
            this.Memployee=new Employee();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            this.Memployee.FirstName = textBox2.Text;
            this.Memployee.LastName = textBox1.Text;
            this.Memployee.Profession = textBox3.Text;
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

    }
}
