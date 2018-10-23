// <fileinfo name="tblStaff_ContractRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_ContractRow"/> that 
	/// represents a record in the <c>tblStaff_Contract</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_ContractRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_ContractRow_Base
	{
		private int _contract_ID;
		private int _staffID;
		private bool _staffIDNull = true;
		private string _jobTitle;
		private string _contract_Code;
		private System.DateTime _con_SDate;
		private bool _con_SDateNull = true;
		private System.DateTime _con_EDate;
		private bool _con_EDateNull = true;
		private int _contractType_ID;
		private bool _contractType_IDNull = true;
		private int _contractStatus_ID;
		private bool _contractStatus_IDNull = true;
		private int _dutyStation_ID;
		private bool _dutyStation_IDNull = true;
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
		/// Initializes a new instance of the <see cref="tblStaff_ContractRow_Base"/> class.
		/// </summary>
		public tblStaff_ContractRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Contract_ID</c> column value.
		/// </summary>
		/// <value>The <c>Contract_ID</c> column value.</value>
		public int Contract_ID
		{
			get { return _contract_ID; }
			set { _contract_ID = value; }
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
		/// Gets or sets the <c>JobTitle</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>JobTitle</c> column value.</value>
		public string JobTitle
		{
			get { return _jobTitle; }
			set { _jobTitle = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contract_Code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contract_Code</c> column value.</value>
		public string Contract_Code
		{
			get { return _contract_Code; }
			set { _contract_Code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Con_SDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Con_SDate</c> column value.</value>
		public System.DateTime Con_SDate
		{
			get
			{
				if(IsCon_SDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _con_SDate;
			}
			set
			{
				_con_SDateNull = false;
				_con_SDate = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Con_SDate"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCon_SDateNull
		{
			get { return _con_SDateNull; }
			set { _con_SDateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Con_EDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Con_EDate</c> column value.</value>
		public System.DateTime Con_EDate
		{
			get
			{
				if(IsCon_EDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _con_EDate;
			}
			set
			{
				_con_EDateNull = false;
				_con_EDate = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Con_EDate"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCon_EDateNull
		{
			get { return _con_EDateNull; }
			set { _con_EDateNull = value; }
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
		/// Gets or sets the <c>ContractStatus_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ContractStatus_ID</c> column value.</value>
		public int ContractStatus_ID
		{
			get
			{
				if(IsContractStatus_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _contractStatus_ID;
			}
			set
			{
				_contractStatus_IDNull = false;
				_contractStatus_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="ContractStatus_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsContractStatus_IDNull
		{
			get { return _contractStatus_IDNull; }
			set { _contractStatus_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>DutyStation_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>DutyStation_ID</c> column value.</value>
		public int DutyStation_ID
		{
			get
			{
				if(IsDutyStation_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _dutyStation_ID;
			}
			set
			{
				_dutyStation_IDNull = false;
				_dutyStation_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="DutyStation_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDutyStation_IDNull
		{
			get { return _dutyStation_IDNull; }
			set { _dutyStation_IDNull = value; }
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
			dynStr.Append("  Contract_ID=");
			dynStr.Append(Contract_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  JobTitle=");
			dynStr.Append(JobTitle);
			dynStr.Append("  Contract_Code=");
			dynStr.Append(Contract_Code);
			dynStr.Append("  Con_SDate=");
			dynStr.Append(IsCon_SDateNull ? (object)"<NULL>" : Con_SDate);
			dynStr.Append("  Con_EDate=");
			dynStr.Append(IsCon_EDateNull ? (object)"<NULL>" : Con_EDate);
			dynStr.Append("  ContractType_ID=");
			dynStr.Append(IsContractType_IDNull ? (object)"<NULL>" : ContractType_ID);
			dynStr.Append("  ContractStatus_ID=");
			dynStr.Append(IsContractStatus_IDNull ? (object)"<NULL>" : ContractStatus_ID);
			dynStr.Append("  DutyStation_ID=");
			dynStr.Append(IsDutyStation_IDNull ? (object)"<NULL>" : DutyStation_ID);
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
	} // End of tblStaff_ContractRow_Base class
} // End of namespace
