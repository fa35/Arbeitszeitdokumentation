using System.Collections.Generic;
using Arbeitszeitdokumentation.Container;
using System;
using FirebirdSql.Data.FirebirdClient;


namespace Arbeitszeitdokumentation.Storage
{
    public class FirebirdStorage : IStorage
    {
        private string connString = "User=SYSDBA;" +
                                    "Password=masterkey;" +
          /*muss angepasst werden*/ "Database=C:\\Users\\Judith\\Documents\\GitHub\\Arbeitszeitdokumentation\\db\\AS_PROJEKT.FDB;" +
                                    "DataSource=localhost;" +
                                    "Port=3050;";

        private FbConnection conn;

        public FirebirdStorage(string connString)
        {
            this.connString = connString;
            CreateTablesIfNeeded();
        }

        public FirebirdStorage()
        {
            CreateTablesIfNeeded();
        }

        ~FirebirdStorage()
        {
            conn.Close();
        }


        private void CreateTablesIfNeeded()
        {
            conn = new FbConnection(connString);
            conn.Open();

            { // MITARBEITER
                if (!CheckDatabaseObjectExists("MITARBEITER", "table"))
                {
                    string sql = "CREATE TABLE MITARBEITER" +
                                 "(" +
                                 "P_MITARBEITER_ID integer NOT NULL," +
                                 "NAME varchar(255) NOT NULL," +
                                 "VORNAME varchar(255) NOT NULL," +
                                 "BERUF varchar(255) NOT NULL," +
                                 "PRIMARY KEY (P_MITARBEITER_ID)" +
                                 ")";
                    FbCommand com = new FbCommand(sql, conn);
                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                // http://www.firebirdfaq.org/faq29/
                if (!CheckDatabaseObjectExists("GEN_MITARBEITER_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_MITARBEITER_ID;";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                if (!CheckDatabaseObjectExists("TRIG_MITA_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_MITA_ID FOR MITARBEITER " +
                                 "ACTIVE BEFORE INSERT POSITION 0 " +
                                 "AS " +
                                 "BEGIN " +
                                 "if (NEW.P_MITARBEITER_ID is NULL) then NEW.P_MITARBEITER_ID = GEN_ID(GEN_MITARBEITER_ID, 1); " +
                                 "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
            }

            { // PROJEKTE
                if (!CheckDatabaseObjectExists("PROJEKTE", "table"))
                {
                    string sql = "CREATE TABLE PROJEKTE" +
                                 "(" +
                                 "P_PROJEKT_ID integer NOT NULL," +
                                 "BEZEICHNUNG varchar(255) NOT NULL," +
                                 "VON varchar(255) NOT NULL," +
                                 "BIS varchar(255) NOT NULL," +
                                 "ORT varchar(255) NOT NULL," +
                                 "PRIMARY KEY (P_PROJEKT_ID)" +
                                 ")";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                // http://www.firebirdfaq.org/faq29/
                if (!CheckDatabaseObjectExists("GEN_PROJEKTE_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_PROJEKTE_ID;";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                if (!CheckDatabaseObjectExists("TRIG_PROJ_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_PROJ_ID FOR PROJEKTE " +
                                 "ACTIVE BEFORE INSERT POSITION 0 " +
                                 "AS " +
                                 "BEGIN " +
                                 "if (NEW.P_PROJEKT_ID is NULL) then NEW.P_PROJEKT_ID = GEN_ID(GEN_PROJEKTE_ID, 1); " +
                                 "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
            }

            { // ARBEITET
                if (!CheckDatabaseObjectExists("ARBEITET", "table"))
                {
                    string sql = "CREATE TABLE ARBEITET" +
                                 "(" +
                                 "P_ARBEITET_ID integer NOT NULL," +
                                 "F_PROJEKT_ID integer NOT NULL," +
                                 "F_MITARBEITER_ID integer NOT NULL," +
                                 "VON varchar(255) NOT NULL," +
                                 "BIS varchar(255) NOT NULL," +
                                 "PRIMARY KEY (P_ARBEITET_ID)" +
                                 ")";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                // http://www.firebirdfaq.org/faq29/
                if (!CheckDatabaseObjectExists("GEN_ARBEITET_ID", "generator"))
                {
                    string sql = "CREATE GENERATOR GEN_ARBEITET_ID;";
                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }

                if (!CheckDatabaseObjectExists("TRIG_ARBEITET_ID", "trigger"))
                {
                    string sql = "CREATE TRIGGER TRIG_ARBEITET_ID FOR ARBEITET " +
                                 "ACTIVE BEFORE INSERT POSITION 0 " +
                                 "AS " +
                                 "BEGIN " +
                                 "if (NEW.P_ARBEITET_ID is NULL) then NEW.P_ARBEITET_ID = GEN_ID(GEN_ARBEITET_ID, 1); " +
                                 "END";

                    FbCommand com = new FbCommand(sql, conn);

                    FbDataReader dr = com.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
            }

        }

        private bool CheckDatabaseObjectExists(string objectName, string type)
        {
            // From http://www.devrace.com/en/fibplus/articles/2325.php
            // and http://www.alberton.info/firebird_sql_meta_info.html
            string sql = "";
            switch (type)
            {
                case "table":
                    sql =
                        "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 AND RDB$RELATION_NAME = '" +
                        objectName + "'";
                    break;
                case "generator":
                    sql = "SELECT RDB$GENERATOR_NAME FROM RDB$GENERATORS WHERE RDB$SYSTEM_FLAG=0 AND RDB$GENERATOR_NAME = '" +
                        objectName + "'";
                    break;
                case "trigger":
                    sql = "SELECT RDB$TRIGGER_NAME FROM RDB$TRIGGERS WHERE RDB$SYSTEM_FLAG=0 AND RDB$TRIGGER_NAME = '" +
                        objectName + "'";
                    break;
            }
            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            bool exists = false;
            if (dr.Read())
            {
                exists = true;
            }

            dr.Close();

            return exists;
        }

        public List<Employee> GetEmployees()
        {
            String sql = "SELECT * FROM MITARBEITER";
            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            List<Employee> resultsList = new List<Employee>();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string lastName = dr.GetString(1);
                string firstName = dr.GetString(2);
                string profession = dr.GetString(3);
                Employee employee = new Employee(lastName, firstName)
                {
                    Profession = profession,
                    Id = id
                };
                resultsList.Add(employee);
            }
            dr.Close();

            return resultsList;

        }

        public List<Project> GetProjects()
        {
            String sql = "SELECT * FROM PROJEKTE";
            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            List<Project> resultsList = new List<Project>();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string title = dr.GetString(1);
                string start = dr.GetString(2);
                string end = dr.GetString(3);
                string location = dr.GetString(4);
                Project project = new Project
                {
                    Id = id,
                    Title = title,
                    Start = start,
                    End = end,
                    Location = location
                };
                resultsList.Add(project);
            }
            dr.Close();

            return resultsList;
        }

        public List<Worklog> GetWorklogs()
        {
            String sql = "SELECT * FROM ARBEITET";
            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            List<Worklog> resultsList = new List<Worklog>();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                int projectId = dr.GetInt32(1);
                int employeeId = dr.GetInt32(2);
                string start = dr.GetString(3);
                string end = dr.GetString(4);
                Worklog worklog = new Worklog()
                {
                    Id = id,
                    ProjectId = projectId,
                    EmployeeId = employeeId,
                    Start = start,
                    End = end
                };
                resultsList.Add(worklog);
            }
            dr.Close();

            return resultsList;
        }

        public void AddEmployee(Employee employee)
        {
            String sql =
                "INSERT into MITARBEITER(NAME,VORNAME,BERUF) VALUES ('" + 
                employee.LastName + "','" + 
                employee.FirstName + "','" +
                employee.Profession + "')";

            FbCommand com = new FbCommand(sql, conn);
            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void AddProject(Project project)
        {
            String sql =
                "INSERT into PROJEKTE(BEZEICHNUNG,VON,BIS,ORT) VALUES ('" + 
                project.Title + "' , '" + 
                project.Start + "' , '" + 
                project.End + "' , '" + 
                project.Location + "')";
            FbCommand com = new FbCommand(sql, conn);

            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void AddWorklog(Worklog worklog)
        {
            String sql = "INSERT into Arbeitet(F_PROJEKT_ID, F_MITARBEITER_ID, VON, BIS) VALUES (" +
                worklog.ProjectId + ", " +
                worklog.EmployeeId + ", '" + 
                worklog.Start + "', '" +
                worklog.End + "')";
            FbCommand com = new FbCommand(sql, conn);

            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }



        public void UpdateEmployee(Employee employee)
        {
            {
                //Firebird
                /*
                FbConnection conn = new FbConnection(connString);
                conn.Open();
                String sql =
                    "UPDATE MITARBEITER SET ('P_MITARBEITER_ID' = '@P_MITARBEITER_ID' , 'NAME' = '@NAME' , 'VORNAME' = '@VORNAME' , 'BERUF' = '@BERUF')";
                FbCommand com = new FbCommand(sql, conn);

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
                 */
            }
        }

        public void UpdateProject(Project project)
        {
            /*
            FbConnection conn = new FbConnection(connString);
            conn.Open();
            String sql =
                "UPDATE  Projekt SET ('P_PROJEKT_ID' = '@P_PROJEKT_ID' , 'BEZEICHNUNG' = '@BEZEICHNUNG' , 'VON' = '@VON' , 'BIS' = '@BIS' , 'ORT' = '@ORT')";
            FbCommand com = new FbCommand(sql, conn);

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
             */
        }

        public void UpdateWorklog(Worklog worklog)
        {
            //Firebird
            /*
            FbConnection conn = new FbConnection(connString);
            conn.Open();
            string sql = "UPDATE Arbeitet SET('VON' = '@VON' , 'BIS' = '@BIS')";

            FbCommand com = new FbCommand(sql, conn);

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
             */
        }

        public void DeleteEmployee(int id)
        {
            String sql = "DELETE FROM MITARBEITER WHERE P_MITARBEITER_ID = @P_MITARBEITER_ID";
            FbCommand com = new FbCommand(sql, conn);

            com.Parameters.Add("@P_MITARBEITER_ID", id);

            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void DeleteProject(int id)
        {
            String sql = "DELETE FROM Projekt WHERE P_PROJEKT_ID = @P_PROJEKT_ID";
            FbCommand com = new FbCommand(sql, conn);

            com.Parameters.Add("@P_PROJEKT_ID", id);

            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void DeleteWorklog(int id)
        {
            String sql = "DELETE FROM Arbeitet WHERE P_ARBEITET_ID = @P_ARBEITET_ID";
            FbCommand com = new FbCommand(sql, conn);
            com.Parameters.Add("@P_ARBEITET_ID", id);

            com.ExecuteNonQuery();
            FbDataReader dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
        }
    }
}
