// <fileinfo name="lkpLeaveCollection_Base.cs">
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
	/// The base class for <see cref="lkpLeaveCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="lkpLeaveCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpLeaveCollection_Base
	{
		// Constants
		public const string Leave_IDColumnName = "Leave_ID";
		public const string ContractType_IDColumnName = "ContractType_ID";
		public const string LeaveTypeIDColumnName = "LeaveTypeID";
		public const string LeaveDaysColumnName = "LeaveDays";
		public const string ActiveColumnName = "Active";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpLeaveCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public lkpLeaveCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>lkpLeave</c> table.
		/// </summary>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public virtual lkpLeaveRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>lkpLeave</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>lkpLeave</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._lkpLeave_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="lkpLeaveRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="lkpLeaveRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public lkpLeaveRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			lkpLeaveRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public lkpLeaveRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects that 
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
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public virtual lkpLeaveRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[lkpLeave]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="lkpLeaveRow"/> by the primary key.
		/// </summary>
		/// <param name="leave_ID">The <c>Leave_ID</c> column value.</param>
		/// <returns>An instance of <see cref="lkpLeaveRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual lkpLeaveRow GetByPrimaryKey(int leave_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_GetByPrimaryKey", true);
			AddParameter(cmd, "Leave_ID", leave_ID);
			lkpLeaveRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects 
		/// by the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public lkpLeaveRow[] GetByContractType_ID(int contractType_ID)
		{
			return GetByContractType_ID(contractType_ID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects 
		/// by the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <param name="contractType_IDNull">true if the method ignores the contractType_ID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public virtual lkpLeaveRow[] GetByContractType_ID(int contractType_ID, bool contractType_IDNull)
		{
			return MapRecords(CreateGetByContractType_IDCommand(contractType_ID, contractType_IDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByContractType_IDAsDataTable(int contractType_ID)
		{
			return GetByContractType_IDAsDataTable(contractType_ID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <param name="contractType_IDNull">true if the method ignores the contractType_ID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByContractType_IDAsDataTable(int contractType_ID, bool contractType_IDNull)
		{
			return MapRecordsToDataTable(CreateGetByContractType_IDCommand(contractType_ID, contractType_IDNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <param name="contractType_IDNull">true if the method ignores the contractType_ID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByContractType_IDCommand(int contractType_ID, bool contractType_IDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_GetBy_ContractType_ID", true);
			AddParameter(cmd, "ContractType_ID", contractType_IDNull ? null : (object)contractType_ID);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects 
		/// by the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public lkpLeaveRow[] GetByLeaveTypeID(int leaveTypeID)
		{
			return GetByLeaveTypeID(leaveTypeID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="lkpLeaveRow"/> objects 
		/// by the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <param name="leaveTypeIDNull">true if the method ignores the leaveTypeID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		public virtual lkpLeaveRow[] GetByLeaveTypeID(int leaveTypeID, bool leaveTypeIDNull)
		{
			return MapRecords(CreateGetByLeaveTypeIDCommand(leaveTypeID, leaveTypeIDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByLeaveTypeIDAsDataTable(int leaveTypeID)
		{
			return GetByLeaveTypeIDAsDataTable(leaveTypeID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <param name="leaveTypeIDNull">true if the method ignores the leaveTypeID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByLeaveTypeIDAsDataTable(int leaveTypeID, bool leaveTypeIDNull)
		{
			return MapRecordsToDataTable(CreateGetByLeaveTypeIDCommand(leaveTypeID, leaveTypeIDNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <param name="leaveTypeIDNull">true if the method ignores the leaveTypeID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByLeaveTypeIDCommand(int leaveTypeID, bool leaveTypeIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_GetBy_LeaveTypeID", true);
			AddParameter(cmd, "LeaveTypeID", leaveTypeIDNull ? null : (object)leaveTypeID);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>lkpLeave</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpLeaveRow"/> object to be inserted.</param>
		public virtual void Insert(lkpLeaveRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_Insert", true);
			AddParameter(cmd, "ContractType_ID",
				value.IsContractType_IDNull ? DBNull.Value : (object)value.ContractType_ID);
			AddParameter(cmd, "LeaveTypeID",
				value.IsLeaveTypeIDNull ? DBNull.Value : (object)value.LeaveTypeID);
			AddParameter(cmd, "LeaveDays",
				value.IsLeaveDaysNull ? DBNull.Value : (object)value.LeaveDays);
			AddParameter(cmd, "Active",
				value.IsActiveNull ? DBNull.Value : (object)value.Active);
			value.Leave_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>lkpLeave</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpLeaveRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(lkpLeaveRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_Update", true);
			AddParameter(cmd, "ContractType_ID",
				value.IsContractType_IDNull ? DBNull.Value : (object)value.ContractType_ID);
			AddParameter(cmd, "LeaveTypeID",
				value.IsLeaveTypeIDNull ? DBNull.Value : (object)value.LeaveTypeID);
			AddParameter(cmd, "LeaveDays",
				value.IsLeaveDaysNull ? DBNull.Value : (object)value.LeaveDays);
			AddParameter(cmd, "Active",
				value.IsActiveNull ? DBNull.Value : (object)value.Active);
			AddParameter(cmd, "Leave_ID", value.Leave_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>lkpLeave</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>lkpLeave</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Leave_ID"]);
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
		/// Deletes the specified object from the <c>lkpLeave</c> table.
		/// </summary>
		/// <param name="value">The <see cref="lkpLeaveRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(lkpLeaveRow value)
		{
			return DeleteByPrimaryKey(value.Leave_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>lkpLeave</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="leave_ID">The <c>Leave_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int leave_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Leave_ID", leave_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>lkpLeave</c> table using the 
		/// <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByContractType_ID(int contractType_ID)
		{
			return DeleteByContractType_ID(contractType_ID, false);
		}

		/// <summary>
		/// Deletes records from the <c>lkpLeave</c> table using the 
		/// <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <param name="contractType_IDNull">true if the method ignores the contractType_ID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByContractType_ID(int contractType_ID, bool contractType_IDNull)
		{
			return CreateDeleteByContractType_IDCommand(contractType_ID, contractType_IDNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_lkpLeave_lkpContract_Type</c> foreign key.
		/// </summary>
		/// <param name="contractType_ID">The <c>ContractType_ID</c> column value.</param>
		/// <param name="contractType_IDNull">true if the method ignores the contractType_ID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByContractType_IDCommand(int contractType_ID, bool contractType_IDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_DeleteBy_ContractType_ID", true);
			AddParameter(cmd, "ContractType_ID", contractType_IDNull ? null : (object)contractType_ID);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>lkpLeave</c> table using the 
		/// <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByLeaveTypeID(int leaveTypeID)
		{
			return DeleteByLeaveTypeID(leaveTypeID, false);
		}

		/// <summary>
		/// Deletes records from the <c>lkpLeave</c> table using the 
		/// <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <param name="leaveTypeIDNull">true if the method ignores the leaveTypeID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByLeaveTypeID(int leaveTypeID, bool leaveTypeIDNull)
		{
			return CreateDeleteByLeaveTypeIDCommand(leaveTypeID, leaveTypeIDNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_lkpLeave_lkpLeaveType</c> foreign key.
		/// </summary>
		/// <param name="leaveTypeID">The <c>LeaveTypeID</c> column value.</param>
		/// <param name="leaveTypeIDNull">true if the method ignores the leaveTypeID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByLeaveTypeIDCommand(int leaveTypeID, bool leaveTypeIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._lkpLeave_DeleteBy_LeaveTypeID", true);
			AddParameter(cmd, "LeaveTypeID", leaveTypeIDNull ? null : (object)leaveTypeID);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>lkpLeave</c> records that match the specified criteria.
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
		/// to delete <c>lkpLeave</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[lkpLeave]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>lkpLeave</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._lkpLeave_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		protected lkpLeaveRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		protected lkpLeaveRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="lkpLeaveRow"/> objects.</returns>
		protected virtual lkpLeaveRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int leave_IDColumnIndex = reader.GetOrdinal("Leave_ID");
			int contractType_IDColumnIndex = reader.GetOrdinal("ContractType_ID");
			int leaveTypeIDColumnIndex = reader.GetOrdinal("LeaveTypeID");
			int leaveDaysColumnIndex = reader.GetOrdinal("LeaveDays");
			int activeColumnIndex = reader.GetOrdinal("Active");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					lkpLeaveRow record = new lkpLeaveRow();
					recordList.Add(record);

					record.Leave_ID = Convert.ToInt32(reader.GetValue(leave_IDColumnIndex));
					if(!reader.IsDBNull(contractType_IDColumnIndex))
						record.ContractType_ID = Convert.ToInt32(reader.GetValue(contractType_IDColumnIndex));
					if(!reader.IsDBNull(leaveTypeIDColumnIndex))
						record.LeaveTypeID = Convert.ToInt32(reader.GetValue(leaveTypeIDColumnIndex));
					if(!reader.IsDBNull(leaveDaysColumnIndex))
						record.LeaveDays = Convert.ToInt32(reader.GetValue(leaveDaysColumnIndex));
					if(!reader.IsDBNull(activeColumnIndex))
						record.Active = Convert.ToBoolean(reader.GetValue(activeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (lkpLeaveRow[])(recordList.ToArray(typeof(lkpLeaveRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="lkpLeaveRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="lkpLeaveRow"/> object.</returns>
		protected virtual lkpLeaveRow MapRow(DataRow row)
		{
			lkpLeaveRow mappedObject = new lkpLeaveRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Leave_ID"
			dataColumn = dataTable.Columns["Leave_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Leave_ID = (int)row[dataColumn];
			// Column "ContractType_ID"
			dataColumn = dataTable.Columns["ContractType_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ContractType_ID = (int)row[dataColumn];
			// Column "LeaveTypeID"
			dataColumn = dataTable.Columns["LeaveTypeID"];
			if(!row.IsNull(dataColumn))
				mappedObject.LeaveTypeID = (int)row[dataColumn];
			// Column "LeaveDays"
			dataColumn = dataTable.Columns["LeaveDays"];
			if(!row.IsNull(dataColumn))
				mappedObject.LeaveDays = (int)row[dataColumn];
			// Column "Active"
			dataColumn = dataTable.Columns["Active"];
			if(!row.IsNull(dataColumn))
				mappedObject.Active = (bool)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>lkpLeave</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "lkpLeave";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Leave_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("ContractType_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("LeaveTypeID", typeof(int));
			dataColumn = dataTable.Columns.Add("LeaveDays", typeof(int));
			dataColumn = dataTable.Columns.Add("Active", typeof(bool));
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
				case "Leave_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "ContractType_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "LeaveTypeID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "LeaveDays":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Active":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of lkpLeaveCollection_Base class
}  // End of namespace
