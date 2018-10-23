// <fileinfo name="tblRCARow_Base.cs">
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
	/// The base class for <see cref="tblRCARow"/> that 
	/// represents a record in the <c>tblRCA</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblRCARow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblRCARow_Base
	{
		private int _rca_id;
		private int _duration;
		private bool _durationNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblRCARow_Base"/> class.
		/// </summary>
		public tblRCARow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>RCA_ID</c> column value.
		/// </summary>
		/// <value>The <c>RCA_ID</c> column value.</value>
		public int RCA_ID
		{
			get { return _rca_id; }
			set { _rca_id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Duration</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Duration</c> column value.</value>
		public int Duration
		{
			get
			{
				if(IsDurationNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _duration;
			}
			set
			{
				_durationNull = false;
				_duration = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Duration"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDurationNull
		{
			get { return _durationNull; }
			set { _durationNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  RCA_ID=");
			dynStr.Append(RCA_ID);
			dynStr.Append("  Duration=");
			dynStr.Append(IsDurationNull ? (object)"<NULL>" : Duration);
			return dynStr.ToString();
		}
	} // End of tblRCARow_Base class
} // End of namespace
