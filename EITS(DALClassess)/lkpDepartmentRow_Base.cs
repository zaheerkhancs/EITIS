// <fileinfo name="lkpDepartmentRow_Base.cs">
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
	/// The base class for <see cref="lkpDepartmentRow"/> that 
	/// represents a record in the <c>lkpDepartment</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpDepartmentRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpDepartmentRow_Base
	{
		private int _department_ID;
		private string _department_Name;
		private int _agency_ID;
		private bool _agency_IDNull = true;
		private int _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpDepartmentRow_Base"/> class.
		/// </summary>
		public lkpDepartmentRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Department_ID</c> column value.
		/// </summary>
		/// <value>The <c>Department_ID</c> column value.</value>
		public int Department_ID
		{
			get { return _department_ID; }
			set { _department_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Department_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Department_Name</c> column value.</value>
		public string Department_Name
		{
			get { return _department_Name; }
			set { _department_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Agency_ID</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Agency_ID</c> column value.</value>
		public int Agency_ID
		{
			get
			{
				if(IsAgency_IDNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _agency_ID;
			}
			set
			{
				_agency_IDNull = false;
				_agency_ID = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Agency_ID"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsAgency_IDNull
		{
			get { return _agency_IDNull; }
			set { _agency_IDNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Active</c> column value.</value>
		public int Active
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
			dynStr.Append("  Department_ID=");
			dynStr.Append(Department_ID);
			dynStr.Append("  Department_Name=");
			dynStr.Append(Department_Name);
			dynStr.Append("  Agency_ID=");
			dynStr.Append(IsAgency_IDNull ? (object)"<NULL>" : Agency_ID);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpDepartmentRow_Base class
} // End of namespace
