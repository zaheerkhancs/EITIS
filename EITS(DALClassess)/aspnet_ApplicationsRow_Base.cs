// <fileinfo name="aspnet_ApplicationsRow_Base.cs">
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
	/// The base class for <see cref="aspnet_ApplicationsRow"/> that 
	/// represents a record in the <c>aspnet_Applications</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_ApplicationsRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_ApplicationsRow_Base
	{
		private string _applicationName;
		private string _loweredApplicationName;
		private System.Guid _applicationId;
		private string _description;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_ApplicationsRow_Base"/> class.
		/// </summary>
		public aspnet_ApplicationsRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ApplicationName</c> column value.
		/// </summary>
		/// <value>The <c>ApplicationName</c> column value.</value>
		public string ApplicationName
		{
			get { return _applicationName; }
			set { _applicationName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LoweredApplicationName</c> column value.
		/// </summary>
		/// <value>The <c>LoweredApplicationName</c> column value.</value>
		public string LoweredApplicationName
		{
			get { return _loweredApplicationName; }
			set { _loweredApplicationName = value; }
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
		/// Gets or sets the <c>Description</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description</c> column value.</value>
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  ApplicationName=");
			dynStr.Append(ApplicationName);
			dynStr.Append("  LoweredApplicationName=");
			dynStr.Append(LoweredApplicationName);
			dynStr.Append("  ApplicationId=");
			dynStr.Append(ApplicationId);
			dynStr.Append("  Description=");
			dynStr.Append(Description);
			return dynStr.ToString();
		}
	} // End of aspnet_ApplicationsRow_Base class
} // End of namespace
