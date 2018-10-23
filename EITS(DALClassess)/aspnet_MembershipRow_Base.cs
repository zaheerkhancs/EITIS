// <fileinfo name="aspnet_MembershipRow_Base.cs">
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
	/// The base class for <see cref="aspnet_MembershipRow"/> that 
	/// represents a record in the <c>aspnet_Membership</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_MembershipRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_MembershipRow_Base
	{
		private System.Guid _applicationId;
		private System.Guid _userId;
		private string _password;
		private int _passwordFormat;
		private string _passwordSalt;
		private string _mobilePIN;
		private string _email;
		private string _loweredEmail;
		private string _passwordQuestion;
		private string _passwordAnswer;
		private bool _isApproved;
		private bool _isLockedOut;
		private System.DateTime _createDate;
		private System.DateTime _lastLoginDate;
		private System.DateTime _lastPasswordChangedDate;
		private System.DateTime _lastLockoutDate;
		private int _failedPasswordAttemptCount;
		private System.DateTime _failedPasswordAttemptWindowStart;
		private int _failedPasswordAnswerAttemptCount;
		private System.DateTime _failedPasswordAnswerAttemptWindowStart;
		private string _comment;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_MembershipRow_Base"/> class.
		/// </summary>
		public aspnet_MembershipRow_Base()
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
		/// Gets or sets the <c>Password</c> column value.
		/// </summary>
		/// <value>The <c>Password</c> column value.</value>
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PasswordFormat</c> column value.
		/// </summary>
		/// <value>The <c>PasswordFormat</c> column value.</value>
		public int PasswordFormat
		{
			get { return _passwordFormat; }
			set { _passwordFormat = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PasswordSalt</c> column value.
		/// </summary>
		/// <value>The <c>PasswordSalt</c> column value.</value>
		public string PasswordSalt
		{
			get { return _passwordSalt; }
			set { _passwordSalt = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MobilePIN</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MobilePIN</c> column value.</value>
		public string MobilePIN
		{
			get { return _mobilePIN; }
			set { _mobilePIN = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LoweredEmail</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LoweredEmail</c> column value.</value>
		public string LoweredEmail
		{
			get { return _loweredEmail; }
			set { _loweredEmail = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PasswordQuestion</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PasswordQuestion</c> column value.</value>
		public string PasswordQuestion
		{
			get { return _passwordQuestion; }
			set { _passwordQuestion = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PasswordAnswer</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PasswordAnswer</c> column value.</value>
		public string PasswordAnswer
		{
			get { return _passwordAnswer; }
			set { _passwordAnswer = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsApproved</c> column value.
		/// </summary>
		/// <value>The <c>IsApproved</c> column value.</value>
		public bool IsApproved
		{
			get { return _isApproved; }
			set { _isApproved = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsLockedOut</c> column value.
		/// </summary>
		/// <value>The <c>IsLockedOut</c> column value.</value>
		public bool IsLockedOut
		{
			get { return _isLockedOut; }
			set { _isLockedOut = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CreateDate</c> column value.
		/// </summary>
		/// <value>The <c>CreateDate</c> column value.</value>
		public System.DateTime CreateDate
		{
			get { return _createDate; }
			set { _createDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastLoginDate</c> column value.
		/// </summary>
		/// <value>The <c>LastLoginDate</c> column value.</value>
		public System.DateTime LastLoginDate
		{
			get { return _lastLoginDate; }
			set { _lastLoginDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastPasswordChangedDate</c> column value.
		/// </summary>
		/// <value>The <c>LastPasswordChangedDate</c> column value.</value>
		public System.DateTime LastPasswordChangedDate
		{
			get { return _lastPasswordChangedDate; }
			set { _lastPasswordChangedDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastLockoutDate</c> column value.
		/// </summary>
		/// <value>The <c>LastLockoutDate</c> column value.</value>
		public System.DateTime LastLockoutDate
		{
			get { return _lastLockoutDate; }
			set { _lastLockoutDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FailedPasswordAttemptCount</c> column value.
		/// </summary>
		/// <value>The <c>FailedPasswordAttemptCount</c> column value.</value>
		public int FailedPasswordAttemptCount
		{
			get { return _failedPasswordAttemptCount; }
			set { _failedPasswordAttemptCount = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FailedPasswordAttemptWindowStart</c> column value.
		/// </summary>
		/// <value>The <c>FailedPasswordAttemptWindowStart</c> column value.</value>
		public System.DateTime FailedPasswordAttemptWindowStart
		{
			get { return _failedPasswordAttemptWindowStart; }
			set { _failedPasswordAttemptWindowStart = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FailedPasswordAnswerAttemptCount</c> column value.
		/// </summary>
		/// <value>The <c>FailedPasswordAnswerAttemptCount</c> column value.</value>
		public int FailedPasswordAnswerAttemptCount
		{
			get { return _failedPasswordAnswerAttemptCount; }
			set { _failedPasswordAnswerAttemptCount = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FailedPasswordAnswerAttemptWindowStart</c> column value.
		/// </summary>
		/// <value>The <c>FailedPasswordAnswerAttemptWindowStart</c> column value.</value>
		public System.DateTime FailedPasswordAnswerAttemptWindowStart
		{
			get { return _failedPasswordAnswerAttemptWindowStart; }
			set { _failedPasswordAnswerAttemptWindowStart = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Comment</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Comment</c> column value.</value>
		public string Comment
		{
			get { return _comment; }
			set { _comment = value; }
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
			dynStr.Append("  Password=");
			dynStr.Append(Password);
			dynStr.Append("  PasswordFormat=");
			dynStr.Append(PasswordFormat);
			dynStr.Append("  PasswordSalt=");
			dynStr.Append(PasswordSalt);
			dynStr.Append("  MobilePIN=");
			dynStr.Append(MobilePIN);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  LoweredEmail=");
			dynStr.Append(LoweredEmail);
			dynStr.Append("  PasswordQuestion=");
			dynStr.Append(PasswordQuestion);
			dynStr.Append("  PasswordAnswer=");
			dynStr.Append(PasswordAnswer);
			dynStr.Append("  IsApproved=");
			dynStr.Append(IsApproved);
			dynStr.Append("  IsLockedOut=");
			dynStr.Append(IsLockedOut);
			dynStr.Append("  CreateDate=");
			dynStr.Append(CreateDate);
			dynStr.Append("  LastLoginDate=");
			dynStr.Append(LastLoginDate);
			dynStr.Append("  LastPasswordChangedDate=");
			dynStr.Append(LastPasswordChangedDate);
			dynStr.Append("  LastLockoutDate=");
			dynStr.Append(LastLockoutDate);
			dynStr.Append("  FailedPasswordAttemptCount=");
			dynStr.Append(FailedPasswordAttemptCount);
			dynStr.Append("  FailedPasswordAttemptWindowStart=");
			dynStr.Append(FailedPasswordAttemptWindowStart);
			dynStr.Append("  FailedPasswordAnswerAttemptCount=");
			dynStr.Append(FailedPasswordAnswerAttemptCount);
			dynStr.Append("  FailedPasswordAnswerAttemptWindowStart=");
			dynStr.Append(FailedPasswordAnswerAttemptWindowStart);
			dynStr.Append("  Comment=");
			dynStr.Append(Comment);
			return dynStr.ToString();
		}
	} // End of aspnet_MembershipRow_Base class
} // End of namespace
