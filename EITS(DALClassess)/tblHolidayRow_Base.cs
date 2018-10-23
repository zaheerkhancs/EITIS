// <fileinfo name="tblHolidayRow_Base.cs">
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
	/// The base class for <see cref="tblHolidayRow"/> that 
	/// represents a record in the <c>tblHoliday</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblHolidayRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblHolidayRow_Base
	{
		private int _holidayId;
		private string _holidayName;
		private System.DateTime _date;
		private bool _dateNull = true;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblHolidayRow_Base"/> class.
		/// </summary>
		public tblHolidayRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>HolidayId</c> column value.
		/// </summary>
		/// <value>The <c>HolidayId</c> column value.</value>
		public int HolidayId
		{
			get { return _holidayId; }
			set { _holidayId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>HolidayName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>HolidayName</c> column value.</value>
		public string HolidayName
		{
			get { return _holidayName; }
			set { _holidayName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Date</c> column value.</value>
		public System.DateTime Date
		{
			get
			{
				if(IsDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _date;
			}
			set
			{
				_dateNull = false;
				_date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDateNull
		{
			get { return _dateNull; }
			set { _dateNull = value; }
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
			dynStr.Append("  HolidayId=");
			dynStr.Append(HolidayId);
			dynStr.Append("  HolidayName=");
			dynStr.Append(HolidayName);
			dynStr.Append("  Date=");
			dynStr.Append(IsDateNull ? (object)"<NULL>" : Date);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of tblHolidayRow_Base class
} // End of namespace
