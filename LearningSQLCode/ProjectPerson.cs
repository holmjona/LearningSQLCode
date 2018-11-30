//Created By: Dad-PC\Dad (using Code generator)
//Created On: 11/28/2018 11:31:47 PM
using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace LearningSQLCode {
    /// <summary>
    /// TODO: Comment this
    /// </summary>
    /// <remarks></remarks>

    public class ProjectPerson {
        #region Constructors
        public ProjectPerson() {
        }
        internal ProjectPerson(System.Data.SqlClient.SqlDataReader dr) {
            Fill(dr);
        }

        #endregion

        #region Database String
        internal const string db_ID = "ProjectPersonID";
        internal const string db_Project = "ProjectID";
        internal const string db_Person = "PersonID";
        internal const string db_DateAssigned = "DateAssigned";
        #endregion

        #region Private Variables
        private int _ID;
        private int _ProjectID;
        private Project _Project;
        private int _PersonID;
        private Person _Person;
        private DateTime _DateAssigned;
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
        /// Gets or sets the Project for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        [XmlIgnore]
        public Project Project {
            get {
                if (_Project == null) {
                  //  _Project = S_DAL.GetProject(_ProjectID);
                }
                return _Project;
            }
            set {
                _Project = value;
                if (value == null) {
                    _ProjectID = -1;
                } else {
                    _ProjectID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the ProjectID for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        public int ProjectID {
            get {
                return _ProjectID;
            }
            set {
                _ProjectID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Person for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        public int PersonID {
            get {
                return _PersonID;
            }
            set {
                _PersonID = value;
            }
        }

        /// <summary>
        /// Gets or sets the Person for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        [XmlIgnore]
        public Person Person {
            get {
                if (_Person == null) {
                 //   _Person = S_DAL.GetPerson(_PersonID);
                }
                return _Person;
            }
            set {
                _Person = value;
                if (value == null) {
                    _PersonID = -1;
                } else {
                    _PersonID = value.ID;
                }
            }
        }

        /// <summary>
        /// Gets or sets the DateAssigned for this SQLCode.ProjectPeople object.
        /// </summary>
        /// <remarks></remarks>
        public DateTime DateAssigned {
            get {
                return _DateAssigned;
            }
            set {
                _DateAssigned = value;
            }
        }


        #endregion

        //#region Public Functions
        ///// <summary>
        ///// Calls DAL function to add ProjectPeople to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbAdd() {
        //    _ID = S_DAL.AddProjectPeople(this);
        //    return ID;
        //}

        ///// <summary>
        ///// Calls DAL function to update ProjectPeople to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbUpdate() {
        //    return S_DAL.UpdateProjectPeople(this);
        //}

        ///// <summary>
        ///// Calls DAL function to remove ProjectPeople from the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbRemove() {
        //    return S_DAL.RemoveProjectPeople(this);
        //}

        //#endregion

        #region Public Subs
        /// <summary>
        /// Fills object from a SqlClient Data Reader
        /// </summary>
        /// <remarks></remarks>
        public void Fill(System.Data.SqlClient.SqlDataReader dr) {
            _ID = (int)dr[db_ID];
            _ProjectID = (int)dr[Project.db_ID];
            _PersonID = (int)dr[db_Person];
            _DateAssigned = (DateTime)dr[db_DateAssigned];
        }

        #endregion

        public override string ToString() {
            return this.GetType().ToString();
        }

    }
}
