// <fileinfo name="aspnet_UsersInRolesCollection_Base.cs">
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
	/// The base class for <see cref="aspnet_UsersInRolesCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="aspnet_UsersInRolesCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_UsersInRolesCollection_Base
	{
		// Constants
		public const string UserIdColumnName = "UserId";
		public const string RoleIdColumnName = "RoleId";

		// Instance fields
		private EITSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_UsersInRolesCollection_Base"/> 
		/// class with the specified <see cref="EITSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="EITSDB"/> object.</param>
		public aspnet_UsersInRolesCollection_Base(EITSDB db)
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
		/// Gets an array of all records from the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		public virtual aspnet_UsersInRolesRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._aspnet_UsersInRoles_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="aspnet_UsersInRolesRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="aspnet_UsersInRolesRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public aspnet_UsersInRolesRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			aspnet_UsersInRolesRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_UsersInRolesRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		public aspnet_UsersInRolesRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_UsersInRolesRow"/> objects that 
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
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		public virtual aspnet_UsersInRolesRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[aspnet_UsersInRoles]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="aspnet_UsersInRolesRow"/> by the primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>An instance of <see cref="aspnet_UsersInRolesRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual aspnet_UsersInRolesRow GetByPrimaryKey(System.Guid userId, System.Guid roleId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_GetByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			AddParameter(cmd, "RoleId", roleId);
			aspnet_UsersInRolesRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_UsersInRolesRow"/> objects 
		/// by the <c>FK__aspnet_Us__RoleI__09A971A2</c> foreign key.
		/// </summary>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		public virtual aspnet_UsersInRolesRow[] GetByRoleId(System.Guid roleId)
		{
			return MapRecords(CreateGetByRoleIdCommand(roleId));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Us__RoleI__09A971A2</c> foreign key.
		/// </summary>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByRoleIdAsDataTable(System.Guid roleId)
		{
			return MapRecordsToDataTable(CreateGetByRoleIdCommand(roleId));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Us__RoleI__09A971A2</c> foreign key.
		/// </summary>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByRoleIdCommand(System.Guid roleId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_GetBy_RoleId", true);
			AddParameter(cmd, "RoleId", roleId);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="aspnet_UsersInRolesRow"/> objects 
		/// by the <c>FK__aspnet_Us__UserI__08B54D69</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		public virtual aspnet_UsersInRolesRow[] GetByUserId(System.Guid userId)
		{
			return MapRecords(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK__aspnet_Us__UserI__08B54D69</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByUserIdAsDataTable(System.Guid userId)
		{
			return MapRecordsToDataTable(CreateGetByUserIdCommand(userId));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK__aspnet_Us__UserI__08B54D69</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_GetBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_UsersInRolesRow"/> object to be inserted.</param>
		public virtual void Insert(aspnet_UsersInRolesRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_Insert", true);
			AddParameter(cmd, "UserId", value.UserId);
			AddParameter(cmd, "RoleId", value.RoleId);
			cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes the specified object from the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <param name="value">The <see cref="aspnet_UsersInRolesRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(aspnet_UsersInRolesRow value)
		{
			return DeleteByPrimaryKey(value.UserId, value.RoleId);
		}

		/// <summary>
		/// Deletes a record from the <c>aspnet_UsersInRoles</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(System.Guid userId, System.Guid roleId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_DeleteByPrimaryKey", true);
			AddParameter(cmd, "UserId", userId);
			AddParameter(cmd, "RoleId", roleId);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_UsersInRoles</c> table using the 
		/// <c>FK__aspnet_Us__RoleI__09A971A2</c> foreign key.
		/// </summary>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByRoleId(System.Guid roleId)
		{
			return CreateDeleteByRoleIdCommand(roleId).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Us__RoleI__09A971A2</c> foreign key.
		/// </summary>
		/// <param name="roleId">The <c>RoleId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByRoleIdCommand(System.Guid roleId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_DeleteBy_RoleId", true);
			AddParameter(cmd, "RoleId", roleId);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>aspnet_UsersInRoles</c> table using the 
		/// <c>FK__aspnet_Us__UserI__08B54D69</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByUserId(System.Guid userId)
		{
			return CreateDeleteByUserIdCommand(userId).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK__aspnet_Us__UserI__08B54D69</c> foreign key.
		/// </summary>
		/// <param name="userId">The <c>UserId</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByUserIdCommand(System.Guid userId)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._aspnet_UsersInRoles_DeleteBy_UserId", true);
			AddParameter(cmd, "UserId", userId);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>aspnet_UsersInRoles</c> records that match the specified criteria.
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
		/// to delete <c>aspnet_UsersInRoles</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[aspnet_UsersInRoles]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._aspnet_UsersInRoles_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		protected aspnet_UsersInRolesRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		protected aspnet_UsersInRolesRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="aspnet_UsersInRolesRow"/> objects.</returns>
		protected virtual aspnet_UsersInRolesRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int userIdColumnIndex = reader.GetOrdinal("UserId");
			int roleIdColumnIndex = reader.GetOrdinal("RoleId");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					aspnet_UsersInRolesRow record = new aspnet_UsersInRolesRow();
					recordList.Add(record);

					record.UserId = reader.GetGuid(userIdColumnIndex);
					record.RoleId = reader.GetGuid(roleIdColumnIndex);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (aspnet_UsersInRolesRow[])(recordList.ToArray(typeof(aspnet_UsersInRolesRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="aspnet_UsersInRolesRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="aspnet_UsersInRolesRow"/> object.</returns>
		protected virtual aspnet_UsersInRolesRow MapRow(DataRow row)
		{
			aspnet_UsersInRolesRow mappedObject = new aspnet_UsersInRolesRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "UserId"
			dataColumn = dataTable.Columns["UserId"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserId = (System.Guid)row[dataColumn];
			// Column "RoleId"
			dataColumn = dataTable.Columns["RoleId"];
			if(!row.IsNull(dataColumn))
				mappedObject.RoleId = (System.Guid)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>aspnet_UsersInRoles</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "aspnet_UsersInRoles";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("UserId", typeof(System.Guid));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("RoleId", typeof(System.Guid));
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

				case "RoleId":
					parameter = _db.AddParameter(cmd, paramName, DbType.Guid, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of aspnet_UsersInRolesCollection_Base class
}  // End of namespace
