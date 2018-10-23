// <fileinfo name="tblStaff_LeaveTransCollection_Base.cs">
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
	/// The base class for <see cref="tblStaff_LeaveTransCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblStaff_LeaveTransCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_LeaveTransCollection_Base
	{
		// Constants
		public const string LeaveTrans_IDColumnName = "LeaveTrans_ID";
		public const string Contract_IDColumnName = "Contract_ID";
		public const string StaffIDColumnName = "StaffID";
		public const string Sub_DateColumnName = "Sub_Date";
		public const string Leave_IDColumnName = "Leave_ID";
		public const string FDateColumnName = "FDate";
		public const string To_DateColumnName = "To_Date";
		public const string RemarksColumnName = "Remarks";
		public const string IsApprovedColumnName = "isApproved";
		public const string IsDeletedColumnName = "isDeleted";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_DateColumnName = "Created_Date";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_DateColumnName = "Updated_Date";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_LeaveTransCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblStaff_LeaveTransCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		public virtual tblStaff_LeaveTransRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblStaff_LeaveTrans_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblStaff_LeaveTransRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblStaff_LeaveTransRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblStaff_LeaveTransRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblStaff_LeaveTransRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveTransRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		public tblStaff_LeaveTransRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveTransRow"/> objects that 
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
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		public virtual tblStaff_LeaveTransRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblStaff_LeaveTrans]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblStaff_LeaveTransRow"/> by the primary key.
		/// </summary>
		/// <param name="leaveTrans_ID">The <c>LeaveTrans_ID</c> column value.</param>
		/// <returns>An instance of <see cref="tblStaff_LeaveTransRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblStaff_LeaveTransRow GetByPrimaryKey(int leaveTrans_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_GetByPrimaryKey", true);
			AddParameter(cmd, "LeaveTrans_ID", leaveTrans_ID);
			tblStaff_LeaveTransRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveTransRow"/> objects 
		/// by the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		public tblStaff_LeaveTransRow[] GetByStaffID(int staffID)
		{
			return GetByStaffID(staffID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveTransRow"/> objects 
		/// by the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		public virtual tblStaff_LeaveTransRow[] GetByStaffID(int staffID, bool staffIDNull)
		{
			return MapRecords(CreateGetByStaffIDCommand(staffID, staffIDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByStaffIDAsDataTable(int staffID)
		{
			return GetByStaffIDAsDataTable(staffID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByStaffIDAsDataTable(int staffID, bool staffIDNull)
		{
			return MapRecordsToDataTable(CreateGetByStaffIDCommand(staffID, staffIDNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_GetBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveTransRow"/> object to be inserted.</param>
		public virtual void Insert(tblStaff_LeaveTransRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_Insert", true);
			AddParameter(cmd, "Contract_ID",
				value.IsContract_IDNull ? DBNull.Value : (object)value.Contract_ID);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "Sub_Date",
				value.IsSub_DateNull ? DBNull.Value : (object)value.Sub_Date);
			AddParameter(cmd, "Leave_ID",
				value.IsLeave_IDNull ? DBNull.Value : (object)value.Leave_ID);
			AddParameter(cmd, "FDate",
				value.IsFDateNull ? DBNull.Value : (object)value.FDate);
			AddParameter(cmd, "To_Date",
				value.IsTo_DateNull ? DBNull.Value : (object)value.To_Date);
			AddParameter(cmd, "Remarks", value.Remarks);
			AddParameter(cmd, "IsApproved",
				value.IsIsApprovedNull ? DBNull.Value : (object)value.IsApproved);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "Created_By",
				value.IsCreated_ByNull ? DBNull.Value : (object)value.Created_By);
			AddParameter(cmd, "Created_Date",
				value.IsCreated_DateNull ? DBNull.Value : (object)value.Created_Date);
			AddParameter(cmd, "Updated_By",
				value.IsUpdated_ByNull ? DBNull.Value : (object)value.Updated_By);
			AddParameter(cmd, "Updated_Date",
				value.IsUpdated_DateNull ? DBNull.Value : (object)value.Updated_Date);
			value.LeaveTrans_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveTransRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblStaff_LeaveTransRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_Update", true);
			AddParameter(cmd, "Contract_ID",
				value.IsContract_IDNull ? DBNull.Value : (object)value.Contract_ID);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "Sub_Date",
				value.IsSub_DateNull ? DBNull.Value : (object)value.Sub_Date);
			AddParameter(cmd, "Leave_ID",
				value.IsLeave_IDNull ? DBNull.Value : (object)value.Leave_ID);
			AddParameter(cmd, "FDate",
				value.IsFDateNull ? DBNull.Value : (object)value.FDate);
			AddParameter(cmd, "To_Date",
				value.IsTo_DateNull ? DBNull.Value : (object)value.To_Date);
			AddParameter(cmd, "Remarks", value.Remarks);
			AddParameter(cmd, "IsApproved",
				value.IsIsApprovedNull ? DBNull.Value : (object)value.IsApproved);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "Created_By",
				value.IsCreated_ByNull ? DBNull.Value : (object)value.Created_By);
			AddParameter(cmd, "Created_Date",
				value.IsCreated_DateNull ? DBNull.Value : (object)value.Created_Date);
			AddParameter(cmd, "Updated_By",
				value.IsUpdated_ByNull ? DBNull.Value : (object)value.Updated_By);
			AddParameter(cmd, "Updated_Date",
				value.IsUpdated_DateNull ? DBNull.Value : (object)value.Updated_Date);
			AddParameter(cmd, "LeaveTrans_ID", value.LeaveTrans_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblStaff_LeaveTrans</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblStaff_LeaveTrans</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["LeaveTrans_ID"]);
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
		/// Deletes the specified object from the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveTransRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblStaff_LeaveTransRow value)
		{
			return DeleteByPrimaryKey(value.LeaveTrans_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblStaff_LeaveTrans</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="leaveTrans_ID">The <c>LeaveTrans_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int leaveTrans_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_DeleteByPrimaryKey", true);
			AddParameter(cmd, "LeaveTrans_ID", leaveTrans_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_LeaveTrans</c> table using the 
		/// <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByStaffID(int staffID)
		{
			return DeleteByStaffID(staffID, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_LeaveTrans</c> table using the 
		/// <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByStaffID(int staffID, bool staffIDNull)
		{
			return CreateDeleteByStaffIDCommand(staffID, staffIDNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblStaff_LeaveTrans_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveTrans_DeleteBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblStaff_LeaveTrans</c> records that match the specified criteria.
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
		/// to delete <c>tblStaff_LeaveTrans</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblStaff_LeaveTrans]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblStaff_LeaveTrans_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		protected tblStaff_LeaveTransRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		protected tblStaff_LeaveTransRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblStaff_LeaveTransRow"/> objects.</returns>
		protected virtual tblStaff_LeaveTransRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int leaveTrans_IDColumnIndex = reader.GetOrdinal("LeaveTrans_ID");
			int contract_IDColumnIndex = reader.GetOrdinal("Contract_ID");
			int staffIDColumnIndex = reader.GetOrdinal("StaffID");
			int sub_DateColumnIndex = reader.GetOrdinal("Sub_Date");
			int leave_IDColumnIndex = reader.GetOrdinal("Leave_ID");
			int fDateColumnIndex = reader.GetOrdinal("FDate");
			int to_DateColumnIndex = reader.GetOrdinal("To_Date");
			int remarksColumnIndex = reader.GetOrdinal("Remarks");
			int isApprovedColumnIndex = reader.GetOrdinal("isApproved");
			int isDeletedColumnIndex = reader.GetOrdinal("isDeleted");
			int created_ByColumnIndex = reader.GetOrdinal("Created_By");
			int created_DateColumnIndex = reader.GetOrdinal("Created_Date");
			int updated_ByColumnIndex = reader.GetOrdinal("Updated_By");
			int updated_DateColumnIndex = reader.GetOrdinal("Updated_Date");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblStaff_LeaveTransRow record = new tblStaff_LeaveTransRow();
					recordList.Add(record);

					record.LeaveTrans_ID = Convert.ToInt32(reader.GetValue(leaveTrans_IDColumnIndex));
					if(!reader.IsDBNull(contract_IDColumnIndex))
						record.Contract_ID = Convert.ToInt32(reader.GetValue(contract_IDColumnIndex));
					if(!reader.IsDBNull(staffIDColumnIndex))
						record.StaffID = Convert.ToInt32(reader.GetValue(staffIDColumnIndex));
					if(!reader.IsDBNull(sub_DateColumnIndex))
						record.Sub_Date = Convert.ToDateTime(reader.GetValue(sub_DateColumnIndex));
					if(!reader.IsDBNull(leave_IDColumnIndex))
						record.Leave_ID = Convert.ToInt32(reader.GetValue(leave_IDColumnIndex));
					if(!reader.IsDBNull(fDateColumnIndex))
						record.FDate = Convert.ToDateTime(reader.GetValue(fDateColumnIndex));
					if(!reader.IsDBNull(to_DateColumnIndex))
						record.To_Date = Convert.ToDateTime(reader.GetValue(to_DateColumnIndex));
					if(!reader.IsDBNull(remarksColumnIndex))
						record.Remarks = Convert.ToString(reader.GetValue(remarksColumnIndex));
					if(!reader.IsDBNull(isApprovedColumnIndex))
						record.IsApproved = Convert.ToBoolean(reader.GetValue(isApprovedColumnIndex));
					if(!reader.IsDBNull(isDeletedColumnIndex))
						record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));
					if(!reader.IsDBNull(created_ByColumnIndex))
						record.Created_By = reader.GetGuid(created_ByColumnIndex);
					if(!reader.IsDBNull(created_DateColumnIndex))
						record.Created_Date = Convert.ToDateTime(reader.GetValue(created_DateColumnIndex));
					if(!reader.IsDBNull(updated_ByColumnIndex))
						record.Updated_By = reader.GetGuid(updated_ByColumnIndex);
					if(!reader.IsDBNull(updated_DateColumnIndex))
						record.Updated_Date = Convert.ToDateTime(reader.GetValue(updated_DateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblStaff_LeaveTransRow[])(recordList.ToArray(typeof(tblStaff_LeaveTransRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblStaff_LeaveTransRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblStaff_LeaveTransRow"/> object.</returns>
		protected virtual tblStaff_LeaveTransRow MapRow(DataRow row)
		{
			tblStaff_LeaveTransRow mappedObject = new tblStaff_LeaveTransRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "LeaveTrans_ID"
			dataColumn = dataTable.Columns["LeaveTrans_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.LeaveTrans_ID = (int)row[dataColumn];
			// Column "Contract_ID"
			dataColumn = dataTable.Columns["Contract_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contract_ID = (int)row[dataColumn];
			// Column "StaffID"
			dataColumn = dataTable.Columns["StaffID"];
			if(!row.IsNull(dataColumn))
				mappedObject.StaffID = (int)row[dataColumn];
			// Column "Sub_Date"
			dataColumn = dataTable.Columns["Sub_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Sub_Date = (System.DateTime)row[dataColumn];
			// Column "Leave_ID"
			dataColumn = dataTable.Columns["Leave_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Leave_ID = (int)row[dataColumn];
			// Column "FDate"
			dataColumn = dataTable.Columns["FDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.FDate = (System.DateTime)row[dataColumn];
			// Column "To_Date"
			dataColumn = dataTable.Columns["To_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.To_Date = (System.DateTime)row[dataColumn];
			// Column "Remarks"
			dataColumn = dataTable.Columns["Remarks"];
			if(!row.IsNull(dataColumn))
				mappedObject.Remarks = (string)row[dataColumn];
			// Column "IsApproved"
			dataColumn = dataTable.Columns["IsApproved"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsApproved = (bool)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			// Column "Created_By"
			dataColumn = dataTable.Columns["Created_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_By = (System.Guid)row[dataColumn];
			// Column "Created_Date"
			dataColumn = dataTable.Columns["Created_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_Date = (System.DateTime)row[dataColumn];
			// Column "Updated_By"
			dataColumn = dataTable.Columns["Updated_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_By = (System.Guid)row[dataColumn];
			// Column "Updated_Date"
			dataColumn = dataTable.Columns["Updated_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_Date = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblStaff_LeaveTrans</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblStaff_LeaveTrans";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("LeaveTrans_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Contract_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("StaffID", typeof(int));
			dataColumn = dataTable.Columns.Add("Sub_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Leave_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("FDate", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("To_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Remarks", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("IsApproved", typeof(bool));
			dataColumn.Caption = "isApproved";
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
			dataColumn.Caption = "isDeleted";
			dataColumn = dataTable.Columns.Add("Created_By", typeof(System.Guid));
			dataColumn = dataTable.Columns.Add("Created_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Updated_By", typeof(System.Guid));
			dataColumn = dataTable.Columns.Add("Updated_Date", typeof(System.DateTime));
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
				case "LeaveTrans_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Contract_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "StaffID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Sub_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Leave_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "FDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "To_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Remarks":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "IsApproved":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Created_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "Created_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Updated_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "Updated_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblStaff_LeaveTransCollection_Base class
}  // End of namespace
