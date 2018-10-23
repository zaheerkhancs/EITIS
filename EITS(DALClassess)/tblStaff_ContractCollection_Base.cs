// <fileinfo name="tblStaff_ContractCollection_Base.cs">
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
	/// The base class for <see cref="tblStaff_ContractCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblStaff_ContractCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_ContractCollection_Base
	{
		// Constants
		public const string Contract_IDColumnName = "Contract_ID";
		public const string StaffIDColumnName = "StaffID";
		public const string JobTitleColumnName = "JobTitle";
		public const string Contract_CodeColumnName = "Contract_Code";
		public const string Con_SDateColumnName = "Con_SDate";
		public const string Con_EDateColumnName = "Con_EDate";
		public const string ContractType_IDColumnName = "ContractType_ID";
		public const string ContractStatus_IDColumnName = "ContractStatus_ID";
		public const string DutyStation_IDColumnName = "DutyStation_ID";
		public const string IsDeletedColumnName = "isDeleted";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_DateColumnName = "Created_Date";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_DateColumnName = "Updated_Date";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_ContractCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblStaff_ContractCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		public virtual tblStaff_ContractRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblStaff_Contract_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblStaff_ContractRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblStaff_ContractRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblStaff_ContractRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblStaff_ContractRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_ContractRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		public tblStaff_ContractRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_ContractRow"/> objects that 
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
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		public virtual tblStaff_ContractRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblStaff_Contract]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblStaff_ContractRow"/> by the primary key.
		/// </summary>
		/// <param name="contract_ID">The <c>Contract_ID</c> column value.</param>
		/// <returns>An instance of <see cref="tblStaff_ContractRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblStaff_ContractRow GetByPrimaryKey(int contract_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_GetByPrimaryKey", true);
			AddParameter(cmd, "Contract_ID", contract_ID);
			tblStaff_ContractRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_ContractRow"/> objects 
		/// by the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		public tblStaff_ContractRow[] GetByStaffID(int staffID)
		{
			return GetByStaffID(staffID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_ContractRow"/> objects 
		/// by the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		public virtual tblStaff_ContractRow[] GetByStaffID(int staffID, bool staffIDNull)
		{
			return MapRecords(CreateGetByStaffIDCommand(staffID, staffIDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByStaffIDAsDataTable(int staffID)
		{
			return GetByStaffIDAsDataTable(staffID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
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
		/// return records by the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_GetBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_ContractRow"/> object to be inserted.</param>
		public virtual void Insert(tblStaff_ContractRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_Insert", true);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "JobTitle", value.JobTitle);
			AddParameter(cmd, "Contract_Code", value.Contract_Code);
			AddParameter(cmd, "Con_SDate",
				value.IsCon_SDateNull ? DBNull.Value : (object)value.Con_SDate);
			AddParameter(cmd, "Con_EDate",
				value.IsCon_EDateNull ? DBNull.Value : (object)value.Con_EDate);
			AddParameter(cmd, "ContractType_ID",
				value.IsContractType_IDNull ? DBNull.Value : (object)value.ContractType_ID);
			AddParameter(cmd, "ContractStatus_ID",
				value.IsContractStatus_IDNull ? DBNull.Value : (object)value.ContractStatus_ID);
			AddParameter(cmd, "DutyStation_ID",
				value.IsDutyStation_IDNull ? DBNull.Value : (object)value.DutyStation_ID);
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
			value.Contract_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_ContractRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblStaff_ContractRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_Update", true);
			AddParameter(cmd, "StaffID",
				value.IsStaffIDNull ? DBNull.Value : (object)value.StaffID);
			AddParameter(cmd, "JobTitle", value.JobTitle);
			AddParameter(cmd, "Contract_Code", value.Contract_Code);
			AddParameter(cmd, "Con_SDate",
				value.IsCon_SDateNull ? DBNull.Value : (object)value.Con_SDate);
			AddParameter(cmd, "Con_EDate",
				value.IsCon_EDateNull ? DBNull.Value : (object)value.Con_EDate);
			AddParameter(cmd, "ContractType_ID",
				value.IsContractType_IDNull ? DBNull.Value : (object)value.ContractType_ID);
			AddParameter(cmd, "ContractStatus_ID",
				value.IsContractStatus_IDNull ? DBNull.Value : (object)value.ContractStatus_ID);
			AddParameter(cmd, "DutyStation_ID",
				value.IsDutyStation_IDNull ? DBNull.Value : (object)value.DutyStation_ID);
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
			AddParameter(cmd, "Contract_ID", value.Contract_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblStaff_Contract</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblStaff_Contract</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Contract_ID"]);
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
		/// Deletes the specified object from the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_ContractRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblStaff_ContractRow value)
		{
			return DeleteByPrimaryKey(value.Contract_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblStaff_Contract</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="contract_ID">The <c>Contract_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int contract_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Contract_ID", contract_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_Contract</c> table using the 
		/// <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByStaffID(int staffID)
		{
			return DeleteByStaffID(staffID, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_Contract</c> table using the 
		/// <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
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
		/// delete records using the <c>FK_tblStaff_Contract_tblStaff</c> foreign key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <param name="staffIDNull">true if the method ignores the staffID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByStaffIDCommand(int staffID, bool staffIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Contract_DeleteBy_StaffID", true);
			AddParameter(cmd, "StaffID", staffIDNull ? null : (object)staffID);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblStaff_Contract</c> records that match the specified criteria.
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
		/// to delete <c>tblStaff_Contract</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblStaff_Contract]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblStaff_Contract_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		protected tblStaff_ContractRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		protected tblStaff_ContractRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblStaff_ContractRow"/> objects.</returns>
		protected virtual tblStaff_ContractRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int contract_IDColumnIndex = reader.GetOrdinal("Contract_ID");
			int staffIDColumnIndex = reader.GetOrdinal("StaffID");
			int jobTitleColumnIndex = reader.GetOrdinal("JobTitle");
			int contract_CodeColumnIndex = reader.GetOrdinal("Contract_Code");
			int con_SDateColumnIndex = reader.GetOrdinal("Con_SDate");
			int con_EDateColumnIndex = reader.GetOrdinal("Con_EDate");
			int contractType_IDColumnIndex = reader.GetOrdinal("ContractType_ID");
			int contractStatus_IDColumnIndex = reader.GetOrdinal("ContractStatus_ID");
			int dutyStation_IDColumnIndex = reader.GetOrdinal("DutyStation_ID");
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
					tblStaff_ContractRow record = new tblStaff_ContractRow();
					recordList.Add(record);

					record.Contract_ID = Convert.ToInt32(reader.GetValue(contract_IDColumnIndex));
					if(!reader.IsDBNull(staffIDColumnIndex))
						record.StaffID = Convert.ToInt32(reader.GetValue(staffIDColumnIndex));
					if(!reader.IsDBNull(jobTitleColumnIndex))
						record.JobTitle = Convert.ToString(reader.GetValue(jobTitleColumnIndex));
					if(!reader.IsDBNull(contract_CodeColumnIndex))
						record.Contract_Code = Convert.ToString(reader.GetValue(contract_CodeColumnIndex));
					if(!reader.IsDBNull(con_SDateColumnIndex))
						record.Con_SDate = Convert.ToDateTime(reader.GetValue(con_SDateColumnIndex));
					if(!reader.IsDBNull(con_EDateColumnIndex))
						record.Con_EDate = Convert.ToDateTime(reader.GetValue(con_EDateColumnIndex));
					if(!reader.IsDBNull(contractType_IDColumnIndex))
						record.ContractType_ID = Convert.ToInt32(reader.GetValue(contractType_IDColumnIndex));
					if(!reader.IsDBNull(contractStatus_IDColumnIndex))
						record.ContractStatus_ID = Convert.ToInt32(reader.GetValue(contractStatus_IDColumnIndex));
					if(!reader.IsDBNull(dutyStation_IDColumnIndex))
						record.DutyStation_ID = Convert.ToInt32(reader.GetValue(dutyStation_IDColumnIndex));
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
			return (tblStaff_ContractRow[])(recordList.ToArray(typeof(tblStaff_ContractRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblStaff_ContractRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblStaff_ContractRow"/> object.</returns>
		protected virtual tblStaff_ContractRow MapRow(DataRow row)
		{
			tblStaff_ContractRow mappedObject = new tblStaff_ContractRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Contract_ID"
			dataColumn = dataTable.Columns["Contract_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contract_ID = (int)row[dataColumn];
			// Column "StaffID"
			dataColumn = dataTable.Columns["StaffID"];
			if(!row.IsNull(dataColumn))
				mappedObject.StaffID = (int)row[dataColumn];
			// Column "JobTitle"
			dataColumn = dataTable.Columns["JobTitle"];
			if(!row.IsNull(dataColumn))
				mappedObject.JobTitle = (string)row[dataColumn];
			// Column "Contract_Code"
			dataColumn = dataTable.Columns["Contract_Code"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contract_Code = (string)row[dataColumn];
			// Column "Con_SDate"
			dataColumn = dataTable.Columns["Con_SDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.Con_SDate = (System.DateTime)row[dataColumn];
			// Column "Con_EDate"
			dataColumn = dataTable.Columns["Con_EDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.Con_EDate = (System.DateTime)row[dataColumn];
			// Column "ContractType_ID"
			dataColumn = dataTable.Columns["ContractType_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ContractType_ID = (int)row[dataColumn];
			// Column "ContractStatus_ID"
			dataColumn = dataTable.Columns["ContractStatus_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ContractStatus_ID = (int)row[dataColumn];
			// Column "DutyStation_ID"
			dataColumn = dataTable.Columns["DutyStation_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.DutyStation_ID = (int)row[dataColumn];
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
		/// the <c>tblStaff_Contract</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblStaff_Contract";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Contract_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("StaffID", typeof(int));
			dataColumn = dataTable.Columns.Add("JobTitle", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Contract_Code", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Con_SDate", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Con_EDate", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("ContractType_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("ContractStatus_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("DutyStation_ID", typeof(int));
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
				case "Contract_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "StaffID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "JobTitle":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Contract_Code":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Con_SDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Con_EDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "ContractType_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "ContractStatus_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "DutyStation_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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
	} // End of tblStaff_ContractCollection_Base class
}  // End of namespace
