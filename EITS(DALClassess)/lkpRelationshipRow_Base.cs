// <fileinfo name="lkpRelationshipRow_Base.cs">
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
	/// The base class for <see cref="lkpRelationshipRow"/> that 
	/// represents a record in the <c>lkpRelationship</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="lkpRelationshipRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class lkpRelationshipRow_Base
	{
		private int _relationship_ID;
		private string _relationship_Name;
		private bool _active;
		private bool _activeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="lkpRelationshipRow_Base"/> class.
		/// </summary>
		public lkpRelationshipRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Relationship_ID</c> column value.
		/// </summary>
		/// <value>The <c>Relationship_ID</c> column value.</value>
		public int Relationship_ID
		{
			get { return _relationship_ID; }
			set { _relationship_ID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Relationship_Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Relationship_Name</c> column value.</value>
		public string Relationship_Name
		{
			get { return _relationship_Name; }
			set { _relationship_Name = value; }
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
			dynStr.Append("  Relationship_ID=");
			dynStr.Append(Relationship_ID);
			dynStr.Append("  Relationship_Name=");
			dynStr.Append(Relationship_Name);
			dynStr.Append("  Active=");
			dynStr.Append(IsActiveNull ? (object)"<NULL>" : Active);
			return dynStr.ToString();
		}
	} // End of lkpRelationshipRow_Base class
} // End of namespace
