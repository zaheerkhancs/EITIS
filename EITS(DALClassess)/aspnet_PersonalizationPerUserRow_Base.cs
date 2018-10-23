// <fileinfo name="aspnet_PersonalizationPerUserRow_Base.cs">
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
	/// The base class for <see cref="aspnet_PersonalizationPerUserRow"/> that 
	/// represents a record in the <c>aspnet_PersonalizationPerUser</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_PersonalizationPerUserRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_PersonalizationPerUserRow_Base
	{
		private System.Guid _id;
		private System.Guid _pathId;
		private bool _pathIdNull = true;
		private System.Guid _userId;
		private bool _userIdNull = true;
		private byte[] _pageSettings;
		private System.DateTime _lastUpdatedDate;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_PersonalizationPerUserRow_Base"/> class.
		/// </summary>
		public aspnet_PersonalizationPerUserRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Id</c> column value.
		/// </summary>
		/// <value>The <c>Id</c> column value.</value>
		public System.Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PathId</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PathId</c> column value.</value>
		public System.Guid PathId
		{
			get
			{
				if(IsPathIdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _pathId;
			}
			set
			{
				_pathIdNull = false;
				_pathId = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="PathId"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPathIdNull
		{
			get { return _pathIdNull; }
			set { _pathIdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
		public System.Guid UserId
		{
			get
			{
				if(IsUserIdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _userId;
			}
			set
			{
				_userIdNull = false;
				_userId = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="UserId"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsUserIdNull
		{
			get { return _userIdNull; }
			set { _userIdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PageSettings</c> column value.
		/// </summary>
		/// <value>The <c>PageSettings</c> column value.</value>
		public byte[] PageSettings
		{
			get { return _pageSettings; }
			set { _pageSettings = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastUpdatedDate</c> column value.
		/// </summary>
		/// <value>The <c>LastUpdatedDate</c> column value.</value>
		public System.DateTime LastUpdatedDate
		{
			get { return _lastUpdatedDate; }
			set { _lastUpdatedDate = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Id=");
			dynStr.Append(Id);
			dynStr.Append("  PathId=");
			dynStr.Append(IsPathIdNull ? (object)"<NULL>" : PathId);
			dynStr.Append("  UserId=");
			dynStr.Append(IsUserIdNull ? (object)"<NULL>" : UserId);
			dynStr.Append("  LastUpdatedDate=");
			dynStr.Append(LastUpdatedDate);
			return dynStr.ToString();
		}
	} // End of aspnet_PersonalizationPerUserRow_Base class
} // End of namespace
