// <fileinfo name="aspnet_PersonalizationPerUserCollection_Base.cs">
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
	/// The base class for <see cref="aspnet_PersonalizationPerUserCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="aspnet_PersonalizationPerUserCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_PersonalizationPerUserCollection_Base
	{
		// Constants
		public const string IdColumnName = "Id";
		public const string PathIdColumnName = "PathId";
		public const string UserIdColumnName = "UserId";
		public const string PageSettingsColumnName = "PageSettings";
		public const string LastUpdatedDateColumnName = "LastUpdatedDate";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_PersonalizationPerUserCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public aspnet_PersonalizationPerUserCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public virtual aspnet_PersonalizationPerUserRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="aspnet_PersonalizationPerUserRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="aspnet_PersonalizationPerUserRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public aspnet_PersonalizationPerUserRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			aspnet_PersonalizationPerUserRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public aspnet_PersonalizationPerUserRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects that 
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
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public virtual aspnet_PersonalizationPerUserRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[aspnet_PersonalizationPerUser]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="aspnet_PersonalizationPerUserRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>An instance of <see cref="aspnet_PersonalizationPerUserRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual aspnet_PersonalizationPerUserRow GetByPrimaryKey(System.Guid id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_GetByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			aspnet_PersonalizationPerUserRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects 
		/// by the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public aspnet_PersonalizationPerUserRow[] GetByPathId(System.Guid pathId)
		{
			return GetByPathId(pathId, false);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects 
		/// by the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <param name="pathIdNull">true if the method ignores the pathId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public virtual aspnet_PersonalizationPerUserRow[] GetByPathId(System.Guid pathId, bool pathIdNull)
		{
			return MapRecords(CreateGetByPathIdCommand(pathId, pathIdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByPathIdAsDataTable(System.Guid pathId)
		{
			return GetByPathIdAsDataTable(pathId, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <param name="pathIdNull">true if the method ignores the pathId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByPathIdAsDataTable(System.Guid pathId, bool pathIdNull)
		{
			return MapRecordsToDataTable(CreateGetByPathIdCommand(pathId, pathIdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <param name="pathIdNull">true if the method ignores the pathId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByPathIdCommand(System.Guid pathId, bool pathIdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_GetBy_PathId", true);
			AddParameter(cmd, "PathId", pathIdNull ? null : (object)pathId);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects 
		/// by the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public aspnet_PersonalizationPerUserRow[] GetByUserId(System.Guid userId)
		{
			return GetByUserId(userId, false);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_PersonalizationPerUserRow"/> objects 
		/// by the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="userIdNull">true if the method ignores the userId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		public virtual aspnet_PersonalizationPerUserRow[] GetByUserId(System.Guid userId, bool userIdNull)
		{
			return MapRecords(CreateGetByUserIdCommand(userId, userIdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByUserIdAsDataTable(System.Guid userId)
		{
			return GetByUserIdAsDataTable(userId, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="userIdNull">true if the method ignores the userId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByUserIdAsDataTable(System.Guid userId, bool userIdNull)
		{
			return MapRecordsToDataTable(CreateGetByUserIdCommand(userId, userIdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="userIdNull">true if the method ignores the userId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByUserIdCommand(System.Guid userId, bool userIdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_GetBy_UserId", true);
			AddParameter(cmd, "UserId", userIdNull ? null : (object)userId);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_PersonalizationPerUserRow"/> object to be inserted.</param>
		public virtual void Insert(aspnet_PersonalizationPerUserRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_Insert", true);
			AddParameter(cmd, "Id", value.Id);
			AddParameter(cmd, "PathId",
				value.IsPathIdNull ? DBNull.Value : (object)value.PathId);
			AddParameter(cmd, "UserId",
				value.IsUserIdNull ? DBNull.Value : (object)value.UserId);
			AddParameter(cmd, "PageSettings", value.PageSettings);
			AddParameter(cmd, "LastUpdatedDate", value.LastUpdatedDate);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates a record in the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_PersonalizationPerUserRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(aspnet_PersonalizationPerUserRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_Update", true);
			AddParameter(cmd, "PathId",
				value.IsPathIdNull ? DBNull.Value : (object)value.PathId);
			AddParameter(cmd, "UserId",
				value.IsUserIdNull ? DBNull.Value : (object)value.UserId);
			AddParameter(cmd, "PageSettings", value.PageSettings);
			AddParameter(cmd, "LastUpdatedDate", value.LastUpdatedDate);
			AddParameter(cmd, "Id", value.Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>aspnet_PersonalizationPerUser</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>aspnet_PersonalizationPerUser</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((System.Guid)row["Id"]);
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
		/// Deletes the specified object from the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_PersonalizationPerUserRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(aspnet_PersonalizationPerUserRow value)
		{
			return DeleteByPrimaryKey(value.Id);
		}

		/// <summary>
		/// Deletes a record from the <c>aspnet_PersonalizationPerUser</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(System.Guid id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_PersonalizationPerUser</c> table using the 
		/// <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByPathId(System.Guid pathId)
		{
			return DeleteByPathId(pathId, false);
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_PersonalizationPerUser</c> table using the 
		/// <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <param name="pathIdNull">true if the method ignores the pathId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByPathId(System.Guid pathId, bool pathIdNull)
		{
			return CreateDeleteByPathIdCommand(pathId, pathIdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Pe__PathI__2180FB33</c> foreign key.
		/// </summary>
		/// <param name="pathId">The <c>PathId</c> column value.</param>
		/// <param name="pathIdNull">true if the method ignores the pathId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByPathIdCommand(System.Guid pathId, bool pathIdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_DeleteBy_PathId", true);
			AddParameter(cmd, "PathId", pathIdNull ? null : (object)pathId);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_PersonalizationPerUser</c> table using the 
		/// <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByUserId(System.Guid userId)
		{
			return DeleteByUserId(userId, false);
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_PersonalizationPerUser</c> table using the 
		/// <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="userIdNull">true if the method ignores the userId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByUserId(System.Guid userId, bool userIdNull)
		{
			return CreateDeleteByUserIdCommand(userId, userIdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Pe__UserI__22751F6C</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="userIdNull">true if the method ignores the userId
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByUserIdCommand(System.Guid userId, bool userIdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_DeleteBy_UserId", true);
			AddParameter(cmd, "UserId", userIdNull ? null : (object)userId);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>aspnet_PersonalizationPerUser</c> records that match the specified criteria.
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
		/// to delete <c>aspnet_PersonalizationPerUser</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[aspnet_PersonalizationPerUser]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._aspnet_PersonalizationPerUser_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		protected aspnet_PersonalizationPerUserRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		protected aspnet_PersonalizationPerUserRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="aspnet_PersonalizationPerUserRow"/> objects.</returns>
		protected virtual aspnet_PersonalizationPerUserRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("Id");
			int pathIdColumnIndex = reader.GetOrdinal("PathId");
			int userIdColumnIndex = reader.GetOrdinal("UserId");
			int pageSettingsColumnIndex = reader.GetOrdinal("PageSettings");
			int lastUpdatedDateColumnIndex = reader.GetOrdinal("LastUpdatedDate");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					aspnet_PersonalizationPerUserRow record = new aspnet_PersonalizationPerUserRow();
					recordList.Add(record);

					record.Id = reader.GetGuid(idColumnIndex);
					if(!reader.IsDBNull(pathIdColumnIndex))
						record.PathId = reader.GetGuid(pathIdColumnIndex);
					if(!reader.IsDBNull(userIdColumnIndex))
						record.UserId = reader.GetGuid(userIdColumnIndex);
					record.PageSettings = (byte[])reader.GetValue(pageSettingsColumnIndex);
					record.LastUpdatedDate = Convert.ToDateTime(reader.GetValue(lastUpdatedDateColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (aspnet_PersonalizationPerUserRow[])(recordList.ToArray(typeof(aspnet_PersonalizationPerUserRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="aspnet_PersonalizationPerUserRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="aspnet_PersonalizationPerUserRow"/> object.</returns>
		protected virtual aspnet_PersonalizationPerUserRow MapRow(DataRow row)
		{
			aspnet_PersonalizationPerUserRow mappedObject = new aspnet_PersonalizationPerUserRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Id"
			dataColumn = dataTable.Columns["Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Id = (System.Guid)row[dataColumn];
			// Column "PathId"
			dataColumn = dataTable.Columns["PathId"];
			if(!row.IsNull(dataColumn))
				mappedObject.PathId = (System.Guid)row[dataColumn];
			// Column "UserId"
			dataColumn = dataTable.Columns["UserId"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserId = (System.Guid)row[dataColumn];
			// Column "PageSettings"
			dataColumn = dataTable.Columns["PageSettings"];
			if(!row.IsNull(dataColumn))
				mappedObject.PageSettings = (byte[])row[dataColumn];
			// Column "LastUpdatedDate"
			dataColumn = dataTable.Columns["LastUpdatedDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.LastUpdatedDate = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>aspnet_PersonalizationPerUser</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "aspnet_PersonalizationPerUser";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Id", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("PathId", typeof(System.Guid));
			dataColumn = dataTable.Columns.Add("UserId", typeof(System.Guid));
			dataColumn = dataTable.Columns.Add("PageSettings", typeof(byte[]));
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
				case "Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "PathId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "UserId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				case "PageSettings":
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
	} // End of aspnet_PersonalizationPerUserCollection_Base class
}  // End of namespace
