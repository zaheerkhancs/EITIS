// <fileinfo name="EITSDB_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;
using System.Data;

namespace IOM.EITS.DAL
{
	/// <summary>
	/// The base class for the <see cref="EITSDB"/> class that 
	/// represents a connection to the <c>EITSDB</c> database. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Modify the EITSDB class
	/// if you need to add or change some functionality.
	/// </remarks>
	public abstract class EITSDB_Base : IDisposable
	{
		private IDbConnection _connection;
		private IDbTransaction _transaction;

		// Table and view fields
		private aspnet_ApplicationsCollection _aspnet_Applications;
		private aspnet_MembershipCollection _aspnet_Membership;
		private aspnet_PathsCollection _aspnet_Paths;
		private aspnet_PersonalizationAllUsersCollection _aspnet_PersonalizationAllUsers;
		private aspnet_PersonalizationPerUserCollection _aspnet_PersonalizationPerUser;
		private aspnet_ProfileCollection _aspnet_Profile;
		private aspnet_RolesCollection _aspnet_Roles;
		private aspnet_SchemaVersionsCollection _aspnet_SchemaVersions;
		private aspnet_UsersCollection _aspnet_Users;
		private aspnet_UsersInRolesCollection _aspnet_UsersInRoles;
		private aspnet_WebEvent_EventsCollection _aspnet_WebEvent_Events;
        private tblStaffCollection _tblStaff;
        private tblStaff_AttendanceCollection _tblStaff_Attendance;
        private tblStaff_ContractCollection _tblStaff_Contract;
        private tblStaff_EmergencyContactCollection _tblStaff_EmergencyContact;
        private tblStaff_FilesCollection _tblStaff_Files;
        private tblStaff_LeaveAvailableCollection _tblStaff_LeaveAvailable;
        private tblStaff_LeaveTransCollection _tblStaff_LeaveTrans;
        private tblStaff_PassportCollection _tblStaff_Passport;
        private tblStaff_VisaCollection _tblStaff_Visa;
        private lkpContract_StatusCollection _lkpContract_Status;
        private lkpContract_TypeCollection _lkpContract_Type;
        private lkpDutyStationCollection _lkpDutyStation;
        private lkpLeaveCollection _lkpLeave;
        private lkpLeaveTypeCollection _lkpLeaveType;
        private lkpPassportTypeCollection _lkpPassportType;
        private lkpRelationshipCollection _lkpRelationship;
        private lkpVisaTypeCollection _lkpVisaType;
        private lkpCountryCollection _lkpCountry;
        private lkpAgencyCollection _lkpAgency;
        private lkpDepartmentCollection _lkpDepartment;
        private tblHolidayCollection _tblHoliday;
        private tblRCACollection _tblRCA;
        private tblRecentLogCollection _tblRecentLog;

        

		/// <summary>
		/// Initializes a new instance of the <see cref="EITSDB_Base"/> 
		/// class and opens the database connection.
		/// </summary>
		protected EITSDB_Base() : this(true)
		{
			// EMPTY
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EITSDB_Base"/> class.
		/// </summary>
		/// <param name="init">Specifies whether the constructor calls the
		/// <see cref="InitConnection"/> method to initialize the database connection.</param>
		protected EITSDB_Base(bool init)
		{
			if(init)
				InitConnection();
		}

		/// <summary>
		/// Initializes the database connection.
		/// </summary>
		protected void InitConnection()
		{
			_connection = CreateConnection();
			_connection.Open();
		}

		/// <summary>
		/// Creates a new connection to the database.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbConnection"/> object.</returns>
		protected abstract IDbConnection CreateConnection();

		/// <summary>
		/// Returns a SQL statement parameter name that is specific for the data provider.
		/// For example it returns ? for OleDb provider, or @paramName for MS SQL provider.
		/// </summary>
		/// <param name="paramName">The data provider neutral SQL parameter name.</param>
		/// <returns>The SQL statement parameter name.</returns>
		protected internal abstract string CreateSqlParameterName(string paramName);

		/// <summary>
		/// Creates <see cref="System.Data.IDataReader"/> for the specified DB command.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.IDataReader"/> object.</returns>
		protected internal virtual IDataReader ExecuteReader(IDbCommand command)
		{
			return command.ExecuteReader();
		}

		/// <summary>
		/// Adds a new parameter to the specified command. It is not recommended that 
		/// you use this method directly from your custom code. Instead use the 
		/// <c>AddParameter</c> method of the &lt;TableCodeName&gt;Collection_Base classes.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="dbType">One of the <see cref="System.Data.DbType"/> values. </param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		internal IDbDataParameter AddParameter(IDbCommand cmd, string paramName,
												DbType dbType, object value)
		{
			IDbDataParameter parameter = cmd.CreateParameter();
			parameter.ParameterName = CreateCollectionParameterName(paramName);
			parameter.DbType = dbType;
			parameter.Value = null == value ? DBNull.Value : value;
			cmd.Parameters.Add(parameter);
			return parameter;
		}
		
