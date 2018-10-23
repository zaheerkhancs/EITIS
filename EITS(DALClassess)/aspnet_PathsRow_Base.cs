// <fileinfo name="aspnet_PathsRow_Base.cs">
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
	/// The base class for <see cref="aspnet_PathsRow"/> that 
	/// represents a record in the <c>aspnet_Paths</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_PathsRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_PathsRow_Base
	{
		private System.Guid _applicationId;
		private System.Guid _pathId;
		private string _path;
		private string _loweredPath;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_PathsRow_Base"/> class.
		/// </summary>
		public aspnet_PathsRow_Base()
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
		/// Gets or sets the <c>PathId</c> column value.
		/// </summary>
		/// <value>The <c>PathId</c> column value.</value>
		public System.Guid PathId
		{
			get { return _pathId; }
			set { _pathId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Path</c> column value.
		/// </summary>
		/// <value>The <c>Path</c> column value.</value>
		public string Path
		{
			get { return _path; }
			set { _path = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LoweredPath</c> column value.
		/// </summary>
		/// <value>The <c>LoweredPath</c> column value.</value>
		public string LoweredPath
		{
			get { return _loweredPath; }
			set { _loweredPath = value; }
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
			dynStr.Append("  PathId=");
			dynStr.Append(PathId);
			dynStr.Append("  Path=");
			dynStr.Append(Path);
			dynStr.Append("  LoweredPath=");
			dynStr.Append(LoweredPath);
			return dynStr.ToString();
		}
	} // End of aspnet_PathsRow_Base class
} // End of namespace
