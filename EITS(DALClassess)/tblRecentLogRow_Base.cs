// <fileinfo name="tblRecentLogRow_Base.cs">
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

namespace IOM.EITS.DAL
{
	/// <summary>
	/// The base class for <see cref="tblRecentLogRow"/> that 
	/// represents a record in the <c>tblRecentLog</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblRecentLogRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblRecentLogRow_Base
	{
		private int _recentLogID;
		private int _recentLogType;
		private string _entityName;
		private System.DateTime _recentLogDateTime;
		private int _entityID;
		private int _userID;
		private string _userName;
		private string _action;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblRecentLogRow_Base"/> class.
		/// </summary>
		public tblRecentLogRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>RecentLogID</c> column value.
		/// </summary>
		/// <value>The <c>RecentLogID</c> column value.</value>
		public int RecentLogID
		{
			get { return _recentLogID; }
			set { _recentLogID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RecentLogType</c> column value.
		/// </summary>
		/// <value>The <c>RecentLogType</c> column value.</value>
		public int RecentLogType
		{
			get { return _recentLogType; }
			set { _recentLogType = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EntityName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>EntityName</c> column value.</value>
		public string EntityName
		{
			get { return _entityName; }
			set { _entityName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RecentLogDateTime</c> column value.
		/// </summary>
		/// <value>The <c>RecentLogDateTime</c> column value.</value>
		public System.DateTime RecentLogDateTime
		{
			get { return _recentLogDateTime; }
			set { _recentLogDateTime = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EntityID</c> column value.
		/// </summary>
		/// <value>The <c>EntityID</c> column value.</value>
		public int EntityID
		{
			get { return _entityID; }
			set { _entityID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserID</c> column value.
		/// </summary>
		/// <value>The <c>UserID</c> column value.</value>
		public int UserID
		{
			get { return _userID; }
			set { _userID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Action</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Action</c> column value.</value>
		public string Action
		{
			get { return _action; }
			set { _action = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  RecentLogID=");
			dynStr.Append(RecentLogID);
			dynStr.Append("  RecentLogType=");
			dynStr.Append(RecentLogType);
			dynStr.Append("  EntityName=");
			dynStr.Append(EntityName);
			dynStr.Append("  RecentLogDateTime=");
			dynStr.Append(RecentLogDateTime);
			dynStr.Append("  EntityID=");
			dynStr.Append(EntityID);
			dynStr.Append("  UserID=");
			dynStr.Append(UserID);
			dynStr.Append("  UserName=");
			dynStr.Append(UserName);
			dynStr.Append("  Action=");
			dynStr.Append(Action);
			return dynStr.ToString();
		}
	} // End of tblRecentLogRow_Base class
} // End of namespace
