// <fileinfo name="lkpLeaveRow_Base.cs">
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
	/// The base class for <see cref="lkpLeaveRow"/> that 
	/// represents a record in the <c>lkpLeave</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpLeaveRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpLeaveRow_Base
	{
		private int _leave_ID;
		private int _contractType_ID;
		private bool _contractType_IDNull = true;
		private int _leaveTypeID;
		private bool _leaveTypeIDNull = true;
		private int _leaveDays;
		private bool _leaveDaysNull = true;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpLeaveRow_Base"/> class.
		/// </summary>
		public lkpLeaveRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Leave_ID</c> column value.
		/// </summary>
		/// <value>The <c>Leave_ID</c> column value.</value>
		public int Leave_ID
		{
			get { return _leave_ID; }
			set { _leave_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ContractType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ContractType_ID</c> column value.</value>
		public int ContractType_ID
		{
			get
			{
				if(IsContractType_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _contractType_ID;
			}
			set
			{
				_contractType_IDNull = false;
				_contractType_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="ContractType_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsContractType_IDNull
		{
			get { return _contractType_IDNull; }
			set { _contractType_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LeaveTypeID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LeaveTypeID</c> column value.</value>
		public int LeaveTypeID
		{
			get
			{
				if(IsLeaveTypeIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _leaveTypeID;
			}
			set
			{
				_leaveTypeIDNull = false;
				_leaveTypeID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="LeaveTypeID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsLeaveTypeIDNull
		{
			get { return _leaveTypeIDNull; }
			set { _leaveTypeIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LeaveDays</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LeaveDays</c> column value.</value>
		public int LeaveDays
		{
			get
			{
				if(IsLeaveDaysNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _leaveDays;
			}
			set
			{
				_leaveDaysNull = false;
				_leaveDays = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="LeaveDays"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsLeaveDaysNull
		{
			get { return _leaveDaysNull; }
			set { _leaveDaysNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
		public bool Active
		{
			get
			{
				if(IsActiveNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _active;
			}
			set
			{
				_activeNull = false;
				_active = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Active"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsActiveNull
		{
			get { return _activeNull; }
			set { _activeNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Leave_ID=");
			dynStr.Append(Leave_ID);
			dynStr.Append("  ContractType_ID=");
			dynStr.Append(IsContractType_IDNull ? (object)"<NULL>" : ContractType_ID);
			dynStr.Append("  LeaveTypeID=");
			dynStr.Append(IsLeaveTypeIDNull ? (object)"<NULL>" : LeaveTypeID);
			dynStr.Append("  LeaveDays=");
			dynStr.Append(IsLeaveDaysNull ? (object)"<NULL>" : LeaveDays);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpLeaveRow_Base class
} // End of namespace
