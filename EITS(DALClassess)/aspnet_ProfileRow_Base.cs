// <fileinfo name="aspnet_ProfileRow_Base.cs">
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
	/// The base class for <see cref="aspnet_ProfileRow"/> that 
	/// represents a record in the <c>aspnet_Profile</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_ProfileRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_ProfileRow_Base
	{
		private System.Guid _userId;
		private string _propertyNames;
		private string _propertyValuesString;
		private byte[] _propertyValuesBinary;
		private System.DateTime _lastUpdatedDate;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_ProfileRow_Base"/> class.
		/// </summary>
		public aspnet_ProfileRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
		public System.Guid UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PropertyNames</c> column value.
		/// </summary>
		/// <value>The <c>PropertyNames</c> column value.</value>
		public string PropertyNames
		{
			get { return _propertyNames; }
			set { _propertyNames = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PropertyValuesString</c> column value.
		/// </summary>
		/// <value>The <c>PropertyValuesString</c> column value.</value>
		public string PropertyValuesString
		{
			get { return _propertyValuesString; }
			set { _propertyValuesString = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PropertyValuesBinary</c> column value.
		/// </summary>
		/// <value>The <c>PropertyValuesBinary</c> column value.</value>
		public byte[] PropertyValuesBinary
		{
			get { return _propertyValuesBinary; }
			set { _propertyValuesBinary = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LastUpdatedDate</c> column value.
		/// </summary>
		/// <value>The <c>LastUpdatedDate</c> column value.</value>
		public System.DateTime LastUpdatedDate
		{
			get { return _lastUpdatedDate; }
			set { _lastUpdatedDate = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  UserId=");
			dynStr.Append(UserId);
			dynStr.Append("  PropertyNames=");
			dynStr.Append(PropertyNames);
			dynStr.Append("  PropertyValuesString=");
			dynStr.Append(PropertyValuesString);
			dynStr.Append("  LastUpdatedDate=");
			dynStr.Append(LastUpdatedDate);
			return dynStr.ToString();
		}
	} // End of aspnet_ProfileRow_Base class
} // End of namespace
