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

    public class ProjectType {
        #region Constructors
        public ProjectType() {
        }
        internal ProjectType(System.Data.SqlClient.SqlDataReader dr) {
            Fill(dr);
        }

        #endregion

        #region Database String
        internal const string db_ID = "ProjectTypeID";
        internal const string db_Name = "Name";

        #endregion

        #region Private Variables
        private int _ID;
        private string _Name;
        private List<Project> _Projects = null;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the ID for this SQLCode.ProjectType object.
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
        /// Gets or sets the Name for this SQLCode.ProjectType object.
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
        /// Gets all Projects for this SQLCode.ProjectType object.
        /// </summary>
        /// <remarks></remarks>
        public List<Project> Projects {
            get {
                if (_Projects == null) {
                   // _Projects = S_DAL.GetProjects(this);
                }
                return _Projects; 
            }
        }


        #endregion

        //#region Public Functions
        ///// <summary>
        ///// Calls DAL function to add ProjectType to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbAdd() {
        //    _ID = S_DAL.AddProjectType(this);
        //    return ID;
        //}

        ///// <summary>
        ///// Calls DAL function to update ProjectType to the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbUpdate() {
        //    return S_DAL.UpdateProjectType(this);
        //}

        ///// <summary>
        ///// Calls DAL function to remove ProjectType from the database.
        ///// </summary>
        ///// <remarks></remarks>
        //public int dbRemove() {
        //    return S_DAL.RemoveProjectType(this);
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
        }

        #endregion

        public override string ToString() {
            return this.GetType().ToString();
        }

    }
}
