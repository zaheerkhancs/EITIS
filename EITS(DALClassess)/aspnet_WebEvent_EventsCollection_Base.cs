// <fileinfo name="aspnet_WebEvent_EventsCollection_Base.cs">
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
	/// The base class for <see cref="aspnet_WebEvent_EventsCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="aspnet_WebEvent_EventsCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_WebEvent_EventsCollection_Base
	{
		// Constants
		public const string EventIdColumnName = "EventId";
		public const string EventTimeUtcColumnName = "EventTimeUtc";
		public const string EventTimeColumnName = "EventTime";
		public const string EventTypeColumnName = "EventType";
		public const string EventSequenceColumnName = "EventSequence";
		public const string EventOccurrenceColumnName = "EventOccurrence";
		public const string EventCodeColumnName = "EventCode";
		public const string EventDetailCodeColumnName = "EventDetailCode";
		public const string MessageColumnName = "Message";
		public const string ApplicationPathColumnName = "ApplicationPath";
		public const string ApplicationVirtualPathColumnName = "ApplicationVirtualPath";
		public const string MachineNameColumnName = "MachineName";
		public const string RequestUrlColumnName = "RequestUrl";
		public const string ExceptionTypeColumnName = "ExceptionType";
		public const string DetailsColumnName = "Details";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_WebEvent_EventsCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public aspnet_WebEvent_EventsCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		public virtual aspnet_WebEvent_EventsRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._aspnet_WebEvent_Events_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="aspnet_WebEvent_EventsRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="aspnet_WebEvent_EventsRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public aspnet_WebEvent_EventsRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			aspnet_WebEvent_EventsRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_WebEvent_EventsRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		public aspnet_WebEvent_EventsRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_WebEvent_EventsRow"/> objects that 
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
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		public virtual aspnet_WebEvent_EventsRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[aspnet_WebEvent_Events]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="aspnet_WebEvent_EventsRow"/> by the primary key.
		/// </summary>
		/// <param name="eventId">The <c>EventId</c> column value.</param>
		/// <returns>An instance of <see cref="aspnet_WebEvent_EventsRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual aspnet_WebEvent_EventsRow GetByPrimaryKey(string eventId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_WebEvent_Events_GetByPrimaryKey", true);
			AddParameter(cmd, "EventId", eventId);
			aspnet_WebEvent_EventsRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_WebEvent_EventsRow"/> object to be inserted.</param>
		public virtual void Insert(aspnet_WebEvent_EventsRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_WebEvent_Events_Insert", true);
			AddParameter(cmd, "EventId", value.EventId);
			AddParameter(cmd, "EventTimeUtc", value.EventTimeUtc);
			AddParameter(cmd, "EventTime", value.EventTime);
			AddParameter(cmd, "EventType", value.EventType);
			AddParameter(cmd, "EventSequence", value.EventSequence);
			AddParameter(cmd, "EventOccurrence", value.EventOccurrence);
			AddParameter(cmd, "EventCode", value.EventCode);
			AddParameter(cmd, "EventDetailCode", value.EventDetailCode);
			AddParameter(cmd, "Message", value.Message);
			AddParameter(cmd, "ApplicationPath", value.ApplicationPath);
			AddParameter(cmd, "ApplicationVirtualPath", value.ApplicationVirtualPath);
			AddParameter(cmd, "MachineName", value.MachineName);
			AddParameter(cmd, "RequestUrl", value.RequestUrl);
			AddParameter(cmd, "ExceptionType", value.ExceptionType);
			AddParameter(cmd, "Details", value.Details);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_WebEvent_EventsRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(aspnet_WebEvent_EventsRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_WebEvent_Events_Update", true);
			AddParameter(cmd, "EventTimeUtc", value.EventTimeUtc);
			AddParameter(cmd, "EventTime", value.EventTime);
			AddParameter(cmd, "EventType", value.EventType);
			AddParameter(cmd, "EventSequence", value.EventSequence);
			AddParameter(cmd, "EventOccurrence", value.EventOccurrence);
			AddParameter(cmd, "EventCode", value.EventCode);
			AddParameter(cmd, "EventDetailCode", value.EventDetailCode);
			AddParameter(cmd, "Message", value.Message);
			AddParameter(cmd, "ApplicationPath", value.ApplicationPath);
			AddParameter(cmd, "ApplicationVirtualPath", value.ApplicationVirtualPath);
			AddParameter(cmd, "MachineName", value.MachineName);
			AddParameter(cmd, "RequestUrl", value.RequestUrl);
			AddParameter(cmd, "ExceptionType", value.ExceptionType);
			AddParameter(cmd, "Details", value.Details);
			AddParameter(cmd, "EventId", value.EventId);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>aspnet_WebEvent_Events</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>aspnet_WebEvent_Events</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((string)row["EventId"]);
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
		/// Deletes the specified object from the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_WebEvent_EventsRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(aspnet_WebEvent_EventsRow value)
		{
			return DeleteByPrimaryKey(value.EventId);
		}

		/// <summary>
		/// Deletes a record from the <c>aspnet_WebEvent_Events</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="eventId">The <c>EventId</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(string eventId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_WebEvent_Events_DeleteByPrimaryKey", true);
			AddParameter(cmd, "EventId", eventId);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>aspnet_WebEvent_Events</c> records that match the specified criteria.
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
		/// to delete <c>aspnet_WebEvent_Events</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[aspnet_WebEvent_Events]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._aspnet_WebEvent_Events_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		protected aspnet_WebEvent_EventsRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		protected aspnet_WebEvent_EventsRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="aspnet_WebEvent_EventsRow"/> objects.</returns>
		protected virtual aspnet_WebEvent_EventsRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int eventIdColumnIndex = reader.GetOrdinal("EventId");
			int eventTimeUtcColumnIndex = reader.GetOrdinal("EventTimeUtc");
			int eventTimeColumnIndex = reader.GetOrdinal("EventTime");
			int eventTypeColumnIndex = reader.GetOrdinal("EventType");
			int eventSequenceColumnIndex = reader.GetOrdinal("EventSequence");
			int eventOccurrenceColumnIndex = reader.GetOrdinal("EventOccurrence");
			int eventCodeColumnIndex = reader.GetOrdinal("EventCode");
			int eventDetailCodeColumnIndex = reader.GetOrdinal("EventDetailCode");
			int messageColumnIndex = reader.GetOrdinal("Message");
			int applicationPathColumnIndex = reader.GetOrdinal("ApplicationPath");
			int applicationVirtualPathColumnIndex = reader.GetOrdinal("ApplicationVirtualPath");
			int machineNameColumnIndex = reader.GetOrdinal("MachineName");
			int requestUrlColumnIndex = reader.GetOrdinal("RequestUrl");
			int exceptionTypeColumnIndex = reader.GetOrdinal("ExceptionType");
			int detailsColumnIndex = reader.GetOrdinal("Details");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					aspnet_WebEvent_EventsRow record = new aspnet_WebEvent_EventsRow();
					recordList.Add(record);

					record.EventId = Convert.ToString(reader.GetValue(eventIdColumnIndex));
					record.EventTimeUtc = Convert.ToDateTime(reader.GetValue(eventTimeUtcColumnIndex));
					record.EventTime = Convert.ToDateTime(reader.GetValue(eventTimeColumnIndex));
					record.EventType = Convert.ToString(reader.GetValue(eventTypeColumnIndex));
					record.EventSequence = Convert.ToDecimal(reader.GetValue(eventSequenceColumnIndex));
					record.EventOccurrence = Convert.ToDecimal(reader.GetValue(eventOccurrenceColumnIndex));
					record.EventCode = Convert.ToInt32(reader.GetValue(eventCodeColumnIndex));
					record.EventDetailCode = Convert.ToInt32(reader.GetValue(eventDetailCodeColumnIndex));
					if(!reader.IsDBNull(messageColumnIndex))
						record.Message = Convert.ToString(reader.GetValue(messageColumnIndex));
					if(!reader.IsDBNull(applicationPathColumnIndex))
						record.ApplicationPath = Convert.ToString(reader.GetValue(applicationPathColumnIndex));
					if(!reader.IsDBNull(applicationVirtualPathColumnIndex))
						record.ApplicationVirtualPath = Convert.ToString(reader.GetValue(applicationVirtualPathColumnIndex));
					record.MachineName = Convert.ToString(reader.GetValue(machineNameColumnIndex));
					if(!reader.IsDBNull(requestUrlColumnIndex))
						record.RequestUrl = Convert.ToString(reader.GetValue(requestUrlColumnIndex));
					if(!reader.IsDBNull(exceptionTypeColumnIndex))
						record.ExceptionType = Convert.ToString(reader.GetValue(exceptionTypeColumnIndex));
					if(!reader.IsDBNull(detailsColumnIndex))
						record.Details = Convert.ToString(reader.GetValue(detailsColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (aspnet_WebEvent_EventsRow[])(recordList.ToArray(typeof(aspnet_WebEvent_EventsRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="aspnet_WebEvent_EventsRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="aspnet_WebEvent_EventsRow"/> object.</returns>
		protected virtual aspnet_WebEvent_EventsRow MapRow(DataRow row)
		{
			aspnet_WebEvent_EventsRow mappedObject = new aspnet_WebEvent_EventsRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "EventId"
			dataColumn = dataTable.Columns["EventId"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventId = (string)row[dataColumn];
			// Column "EventTimeUtc"
			dataColumn = dataTable.Columns["EventTimeUtc"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventTimeUtc = (System.DateTime)row[dataColumn];
			// Column "EventTime"
			dataColumn = dataTable.Columns["EventTime"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventTime = (System.DateTime)row[dataColumn];
			// Column "EventType"
			dataColumn = dataTable.Columns["EventType"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventType = (string)row[dataColumn];
			// Column "EventSequence"
			dataColumn = dataTable.Columns["EventSequence"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventSequence = (decimal)row[dataColumn];
			// Column "EventOccurrence"
			dataColumn = dataTable.Columns["EventOccurrence"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventOccurrence = (decimal)row[dataColumn];
			// Column "EventCode"
			dataColumn = dataTable.Columns["EventCode"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventCode = (int)row[dataColumn];
			// Column "EventDetailCode"
			dataColumn = dataTable.Columns["EventDetailCode"];
			if(!row.IsNull(dataColumn))
				mappedObject.EventDetailCode = (int)row[dataColumn];
			// Column "Message"
			dataColumn = dataTable.Columns["Message"];
			if(!row.IsNull(dataColumn))
				mappedObject.Message = (string)row[dataColumn];
			// Column "ApplicationPath"
			dataColumn = dataTable.Columns["ApplicationPath"];
			if(!row.IsNull(dataColumn))
				mappedObject.ApplicationPath = (string)row[dataColumn];
			// Column "ApplicationVirtualPath"
			dataColumn = dataTable.Columns["ApplicationVirtualPath"];
			if(!row.IsNull(dataColumn))
				mappedObject.ApplicationVirtualPath = (string)row[dataColumn];
			// Column "MachineName"
			dataColumn = dataTable.Columns["MachineName"];
			if(!row.IsNull(dataColumn))
				mappedObject.MachineName = (string)row[dataColumn];
			// Column "RequestUrl"
			dataColumn = dataTable.Columns["RequestUrl"];
			if(!row.IsNull(dataColumn))
				mappedObject.RequestUrl = (string)row[dataColumn];
			// Column "ExceptionType"
			dataColumn = dataTable.Columns["ExceptionType"];
			if(!row.IsNull(dataColumn))
				mappedObject.ExceptionType = (string)row[dataColumn];
			// Column "Details"
			dataColumn = dataTable.Columns["Details"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>aspnet_WebEvent_Events</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "aspnet_WebEvent_Events";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("EventId", typeof(string));
			dataColumn.MaxLength = 32;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventTimeUtc", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventTime", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventType", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventSequence", typeof(decimal));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventOccurrence", typeof(decimal));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventCode", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("EventDetailCode", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Message", typeof(string));
			dataColumn.MaxLength = 1024;
			dataColumn = dataTable.Columns.Add("ApplicationPath", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("ApplicationVirtualPath", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("MachineName", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("RequestUrl", typeof(string));
			dataColumn.MaxLength = 1024;
			dataColumn = dataTable.Columns.Add("ExceptionType", typeof(string));
			dataColumn.MaxLength = 256;
			dataColumn = dataTable.Columns.Add("Details", typeof(string));
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
				case "EventId":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiStringFixedLength, value);
					break;

				case "EventTimeUtc":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "EventTime":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "EventType":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "EventSequence":
					parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
					break;

				case "EventOccurrence":
					parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
					break;

				case "EventCode":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "EventDetailCode":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Message":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "ApplicationPath":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "ApplicationVirtualPath":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "MachineName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "RequestUrl":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "ExceptionType":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Details":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of aspnet_WebEvent_EventsCollection_Base class
}  // End of namespace
