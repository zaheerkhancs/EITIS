// <fileinfo name="tblStaffCollection_Base.cs">
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
	/// The base class for <see cref="tblStaffCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblStaffCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaffCollection_Base
	{
		// Constants
		public const string StaffIDColumnName = "StaffID";
		public const string LastNameColumnName = "LastName";
		public const string FirstNameColumnName = "FirstName";
		public const string MiddleNameColumnName = "MiddleName";
		public const string BirthDateColumnName = "BirthDate";
		public const string Id_NoColumnName = "Id_No";
		public const string Department_IDColumnName = "Department_ID";
		public const string HomeAddress1ColumnName = "HomeAddress1";
		public const string HomeAddress2ColumnName = "HomeAddress2";
		public const string Country_IDColumnName = "Country_ID";
		public const string Contact_KabulColumnName = "Contact_Kabul";
		public const string Contact_PersonalColumnName = "Contact_Personal";
		public const string EmailColumnName = "Email";
		public const string Email_PersonalColumnName = "Email_Personal";
		public const string IsDeletedColumnName = "isDeleted";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_DateColumnName = "Created_Date";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_DateColumnName = "Updated_Date";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaffCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblStaffCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblStaff</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		public virtual tblStaffRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblStaff</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblStaff</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblStaff_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblStaffRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblStaffRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblStaffRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblStaffRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaffRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		public tblStaffRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblStaffRow"/> objects that 
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
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		public virtual tblStaffRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblStaff]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblStaffRow"/> by the primary key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>An instance of <see cref="tblStaffRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblStaffRow GetByPrimaryKey(int staffID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_GetByPrimaryKey", true);
			AddParameter(cmd, "StaffID", staffID);
			tblStaffRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>tblStaff</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaffRow"/> object to be inserted.</param>
		public virtual void Insert(tblStaffRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Insert", true);
			AddParameter(cmd, "LastName", value.LastName);
			AddParameter(cmd, "FirstName", value.FirstName);
			AddParameter(cmd, "MiddleName", value.MiddleName);
			AddParameter(cmd, "BirthDate",
				value.IsBirthDateNull ? DBNull.Value : (object)value.BirthDate);
			AddParameter(cmd, "Id_No", value.Id_No);
			AddParameter(cmd, "Department_ID",
				value.IsDepartment_IDNull ? DBNull.Value : (object)value.Department_ID);
			AddParameter(cmd, "HomeAddress1", value.HomeAddress1);
			AddParameter(cmd, "HomeAddress2", value.HomeAddress2);
			AddParameter(cmd, "Country_ID",
				value.IsCountry_IDNull ? DBNull.Value : (object)value.Country_ID);
			AddParameter(cmd, "Contact_Kabul", value.Contact_Kabul);
			AddParameter(cmd, "Contact_Personal", value.Contact_Personal);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Email_Personal", value.Email_Personal);
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
			value.StaffID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblStaff</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaffRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblStaffRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_Update", true);
			AddParameter(cmd, "LastName", value.LastName);
			AddParameter(cmd, "FirstName", value.FirstName);
			AddParameter(cmd, "MiddleName", value.MiddleName);
			AddParameter(cmd, "BirthDate",
				value.IsBirthDateNull ? DBNull.Value : (object)value.BirthDate);
			AddParameter(cmd, "Id_No", value.Id_No);
			AddParameter(cmd, "Department_ID",
				value.IsDepartment_IDNull ? DBNull.Value : (object)value.Department_ID);
			AddParameter(cmd, "HomeAddress1", value.HomeAddress1);
			AddParameter(cmd, "HomeAddress2", value.HomeAddress2);
			AddParameter(cmd, "Country_ID",
				value.IsCountry_IDNull ? DBNull.Value : (object)value.Country_ID);
			AddParameter(cmd, "Contact_Kabul", value.Contact_Kabul);
			AddParameter(cmd, "Contact_Personal", value.Contact_Personal);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Email_Personal", value.Email_Personal);
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
			AddParameter(cmd, "StaffID", value.StaffID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblStaff</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblStaff</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["StaffID"]);
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
		/// Deletes the specified object from the <c>tblStaff</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblStaffRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblStaffRow value)
		{
			return DeleteByPrimaryKey(value.StaffID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblStaff</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="staffID">The <c>StaffID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int staffID)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblStaff_DeleteByPrimaryKey", true);
			AddParameter(cmd, "StaffID", staffID);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>tblStaff</c> records that match the specified criteria.
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
		/// to delete <c>tblStaff</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblStaff]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblStaff</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblStaff_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		protected tblStaffRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		protected tblStaffRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblStaffRow"/> objects.</returns>
		protected virtual tblStaffRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int staffIDColumnIndex = reader.GetOrdinal("StaffID");
			int lastNameColumnIndex = reader.GetOrdinal("LastName");
			int firstNameColumnIndex = reader.GetOrdinal("FirstName");
			int middleNameColumnIndex = reader.GetOrdinal("MiddleName");
			int birthDateColumnIndex = reader.GetOrdinal("BirthDate");
			int id_NoColumnIndex = reader.GetOrdinal("Id_No");
			int department_IDColumnIndex = reader.GetOrdinal("Department_ID");
			int homeAddress1ColumnIndex = reader.GetOrdinal("HomeAddress1");
			int homeAddress2ColumnIndex = reader.GetOrdinal("HomeAddress2");
			int country_IDColumnIndex = reader.GetOrdinal("Country_ID");
			int contact_KabulColumnIndex = reader.GetOrdinal("Contact_Kabul");
			int contact_PersonalColumnIndex = reader.GetOrdinal("Contact_Personal");
			int emailColumnIndex = reader.GetOrdinal("Email");
			int email_PersonalColumnIndex = reader.GetOrdinal("Email_Personal");
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
					tblStaffRow record = new tblStaffRow();
					recordList.Add(record);

					record.StaffID = Convert.ToInt32(reader.GetValue(staffIDColumnIndex));
					if(!reader.IsDBNull(lastNameColumnIndex))
						record.LastName = Convert.ToString(reader.GetValue(lastNameColumnIndex));
					if(!reader.IsDBNull(firstNameColumnIndex))
						record.FirstName = Convert.ToString(reader.GetValue(firstNameColumnIndex));
					if(!reader.IsDBNull(middleNameColumnIndex))
						record.MiddleName = Convert.ToString(reader.GetValue(middleNameColumnIndex));
					if(!reader.IsDBNull(birthDateColumnIndex))
						record.BirthDate = Convert.ToDateTime(reader.GetValue(birthDateColumnIndex));
					if(!reader.IsDBNull(id_NoColumnIndex))
						record.Id_No = Convert.ToString(reader.GetValue(id_NoColumnIndex));
					if(!reader.IsDBNull(department_IDColumnIndex))
						record.Department_ID = Convert.ToInt32(reader.GetValue(department_IDColumnIndex));
					if(!reader.IsDBNull(homeAddress1ColumnIndex))
						record.HomeAddress1 = Convert.ToString(reader.GetValue(homeAddress1ColumnIndex));
					if(!reader.IsDBNull(homeAddress2ColumnIndex))
						record.HomeAddress2 = Convert.ToString(reader.GetValue(homeAddress2ColumnIndex));
					if(!reader.IsDBNull(country_IDColumnIndex))
						record.Country_ID = Convert.ToInt32(reader.GetValue(country_IDColumnIndex));
					if(!reader.IsDBNull(contact_KabulColumnIndex))
						record.Contact_Kabul = Convert.ToString(reader.GetValue(contact_KabulColumnIndex));
					if(!reader.IsDBNull(contact_PersonalColumnIndex))
						record.Contact_Personal = Convert.ToString(reader.GetValue(contact_PersonalColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(email_PersonalColumnIndex))
						record.Email_Personal = Convert.ToString(reader.GetValue(email_PersonalColumnIndex));
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
			return (tblStaffRow[])(recordList.ToArray(typeof(tblStaffRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblStaffRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblStaffRow"/> object.</returns>
		protected virtual tblStaffRow MapRow(DataRow row)
		{
			tblStaffRow mappedObject = new tblStaffRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "StaffID"
			dataColumn = dataTable.Columns["StaffID"];
			if(!row.IsNull(dataColumn))
				mappedObject.StaffID = (int)row[dataColumn];
			// Column "LastName"
			dataColumn = dataTable.Columns["LastName"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastName = (string)row[dataColumn];
			// Column "FirstName"
			dataColumn = dataTable.Columns["FirstName"];
			if(!row.IsNull(dataColumn))
				mappedObject.FirstName = (string)row[dataColumn];
			// Column "MiddleName"
			dataColumn = dataTable.Columns["MiddleName"];
			if(!row.IsNull(dataColumn))
				mappedObject.MiddleName = (string)row[dataColumn];
			// Column "BirthDate"
			dataColumn = dataTable.Columns["BirthDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.BirthDate = (System.DateTime)row[dataColumn];
			// Column "Id_No"
			dataColumn = dataTable.Columns["Id_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Id_No = (string)row[dataColumn];
			// Column "Department_ID"
			dataColumn = dataTable.Columns["Department_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Department_ID = (int)row[dataColumn];
			// Column "HomeAddress1"
			dataColumn = dataTable.Columns["HomeAddress1"];
			if(!row.IsNull(dataColumn))
				mappedObject.HomeAddress1 = (string)row[dataColumn];
			// Column "HomeAddress2"
			dataColumn = dataTable.Columns["HomeAddress2"];
			if(!row.IsNull(dataColumn))
				mappedObject.HomeAddress2 = (string)row[dataColumn];
			// Column "Country_ID"
			dataColumn = dataTable.Columns["Country_ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.Country_ID = (int)row[dataColumn];
			// Column "Contact_Kabul"
			dataColumn = dataTable.Columns["Contact_Kabul"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contact_Kabul = (string)row[dataColumn];
			// Column "Contact_Personal"
			dataColumn = dataTable.Columns["Contact_Personal"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contact_Personal = (string)row[dataColumn];
			// Column "Email"
			dataColumn = dataTable.Columns["Email"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email = (string)row[dataColumn];
			// Column "Email_Personal"
			dataColumn = dataTable.Columns["Email_Personal"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email_Personal = (string)row[dataColumn];
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
		/// the <c>tblStaff</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblStaff";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("StaffID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("LastName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("FirstName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("MiddleName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("BirthDate", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Id_No", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Department_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("HomeAddress1", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("HomeAddress2", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Country_ID", typeof(int));
			dataColumn = dataTable.Columns.Add("Contact_Kabul", typeof(string));
			dataColumn.MaxLength = 12;
			dataColumn = dataTable.Columns.Add("Contact_Personal", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn = dataTable.Columns.Add("Email", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn = dataTable.Columns.Add("Email_Personal", typeof(string));
			dataColumn.MaxLength = 20;
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
				case "StaffID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "LastName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "FirstName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "MiddleName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "BirthDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Id_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Department_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "HomeAddress1":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "HomeAddress2":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Country_ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Contact_Kabul":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Contact_Personal":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Email":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Email_Personal":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
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
	} // End of tblStaffCollection_Base class
}  // End of namespace
