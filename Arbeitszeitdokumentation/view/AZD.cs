using Arbeitszeitdokumentation.BusinessLogic;
using Arbeitszeitdokumentation.Container;
using Arbeitszeitdokumentation_v0._1.view;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Arbeitszeitdokumentation.view
{
    public partial class AZD : Form
    {

        private IBusinessLogic fachkonzept;

        public AZD(IBusinessLogic a)
        {
            InitializeComponent();
            fachkonzept = a;
        }

        private void b11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Mitarbeiter VMItarbeiter = new Mitarbeiter();
            var result =  VMItarbeiter.ShowDialog();
            if (result == DialogResult.OK)
            {
                fachkonzept.AddEmployee(VMItarbeiter.Memployee);
            }

        }

        private void b5_Click(object sender, EventArgs e)
        {
            Projekt VProjekt = new Projekt();
            var result = VProjekt.ShowDialog();
            if (result == DialogResult.OK)
            {
                fachkonzept.AddProject(VProjekt.Pproject);
            }

        }

        private void b8_Click(object sender, EventArgs e)
        {
            Arbeitszeiten VArbeitszeiten = new Arbeitszeiten();
            var result = VArbeitszeiten.ShowDialog();
            if (result == DialogResult.OK)
            {
                fachkonzept.AddWorklog(VArbeitszeiten.Wworklog);
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.GridEmployees.DataSource = new List<int>();
            this.GridEmployees.DataSource = fachkonzept.GetEmployees();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            this.GridProjects.DataSource = new List<int>();
            this.GridProjects.DataSource = fachkonzept.GetProjects();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            this.GridWorklog.DataSource = new List<int>();
            this.GridWorklog.DataSource = fachkonzept.GetWorklogs();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            var tmp = this.GridEmployees.CurrentRow.DataBoundItem as Employee;
            fachkonzept.DeleteEmployee(tmp.Id);
            this.GridEmployees.DataSource = new List<int>();
            this.GridEmployees.DataSource = fachkonzept.GetEmployees();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            var tmp = this.GridProjects.CurrentRow.DataBoundItem as Project;
            fachkonzept.DeleteProject(tmp.Id);
            this.GridProjects.DataSource = new List<int>();
            this.GridProjects.DataSource = fachkonzept.GetProjects();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            var tmp = this.GridWorklog.CurrentRow.DataBoundItem as Worklog;
            fachkonzept.DeleteWorklog(tmp.Id);
            this.GridWorklog.DataSource = new List<int>();
            this.GridWorklog.DataSource = fachkonzept.GetWorklogs();
        }

       

    }
}
