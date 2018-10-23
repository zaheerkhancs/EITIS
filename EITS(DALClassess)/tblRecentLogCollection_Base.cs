// <fileinfo name="tblRecentLogCollection_Base.cs">
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
	/// The base class for <see cref="tblRecentLogCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblRecentLogCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblRecentLogCollection_Base
	{
		// Constants
		public const string RecentLogIDColumnName = "RecentLogID";
		public const string RecentLogTypeColumnName = "RecentLogType";
		public const string EntityNameColumnName = "EntityName";
		public const string RecentLogDateTimeColumnName = "RecentLogDateTime";
		public const string EntityIDColumnName = "EntityID";
		public const string UserIDColumnName = "UserID";
		public const string UserNameColumnName = "UserName";
		public const string ActionColumnName = "Action";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblRecentLogCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public tblRecentLogCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>tblRecentLog</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		public virtual tblRecentLogRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblRecentLog</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblRecentLog</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblRecentLog_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblRecentLogRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblRecentLogRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblRecentLogRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblRecentLogRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblRecentLogRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		public tblRecentLogRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblRecentLogRow"/> objects that 
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
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		public virtual tblRecentLogRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblRecentLog]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Adds a new record into the <c>tblRecentLog</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblRecentLogRow"/> object to be inserted.</param>
		public virtual void Insert(tblRecentLogRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblRecentLog_Insert", true);
			AddParameter(cmd, "RecentLogType", value.RecentLogType);
			AddParameter(cmd, "EntityName", value.EntityName);
			AddParameter(cmd, "RecentLogDateTime", value.RecentLogDateTime);
			AddParameter(cmd, "EntityID", value.EntityID);
			AddParameter(cmd, "UserID", value.UserID);
			AddParameter(cmd, "UserName", value.UserName);
			AddParameter(cmd, "Action", value.Action);
			value.RecentLogID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Deletes <c>tblRecentLog</c> records that match the specified criteria.
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
		/// to delete <c>tblRecentLog</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblRecentLog]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblRecentLog</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblRecentLog_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		protected tblRecentLogRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		protected tblRecentLogRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblRecentLogRow"/> objects.</returns>
		protected virtual tblRecentLogRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int recentLogIDColumnIndex = reader.GetOrdinal("RecentLogID");
			int recentLogTypeColumnIndex = reader.GetOrdinal("RecentLogType");
			int entityNameColumnIndex = reader.GetOrdinal("EntityName");
			int recentLogDateTimeColumnIndex = reader.GetOrdinal("RecentLogDateTime");
			int entityIDColumnIndex = reader.GetOrdinal("EntityID");
			int userIDColumnIndex = reader.GetOrdinal("UserID");
			int userNameColumnIndex = reader.GetOrdinal("UserName");
			int actionColumnIndex = reader.GetOrdinal("Action");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblRecentLogRow record = new tblRecentLogRow();
					recordList.Add(record);

					record.RecentLogID = Convert.ToInt32(reader.GetValue(recentLogIDColumnIndex));
					record.RecentLogType = Convert.ToInt32(reader.GetValue(recentLogTypeColumnIndex));
					if(!reader.IsDBNull(entityNameColumnIndex))
						record.EntityName = Convert.ToString(reader.GetValue(entityNameColumnIndex));
					record.RecentLogDateTime = Convert.ToDateTime(reader.GetValue(recentLogDateTimeColumnIndex));
					record.EntityID = Convert.ToInt32(reader.GetValue(entityIDColumnIndex));
					record.UserID = Convert.ToInt32(reader.GetValue(userIDColumnIndex));
					if(!reader.IsDBNull(userNameColumnIndex))
						record.UserName = Convert.ToString(reader.GetValue(userNameColumnIndex));
					if(!reader.IsDBNull(actionColumnIndex))
						record.Action = Convert.ToString(reader.GetValue(actionColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblRecentLogRow[])(recordList.ToArray(typeof(tblRecentLogRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblRecentLogRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblRecentLogRow"/> object.</returns>
		protected virtual tblRecentLogRow MapRow(DataRow row)
		{
			tblRecentLogRow mappedObject = new tblRecentLogRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "RecentLogID"
			dataColumn = dataTable.Columns["RecentLogID"];
			if(!row.IsNull(dataColumn))
				mappedObject.RecentLogID = (int)row[dataColumn];
			// Column "RecentLogType"
			dataColumn = dataTable.Columns["RecentLogType"];
			if(!row.IsNull(dataColumn))
				mappedObject.RecentLogType = (int)row[dataColumn];
			// Column "EntityName"
			dataColumn = dataTable.Columns["EntityName"];
			if(!row.IsNull(dataColumn))
				mappedObject.EntityName = (string)row[dataColumn];
			// Column "RecentLogDateTime"
			dataColumn = dataTable.Columns["RecentLogDateTime"];
			if(!row.IsNull(dataColumn))
				mappedObject.RecentLogDateTime = (System.DateTime)row[dataColumn];
			// Column "EntityID"
			dataColumn = dataTable.Columns["EntityID"];
			if(!row.IsNull(dataColumn))
				mappedObject.EntityID = (int)row[dataColumn];
			// Column "UserID"
			dataColumn = dataTable.Columns["UserID"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserID = (int)row[dataColumn];
			// Column "UserName"
			dataColumn = dataTable.Columns["UserName"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserName = (string)row[dataColumn];
			// Column "Action"
			dataColumn = dataTable.Columns["Action"];
			if(!row.IsNull(dataColumn))
				mappedObject.Action = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblRecentLog</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblRecentLog";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("RecentLogID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("RecentLogType", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EntityName", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn = dataTable.Columns.Add("RecentLogDateTime", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EntityID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("UserID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("UserName", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn = dataTable.Columns.Add("Action", typeof(string));
			dataColumn.MaxLength = 20;
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
				case "RecentLogID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "RecentLogType":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "EntityName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "RecentLogDateTime":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "EntityID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "UserID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "UserName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Action":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblRecentLogCollection_Base class
}  // End of namespace
