// <fileinfo name="tblStaff_LeaveAvailableCollection_Base.cs">
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
	/// The base class for <see cref="tblStaff_LeaveAvailableCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblStaff_LeaveAvailableCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_LeaveAvailableCollection_Base
	{
		// Constants
		public const string LeaveAvailable_IDColumnName = "LeaveAvailable_ID";
		public const string StaffIDColumnName = "StaffID";
		public const string LeaveAvailableColumnName = "LeaveAvailable";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_LeaveAvailableCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblStaff_LeaveAvailableCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		public virtual tblStaff_LeaveAvailableRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblStaff_LeaveAvailable_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblStaff_LeaveAvailableRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblStaff_LeaveAvailableRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblStaff_LeaveAvailableRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblStaff_LeaveAvailableRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveAvailableRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		public tblStaff_LeaveAvailableRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveAvailableRow"/> objects that 
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
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		public virtual tblStaff_LeaveAvailableRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblStaff_LeaveAvailable]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblStaff_LeaveAvailableRow"/> by the primary key.
		/// </summary>
		/// <param name="leaveAvailable_ID">The <c>LeaveAvailable_ID</c> column value.</param>
		/// <returns>An instance of <see cref="tblStaff_LeaveAvailableRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblStaff_LeaveAvailableRow GetByPrimaryKey(int leaveAvailable_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_GetByPrimaryKey", true);
			AddParameter(cmd, "LeaveAvailable_ID", leaveAvailable_ID);
			tblStaff_LeaveAvailableRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveAvailableRow"/> objects 
		/// by the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		public tblStaff_LeaveAvailableRow[] GetByStaffID(int staffID)
		{
			return GetByStaffID(staffID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_LeaveAvailableRow"/> objects 
		/// by the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		public virtual tblStaff_LeaveAvailableRow[] GetByStaffID(int staffID, bool staffIDNull)
		{
			return MapRecords(CreateGetByStaffIDCommand(staffID, staffIDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByStaffIDAsDataTable(int staffID)
		{
			return GetByStaffIDAsDataTable(staffID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
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
		/// return records by the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_GetBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveAvailableRow"/> object to be inserted.</param>
		public virtual void Insert(tblStaff_LeaveAvailableRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_Insert", true);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "LeaveAvailable",
				value.IsLeaveAvailableNull ? DBNull.Value : (object)value.LeaveAvailable);
			value.LeaveAvailable_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveAvailableRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblStaff_LeaveAvailableRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_Update", true);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "LeaveAvailable",
				value.IsLeaveAvailableNull ? DBNull.Value : (object)value.LeaveAvailable);
			AddParameter(cmd, "LeaveAvailable_ID", value.LeaveAvailable_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblStaff_LeaveAvailable</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblStaff_LeaveAvailable</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["LeaveAvailable_ID"]);
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
		/// Deletes the specified object from the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_LeaveAvailableRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblStaff_LeaveAvailableRow value)
		{
			return DeleteByPrimaryKey(value.LeaveAvailable_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblStaff_LeaveAvailable</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="leaveAvailable_ID">The <c>LeaveAvailable_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int leaveAvailable_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_DeleteByPrimaryKey", true);
			AddParameter(cmd, "LeaveAvailable_ID", leaveAvailable_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_LeaveAvailable</c> table using the 
		/// <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByStaffID(int staffID)
		{
			return DeleteByStaffID(staffID, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_LeaveAvailable</c> table using the 
		/// <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
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
		/// delete records using the <c>FK_tblStaff_LeaveAvailable_tblStaff1</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_LeaveAvailable_DeleteBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblStaff_LeaveAvailable</c> records that match the specified criteria.
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
		/// to delete <c>tblStaff_LeaveAvailable</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblStaff_LeaveAvailable]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblStaff_LeaveAvailable_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		protected tblStaff_LeaveAvailableRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		protected tblStaff_LeaveAvailableRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblStaff_LeaveAvailableRow"/> objects.</returns>
		protected virtual tblStaff_LeaveAvailableRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int leaveAvailable_IDColumnIndex = reader.GetOrdinal("LeaveAvailable_ID");
			int staffIDColumnIndex = reader.GetOrdinal("StaffID");
			int leaveAvailableColumnIndex = reader.GetOrdinal("LeaveAvailable");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblStaff_LeaveAvailableRow record = new tblStaff_LeaveAvailableRow();
					recordList.Add(record);

					record.LeaveAvailable_ID = Convert.ToInt32(reader.GetValue(leaveAvailable_IDColumnIndex));
					if(!reader.IsDBNull(staffIDColumnIndex))
						record.StaffID = Convert.ToInt32(reader.GetValue(staffIDColumnIndex));
					if(!reader.IsDBNull(leaveAvailableColumnIndex))
						record.LeaveAvailable = Convert.ToInt32(reader.GetValue(leaveAvailableColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblStaff_LeaveAvailableRow[])(recordList.ToArray(typeof(tblStaff_LeaveAvailableRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblStaff_LeaveAvailableRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblStaff_LeaveAvailableRow"/> object.</returns>
		protected virtual tblStaff_LeaveAvailableRow MapRow(DataRow row)
		{
			tblStaff_LeaveAvailableRow mappedObject = new tblStaff_LeaveAvailableRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "LeaveAvailable_ID"
			dataColumn = dataTable.Columns["LeaveAvailable_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.LeaveAvailable_ID = (int)row[dataColumn];
			// Column "StaffID"
			dataColumn = dataTable.Columns["StaffID"];
			if(!row.IsNull(dataColumn))
				mappedObject.StaffID = (int)row[dataColumn];
			// Column "LeaveAvailable"
			dataColumn = dataTable.Columns["LeaveAvailable"];
			if(!row.IsNull(dataColumn))
				mappedObject.LeaveAvailable = (int)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblStaff_LeaveAvailable</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblStaff_LeaveAvailable";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("LeaveAvailable_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("StaffID", typeof(int));
			dataColumn = dataTable.Columns.Add("LeaveAvailable", typeof(int));
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
				case "LeaveAvailable_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "StaffID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "LeaveAvailable":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblStaff_LeaveAvailableCollection_Base class
}  // End of namespace
