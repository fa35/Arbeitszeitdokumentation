using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Arbeitszeitdokumentation.Container;

namespace Arbeitszeitdokumentation.Storage
{
    class XMLStorage : IStorage
    {
        public List<Employee> GetEmployees()
        {
            

        }

        public List<Project> GetProjects()
        {
            
        }

        public List<Worklog> GetWorklogs()
        {
            
        }

        public void AddEmployee(Employee employee)
        {
            //XML
            DataTable dt = new DataTable();
            dt.TableName = "Mitarbeiter";

            DataColumn p_mitarbeiter_id = new DataColumn("P_MITARBEITER_ID");
            DataColumn name = new DataColumn("NAME");
            DataColumn vorname = new DataColumn("VORNAME");
            DataColumn beruf = new DataColumn("BERUF");

            dt.Columns.Add(p_mitarbeiter_id);
            dt.Columns.Add(name);
            dt.Columns.Add(vorname);
            dt.Columns.Add(beruf);
            /*TextBox müssen noch angepasst werden */
            dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml("ASProjekt.xml");
        }

        public void AddProject(Project project)
        {
            //XML
            DataTable dt = new DataTable();
            dt.TableName = "Project";

            DataColumn p_id_projekt = new DataColumn("P_PROJEKT_ID");
            DataColumn bezeichnung = new DataColumn("BEZEICHNUNG");
            DataColumn von = new DataColumn("VON");
            DataColumn bis = new DataColumn("BIS");
            DataColumn ort = new DataColumn("ORT");

            dt.Columns.Add(p_id_projekt);
            dt.Columns.Add(bezeichnung);
            dt.Columns.Add(von);
            dt.Columns.Add(bis);
            dt.Columns.Add(ort);
            /*TextBox müssen noch angepasst werden */
            dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml("ASProjekt.xml");
        }

        public void AddWorklog(Worklog worklog)
        {
            //XML
            DataTable dt = new DataTable();
            dt.TableName = "Project";

            DataColumn von = new DataColumn("VON");
            DataColumn bis = new DataColumn("BIS");

            dt.Columns.Add(von);
            dt.Columns.Add(bis);
            /*TextBox müssen noch angepasst werden */
            dt.Rows.Add(TextBox.Text, TextBox.Text);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml("ASProjekt.xml");
        }

        public void UpdateEmployee(Employee employee)
        {
            //XML
              DataTable dt = new DataTable();
              dt.TableName = "Mitarbeiter";

              DataColumn p_mitarbeiter_id = new DataColumn("P_MITARBEITER_ID");
              DataColumn name = new DataColumn("NAME");
              DataColumn vorname = new DataColumn("VORNAME");
              DataColumn beruf = new DataColumn("BERUF");

              /*TextBox müssen noch angepasst werden */
              /*Rows Dynamisch* anpassen*/
              dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);
              dt.Rows[][p_mitarbeiter_id] = TextBox.Text;
              dt.Rows[][name] = TextBox.Text;
              dt.Rows[][vorname] = TextBox.Text;
              dt.Rows[][beruf] = TextBox.Text;
              DataSet ds = new DataSet();
              ds.Tables.Add(dt);
              ds.WriteXml("ASProjekt.xml");
        }

        public void UpdateProject(Project project)
        {
            //XML
           DataTable dt = new DataTable();
           dt.TableName = "Project";

           DataColumn p_id_projekt = new DataColumn("P_PROJEKT_ID");
           DataColumn bezeichnung = new DataColumn("BEZEICHNUNG");
           DataColumn von = new DataColumn("VON");
           DataColumn bis = new DataColumn("BIS");
           DataColumn ort = new DataColumn("ORT");

           /*TextBox müssen noch angepasst werden */
           /*Rows Dynamisch* anpassen*/
           dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);
           dt.Rows[][p_id_projekt] = TextBox.Text;
           dt.Rows[][bezeichnung] = TextBox.Text;
           dt.Rows[][von] = TextBox.Text;
           dt.Rows[][bis] = TextBox.Text;
           dt.Rows[][ort] = TextBox.Text;
           DataSet ds = new DataSet();
           ds.Tables.Add(dt);
           ds.WriteXml("ASProjekt.xml");
        }

        public void UpdateWorklog(Worklog worklog)
        {
            //XML
                DataTable dt = new DataTable();
                dt.TableName = "Project";

                DataColumn von = new DataColumn("VON");
                DataColumn bis = new DataColumn("BIS");

                /*TextBox müssen noch angepasst werden */
                /*Rows Dynamisch* anpassen*/
                dt.Rows.Add(TextBox.Text, TextBox.Text);
                dt.Rows[][von] = TextBox.Text;
                dt.Rows[][bis] = TextBox.Text;
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.WriteXml("ASProjekt.xml");
        }

        public void DeleteEmployee(int id)
        {
            //XML
           DataTable dt = new DataTable();
           dt.TableName = "Mitarbeiter";

           DataColumn p_mitarbeiter_id = new DataColumn("P_MITARBEITER_ID");
           DataColumn name = new DataColumn("NAME");
           DataColumn vorname = new DataColumn("VORNAME");
           DataColumn beruf = new DataColumn("BERUF");

           /*TextBox müssen noch angepasst werden */
           /*Rows Dynamisch* anpassen*/
           dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);
           dt.Rows[].Delete();
           DataSet ds = new DataSet();
           ds.Tables.Add(dt);
           ds.WriteXml("ASProjekt.xml");
        }

        public void DeleteProject(int id)
        {
            //XML
           DataTable dt = new DataTable();
           dt.TableName = "Project";

           DataColumn p_id_projekt = new DataColumn("P_PROJEKT_ID");
           DataColumn bezeichnung = new DataColumn("BEZEICHNUNG");
           DataColumn von = new DataColumn("VON");
           DataColumn bis = new DataColumn("BIS");
           DataColumn ort = new DataColumn("ORT");

           /*TextBox müssen noch angepasst werden */
           /*Rows Dynamisch* anpassen*/
           dt.Rows.Add(TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text, TextBox.Text);
           dt.Rows[].Delete();
           DataSet ds = new DataSet();
           ds.Tables.Add(dt);
           ds.WriteXml("ASProjekt.xml");
        }

        public void DeleteWorklog(int id)
        {
            //XML
                DataTable dt = new DataTable();
                dt.TableName = "Project";

                DataColumn von = new DataColumn("VON");
                DataColumn bis = new DataColumn("BIS");

                /*TextBox müssen noch angepasst werden */
                /*Rows Dynamisch* anpassen*/
                dt.Rows.Add(TextBox.Text, TextBox.Text);
                dt.Rows[].Delete();
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.WriteXml("ASProjekt.xml");
        }
    }
}
