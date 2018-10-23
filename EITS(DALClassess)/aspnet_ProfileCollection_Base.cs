// <fileinfo name="aspnet_ProfileCollection_Base.cs">
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
	/// The base class for <see cref="aspnet_ProfileCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="aspnet_ProfileCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_ProfileCollection_Base
	{
		// Constants
		public const string UserIdColumnName = "UserId";
		public const string PropertyNamesColumnName = "PropertyNames";
		public const string PropertyValuesStringColumnName = "PropertyValuesString";
		public const string PropertyValuesBinaryColumnName = "PropertyValuesBinary";
		public const string LastUpdatedDateColumnName = "LastUpdatedDate";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_ProfileCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public aspnet_ProfileCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		public virtual aspnet_ProfileRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._aspnet_Profile_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="aspnet_ProfileRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="aspnet_ProfileRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public aspnet_ProfileRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			aspnet_ProfileRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_ProfileRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		public aspnet_ProfileRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_ProfileRow"/> objects that 
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
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		public virtual aspnet_ProfileRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[aspnet_Profile]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="aspnet_ProfileRow"/> by the primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An instance of <see cref="aspnet_ProfileRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual aspnet_ProfileRow GetByPrimaryKey(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_GetByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			aspnet_ProfileRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_ProfileRow"/> objects 
		/// by the <c>FK__aspnet_Pr__UserI__7B5B524B</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		public virtual aspnet_ProfileRow[] GetByUserId(System.Guid userId)
		{
			return MapRecords(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Pr__UserI__7B5B524B</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByUserIdAsDataTable(System.Guid userId)
		{
			return MapRecordsToDataTable(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Pr__UserI__7B5B524B</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_GetBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_ProfileRow"/> object to be inserted.</param>
		public virtual void Insert(aspnet_ProfileRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_Insert", true);
			AddParameter(cmd, "UserId", value.UserId);
			AddParameter(cmd, "PropertyNames", value.PropertyNames);
			AddParameter(cmd, "PropertyValuesString", value.PropertyValuesString);
			AddParameter(cmd, "PropertyValuesBinary", value.PropertyValuesBinary);
			AddParameter(cmd, "LastUpdatedDate", value.LastUpdatedDate);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_ProfileRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(aspnet_ProfileRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_Update", true);
			AddParameter(cmd, "PropertyNames", value.PropertyNames);
			AddParameter(cmd, "PropertyValuesString", value.PropertyValuesString);
			AddParameter(cmd, "PropertyValuesBinary", value.PropertyValuesBinary);
			AddParameter(cmd, "LastUpdatedDate", value.LastUpdatedDate);
			AddParameter(cmd, "UserId", value.UserId);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>aspnet_Profile</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>aspnet_Profile</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
		/// Deletes the specified object from the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_ProfileRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(aspnet_ProfileRow value)
		{
			return DeleteByPrimaryKey(value.UserId);
		}

		/// <summary>
		/// Deletes a record from the <c>aspnet_Profile</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_DeleteByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_Profile</c> table using the 
		/// <c>FK__aspnet_Pr__UserI__7B5B524B</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByUserId(System.Guid userId)
		{
			return CreateDeleteByUserIdCommand(userId).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Pr__UserI__7B5B524B</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_Profile_DeleteBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>aspnet_Profile</c> records that match the specified criteria.
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
		/// to delete <c>aspnet_Profile</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[aspnet_Profile]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._aspnet_Profile_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		protected aspnet_ProfileRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		protected aspnet_ProfileRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="aspnet_ProfileRow"/> objects.</returns>
		protected virtual aspnet_ProfileRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int userIdColumnIndex = reader.GetOrdinal("UserId");
			int propertyNamesColumnIndex = reader.GetOrdinal("PropertyNames");
			int propertyValuesStringColumnIndex = reader.GetOrdinal("PropertyValuesString");
			int propertyValuesBinaryColumnIndex = reader.GetOrdinal("PropertyValuesBinary");
			int lastUpdatedDateColumnIndex = reader.GetOrdinal("LastUpdatedDate");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					aspnet_ProfileRow record = new aspnet_ProfileRow();
					recordList.Add(record);

					record.UserId = reader.GetGuid(userIdColumnIndex);
					record.PropertyNames = Convert.ToString(reader.GetValue(propertyNamesColumnIndex));
					record.PropertyValuesString = Convert.ToString(reader.GetValue(propertyValuesStringColumnIndex));
					record.PropertyValuesBinary = (byte[])reader.GetValue(propertyValuesBinaryColumnIndex);
					record.LastUpdatedDate = Convert.ToDateTime(reader.GetValue(lastUpdatedDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (aspnet_ProfileRow[])(recordList.ToArray(typeof(aspnet_ProfileRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="aspnet_ProfileRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="aspnet_ProfileRow"/> object.</returns>
		protected virtual aspnet_ProfileRow MapRow(DataRow row)
		{
			aspnet_ProfileRow mappedObject = new aspnet_ProfileRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "UserId"
			dataColumn = dataTable.Columns["UserId"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserId = (System.Guid)row[dataColumn];
			// Column "PropertyNames"
			dataColumn = dataTable.Columns["PropertyNames"];
			if(!row.IsNull(dataColumn))
				mappedObject.PropertyNames = (string)row[dataColumn];
			// Column "PropertyValuesString"
			dataColumn = dataTable.Columns["PropertyValuesString"];
			if(!row.IsNull(dataColumn))
				mappedObject.PropertyValuesString = (string)row[dataColumn];
			// Column "PropertyValuesBinary"
			dataColumn = dataTable.Columns["PropertyValuesBinary"];
			if(!row.IsNull(dataColumn))
				mappedObject.PropertyValuesBinary = (byte[])row[dataColumn];
			// Column "LastUpdatedDate"
			dataColumn = dataTable.Columns["LastUpdatedDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastUpdatedDate = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>aspnet_Profile</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "aspnet_Profile";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("UserId", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PropertyNames", typeof(string));
			dataColumn.MaxLength = 1073741823;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PropertyValuesString", typeof(string));
			dataColumn.MaxLength = 1073741823;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PropertyValuesBinary", typeof(byte[]));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("LastUpdatedDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
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
				case "UserId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "PropertyNames":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PropertyValuesString":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "PropertyValuesBinary":
					parameter = _db.AddParameter(cmd, paramName, DbType.Binary, value);
					break;

				case "LastUpdatedDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of aspnet_ProfileCollection_Base class
}  // End of namespace
