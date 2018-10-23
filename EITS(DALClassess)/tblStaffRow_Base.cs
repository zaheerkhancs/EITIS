// <fileinfo name="tblStaffRow_Base.cs">
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
	/// The base class for <see cref="tblStaffRow"/> that 
	/// represents a record in the <c>tblStaff</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaffRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaffRow_Base
	{
		private int _staffID;
		private string _lastName;
		private string _firstName;
		private string _middleName;
		private System.DateTime _birthDate;
		private bool _birthDateNull = true;
		private string _id_No;
		private int _department_ID;
		private bool _department_IDNull = true;
		private string _homeAddress1;
		private string _homeAddress2;
		private int _country_ID;
		private bool _country_IDNull = true;
		private string _contact_Kabul;
		private string _contact_Personal;
		private string _email;
		private string _email_Personal;
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
		/// Initializes a new instance of the <see cref="tblStaffRow_Base"/> class.
		/// </summary>
		public tblStaffRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>StaffID</c> column value.
		/// </summary>
		/// <value>The <c>StaffID</c> column value.</value>
		public int StaffID
		{
			get { return _staffID; }
			set { _staffID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>LastName</c> column value.</value>
		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FirstName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FirstName</c> column value.</value>
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MiddleName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>MiddleName</c> column value.</value>
		public string MiddleName
		{
			get { return _middleName; }
			set { _middleName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BirthDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>BirthDate</c> column value.</value>
		public System.DateTime BirthDate
		{
			get
			{
				if(IsBirthDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _birthDate;
			}
			set
			{
				_birthDateNull = false;
				_birthDate = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="BirthDate"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsBirthDateNull
		{
			get { return _birthDateNull; }
			set { _birthDateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Id_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Id_No</c> column value.</value>
		public string Id_No
		{
			get { return _id_No; }
			set { _id_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Department_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Department_ID</c> column value.</value>
		public int Department_ID
		{
			get
			{
				if(IsDepartment_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _department_ID;
			}
			set
			{
				_department_IDNull = false;
				_department_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Department_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDepartment_IDNull
		{
			get { return _department_IDNull; }
			set { _department_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>HomeAddress1</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HomeAddress1</c> column value.</value>
		public string HomeAddress1
		{
			get { return _homeAddress1; }
			set { _homeAddress1 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>HomeAddress2</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HomeAddress2</c> column value.</value>
		public string HomeAddress2
		{
			get { return _homeAddress2; }
			set { _homeAddress2 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Country_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country_ID</c> column value.</value>
		public int Country_ID
		{
			get
			{
				if(IsCountry_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _country_ID;
			}
			set
			{
				_country_IDNull = false;
				_country_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Country_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCountry_IDNull
		{
			get { return _country_IDNull; }
			set { _country_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contact_Kabul</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact_Kabul</c> column value.</value>
		public string Contact_Kabul
		{
			get { return _contact_Kabul; }
			set { _contact_Kabul = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contact_Personal</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact_Personal</c> column value.</value>
		public string Contact_Personal
		{
			get { return _contact_Personal; }
			set { _contact_Personal = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email_Personal</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email_Personal</c> column value.</value>
		public string Email_Personal
		{
			get { return _email_Personal; }
			set { _email_Personal = value; }
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
			dynStr.Append("  StaffID=");
			dynStr.Append(StaffID);
			dynStr.Append("  LastName=");
			dynStr.Append(LastName);
			dynStr.Append("  FirstName=");
			dynStr.Append(FirstName);
			dynStr.Append("  MiddleName=");
			dynStr.Append(MiddleName);
			dynStr.Append("  BirthDate=");
			dynStr.Append(IsBirthDateNull ? (object)"<NULL>" : BirthDate);
			dynStr.Append("  Id_No=");
			dynStr.Append(Id_No);
			dynStr.Append("  Department_ID=");
			dynStr.Append(IsDepartment_IDNull ? (object)"<NULL>" : Department_ID);
			dynStr.Append("  HomeAddress1=");
			dynStr.Append(HomeAddress1);
			dynStr.Append("  HomeAddress2=");
			dynStr.Append(HomeAddress2);
			dynStr.Append("  Country_ID=");
			dynStr.Append(IsCountry_IDNull ? (object)"<NULL>" : Country_ID);
			dynStr.Append("  Contact_Kabul=");
			dynStr.Append(Contact_Kabul);
			dynStr.Append("  Contact_Personal=");
			dynStr.Append(Contact_Personal);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  Email_Personal=");
			dynStr.Append(Email_Personal);
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
	} // End of tblStaffRow_Base class
} // End of namespace
