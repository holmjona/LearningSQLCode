using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSQLCode {
    class Person {
        #region Private Variables
        private int _ID;
        private string _FirstName;
        private DateTime _DateOfBirth;
        private bool _IsManager;
        private string _PreFix;
        private string _PostFix;
        private string _Phone;
        private string _Email;
        private string _HomePage;
        #endregion

        #region Public Properties
        public int ID {
            get {
                return _ID;
            }
            set {
                _ID = value;
            }
        }

        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private String _LastName;

        public String LastName {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public DateTime DateOfBirth {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }


        public bool IsManager {
            get { return _IsManager; }
            set { _IsManager = value; }
        }


        public string PreFix {
            get { return _PreFix; }
            set { _PreFix = value; }
        }


        public string PostFix {
            get { return _PostFix; }
            set { _PostFix = value; }
        }


        public string Phone {
            get { return _Phone; }
            set { _Phone = value; }
        }


        public string Email {
            get { return _Email; }
            set { _Email = value; }
        }


        public string HomePage {
            get { return _HomePage; }
            set { _HomePage = value; }
        }
        #endregion

    }
}
