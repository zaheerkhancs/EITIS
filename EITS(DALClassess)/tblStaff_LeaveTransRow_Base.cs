// <fileinfo name="tblStaff_LeaveTransRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_LeaveTransRow"/> that 
	/// represents a record in the <c>tblStaff_LeaveTrans</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_LeaveTransRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_LeaveTransRow_Base
	{
		private int _leaveTrans_ID;
		private int _contract_ID;
		private bool _contract_IDNull = true;
		private int _staffID;
		private bool _staffIDNull = true;
		private System.DateTime _sub_Date;
		private bool _sub_DateNull = true;
		private int _leave_ID;
		private bool _leave_IDNull = true;
		private System.DateTime _fDate;
		private bool _fDateNull = true;
		private System.DateTime _to_Date;
		private bool _to_DateNull = true;
		private string _remarks;
		private bool _isApproved;
		private bool _isApprovedNull = true;
		private bool _isDeleted;
		private bool _isDeletedNull = true;
		private System.Guid _created_By;
		private bool _created_ByNull = true;
		private System.DateTime _created_Date;
		private bool _created_DateNull = true;
		private System.Guid _updated_By;
		private bool _updated_ByNull = true;
		private System.DateTime _updated_Date;
		private bool _updated_DateNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_LeaveTransRow_Base"/> class.
		/// </summary>
		public tblStaff_LeaveTransRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>LeaveTrans_ID</c> column value.
		/// </summary>
		/// <value>The <c>LeaveTrans_ID</c> column value.</value>
		public int LeaveTrans_ID
		{
			get { return _leaveTrans_ID; }
			set { _leaveTrans_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contract_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contract_ID</c> column value.</value>
		public int Contract_ID
		{
			get
			{
				if(IsContract_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _contract_ID;
			}
			set
			{
				_contract_IDNull = false;
				_contract_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Contract_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsContract_IDNull
		{
			get { return _contract_IDNull; }
			set { _contract_IDNull = value; }
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
		/// Gets or sets the <c>Sub_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Sub_Date</c> column value.</value>
		public System.DateTime Sub_Date
		{
			get
			{
				if(IsSub_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _sub_Date;
			}
			set
			{
				_sub_DateNull = false;
				_sub_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Sub_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsSub_DateNull
		{
			get { return _sub_DateNull; }
			set { _sub_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Leave_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Leave_ID</c> column value.</value>
		public int Leave_ID
		{
			get
			{
				if(IsLeave_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _leave_ID;
			}
			set
			{
				_leave_IDNull = false;
				_leave_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Leave_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsLeave_IDNull
		{
			get { return _leave_IDNull; }
			set { _leave_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FDate</c> column value.</value>
		public System.DateTime FDate
		{
			get
			{
				if(IsFDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _fDate;
			}
			set
			{
				_fDateNull = false;
				_fDate = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="FDate"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsFDateNull
		{
			get { return _fDateNull; }
			set { _fDateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>To_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>To_Date</c> column value.</value>
		public System.DateTime To_Date
		{
			get
			{
				if(IsTo_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _to_Date;
			}
			set
			{
				_to_DateNull = false;
				_to_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="To_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsTo_DateNull
		{
			get { return _to_DateNull; }
			set { _to_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Remarks</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Remarks</c> column value.</value>
		public string Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the <c>isApproved</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>isApproved</c> column value.</value>
		public bool IsApproved
		{
			get
			{
				if(IsIsApprovedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _isApproved;
			}
			set
			{
				_isApprovedNull = false;
				_isApproved = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="IsApproved"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIsApprovedNull
		{
			get { return _isApprovedNull; }
			set { _isApprovedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>isDeleted</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>isDeleted</c> column value.</value>
		public bool IsDeleted
		{
			get
			{
				if(IsIsDeletedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _isDeleted;
			}
			set
			{
				_isDeletedNull = false;
				_isDeleted = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="IsDeleted"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIsDeletedNull
		{
			get { return _isDeletedNull; }
			set { _isDeletedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Created_By</c> column value.</value>
		public System.Guid Created_By
		{
			get
			{
				if(IsCreated_ByNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_By;
			}
			set
			{
				_created_ByNull = false;
				_created_By = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_By"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_ByNull
		{
			get { return _created_ByNull; }
			set { _created_ByNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Created_Date</c> column value.</value>
		public System.DateTime Created_Date
		{
			get
			{
				if(IsCreated_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_Date;
			}
			set
			{
				_created_DateNull = false;
				_created_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_DateNull
		{
			get { return _created_DateNull; }
			set { _created_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Updated_By</c> column value.</value>
		public System.Guid Updated_By
		{
			get
			{
				if(IsUpdated_ByNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _updated_By;
			}
			set
			{
				_updated_ByNull = false;
				_updated_By = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Updated_By"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsUpdated_ByNull
		{
			get { return _updated_ByNull; }
			set { _updated_ByNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Updated_Date</c> column value.</value>
		public System.DateTime Updated_Date
		{
			get
			{
				if(IsUpdated_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _updated_Date;
			}
			set
			{
				_updated_DateNull = false;
				_updated_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Updated_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsUpdated_DateNull
		{
			get { return _updated_DateNull; }
			set { _updated_DateNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  LeaveTrans_ID=");
			dynStr.Append(LeaveTrans_ID);
			dynStr.Append("  Contract_ID=");
			dynStr.Append(IsContract_IDNull ? (object)"<NULL>" : Contract_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  Sub_Date=");
			dynStr.Append(IsSub_DateNull ? (object)"<NULL>" : Sub_Date);
			dynStr.Append("  Leave_ID=");
			dynStr.Append(IsLeave_IDNull ? (object)"<NULL>" : Leave_ID);
			dynStr.Append("  FDate=");
			dynStr.Append(IsFDateNull ? (object)"<NULL>" : FDate);
			dynStr.Append("  To_Date=");
			dynStr.Append(IsTo_DateNull ? (object)"<NULL>" : To_Date);
			dynStr.Append("  Remarks=");
			dynStr.Append(Remarks);
			dynStr.Append("  IsApproved=");
			dynStr.Append(IsIsApprovedNull ? (object)"<NULL>" : IsApproved);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsIsDeletedNull ? (object)"<NULL>" : IsDeleted);
			dynStr.Append("  Created_By=");
			dynStr.Append(IsCreated_ByNull ? (object)"<NULL>" : Created_By);
			dynStr.Append("  Created_Date=");
			dynStr.Append(IsCreated_DateNull ? (object)"<NULL>" : Created_Date);
			dynStr.Append("  Updated_By=");
			dynStr.Append(IsUpdated_ByNull ? (object)"<NULL>" : Updated_By);
			dynStr.Append("  Updated_Date=");
			dynStr.Append(IsUpdated_DateNull ? (object)"<NULL>" : Updated_Date);
			return dynStr.ToString();
		}
	} // End of tblStaff_LeaveTransRow_Base class
} // End of namespace
