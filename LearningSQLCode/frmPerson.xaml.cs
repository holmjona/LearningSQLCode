using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LearningSQLCode {
    /// <summary>
    /// Interaction logic for frmPerson.xaml
    /// </summary>
    public partial class frmPerson : Window {
        public frmPerson() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e) {

            Person p = new Person();
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.Phone = txtPhone.Text;
            p.Prefix = txtPreFix.Text;
            p.Postfix = txtPostFix.Text;
            p.Homepage = txtHomePage.Text;
            p.DateOfBirth = dpDateOfBirth.DisplayDate;
            p.Email = txtEmail.Text;
            p.IsManager = chkIsManager.IsChecked == true;
            
            SprocDAL.AddPerson(p);

        }
    }
}
