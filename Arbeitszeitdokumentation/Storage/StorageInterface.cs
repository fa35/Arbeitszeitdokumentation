using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using FirebirdSql;
using FirebirdSql.Data;
using FirebirdSql.Data.FirebirdClient;


namespace Arbeitszeitdokumentation.Storage
{
    public interface IStorage
    {
        

        string connString =           "User=SYSDBA;" +
                                      "Password=masterkey;" +
            /*muss angepasst werden*/ "Database=E:\\FBD\\AS_PROJEKT.FDB;" +
                                      "DataSource=localhost;" +
                                      "Port=3050;";


        List<Employee> GetEmployees();
        List<Project> GetProjects();
        List<Worklog> GetWorklogs();

        void AddEmployee(Employee employee)
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

                  //Firebird
                  FbConnection conn = new FbConnection(connString);
                  conn.Open();
                  String sql = "INSERT into mitarbeiter(P_MITARBEITER_ID,NAME,VORNAME,BERUF) VALUES ('@P_MITARBEITER_ID','@NAME','@VORNAME','@BERUF')";
                  FbCommand com = new FbCommand(sql, conn);
                  /*TextBox müssen noch angepasst werden */
                  com.Parameters.Add("@P_MITARBEITER_ID", TextBox.Text);
                  com.Parameters.Add("@NAME", TextBox.Text);
                  com.Parameters.Add("@VORNAME", TextBox.Text);
                  com.Parameters.Add("@BERUF", TextBox.Text);
                  com.ExecuteNonQuery(); 
                  FbDataReader dr = com.ExecuteReader();
                  while (dr.Read()) 
                  {
                    Console.WriteLine(dr.GetString(0));
                  }
                 dr.Close();
                 conn.Close();
                 Console.ReadLine();
                 
       }
       void AddProject(Project project)
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

