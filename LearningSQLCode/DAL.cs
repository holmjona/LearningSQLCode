using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSQLCode {
    static class DAL {
        private static string _ConnectionString = null;

        public static string ConnectionString {
            get {
                if (_ConnectionString == null) {
                    //the next three lines of code are to allow for relative paths 
                    // and is based on code found at:
                    // https://stackoverflow.com/questions/1833640/connection-string-with-relative-path-to-the-database-file
                    string exeLoc = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string path = (System.IO.Path.GetDirectoryName(exeLoc));
                    AppDomain.CurrentDomain.SetData("DataDirectory", path);
                    _ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data\MyData.mdf;Integrated Security=True";
                }
                return _ConnectionString;
            }
        }

        #region DAL Methods
        public static List<Person> GetPeople() {
            List<Person> lstPeople = new List<Person>();
            SqlConnection conn = null;
            try {
                conn = new SqlConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();
                
                SqlCommand comm
                    = new SqlCommand("SELECT * FROM People");
                comm.Connection = conn;
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read()) {
                    Person p = new Person();
                    p.ID = (int)dr["PersonID"];
                    p.FirstName = (string)dr["FirstName"];
                    p.LastName = (string)dr["LastName"];
                    p.DateOfBirth = (DateTime)dr["DateOfBirth"];
                    p.Email = (String)dr["Email"];
                    p.Homepage = (String)dr["HomePage"];
                    p.IsManager = (bool)dr["IsManager"];
                    p.Phone = (String)dr["Phone"];
                    p.Postfix = (String)dr["PostFix"];
                    p.Prefix = (String)dr["PreFix"];
                    lstPeople.Add(p);
                }
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            } finally {
                if (conn != null) conn.Close();
            }
            return lstPeople;
        }

        public static Person GetPerson(int id) {
            Person retPerson = null;

            SqlConnection conn = null;
            try {
                conn = new SqlConnection(ConnectionString);
                //conn.ConnectionString = ConnectionString;
                conn.Open();
                String qry = "SELECT * FROM People WHERE PersonID = @ID";
                SqlCommand comm = new SqlCommand(qry, conn);
                comm.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read()) {
                    retPerson = new Person();
                    retPerson.ID = (int)dr["PersonID"];
                    retPerson.FirstName = (string)dr["FirstName"];
                    retPerson.LastName = (string)dr["LastName"];
                    retPerson.DateOfBirth = (DateTime)dr["DateOfBirth"];
                    retPerson.Email = (String)dr["Email"];
                    retPerson.Homepage = (String)dr["HomePage"];
                    retPerson.IsManager = (bool)dr["IsManager"];
                    retPerson.Phone = (String)dr["Phone"];
                    retPerson.Postfix = (String)dr["PostFix"];
                    retPerson.Prefix = (String)dr["PreFix"];
                }
            }catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            } finally {
                if (conn != null) conn.Close();
            }

            return retPerson;
        }


        #endregion  

    }
}
