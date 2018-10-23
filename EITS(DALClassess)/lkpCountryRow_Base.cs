// <fileinfo name="lkpCountryRow_Base.cs">
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
	/// The base class for <see cref="lkpCountryRow"/> that 
	/// represents a record in the <c>lkpCountry</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpCountryRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpCountryRow_Base
	{
		private int _country_ID;
		private string _country_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpCountryRow_Base"/> class.
		/// </summary>
		public lkpCountryRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Country_ID</c> column value.
		/// </summary>
		/// <value>The <c>Country_ID</c> column value.</value>
		public int Country_ID
		{
			get { return _country_ID; }
			set { _country_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Country_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country_Name</c> column value.</value>
		public string Country_Name
		{
			get { return _country_Name; }
			set { _country_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Country_ID=");
			dynStr.Append(Country_ID);
			dynStr.Append("  Country_Name=");
			dynStr.Append(Country_Name);
			return dynStr.ToString();
		}
	} // End of lkpCountryRow_Base class
} // End of namespace
