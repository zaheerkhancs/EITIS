// <fileinfo name="aspnet_MembershipCollection_Base.cs">
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
	/// The base class for <see cref="aspnet_MembershipCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="aspnet_MembershipCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_MembershipCollection_Base
	{
		// Constants
		public const string ApplicationIdColumnName = "ApplicationId";
		public const string UserIdColumnName = "UserId";
		public const string PasswordColumnName = "Password";
		public const string PasswordFormatColumnName = "PasswordFormat";
		public const string PasswordSaltColumnName = "PasswordSalt";
		public const string MobilePINColumnName = "MobilePIN";
		public const string EmailColumnName = "Email";
		public const string LoweredEmailColumnName = "LoweredEmail";
		public const string PasswordQuestionColumnName = "PasswordQuestion";
		public const string PasswordAnswerColumnName = "PasswordAnswer";
		public const string IsApprovedColumnName = "IsApproved";
		public const string IsLockedOutColumnName = "IsLockedOut";
		public const string CreateDateColumnName = "CreateDate";
		public const string LastLoginDateColumnName = "LastLoginDate";
		public const string LastPasswordChangedDateColumnName = "LastPasswordChangedDate";
		public const string LastLockoutDateColumnName = "LastLockoutDate";
		public const string FailedPasswordAttemptCountColumnName = "FailedPasswordAttemptCount";
		public const string FailedPasswordAttemptWindowStartColumnName = "FailedPasswordAttemptWindowStart";
		public const string FailedPasswordAnswerAttemptCountColumnName = "FailedPasswordAnswerAttemptCount";
		public const string FailedPasswordAnswerAttemptWindowStartColumnName = "FailedPasswordAnswerAttemptWindowStart";
		public const string CommentColumnName = "Comment";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_MembershipCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public aspnet_MembershipCollection_Base(EITSDB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="EITSDB"/> object.</value>
		protected EITSDB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		public virtual aspnet_MembershipRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._aspnet_Membership_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="aspnet_MembershipRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="aspnet_MembershipRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public aspnet_MembershipRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			aspnet_MembershipRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_MembershipRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		public aspnet_MembershipRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_MembershipRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		public virtual aspnet_MembershipRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[aspnet_Membership]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="aspnet_MembershipRow"/> by the primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An instance of <see cref="aspnet_MembershipRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual aspnet_MembershipRow GetByPrimaryKey(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_GetByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			aspnet_MembershipRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_MembershipRow"/> objects 
		/// by the <c>FK__aspnet_Me__Appli__66603565</c> foreign key.
		/// </summary>
		/// <param name="applicationId">The <c>ApplicationId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		public virtual aspnet_MembershipRow[] GetByApplicationId(System.Guid applicationId)
		{
			return MapRecords(CreateGetByApplicationIdCommand(applicationId));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Me__Appli__66603565</c> foreign key.
		/// </summary>
		/// <param name="applicationId">The <c>ApplicationId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByApplicationIdAsDataTable(System.Guid applicationId)
		{
			return MapRecordsToDataTable(CreateGetByApplicationIdCommand(applicationId));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Me__Appli__66603565</c> foreign key.
		/// </summary>
		/// <param name="applicationId">The <c>ApplicationId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByApplicationIdCommand(System.Guid applicationId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_GetBy_ApplicationId", true);
			AddParameter(cmd, "ApplicationId", applicationId);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_MembershipRow"/> objects 
		/// by the <c>FK__aspnet_Me__UserI__6754599E</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		public virtual aspnet_MembershipRow[] GetByUserId(System.Guid userId)
		{
			return MapRecords(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Me__UserI__6754599E</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByUserIdAsDataTable(System.Guid userId)
		{
			return MapRecordsToDataTable(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Me__UserI__6754599E</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_GetBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_MembershipRow"/> object to be inserted.</param>
		public virtual void Insert(aspnet_MembershipRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_Insert", true);
			AddParameter(cmd, "ApplicationId", value.ApplicationId);
			AddParameter(cmd, "UserId", value.UserId);
			AddParameter(cmd, "Password", value.Password);
			AddParameter(cmd, "PasswordFormat", value.PasswordFormat);
			AddParameter(cmd, "PasswordSalt", value.PasswordSalt);
			AddParameter(cmd, "MobilePIN", value.MobilePIN);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "LoweredEmail", value.LoweredEmail);
			AddParameter(cmd, "PasswordQuestion", value.PasswordQuestion);
			AddParameter(cmd, "PasswordAnswer", value.PasswordAnswer);
			AddParameter(cmd, "IsApproved", value.IsApproved);
			AddParameter(cmd, "IsLockedOut", value.IsLockedOut);
			AddParameter(cmd, "CreateDate", value.CreateDate);
			AddParameter(cmd, "LastLoginDate", value.LastLoginDate);
			AddParameter(cmd, "LastPasswordChangedDate", value.LastPasswordChangedDate);
			AddParameter(cmd, "LastLockoutDate", value.LastLockoutDate);
			AddParameter(cmd, "FailedPasswordAttemptCount", value.FailedPasswordAttemptCount);
			AddParameter(cmd, "FailedPasswordAttemptWindowStart", value.FailedPasswordAttemptWindowStart);
			AddParameter(cmd, "FailedPasswordAnswerAttemptCount", value.FailedPasswordAnswerAttemptCount);
			AddParameter(cmd, "FailedPasswordAnswerAttemptWindowStart", value.FailedPasswordAnswerAttemptWindowStart);
			AddParameter(cmd, "Comment", value.Comment);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_MembershipRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(aspnet_MembershipRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_Update", true);
			AddParameter(cmd, "ApplicationId", value.ApplicationId);
			AddParameter(cmd, "Password", value.Password);
			AddParameter(cmd, "PasswordFormat", value.PasswordFormat);
			AddParameter(cmd, "PasswordSalt", value.PasswordSalt);
			AddParameter(cmd, "MobilePIN", value.MobilePIN);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "LoweredEmail", value.LoweredEmail);
			AddParameter(cmd, "PasswordQuestion", value.PasswordQuestion);
			AddParameter(cmd, "PasswordAnswer", value.PasswordAnswer);
			AddParameter(cmd, "IsApproved", value.IsApproved);
			AddParameter(cmd, "IsLockedOut", value.IsLockedOut);
			AddParameter(cmd, "CreateDate", value.CreateDate);
			AddParameter(cmd, "LastLoginDate", value.LastLoginDate);
			AddParameter(cmd, "LastPasswordChangedDate", value.LastPasswordChangedDate);
			AddParameter(cmd, "LastLockoutDate", value.LastLockoutDate);
			AddParameter(cmd, "FailedPasswordAttemptCount", value.FailedPasswordAttemptCount);
			AddParameter(cmd, "FailedPasswordAttemptWindowStart", value.FailedPasswordAttemptWindowStart);
			AddParameter(cmd, "FailedPasswordAnswerAttemptCount", value.FailedPasswordAnswerAttemptCount);
			AddParameter(cmd, "FailedPasswordAnswerAttemptWindowStart", value.FailedPasswordAnswerAttemptWindowStart);
			AddParameter(cmd, "Comment", value.Comment);
			AddParameter(cmd, "UserId", value.UserId);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>aspnet_Membership</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>aspnet_Membership</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((System.Guid)row["UserId"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_MembershipRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(aspnet_MembershipRow value)
		{
			return DeleteByPrimaryKey(value.UserId);
		}

		/// <summary>
		/// Deletes a record from the <c>aspnet_Membership</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_DeleteByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_Membership</c> table using the 
		/// <c>FK__aspnet_Me__Appli__66603565</c> foreign key.
		/// </summary>
		/// <param name="applicationId">The <c>ApplicationId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByApplicationId(System.Guid applicationId)
		{
			return CreateDeleteByApplicationIdCommand(applicationId).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Me__Appli__66603565</c> foreign key.
		/// </summary>
		/// <param name="applicationId">The <c>ApplicationId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByApplicationIdCommand(System.Guid applicationId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_DeleteBy_ApplicationId", true);
			AddParameter(cmd, "ApplicationId", applicationId);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_Membership</c> table using the 
		/// <c>FK__aspnet_Me__UserI__6754599E</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByUserId(System.Guid userId)
		{
			return CreateDeleteByUserIdCommand(userId).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Me__UserI__6754599E</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Membership_DeleteBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>aspnet_Membership</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
		/// to delete <c>aspnet_Membership</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[aspnet_Membership]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._aspnet_Membership_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		protected aspnet_MembershipRow[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		protected aspnet_MembershipRow[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="aspnet_MembershipRow"/> objects.</returns>
		protected virtual aspnet_MembershipRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int applicationIdColumnIndex = reader.GetOrdinal("ApplicationId");
			int userIdColumnIndex = reader.GetOrdinal("UserId");
			int passwordColumnIndex = reader.GetOrdinal("Password");
			int passwordFormatColumnIndex = reader.GetOrdinal("PasswordFormat");
			int passwordSaltColumnIndex = reader.GetOrdinal("PasswordSalt");
			int mobilePINColumnIndex = reader.GetOrdinal("MobilePIN");
			int emailColumnIndex = reader.GetOrdinal("Email");
			int loweredEmailColumnIndex = reader.GetOrdinal("LoweredEmail");
			int passwordQuestionColumnIndex = reader.GetOrdinal("PasswordQuestion");
			int passwordAnswerColumnIndex = reader.GetOrdinal("PasswordAnswer");
			int isApprovedColumnIndex = reader.GetOrdinal("IsApproved");
			int isLockedOutColumnIndex = reader.GetOrdinal("IsLockedOut");
			int createDateColumnIndex = reader.GetOrdinal("CreateDate");
			int lastLoginDateColumnIndex = reader.GetOrdinal("LastLoginDate");
			int lastPasswordChangedDateColumnIndex = reader.GetOrdinal("LastPasswordChangedDate");
			int lastLockoutDateColumnIndex = reader.GetOrdinal("LastLockoutDate");
			int failedPasswordAttemptCountColumnIndex = reader.GetOrdinal("FailedPasswordAttemptCount");
			int failedPasswordAttemptWindowStartColumnIndex = reader.GetOrdinal("FailedPasswordAttemptWindowStart");
			int failedPasswordAnswerAttemptCountColumnIndex = reader.GetOrdinal("FailedPasswordAnswerAttemptCount");
			int failedPasswordAnswerAttemptWindowStartColumnIndex = reader.GetOrdinal("FailedPasswordAnswerAttemptWindowStart");
			int commentColumnIndex = reader.GetOrdinal("Comment");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					aspnet_MembershipRow record = new aspnet_MembershipRow();
					recordList.Add(record);

					record.ApplicationId = reader.GetGuid(applicationIdColumnIndex);
					record.UserId = reader.GetGuid(userIdColumnIndex);
					record.Password = Convert.ToString(reader.GetValue(passwordColumnIndex));
					record.PasswordFormat = Convert.ToInt32(reader.GetValue(passwordFormatColumnIndex));
					record.PasswordSalt = Convert.ToString(reader.GetValue(passwordSaltColumnIndex));
					if(!reader.IsDBNull(mobilePINColumnIndex))
						record.MobilePIN = Convert.ToString(reader.GetValue(mobilePINColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(loweredEmailColumnIndex))
						record.LoweredEmail = Convert.ToString(reader.GetValue(loweredEmailColumnIndex));
					if(!reader.IsDBNull(passwordQuestionColumnIndex))
						record.PasswordQuestion = Convert.ToString(reader.GetValue(passwordQuestionColumnIndex));
					if(!reader.IsDBNull(passwordAnswerColumnIndex))
						record.PasswordAnswer = Convert.ToString(reader.GetValue(passwordAnswerColumnIndex));
					record.IsApproved = Convert.ToBoolean(reader.GetValue(isApprovedColumnIndex));
					record.IsLockedOut = Convert.ToBoolean(reader.GetValue(isLockedOutColumnIndex));
					record.CreateDate = Convert.ToDateTime(reader.GetValue(createDateColumnIndex));
					record.LastLoginDate = Convert.ToDateTime(reader.GetValue(lastLoginDateColumnIndex));
					record.LastPasswordChangedDate = Convert.ToDateTime(reader.GetValue(lastPasswordChangedDateColumnIndex));
					record.LastLockoutDate = Convert.ToDateTime(reader.GetValue(lastLockoutDateColumnIndex));
					record.FailedPasswordAttemptCount = Convert.ToInt32(reader.GetValue(failedPasswordAttemptCountColumnIndex));
					record.FailedPasswordAttemptWindowStart = Convert.ToDateTime(reader.GetValue(failedPasswordAttemptWindowStartColumnIndex));
					record.FailedPasswordAnswerAttemptCount = Convert.ToInt32(reader.GetValue(failedPasswordAnswerAttemptCountColumnIndex));
					record.FailedPasswordAnswerAttemptWindowStart = Convert.ToDateTime(reader.GetValue(failedPasswordAnswerAttemptWindowStartColumnIndex));
					if(!reader.IsDBNull(commentColumnIndex))
						record.Comment = Convert.ToString(reader.GetValue(commentColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (aspnet_MembershipRow[])(recordList.ToArray(typeof(aspnet_MembershipRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="aspnet_MembershipRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="aspnet_MembershipRow"/> object.</returns>
		protected virtual aspnet_MembershipRow MapRow(DataRow row)
		{
			aspnet_MembershipRow mappedObject = new aspnet_MembershipRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "ApplicationId"
			dataColumn = dataTable.Columns["ApplicationId"];
			if(!row.IsNull(dataColumn))
				mappedObject.ApplicationId = (System.Guid)row[dataColumn];
			// Column "UserId"
			dataColumn = dataTable.Columns["UserId"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserId = (System.Guid)row[dataColumn];
			// Column "Password"
			dataColumn = dataTable.Columns["Password"];
			if(!row.IsNull(dataColumn))
				mappedObject.Password = (string)row[dataColumn];
			// Column "PasswordFormat"
			dataColumn = dataTable.Columns["PasswordFormat"];
			if(!row.IsNull(dataColumn))
				mappedObject.PasswordFormat = (int)row[dataColumn];
			// Column "PasswordSalt"
			dataColumn = dataTable.Columns["PasswordSalt"];
			if(!row.IsNull(dataColumn))
				mappedObject.PasswordSalt = (string)row[dataColumn];
			// Column "MobilePIN"
			dataColumn = dataTable.Columns["MobilePIN"];
			if(!row.IsNull(dataColumn))
				mappedObject.MobilePIN = (string)row[dataColumn];
			// Column "Email"
			dataColumn = dataTable.Columns["Email"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email = (string)row[dataColumn];
			// Column "LoweredEmail"
			dataColumn = dataTable.Columns["LoweredEmail"];
			if(!row.IsNull(dataColumn))
				mappedObject.LoweredEmail = (string)row[dataColumn];
			// Column "PasswordQuestion"
			dataColumn = dataTable.Columns["PasswordQuestion"];
			if(!row.IsNull(dataColumn))
				mappedObject.PasswordQuestion = (string)row[dataColumn];
			// Column "PasswordAnswer"
			dataColumn = dataTable.Columns["PasswordAnswer"];
			if(!row.IsNull(dataColumn))
				mappedObject.PasswordAnswer = (string)row[dataColumn];
			// Column "IsApproved"
			dataColumn = dataTable.Columns["IsApproved"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsApproved = (bool)row[dataColumn];
			// Column "IsLockedOut"
			dataColumn = dataTable.Columns["IsLockedOut"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsLockedOut = (bool)row[dataColumn];
			// Column "CreateDate"
			dataColumn = dataTable.Columns["CreateDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.CreateDate = (System.DateTime)row[dataColumn];
			// Column "LastLoginDate"
			dataColumn = dataTable.Columns["LastLoginDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastLoginDate = (System.DateTime)row[dataColumn];
			// Column "LastPasswordChangedDate"
			dataColumn = dataTable.Columns["LastPasswordChangedDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastPasswordChangedDate = (System.DateTime)row[dataColumn];
			// Column "LastLockoutDate"
			dataColumn = dataTable.Columns["LastLockoutDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastLockoutDate = (System.DateTime)row[dataColumn];
			// Column "FailedPasswordAttemptCount"
			dataColumn = dataTable.Columns["FailedPasswordAttemptCount"];
			if(!row.IsNull(dataColumn))
				mappedObject.FailedPasswordAttemptCount = (int)row[dataColumn];
			// Column "FailedPasswordAttemptWindowStart"
			dataColumn = dataTable.Columns["FailedPasswordAttemptWindowStart"];
			if(!row.IsNull(dataColumn))
				mappedObject.FailedPasswordAttemptWindowStart = (System.DateTime)row[dataColumn];
			// Column "FailedPasswordAnswerAttemptCount"
			dataColumn = dataTable.Columns["FailedPasswordAnswerAttemptCount"];
			if(!row.IsNull(dataColumn))
				mappedObject.FailedPasswordAnswerAttemptCount = (int)row[dataColumn];
			// Column "FailedPasswordAnswerAttemptWindowStart"
			dataColumn = dataTable.Columns["FailedPasswordAnswerAttemptWindowStart"];
			if(!row.IsNull(dataColumn))
				mappedObject.FailedPasswordAnswerAttemptWindowStart = (System.DateTime)row[dataColumn];
			// Column "Comment"
			dataColumn = dataTable.Columns["Comment"];
			if(!row.IsNull(dataColumn))
				mappedObject.Comment = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>aspnet_Membership</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "aspnet_Membership";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("ApplicationId", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("UserId", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Password", typeof(string));
			dataColumn.MaxLength = 128;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PasswordFormat", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PasswordSalt", typeof(string));
			dataColumn.MaxLength = 128;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("MobilePIN", typeof(string));
			dataColumn.MaxLength = 16;
			dataColumn = dataTable.Columns.Add("Email", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("LoweredEmail", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("PasswordQuestion", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("PasswordAnswer", typeof(string));
			dataColumn.MaxLength = 128;
			dataColumn = dataTable.Columns.Add("IsApproved", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("IsLockedOut", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("CreateDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("LastLoginDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("LastPasswordChangedDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("LastLockoutDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("FailedPasswordAttemptCount", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("FailedPasswordAttemptWindowStart", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("FailedPasswordAnswerAttemptCount", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("FailedPasswordAnswerAttemptWindowStart", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Comment", typeof(string));
			dataColumn.MaxLength = 1073741823;
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual IDbDataParameter AddParameter(IDbCommand cmd, string paramName, object value)
		{
			IDbDataParameter parameter;
			switch(paramName)
			{
				case "ApplicationId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "UserId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "Password":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PasswordFormat":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "PasswordSalt":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "MobilePIN":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Email":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "LoweredEmail":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PasswordQuestion":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PasswordAnswer":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "IsApproved":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "IsLockedOut":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "CreateDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "LastLoginDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "LastPasswordChangedDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "LastLockoutDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "FailedPasswordAttemptCount":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "FailedPasswordAttemptWindowStart":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "FailedPasswordAnswerAttemptCount":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "FailedPasswordAnswerAttemptWindowStart":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Comment":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of aspnet_MembershipCollection_Base class
}  // End of namespace
