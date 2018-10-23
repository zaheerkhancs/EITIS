// <fileinfo name="aspnet_PersonalizationAllUsersRow_Base.cs">
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
	/// The base class for <see cref="aspnet_PersonalizationAllUsersRow"/> that 
	/// represents a record in the <c>aspnet_PersonalizationAllUsers</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_PersonalizationAllUsersRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_PersonalizationAllUsersRow_Base
	{
		private System.Guid _pathId;
		private byte[] _pageSettings;
		private System.DateTime _lastUpdatedDate;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_PersonalizationAllUsersRow_Base"/> class.
		/// </summary>
		public aspnet_PersonalizationAllUsersRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>PathId</c> column value.
		/// </summary>
		/// <value>The <c>PathId</c> column value.</value>
		public System.Guid PathId
		{
			get { return _pathId; }
			set { _pathId = value; }
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
			dynStr.Append("  PathId=");
			dynStr.Append(PathId);
			dynStr.Append("  LastUpdatedDate=");
			dynStr.Append(LastUpdatedDate);
			return dynStr.ToString();
		}
	} // End of aspnet_PersonalizationAllUsersRow_Base class
} // End of namespace
