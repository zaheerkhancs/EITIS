// <fileinfo name="aspnet_SchemaVersionsRow_Base.cs">
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
	/// The base class for <see cref="aspnet_SchemaVersionsRow"/> that 
	/// represents a record in the <c>aspnet_SchemaVersions</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_SchemaVersionsRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_SchemaVersionsRow_Base
	{
		private string _feature;
		private string _compatibleSchemaVersion;
		private bool _isCurrentVersion;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_SchemaVersionsRow_Base"/> class.
		/// </summary>
		public aspnet_SchemaVersionsRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Feature</c> column value.
		/// </summary>
		/// <value>The <c>Feature</c> column value.</value>
		public string Feature
		{
			get { return _feature; }
			set { _feature = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CompatibleSchemaVersion</c> column value.
		/// </summary>
		/// <value>The <c>CompatibleSchemaVersion</c> column value.</value>
		public string CompatibleSchemaVersion
		{
			get { return _compatibleSchemaVersion; }
			set { _compatibleSchemaVersion = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsCurrentVersion</c> column value.
		/// </summary>
		/// <value>The <c>IsCurrentVersion</c> column value.</value>
		public bool IsCurrentVersion
		{
			get { return _isCurrentVersion; }
			set { _isCurrentVersion = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Feature=");
			dynStr.Append(Feature);
			dynStr.Append("  CompatibleSchemaVersion=");
			dynStr.Append(CompatibleSchemaVersion);
			dynStr.Append("  IsCurrentVersion=");
			dynStr.Append(IsCurrentVersion);
			return dynStr.ToString();
		}
	} // End of aspnet_SchemaVersionsRow_Base class
} // End of namespace
