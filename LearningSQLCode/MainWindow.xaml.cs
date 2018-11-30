using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningSQLCode {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Project p = SprocDAL.GetProject(1);

            MessageBox.Show(p.ProjectTypeID.ToString());
            MessageBox.Show(p.ProjectType.Name);

        }

        private void btnGetPeople_Click(object sender, RoutedEventArgs e) {
            //List<Person> lstPeople = DAL.GetPeople(); //GetPeopleFromDatabase();
            List<Person> lstPeople = SprocDAL.GetPeople(); 

            // GUI Code
            foreach (Person p in lstPeople) {
                Label lbl = new Label();
                lbl.Content = p.LastName + ", " + p.FirstName + " : " + p.Phone;
                stkPeople.Children.Add(lbl);
            }
        }

        private void btnGetPerson_Click(object sender, RoutedEventArgs e) {
            int pID = int.Parse(txtPersonID.Text);
            Person p = SprocDAL.GetPerson(pID);
            MessageBox.Show(p.FirstName);
        }

        private void BtnAddNew_Click(object sender, RoutedEventArgs e) {
            frmPerson frm = new frmPerson();
            frm.ShowDialog();
        }

        //private List<Person> GetPeopleFromDatabase() {
        //    List<Person> lstPeople = new List<Person>();
        //    SqlConnection conn = null;
        //    try {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\holmjona\source\repos\LearningSQLCode\LearningSQLCode\data\myData.mdf;Integrated Security=True";
        //        //conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\holmjona\\source\\repos\\LearningSQLCode\\LearningSQLCode\\data\\myData.mdf;Integrated Security=True";
        //        conn.Open();
        //        //MessageBox.Show("i am in ");
        //        SqlCommand comm
        //            = new SqlCommand("SELECT LastName, FirstName FROM People");
        //        comm.Connection = conn;
        //        SqlDataReader dr = comm.ExecuteReader();
        //        while (dr.Read()) {
        //            Person p = new Person();
        //            p.FirstName = (string)dr["FirstName"];
        //            p.LastName = (string)dr["LastName"];
        //            lstPeople.Add(p);
        //        }
        //    } catch (Exception ex) {
        //        MessageBox.Show(ex.Message);
        //    } finally {
        //        if (conn != null) conn.Close();
        //    }
        //    return lstPeople;
        //}
        //Person p = new Person();
        //p.SetID(1); // Mutator
        //int id = p.GetID(); // Accessor

        //p.ID = 1; // Properties instead of Accessor and Mutators
        //int idd = p.ID;


    }

}
