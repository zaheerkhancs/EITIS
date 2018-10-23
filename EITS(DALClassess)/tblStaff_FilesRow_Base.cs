// <fileinfo name="tblStaff_FilesRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_FilesRow"/> that 
	/// represents a record in the <c>tblStaff_Files</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_FilesRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_FilesRow_Base
	{
		private int _files_ID;
		private int _staffID;
		private bool _staffIDNull = true;
		private string _path;
		private string _description;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_FilesRow_Base"/> class.
		/// </summary>
		public tblStaff_FilesRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Files_ID</c> column value.
		/// </summary>
		/// <value>The <c>Files_ID</c> column value.</value>
		public int Files_ID
		{
			get { return _files_ID; }
			set { _files_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>StaffID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>StaffID</c> column value.</value>
		public int StaffID
		{
			get
			{
				if(IsStaffIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _staffID;
			}
			set
			{
				_staffIDNull = false;
				_staffID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="StaffID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsStaffIDNull
		{
			get { return _staffIDNull; }
			set { _staffIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Path</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Path</c> column value.</value>
		public string Path
		{
			get { return _path; }
			set { _path = value; }
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
			dynStr.Append("  Files_ID=");
			dynStr.Append(Files_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  Path=");
			dynStr.Append(Path);
			dynStr.Append("  Description=");
			dynStr.Append(Description);
			return dynStr.ToString();
		}
	} // End of tblStaff_FilesRow_Base class
} // End of namespace