		/// <summary>
		/// Creates a .Net data provider specific name that is used by the 
		/// <see cref="AddParameter"/> method.
		/// </summary>
		/// <param name="baseParamName">The base name of the parameter.</param>
		/// <returns>The full data provider specific parameter name.</returns>
		protected abstract string CreateCollectionParameterName(string baseParamName);

		/// <summary>
		/// Gets <see cref="System.Data.IDbConnection"/> associated with this object.
		/// </summary>
		/// <value>A reference to the <see cref="System.Data.IDbConnection"/> object.</value>
		public IDbConnection Connection
		{
			get { return _connection; }
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Applications</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_ApplicationsCollection"/> object.</value>
		public aspnet_ApplicationsCollection aspnet_ApplicationsCollection
		{
			get
			{
				if(null == _aspnet_Applications)
					_aspnet_Applications = new aspnet_ApplicationsCollection((EITSDB)this);
				return _aspnet_Applications;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_MembershipCollection"/> object.</value>
		public aspnet_MembershipCollection aspnet_MembershipCollection
		{
			get
			{
				if(null == _aspnet_Membership)
					_aspnet_Membership = new aspnet_MembershipCollection((EITSDB)this);
				return _aspnet_Membership;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Paths</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_PathsCollection"/> object.</value>
		public aspnet_PathsCollection aspnet_PathsCollection
		{
			get
			{
				if(null == _aspnet_Paths)
					_aspnet_Paths = new aspnet_PathsCollection((EITSDB)this);
				return _aspnet_Paths;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_PersonalizationAllUsers</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_PersonalizationAllUsersCollection"/> object.</value>
		public aspnet_PersonalizationAllUsersCollection aspnet_PersonalizationAllUsersCollection
		{
			get
			{
				if(null == _aspnet_PersonalizationAllUsers)
					_aspnet_PersonalizationAllUsers = new aspnet_PersonalizationAllUsersCollection((EITSDB)this);
				return _aspnet_PersonalizationAllUsers;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_PersonalizationPerUserCollection"/> object.</value>
		public aspnet_PersonalizationPerUserCollection aspnet_PersonalizationPerUserCollection
		{
			get
			{
				if(null == _aspnet_PersonalizationPerUser)
					_aspnet_PersonalizationPerUser = new aspnet_PersonalizationPerUserCollection((EITSDB)this);
				return _aspnet_PersonalizationPerUser;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_ProfileCollection"/> object.</value>
		public aspnet_ProfileCollection aspnet_ProfileCollection
		{
			get
			{
				if(null == _aspnet_Profile)
					_aspnet_Profile = new aspnet_ProfileCollection((EITSDB)this);
				return _aspnet_Profile;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Roles</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_RolesCollection"/> object.</value>
		public aspnet_RolesCollection aspnet_RolesCollection
		{
			get
			{
				if(null == _aspnet_Roles)
					_aspnet_Roles = new aspnet_RolesCollection((EITSDB)this);
				return _aspnet_Roles;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_SchemaVersions</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_SchemaVersionsCollection"/> object.</value>
		public aspnet_SchemaVersionsCollection aspnet_SchemaVersionsCollection
		{
			get
			{
				if(null == _aspnet_SchemaVersions)
					_aspnet_SchemaVersions = new aspnet_SchemaVersionsCollection((EITSDB)this);
				return _aspnet_SchemaVersions;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_Users</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_UsersCollection"/> object.</value>
		public aspnet_UsersCollection aspnet_UsersCollection
		{
			get
			{
				if(null == _aspnet_Users)
					_aspnet_Users = new aspnet_UsersCollection((EITSDB)this);
				return _aspnet_Users;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_UsersInRolesCollection"/> object.</value>
		public aspnet_UsersInRolesCollection aspnet_UsersInRolesCollection
		{
			get
			{
				if(null == _aspnet_UsersInRoles)
					_aspnet_UsersInRoles = new aspnet_UsersInRolesCollection((EITSDB)this);
				return _aspnet_UsersInRoles;
			}
		}

		/// <summary>
		/// Gets an object that represents the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <value>A reference to the <see cref="aspnet_WebEvent_EventsCollection"/> object.</value>
		public aspnet_WebEvent_EventsCollection aspnet_WebEvent_EventsCollection
		{
			get
			{
				if(null == _aspnet_WebEvent_Events)
					_aspnet_WebEvent_Events = new aspnet_WebEvent_EventsCollection((EITSDB)this);
				return _aspnet_WebEvent_Events;
			}
		}

        /// <summary>
        /// Gets an object that represents the <c>tblStaff</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaffCollection"/> object.</value>
        public tblStaffCollection tblStaffCollection
        {
            get
            {
                if (null == _tblStaff)
                    _tblStaff = new tblStaffCollection((EITSDB)this);
                return _tblStaff;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_Attendance</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_AttendanceCollection"/> object.</value>
        public tblStaff_AttendanceCollection tblStaff_AttendanceCollection
        {
            get
            {
                if (null == _tblStaff_Attendance)
                    _tblStaff_Attendance = new tblStaff_AttendanceCollection((EITSDB)this);
                return _tblStaff_Attendance;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_Contract</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_ContractCollection"/> object.</value>
        public tblStaff_ContractCollection tblStaff_ContractCollection
        {
            get
            {
                if (null == _tblStaff_Contract)
                    _tblStaff_Contract = new tblStaff_ContractCollection((EITSDB)this);
                return _tblStaff_Contract;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_EmergencyContact</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_EmergencyContactCollection"/> object.</value>
        public tblStaff_EmergencyContactCollection tblStaff_EmergencyContactCollection
        {
            get
            {
                if (null == _tblStaff_EmergencyContact)
                    _tblStaff_EmergencyContact = new tblStaff_EmergencyContactCollection((EITSDB)this);
                return _tblStaff_EmergencyContact;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_Files</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_FilesCollection"/> object.</value>
        public tblStaff_FilesCollection tblStaff_FilesCollection
        {
            get
            {
                if (null == _tblStaff_Files)
                    _tblStaff_Files = new tblStaff_FilesCollection((EITSDB)this);
                return _tblStaff_Files;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_LeaveAvailable</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_LeaveAvailableCollection"/> object.</value>
        public tblStaff_LeaveAvailableCollection tblStaff_LeaveAvailableCollection
        {
            get
            {
                if (null == _tblStaff_LeaveAvailable)
                    _tblStaff_LeaveAvailable = new tblStaff_LeaveAvailableCollection((EITSDB)this);
                return _tblStaff_LeaveAvailable;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_LeaveTrans</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_LeaveTransCollection"/> object.</value>
        public tblStaff_LeaveTransCollection tblStaff_LeaveTransCollection
        {
            get
            {
                if (null == _tblStaff_LeaveTrans)
                    _tblStaff_LeaveTrans = new tblStaff_LeaveTransCollection((EITSDB)this);
                return _tblStaff_LeaveTrans;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_Passport</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_PassportCollection"/> object.</value>
        public tblStaff_PassportCollection tblStaff_PassportCollection
        {
            get
            {
                if (null == _tblStaff_Passport)
                    _tblStaff_Passport = new tblStaff_PassportCollection((EITSDB)this);
                return _tblStaff_Passport;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblStaff_Visa</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblStaff_VisaCollection"/> object.</value>
        public tblStaff_VisaCollection tblStaff_VisaCollection
        {
            get
            {
                if (null == _tblStaff_Visa)
                    _tblStaff_Visa = new tblStaff_VisaCollection((EITSDB)this);
                return _tblStaff_Visa;
            }
        }


        /// <summary>
        /// Gets an object that represents the <c>lkpContract_Status</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpContract_StatusCollection"/> object.</value>
        public lkpContract_StatusCollection lkpContract_StatusCollection
        {
            get
            {
                if (null == _lkpContract_Status)
                    _lkpContract_Status = new lkpContract_StatusCollection((EITSDB)this);
                return _lkpContract_Status;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpContract_Type</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpContract_TypeCollection"/> object.</value>
        public lkpContract_TypeCollection lkpContract_TypeCollection
        {
            get
            {
                if (null == _lkpContract_Type)
                    _lkpContract_Type = new lkpContract_TypeCollection((EITSDB)this);
                return _lkpContract_Type;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpDutyStation</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpDutyStationCollection"/> object.</value>
        public lkpDutyStationCollection lkpDutyStationCollection
        {
            get
            {
                if (null == _lkpDutyStation)
                    _lkpDutyStation = new lkpDutyStationCollection((EITSDB)this);
                return _lkpDutyStation;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpLeave</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpLeaveCollection"/> object.</value>
        public lkpLeaveCollection lkpLeaveCollection
        {
            get
            {
                if (null == _lkpLeave)
                    _lkpLeave = new lkpLeaveCollection((EITSDB)this);
                return _lkpLeave;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpLeaveType</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpLeaveTypeCollection"/> object.</value>
        public lkpLeaveTypeCollection lkpLeaveTypeCollection
        {
            get
            {
                if (null == _lkpLeaveType)
                    _lkpLeaveType = new lkpLeaveTypeCollection((EITSDB)this);
                return _lkpLeaveType;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpPassportType</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpPassportTypeCollection"/> object.</value>
        public lkpPassportTypeCollection lkpPassportTypeCollection
        {
            get
            {
                if (null == _lkpPassportType)
                    _lkpPassportType = new lkpPassportTypeCollection((EITSDB)this);
                return _lkpPassportType;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpRelationship</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpRelationshipCollection"/> object.</value>
        public lkpRelationshipCollection lkpRelationshipCollection
        {
            get
            {
                if (null == _lkpRelationship)
                    _lkpRelationship = new lkpRelationshipCollection((EITSDB)this);
                return _lkpRelationship;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpVisaType</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpVisaTypeCollection"/> object.</value>
        public lkpVisaTypeCollection lkpVisaTypeCollection
        {
            get
            {
                if (null == _lkpVisaType)
                    _lkpVisaType = new lkpVisaTypeCollection((EITSDB)this);
                return _lkpVisaType;
            }
        }
        public lkpAgencyCollection lkpAgencyCollection
        {
            get
            {
                if (null == _lkpAgency)
                    _lkpAgency = new lkpAgencyCollection((EITSDB)this);
                return _lkpAgency;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblHoliday</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblHolidayCollection"/> object.</value>
        public tblHolidayCollection tblHolidayCollection
        {
            get
            {
                if (null == _tblHoliday)
                    _tblHoliday = new tblHolidayCollection((EITSDB)this);
                return _tblHoliday;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblRCA</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblRCACollection"/> object.</value>
        public tblRCACollection tblRCACollection
        {
            get
            {
                if (null == _tblRCA)
                    _tblRCA = new tblRCACollection((EITSDB)this);
                return _tblRCA;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>tblRecentLog</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="tblRecentLogCollection"/> object.</value>
        public tblRecentLogCollection tblRecentLogCollection
        {
            get
            {
                if (null == _tblRecentLog)
                    _tblRecentLog = new tblRecentLogCollection((EITSDB)this);
                return _tblRecentLog;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpCountry</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpCountryCollection"/> object.</value>
        public lkpCountryCollection lkpCountryCollection
        {
            get
            {
                if (null == _lkpCountry)
                    _lkpCountry = new lkpCountryCollection((EITSDB)this);
                return _lkpCountry;
            }
        }

        /// <summary>
        /// Gets an object that represents the <c>lkpAgency</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpAgencyCollection"/> object.</value>
       
        /// <summary>
        /// Gets an object that represents the <c>lkpDepartment</c> table.
        /// </summary>
        /// <value>A reference to the <see cref="lkpDepartmentCollection"/> object.</value>
        public lkpDepartmentCollection lkpDepartmentCollection
        {
            get
            {
                if (null == _lkpDepartment)
                    _lkpDepartment = new lkpDepartmentCollection((EITSDB)this);
                return _lkpDepartment;
            }
        }




		/// <summary>
		/// Begins a new database transaction.
		/// </summary>
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction()
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction();
			return _transaction;
		}

		/// <summary>
		/// Begins a new database transaction with the specified 
		/// transaction isolation level.
		/// <seealso cref="CommitTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		/// <param name="isolationLevel">The transaction isolation level.</param>
		/// <returns>An object representing the new transaction.</returns>
		public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			CheckTransactionState(false);
			_transaction = _connection.BeginTransaction(isolationLevel);
			return _transaction;
		}

		/// <summary>
		/// Commits the current database transaction.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="RollbackTransaction"/>
		/// </summary>
		public void CommitTransaction()
		{
			CheckTransactionState(true);
			_transaction.Commit();
			_transaction = null;
		}

		/// <summary>
		/// Rolls back the current transaction from a pending state.
		/// <seealso cref="BeginTransaction"/>
		/// <seealso cref="CommitTransaction"/>
		/// </summary>
		public void RollbackTransaction()
		{
			CheckTransactionState(true);
			_transaction.Rollback();
			_transaction = null;
		}

		// Checks the state of the current transaction
		private void CheckTransactionState(bool mustBeOpen)
		{
			if(mustBeOpen)
			{
				if(null == _transaction)
					throw new InvalidOperationException("Transaction is not open.");
			}
			else
			{
				if(null != _transaction)
					throw new InvalidOperationException("Transaction is already open.");
			}
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText)
		{
			return CreateCommand(sqlText, false);
		}

		/// <summary>
		/// Creates and returns a new <see cref="System.Data.IDbCommand"/> object.
		/// </summary>
		/// <param name="sqlText">The text of the query.</param>
		/// <param name="procedure">Specifies whether the sqlText parameter is 
		/// the name of a stored procedure.</param>
		/// <returns>An <see cref="System.Data.IDbCommand"/> object.</returns>
		internal IDbCommand CreateCommand(string sqlText, bool procedure)
		{
			IDbCommand cmd = _connection.CreateCommand();
			cmd.CommandText = sqlText;
			cmd.Transaction = _transaction;
			if(procedure)
				cmd.CommandType = CommandType.StoredProcedure;
			return cmd;
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// An application can call the <c>Close</c> method more than
		/// one time without generating an exception.
		/// </summary>
		public virtual void Close()
		{
			if(null != _connection)
				_connection.Close();
		}

		/// <summary>
		/// Rolls back any pending transactions and closes the DB connection.
		/// </summary>
		public virtual void Dispose()
		{
			Close();
			if(null != _connection)
				_connection.Dispose();
		}
	} // End of EITSDB_Base class
} // End of namespace
