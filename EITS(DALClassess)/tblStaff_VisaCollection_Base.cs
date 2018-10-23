// <fileinfo name="tblStaff_VisaCollection_Base.cs">
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
	/// The base class for <see cref="tblStaff_VisaCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblStaff_VisaCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_VisaCollection_Base
	{
		// Constants
		public const string Visa_IDColumnName = "Visa_ID";
		public const string PassportIDColumnName = "PassportID";
		public const string Visa_NoColumnName = "Visa_No";
		public const string Date_GivenColumnName = "Date_Given";
		public const string Valid_DateColumnName = "Valid_Date";
		public const string VisaType_IDColumnName = "VisaType_ID";
		public const string IsDeletedColumnName = "isDeleted";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_DateColumnName = "Created_Date";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_DateColumnName = "Updated_Date";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_VisaCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblStaff_VisaCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		public virtual tblStaff_VisaRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblStaff_Visa_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblStaff_VisaRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblStaff_VisaRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblStaff_VisaRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblStaff_VisaRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_VisaRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		public tblStaff_VisaRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_VisaRow"/> objects that 
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
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		public virtual tblStaff_VisaRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblStaff_Visa]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblStaff_VisaRow"/> by the primary key.
		/// </summary>
		/// <param name="visa_ID">The <c>Visa_ID</c> column value.</param>
		/// <returns>An instance of <see cref="tblStaff_VisaRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblStaff_VisaRow GetByPrimaryKey(int visa_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_GetByPrimaryKey", true);
			AddParameter(cmd, "Visa_ID", visa_ID);
			tblStaff_VisaRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_VisaRow"/> objects 
		/// by the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		public tblStaff_VisaRow[] GetByPassportID(int passportID)
		{
			return GetByPassportID(passportID, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaff_VisaRow"/> objects 
		/// by the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <param name="passportIDNull">true if the method ignores the passportID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		public virtual tblStaff_VisaRow[] GetByPassportID(int passportID, bool passportIDNull)
		{
			return MapRecords(CreateGetByPassportIDCommand(passportID, passportIDNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByPassportIDAsDataTable(int passportID)
		{
			return GetByPassportIDAsDataTable(passportID, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <param name="passportIDNull">true if the method ignores the passportID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByPassportIDAsDataTable(int passportID, bool passportIDNull)
		{
			return MapRecordsToDataTable(CreateGetByPassportIDCommand(passportID, passportIDNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <param name="passportIDNull">true if the method ignores the passportID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByPassportIDCommand(int passportID, bool passportIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_GetBy_PassportID", true);
			AddParameter(cmd, "PassportID", passportIDNull ? null : (object)passportID);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_VisaRow"/> object to be inserted.</param>
		public virtual void Insert(tblStaff_VisaRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_Insert", true);
			AddParameter(cmd, "PassportID",
				value.IsPassportIDNull ? DBNull.Value : (object)value.PassportID);
			AddParameter(cmd, "Visa_No", value.Visa_No);
			AddParameter(cmd, "Date_Given",
				value.IsDate_GivenNull ? DBNull.Value : (object)value.Date_Given);
			AddParameter(cmd, "Valid_Date",
				value.IsValid_DateNull ? DBNull.Value : (object)value.Valid_Date);
			AddParameter(cmd, "VisaType_ID",
				value.IsVisaType_IDNull ? DBNull.Value : (object)value.VisaType_ID);
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
			value.Visa_ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_VisaRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblStaff_VisaRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_Update", true);
			AddParameter(cmd, "PassportID",
				value.IsPassportIDNull ? DBNull.Value : (object)value.PassportID);
			AddParameter(cmd, "Visa_No", value.Visa_No);
			AddParameter(cmd, "Date_Given",
				value.IsDate_GivenNull ? DBNull.Value : (object)value.Date_Given);
			AddParameter(cmd, "Valid_Date",
				value.IsValid_DateNull ? DBNull.Value : (object)value.Valid_Date);
			AddParameter(cmd, "VisaType_ID",
				value.IsVisaType_IDNull ? DBNull.Value : (object)value.VisaType_ID);
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
			AddParameter(cmd, "Visa_ID", value.Visa_ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblStaff_Visa</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblStaff_Visa</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Visa_ID"]);
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
		/// Deletes the specified object from the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaff_VisaRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblStaff_VisaRow value)
		{
			return DeleteByPrimaryKey(value.Visa_ID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblStaff_Visa</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="visa_ID">The <c>Visa_ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int visa_ID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Visa_ID", visa_ID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_Visa</c> table using the 
		/// <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByPassportID(int passportID)
		{
			return DeleteByPassportID(passportID, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblStaff_Visa</c> table using the 
		/// <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <param name="passportIDNull">true if the method ignores the passportID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByPassportID(int passportID, bool passportIDNull)
		{
			return CreateDeleteByPassportIDCommand(passportID, passportIDNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblStaff_Visa_tblStaff_Passport</c> foreign key.
		/// </summary>
		/// <param name="passportID">The <c>PassportID</c> column value.</param>
		/// <param name="passportIDNull">true if the method ignores the passportID
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByPassportIDCommand(int passportID, bool passportIDNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Visa_DeleteBy_PassportID", true);
			AddParameter(cmd, "PassportID", passportIDNull ? null : (object)passportID);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblStaff_Visa</c> records that match the specified criteria.
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
		/// to delete <c>tblStaff_Visa</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblStaff_Visa]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblStaff_Visa_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		protected tblStaff_VisaRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		protected tblStaff_VisaRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblStaff_VisaRow"/> objects.</returns>
		protected virtual tblStaff_VisaRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int visa_IDColumnIndex = reader.GetOrdinal("Visa_ID");
			int passportIDColumnIndex = reader.GetOrdinal("PassportID");
			int visa_NoColumnIndex = reader.GetOrdinal("Visa_No");
			int date_GivenColumnIndex = reader.GetOrdinal("Date_Given");
			int valid_DateColumnIndex = reader.GetOrdinal("Valid_Date");
			int visaType_IDColumnIndex = reader.GetOrdinal("VisaType_ID");
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
					tblStaff_VisaRow record = new tblStaff_VisaRow();
					recordList.Add(record);

					record.Visa_ID = Convert.ToInt32(reader.GetValue(visa_IDColumnIndex));
					if(!reader.IsDBNull(passportIDColumnIndex))
						record.PassportID = Convert.ToInt32(reader.GetValue(passportIDColumnIndex));
					if(!reader.IsDBNull(visa_NoColumnIndex))
						record.Visa_No = Convert.ToString(reader.GetValue(visa_NoColumnIndex));
					if(!reader.IsDBNull(date_GivenColumnIndex))
						record.Date_Given = Convert.ToDateTime(reader.GetValue(date_GivenColumnIndex));
					if(!reader.IsDBNull(valid_DateColumnIndex))
						record.Valid_Date = Convert.ToDateTime(reader.GetValue(valid_DateColumnIndex));
					if(!reader.IsDBNull(visaType_IDColumnIndex))
						record.VisaType_ID = Convert.ToInt32(reader.GetValue(visaType_IDColumnIndex));
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
			return (tblStaff_VisaRow[])(recordList.ToArray(typeof(tblStaff_VisaRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblStaff_VisaRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblStaff_VisaRow"/> object.</returns>
		protected virtual tblStaff_VisaRow MapRow(DataRow row)
		{
			tblStaff_VisaRow mappedObject = new tblStaff_VisaRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Visa_ID"
			dataColumn = dataTable.Columns["Visa_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Visa_ID = (int)row[dataColumn];
			// Column "PassportID"
			dataColumn = dataTable.Columns["PassportID"];
			if(!row.IsNull(dataColumn))
				mappedObject.PassportID = (int)row[dataColumn];
			// Column "Visa_No"
			dataColumn = dataTable.Columns["Visa_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Visa_No = (string)row[dataColumn];
			// Column "Date_Given"
			dataColumn = dataTable.Columns["Date_Given"];
			if(!row.IsNull(dataColumn))
				mappedObject.Date_Given = (System.DateTime)row[dataColumn];
			// Column "Valid_Date"
			dataColumn = dataTable.Columns["Valid_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Valid_Date = (System.DateTime)row[dataColumn];
			// Column "VisaType_ID"
			dataColumn = dataTable.Columns["VisaType_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.VisaType_ID = (int)row[dataColumn];
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
		/// the <c>tblStaff_Visa</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblStaff_Visa";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Visa_ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("PassportID", typeof(int));
			dataColumn = dataTable.Columns.Add("Visa_No", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Date_Given", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Valid_Date", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("VisaType_ID", typeof(int));
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
				case "Visa_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "PassportID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Visa_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Date_Given":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Valid_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "VisaType_ID":
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
	} // End of tblStaff_VisaCollection_Base class
}  // End of namespace
