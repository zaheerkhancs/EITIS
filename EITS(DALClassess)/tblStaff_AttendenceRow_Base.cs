// <fileinfo name="tblStaff_AttendenceRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_AttendenceRow"/> that 
	/// represents a record in the <c>tblStaff_Attendence</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_AttendenceRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_AttendenceRow_Base
	{
		private long _atten_ID;
		private int _contract_ID;
		private bool _contract_IDNull = true;
		private System.DateTime _atten_Date;
		private bool _atten_DateNull = true;
		private int _daysWorked;
		private bool _daysWorkedNull = true;
		private decimal _amountPaid;
		private bool _amountPaidNull = true;
		private string _remarks;
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
		/// Initializes a new instance of the <see cref="tblStaff_AttendenceRow_Base"/> class.
		/// </summary>
		public tblStaff_AttendenceRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Atten_ID</c> column value.
		/// </summary>
		/// <value>The <c>Atten_ID</c> column value.</value>
		public long Atten_ID
		{
			get { return _atten_ID; }
			set { _atten_ID = value; }
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
		/// Gets or sets the <c>Atten_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Atten_Date</c> column value.</value>
		public System.DateTime Atten_Date
		{
			get
			{
				if(IsAtten_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _atten_Date;
			}
			set
			{
				_atten_DateNull = false;
				_atten_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Atten_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsAtten_DateNull
		{
			get { return _atten_DateNull; }
			set { _atten_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DaysWorked</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DaysWorked</c> column value.</value>
		public int DaysWorked
		{
			get
			{
				if(IsDaysWorkedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _daysWorked;
			}
			set
			{
				_daysWorkedNull = false;
				_daysWorked = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DaysWorked"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDaysWorkedNull
		{
			get { return _daysWorkedNull; }
			set { _daysWorkedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AmountPaid</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>AmountPaid</c> column value.</value>
		public decimal AmountPaid
		{
			get
			{
				if(IsAmountPaidNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _amountPaid;
			}
			set
			{
				_amountPaidNull = false;
				_amountPaid = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="AmountPaid"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsAmountPaidNull
		{
			get { return _amountPaidNull; }
			set { _amountPaidNull = value; }
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
			dynStr.Append("  Atten_ID=");
			dynStr.Append(Atten_ID);
			dynStr.Append("  Contract_ID=");
			dynStr.Append(IsContract_IDNull ? (object)"<NULL>" : Contract_ID);
			dynStr.Append("  Atten_Date=");
			dynStr.Append(IsAtten_DateNull ? (object)"<NULL>" : Atten_Date);
			dynStr.Append("  DaysWorked=");
			dynStr.Append(IsDaysWorkedNull ? (object)"<NULL>" : DaysWorked);
			dynStr.Append("  AmountPaid=");
			dynStr.Append(IsAmountPaidNull ? (object)"<NULL>" : AmountPaid);
			dynStr.Append("  Remarks=");
			dynStr.Append(Remarks);
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
	} // End of tblStaff_AttendenceRow_Base class
} // End of namespace
