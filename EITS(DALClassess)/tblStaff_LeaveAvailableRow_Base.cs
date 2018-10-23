// <fileinfo name="tblStaff_LeaveAvailableRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_LeaveAvailableRow"/> that 
	/// represents a record in the <c>tblStaff_LeaveAvailable</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_LeaveAvailableRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_LeaveAvailableRow_Base
	{
		private int _leaveAvailable_ID;
		private int _staffID;
		private bool _staffIDNull = true;
		private int _leaveAvailable;
		private bool _leaveAvailableNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_LeaveAvailableRow_Base"/> class.
		/// </summary>
		public tblStaff_LeaveAvailableRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>LeaveAvailable_ID</c> column value.
		/// </summary>
		/// <value>The <c>LeaveAvailable_ID</c> column value.</value>
		public int LeaveAvailable_ID
		{
			get { return _leaveAvailable_ID; }
			set { _leaveAvailable_ID = value; }
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
		/// Gets or sets the <c>LeaveAvailable</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LeaveAvailable</c> column value.</value>
		public int LeaveAvailable
		{
			get
			{
				if(IsLeaveAvailableNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _leaveAvailable;
			}
			set
			{
				_leaveAvailableNull = false;
				_leaveAvailable = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="LeaveAvailable"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsLeaveAvailableNull
		{
			get { return _leaveAvailableNull; }
			set { _leaveAvailableNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  LeaveAvailable_ID=");
			dynStr.Append(LeaveAvailable_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  LeaveAvailable=");
			dynStr.Append(IsLeaveAvailableNull ? (object)"<NULL>" : LeaveAvailable);
			return dynStr.ToString();
		}
	} // End of tblStaff_LeaveAvailableRow_Base class
} // End of namespace
