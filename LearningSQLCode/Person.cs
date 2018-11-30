//Created By: Dad-PC\Dad (using Code generator)
//Created On: 11/28/2018 11:31:47 PM
using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
namespace LearningSQLCode {
    /// <summary>
    /// TODO: Comment this
    /// </summary>
    /// <remarks></remarks>

    public class Person {
        #region Constructors
        public Person() {
        }
        internal Person(System.Data.SqlClient.SqlDataReader dr) {
            Fill(dr);
        }

        #endregion

        #region Database String
        internal const string db_ID = "PersonID";
        internal const string db_FirstName = "FirstName";
        internal const string db_LastName = "LastName";
        internal const string db_DateOfBirth = "DateOfBirth";
        internal const string db_IsManager = "IsManager";
        internal const string db_Prefix = "Prefix";
        internal const string db_Postfix = "Postfix";
        internal const string db_Phone = "Phone";
        internal const string db_Email = "Email";
        internal const string db_Homepage = "Homepage";

        #endregion

        #region Private Variables
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private DateTime _DateOfBirth;
        private bool _IsManager;
        private string _Prefix;
        private string _Postfix;
        private string _Phone;
        private string _Email;
        private string _Homepage;
        private List<ProjectPerson> _Assignments = null;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        public int ID {
            get {
                return _ID;
            }
            set {
                _ID = value;
            }
        }

        /// <summary>
        /// Gets or sets the FirstName for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the LastName for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the DateOfBirth for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                _DateOfBirth = value;
            }
        }

        /// <summary>
        /// Gets or sets the IsManager for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public bool IsManager {
            get {
                return _IsManager;
            }
            set {
                _IsManager = value;
            }
        }

        /// <summary>
        /// Gets or sets the Prefix for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string Prefix {
            get {
                return _Prefix;
            }
            set {
                _Prefix = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the Postfix for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string Postfix {
            get {
                return _Postfix;
            }
            set {
                _Postfix = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the Phone for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string Phone {
            get {
                return _Phone;
            }
            set {
                _Phone = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the Email for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string Email {
            get {
                return _Email;
            }
            set {
                _Email = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the Homepage for this SQLCode.People object.
        /// </summary>
        /// <remarks></remarks>
        public string Homepage {
            get {
                return _Homepage;
            }
            set {
                _Homepage = value.Trim();
            }
        }

        public List<ProjectPerson> Assignments {
            get {
                if(_Assignments == null) {
                 //   _Assignments = S_DAL.GetProjectPeople(this);
                }
                return _Assignments;
            }
        }


        #endregion

        //#region Public Functions
        ///// <summary>
        ///// Calls DAL function to add People to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbAdd() {
        //    _ID = S_DAL.AddPeople(this);
        //    return ID;
        //}

        ///// <summary>
        ///// Calls DAL function to update People to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbUpdate() {
        //    return S_DAL.UpdatePeople(this);
        //}

        ///// <summary>
        ///// Calls DAL function to remove People from the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbRemove() {
        //    return S_DAL.RemovePeople(this);
        //}

        //#endregion

        #region Public Subs
        /// <summary>
        /// Fills object from a SqlClient Data Reader
        /// </summary>
        /// <remarks></remarks>
        public void Fill(System.Data.SqlClient.SqlDataReader dr) {
            _ID = (int)dr[db_ID];
            _FirstName = (string)dr[db_FirstName];
            _LastName = (string)dr[db_LastName];
            _DateOfBirth = (DateTime)dr[db_DateOfBirth];
            _IsManager = (bool)dr[db_IsManager];
            _Prefix = (string)dr[db_Prefix];
            _Postfix = (string)dr[db_Postfix];
            _Phone = (string)dr[db_Phone];
            _Email = (string)dr[db_Email];
            _Homepage = (string)dr[db_Homepage];
        }

        #endregion

        public override string ToString() {
            return this.GetType().ToString();
        }

    }
}