               //Firebird
               FbConnection conn = new FbConnection(connString);
               conn.Open();
               String sql = "INSERT into Projekt(P_PROJEKT_ID,BEZEICHNUNG,VON,BIS,ORT) VALUES ('@P_PROJEKT_ID' , '@BEZEICHNUNG' , '@VON' , '@BIS' , '@ORT')";
               FbCommand com = new FbCommand(sql, conn);
               /*TextBox müssen noch angepasst werden */
               com.Parameters.Add("@P_PROJEKT_ID", TextBox.Text);
               com.Parameters.Add("@BEZEICHNUNG", TextBox.Text);
               com.Parameters.Add("@VON", TextBox.Text);
               com.Parameters.Add("@BIS", TextBox.Text);
               com.Parameters.Add("@ORT", TextBox.Text);
               com.ExecuteNonQuery(); 
               FbDataReader dr = com.ExecuteReader();
               while (dr.Read())
               {
                   Console.WriteLine(dr.GetString(0));
               }
               dr.Close();
               conn.Close();
               Console.ReadLine();
       }

       void AddWorklog(Worklog worklog)
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

               //Firebird
               FbConnection conn = new FbConnection(connString);
               conn.Open();
               String sql = "INSERT into Arbeitet(VON,BIS) VALUES ('@VON' , '@BIS')";
               FbCommand com = new FbCommand(sql, conn);
               /*TextBox müssen noch angepasst werden */
               com.Parameters.Add("@VON", TextBox.Text);
               com.Parameters.Add("@BIS", TextBox.Text);
               FbDataReader dr = com.ExecuteReader();
               while (dr.Read())
               {
                   Console.WriteLine(dr.GetString(0));
               }
               dr.Close();
               conn.Close();
               Console.ReadLine();
       }

        void UpdateEmployee(Employee employee)
       {
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

              //Firebird
              FbConnection conn = new FbConnection(connString);
              conn.Open();
              String sql = "UPDATE mitarbeiter SET ('P_MITARBEITER_ID' = '@P_MITARBEITER_ID' , 'NAME' = '@NAME' , 'VORNAME' = '@VORNAME' , 'BERUF' = '@BERUF')";
              FbCommand com = new FbCommand(sql, conn);

              /*TextBox müssen noch angepasst werden */

              com.Parameters.Add("@P_MITARBEITER_ID", TextBox.Text);
              com.Parameters.Add("@NAME", TextBox.Text);
              com.Parameters.Add("@VORNAME", TextBox.Text);
              com.Parameters.Add("@BERUF", TextBox.Text);
              com.ExecuteNonQuery(); 
              FbDataReader dr = com.ExecuteReader();
              while (dr.Read())
              {
                  Console.WriteLine(dr.GetString(0));
              }
              dr.Close();
              conn.Close();
              Console.ReadLine();
          }
       }
        void UpdateProject(Project project)
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

            FbConnection conn = new FbConnection(connString);
            conn.Open();
            String sql = "UPDATE  Projekt SET ('P_PROJEKT_ID' = '@P_PROJEKT_ID' , 'BEZEICHNUNG' = '@BEZEICHNUNG' , 'VON' = '@VON' , 'BIS' = '@BIS' , 'ORT' = '@ORT')";
            FbCommand com = new FbCommand(sql, conn);

            /*TextBox müssen noch angepasst werden */

            com.Parameters.Add("@P_PROJEKT_ID", TextBox.Text); 
            com.Parameters.Add("@BEZEICHNUNG", TextBox.Text);
            com.Parameters.Add("@VON", TextBox.Text);
            com.Parameters.Add("@BIS", TextBox.Text);
            com.Parameters.Add("@ORT", TextBox.Text);
            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
            Console.ReadLine();
      }
       void UpdateWorklog(Worklog worklog)
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

                //Firebird
                FbConnection conn = new FbConnection(connString);
                conn.Open();
                string sql = "UPDATE Arbeitet SET('VON' = '@VON' , 'BIS' = '@BIS')";

               FbCommand com = new FbCommand(sql, conn);

               /*TextBox müssen noch angepasst werden */

               com.Parameters.Add("@VON", TextBox.Text);
               com.Parameters.Add("@BIS", TextBox.Text);
               FbDataReader dr = com.ExecuteReader();
               while (dr.Read())
               {
                   Console.WriteLine(dr.GetString(0));
               }
               dr.Close();
               conn.Close();
               Console.ReadLine();
       }
        void DeleteEmployee(int id)
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


            //Firebird
            FbConnection conn = new FbConnection(connString);
            conn.Open();
            String sql = "DELETE FROM mitarbeiter WHERE P_MITARBEITER_ID = @P_MITARBEITER_ID";
            FbCommand com = new FbCommand(sql, conn);
            /*TextBox müssen noch angepasst werden */
            com.Parameters.Add("@P_MITARBEITER_ID", TextBox.Text);

            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
            Console.ReadLine();
       }
        void DeleteProject(int id)
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


            //Firebird
            FbConnection conn = new FbConnection(connString);
            conn.Open();
            String sql = "DELETE FROM Projekt WHERE P_PROJEKT_ID = @P_PROJEKT_ID";
            FbCommand com = new FbCommand(sql, conn);
            /*TextBox müssen noch angepasst werden */
            com.Parameters.Add("@P_PROJEKT_ID", TextBox.Text); 

            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
            Console.ReadLine();
       }
        void DeleteWorklog(int id)
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

                //Firebird
                FbConnection conn = new FbConnection(connString);
                conn.Open();
                String sql = "DELETE FROM Arbeitet WHERE VON = @VON , BIS = @BIS";
                FbCommand com = new FbCommand(sql, conn);
                /*TextBox müssen noch angepasst werden */
                com.Parameters.Add("@VON", TextBox.Text);
                com.Parameters.Add("@BIS", TextBox.Text);

                com.ExecuteNonQuery();
                FbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr.GetString(0));
                }
                dr.Close();
                conn.Close();
                Console.ReadLine();
       }
     }
}
