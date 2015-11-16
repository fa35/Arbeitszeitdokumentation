using Arbeitszeitdokumentation.Controller;
using Arbeitszeitdokumentation_v0._1.view;
using System;
using System.Windows.Forms;

namespace Arbeitszeitdokumentation.view
{
    public partial class AZD : Form
    {
        public AZD(IController a)
        {
            InitializeComponent();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Mitarbeiter VMItarbeiter = new Mitarbeiter();
            VMItarbeiter.Show();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Projekt VProjekt = new Projekt();
            VProjekt.Show();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Arbeitszeiten VArbeitszeiten = new Arbeitszeiten();
            VArbeitszeiten.Show();
        }

        // Bearbeiten-Alternative aus dem Projekt entfernt. Im ersten Entwurf brauchen wir das nicht. Das kann man später noch einfügen.
        //Wie wird die Selektion im Grid geregelt?

    }
}
