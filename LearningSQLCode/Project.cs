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

    public class Project {
        #region Constructors
        public Project() {
        }
        internal Project(System.Data.SqlClient.SqlDataReader dr) {
            Fill(dr);
        }

        #endregion

        #region Database String
        internal const string db_ID = "ProjectID";
        internal const string db_Name = "Name";
        internal const string db_ProjectType = "ProjectTypeID";
        internal const string db_DateStarted = "DateStarted";
        internal const string db_DateEnded = "DateEnded";

        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        private int _ProjectTypeID;
        private ProjectType _ProjectType;
        private DateTime _DateStarted;
        private DateTime _DateEnded;
        private List<ProjectPerson> _Workers = null;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the ID for this SQLCode.Project object.
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
        /// Gets or sets the Name for this SQLCode.Project object.
        /// </summary>
        /// <remarks></remarks>
        public string Name {
            get {
                return _Name;
            }
            set {
                _Name = value.Trim();
            }
        }

        /// <summary>
        /// Gets or sets the ProjectType for this SQLCode.Project object.
        /// </summary>
        /// <remarks></remarks>
        [XmlIgnore]
        public ProjectType ProjectType {
            get {
                if (_ProjectType == null) {
                    _ProjectType = SprocDAL.GetProjectType(_ProjectTypeID);
                }
                return _ProjectType;
            }
            set {
                _ProjectType = value;
                if (value == null) {
                    _ProjectTypeID = -1;
                } else {
                    _ProjectTypeID = value.ID;
                }
            }
        }
        /// <summary>
        /// Gets or sets the ProjectTypeID for this SQLCode.Project object.
        /// </summary>
        /// <remarks></remarks>
        public int ProjectTypeID {
            get {
                return _ProjectTypeID;
            }
            set {
                _ProjectTypeID = value;
            }
        }

        /// <summary>
        /// Gets or sets the DateStarted for this SQLCode.Project object.
        /// </summary>
        /// <remarks></remarks>
        public DateTime DateStarted {
            get {
                return _DateStarted;
            }
            set {
                _DateStarted = value;
            }
        }

        /// <summary>
        /// Gets or sets the DateEnded for this SQLCode.Project object.
        /// </summary>
        /// <remarks></remarks>
        public DateTime DateEnded {
            get {
                return _DateEnded;
            }
            set {
                _DateEnded = value;
            }
        }

        public List<ProjectPerson> Workers {
            get {
                if (_Workers == null) {
                   // _Workers = S_DAL.GetProjectPeople(this);
                }
                return _Workers;
            }
        }
        #endregion

        //#region Public Functions
        ///// <summary>
        ///// Calls DAL function to add Project to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbAdd() {
        //    _ID = S_DAL.AddProject(this);
        //    return ID;
        //}

        ///// <summary>
        ///// Calls DAL function to update Project to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbUpdate() {
        //    return S_DAL.UpdateProject(this);
        //}

        ///// <summary>
        ///// Calls DAL function to remove Project from the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbRemove() {
        //    return S_DAL.RemoveProject(this);
        //}

        //#endregion

        #region Public Subs
        /// <summary>
        /// Fills object from a SqlClient Data Reader
        /// </summary>
        /// <remarks></remarks>
        public void Fill(System.Data.SqlClient.SqlDataReader dr) {
            _ID = (int)dr[db_ID];
            _Name = (string)dr[db_Name];
            _ProjectTypeID = (int)dr[ProjectType.db_ID];
            _DateStarted = (DateTime)dr[db_DateStarted];
            _DateEnded = (DateTime)dr[db_DateEnded];
        }

        #endregion

        public override string ToString() {
            return this.GetType().ToString();
        }

    }
}
