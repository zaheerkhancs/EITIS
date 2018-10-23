// <fileinfo name="aspnet_UsersRow_Base.cs">
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
	/// The base class for <see cref="aspnet_UsersRow"/> that 
	/// represents a record in the <c>aspnet_Users</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_UsersRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_UsersRow_Base
	{
		private System.Guid _applicationId;
		private System.Guid _userId;
		private string _userName;
		private string _loweredUserName;
		private string _mobileAlias;
		private bool _isAnonymous;
		private System.DateTime _lastActivityDate;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_UsersRow_Base"/> class.
		/// </summary>
		public aspnet_UsersRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ApplicationId</c> column value.
		/// </summary>
		/// <value>The <c>ApplicationId</c> column value.</value>
		public System.Guid ApplicationId
		{
			get { return _applicationId; }
			set { _applicationId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
		public System.Guid UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LoweredUserName</c> column value.
		/// </summary>
		/// <value>The <c>LoweredUserName</c> column value.</value>
		public string LoweredUserName
		{
			get { return _loweredUserName; }
			set { _loweredUserName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MobileAlias</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MobileAlias</c> column value.</value>
		public string MobileAlias
		{
			get { return _mobileAlias; }
			set { _mobileAlias = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsAnonymous</c> column value.
		/// </summary>
		/// <value>The <c>IsAnonymous</c> column value.</value>
		public bool IsAnonymous
		{
			get { return _isAnonymous; }
			set { _isAnonymous = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastActivityDate</c> column value.
		/// </summary>
		/// <value>The <c>LastActivityDate</c> column value.</value>
		public System.DateTime LastActivityDate
		{
			get { return _lastActivityDate; }
			set { _lastActivityDate = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  ApplicationId=");
			dynStr.Append(ApplicationId);
			dynStr.Append("  UserId=");
			dynStr.Append(UserId);
			dynStr.Append("  UserName=");
			dynStr.Append(UserName);
			dynStr.Append("  LoweredUserName=");
			dynStr.Append(LoweredUserName);
			dynStr.Append("  MobileAlias=");
			dynStr.Append(MobileAlias);
			dynStr.Append("  IsAnonymous=");
			dynStr.Append(IsAnonymous);
			dynStr.Append("  LastActivityDate=");
			dynStr.Append(LastActivityDate);
			return dynStr.ToString();
		}
	} // End of aspnet_UsersRow_Base class
} // End of namespace
