// <fileinfo name="tblStaff_VisaRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_VisaRow"/> that 
	/// represents a record in the <c>tblStaff_Visa</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_VisaRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_VisaRow_Base
	{
		private int _visa_ID;
		private int _passportID;
		private bool _passportIDNull = true;
		private string _visa_No;
		private System.DateTime _date_Given;
		private bool _date_GivenNull = true;
		private System.DateTime _valid_Date;
		private bool _valid_DateNull = true;
		private int _visaType_ID;
		private bool _visaType_IDNull = true;
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
		/// Initializes a new instance of the <see cref="tblStaff_VisaRow_Base"/> class.
		/// </summary>
		public tblStaff_VisaRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Visa_ID</c> column value.
		/// </summary>
		/// <value>The <c>Visa_ID</c> column value.</value>
		public int Visa_ID
		{
			get { return _visa_ID; }
			set { _visa_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PassportID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PassportID</c> column value.</value>
		public int PassportID
		{
			get
			{
				if(IsPassportIDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _passportID;
			}
			set
			{
				_passportIDNull = false;
				_passportID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="PassportID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPassportIDNull
		{
			get { return _passportIDNull; }
			set { _passportIDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Visa_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Visa_No</c> column value.</value>
		public string Visa_No
		{
			get { return _visa_No; }
			set { _visa_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Date_Given</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Date_Given</c> column value.</value>
		public System.DateTime Date_Given
		{
			get
			{
				if(IsDate_GivenNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _date_Given;
			}
			set
			{
				_date_GivenNull = false;
				_date_Given = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Date_Given"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDate_GivenNull
		{
			get { return _date_GivenNull; }
			set { _date_GivenNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Valid_Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Valid_Date</c> column value.</value>
		public System.DateTime Valid_Date
		{
			get
			{
				if(IsValid_DateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _valid_Date;
			}
			set
			{
				_valid_DateNull = false;
				_valid_Date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Valid_Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsValid_DateNull
		{
			get { return _valid_DateNull; }
			set { _valid_DateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>VisaType_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>VisaType_ID</c> column value.</value>
		public int VisaType_ID
		{
			get
			{
				if(IsVisaType_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _visaType_ID;
			}
			set
			{
				_visaType_IDNull = false;
				_visaType_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="VisaType_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsVisaType_IDNull
		{
			get { return _visaType_IDNull; }
			set { _visaType_IDNull = value; }
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
			dynStr.Append("  Visa_ID=");
			dynStr.Append(Visa_ID);
			dynStr.Append("  PassportID=");
			dynStr.Append(IsPassportIDNull ? (object)"<NULL>" : PassportID);
			dynStr.Append("  Visa_No=");
			dynStr.Append(Visa_No);
			dynStr.Append("  Date_Given=");
			dynStr.Append(IsDate_GivenNull ? (object)"<NULL>" : Date_Given);
			dynStr.Append("  Valid_Date=");
			dynStr.Append(IsValid_DateNull ? (object)"<NULL>" : Valid_Date);
			dynStr.Append("  VisaType_ID=");
			dynStr.Append(IsVisaType_IDNull ? (object)"<NULL>" : VisaType_ID);
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
	} // End of tblStaff_VisaRow_Base class
} // End of namespace
