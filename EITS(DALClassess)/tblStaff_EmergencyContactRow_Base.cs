// <fileinfo name="tblStaff_EmergencyContactRow_Base.cs">
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
	/// The base class for <see cref="tblStaff_EmergencyContactRow"/> that 
	/// represents a record in the <c>tblStaff_EmergencyContact</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblStaff_EmergencyContactRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblStaff_EmergencyContactRow_Base
	{
		private int _emergencyContact_ID;
		private int _staffID;
		private bool _staffIDNull = true;
		private string _emergency_Name;
		private string _emergency_Telephone;
		private string _emergency_Address;
		private int _relationship_ID;
		private bool _relationship_IDNull = true;
		private string _created_By;
		private System.DateTime _created_Date;
		private bool _created_DateNull = true;
		private string _updated_By;
		private System.DateTime _updated_Date;
		private bool _updated_DateNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblStaff_EmergencyContactRow_Base"/> class.
		/// </summary>
		public tblStaff_EmergencyContactRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>EmergencyContact_ID</c> column value.
		/// </summary>
		/// <value>The <c>EmergencyContact_ID</c> column value.</value>
		public int EmergencyContact_ID
		{
			get { return _emergencyContact_ID; }
			set { _emergencyContact_ID = value; }
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
		/// Gets or sets the <c>Emergency_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Emergency_Name</c> column value.</value>
		public string Emergency_Name
		{
			get { return _emergency_Name; }
			set { _emergency_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Emergency_Telephone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Emergency_Telephone</c> column value.</value>
		public string Emergency_Telephone
		{
			get { return _emergency_Telephone; }
			set { _emergency_Telephone = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Emergency_Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Emergency_Address</c> column value.</value>
		public string Emergency_Address
		{
			get { return _emergency_Address; }
			set { _emergency_Address = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Relationship_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Relationship_ID</c> column value.</value>
		public int Relationship_ID
		{
			get
			{
				if(IsRelationship_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _relationship_ID;
			}
			set
			{
				_relationship_IDNull = false;
				_relationship_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Relationship_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsRelationship_IDNull
		{
			get { return _relationship_IDNull; }
			set { _relationship_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Created_By</c> column value.</value>
		public string Created_By
		{
			get { return _created_By; }
			set { _created_By = value; }
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
		public string Updated_By
		{
			get { return _updated_By; }
			set { _updated_By = value; }
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
			dynStr.Append("  EmergencyContact_ID=");
			dynStr.Append(EmergencyContact_ID);
			dynStr.Append("  StaffID=");
			dynStr.Append(IsStaffIDNull ? (object)"<NULL>" : StaffID);
			dynStr.Append("  Emergency_Name=");
			dynStr.Append(Emergency_Name);
			dynStr.Append("  Emergency_Telephone=");
			dynStr.Append(Emergency_Telephone);
			dynStr.Append("  Emergency_Address=");
			dynStr.Append(Emergency_Address);
			dynStr.Append("  Relationship_ID=");
			dynStr.Append(IsRelationship_IDNull ? (object)"<NULL>" : Relationship_ID);
			dynStr.Append("  Created_By=");
			dynStr.Append(Created_By);
			dynStr.Append("  Created_Date=");
			dynStr.Append(IsCreated_DateNull ? (object)"<NULL>" : Created_Date);
			dynStr.Append("  Updated_By=");
			dynStr.Append(Updated_By);
			dynStr.Append("  Updated_Date=");
			dynStr.Append(IsUpdated_DateNull ? (object)"<NULL>" : Updated_Date);
			return dynStr.ToString();
		}
	} // End of tblStaff_EmergencyContactRow_Base class
} // End of namespace
