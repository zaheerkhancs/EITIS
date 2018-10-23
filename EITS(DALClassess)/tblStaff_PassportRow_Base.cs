// <fileinfo name="tblStaff_PassportRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_PassportRow"/> that 
	/// represents a record in the <c>tblStaff_Passport</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_PassportRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_PassportRow_Base
	{
		private int _passport_ID;
		private int _staffID;
		private bool _staffIDNull = true;
		private int _passportType_ID;
		private bool _passportType_IDNull = true;
		private string _passport_No;
		private System.DateTime _date_Issued;
		private bool _date_IssuedNull = true;
		private System.DateTime _valid_Until;
		private bool _valid_UntilNull = true;
		private bool _active;
		private bool _activeNull = true;
		private System.Guid _created_By;
		private bool _created_ByNull = true;
		private System.DateTime _created_Date;
		private bool _created_DateNull = true;
		private System.Guid _updated_By;
		private bool _updated_ByNull = true;
		private System.DateTime _updated_Date;
		private bool _updated_DateNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_PassportRow_Base"/> class.
		/// </summary>
		public tblStaff_PassportRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Passport_ID</c> column value.
		/// </summary>
		/// <value>The <c>Passport_ID</c> column value.</value>
		public int Passport_ID
		{
			get { return _passport_ID; }
			set { _passport_ID = value; }
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
		/// Gets or sets the <c>PassportType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PassportType_ID</c> column value.</value>
		public int PassportType_ID
		{
			get
			{
				if(IsPassportType_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _passportType_ID;
			}
			set
			{
				_passportType_IDNull = false;
				_passportType_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="PassportType_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPassportType_IDNull
		{
			get { return _passportType_IDNull; }
			set { _passportType_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Passport_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Passport_No</c> column value.</value>
		public string Passport_No
		{
			get { return _passport_No; }
			set { _passport_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Date_Issued</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Date_Issued</c> column value.</value>
		public System.DateTime Date_Issued
		{
			get
			{
				if(IsDate_IssuedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _date_Issued;
			}
			set
			{
				_date_IssuedNull = false;
				_date_Issued = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Date_Issued"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDate_IssuedNull
		{
			get { return _date_IssuedNull; }
			set { _date_IssuedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Valid_Until</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Valid_Until</c> column value.</value>
		public System.DateTime Valid_Until
		{
			get
			{
				if(IsValid_UntilNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _valid_Until;
			}
			set
			{
				_valid_UntilNull = false;
				_valid_Until = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Valid_Until"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsValid_UntilNull
		{
			get { return _valid_UntilNull; }
			set { _valid_UntilNull = value; }
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
			dynStr.Append("  Passport_ID=");
			dynStr.Append(Passport_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  PassportType_ID=");
			dynStr.Append(IsPassportType_IDNull ? (object)"<NULL>" : PassportType_ID);
			dynStr.Append("  Passport_No=");
			dynStr.Append(Passport_No);
			dynStr.Append("  Date_Issued=");
			dynStr.Append(IsDate_IssuedNull ? (object)"<NULL>" : Date_Issued);
			dynStr.Append("  Valid_Until=");
			dynStr.Append(IsValid_UntilNull ? (object)"<NULL>" : Valid_Until);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
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
	} // End of tblStaff_PassportRow_Base class
} // End of namespace
