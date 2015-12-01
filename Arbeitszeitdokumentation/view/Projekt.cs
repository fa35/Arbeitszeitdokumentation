using Arbeitszeitdokumentation.Container;
using System;
using System.Windows.Forms;

namespace Arbeitszeitdokumentation_v0._1.view
{
    public partial class Projekt : Form
    {

        public Project Pproject { get; set; }

        public Projekt()
        {
            InitializeComponent();
            this.Pproject = new Project();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            this.Pproject.Title = textBox1.Text;
            this.Pproject.Start = textBox2.Text;
            this.Pproject.End = textBox3.Text;
            this.Pproject.Location = textBox4.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
