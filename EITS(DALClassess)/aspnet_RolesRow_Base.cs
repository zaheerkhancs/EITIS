// <fileinfo name="aspnet_RolesRow_Base.cs">
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
	/// The base class for <see cref="aspnet_RolesRow"/> that 
	/// represents a record in the <c>aspnet_Roles</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_RolesRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_RolesRow_Base
	{
		private System.Guid _applicationId;
		private System.Guid _roleId;
		private string _roleName;
		private string _loweredRoleName;
		private string _description;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_RolesRow_Base"/> class.
		/// </summary>
		public aspnet_RolesRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ApplicationId</c> column value.
		/// </summary>
		/// <value>The <c>ApplicationId</c> column value.</value>
		public System.Guid ApplicationId
		{
			get { return _applicationId; }
			set { _applicationId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RoleId</c> column value.
		/// </summary>
		/// <value>The <c>RoleId</c> column value.</value>
		public System.Guid RoleId
		{
			get { return _roleId; }
			set { _roleId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RoleName</c> column value.
		/// </summary>
		/// <value>The <c>RoleName</c> column value.</value>
		public string RoleName
		{
			get { return _roleName; }
			set { _roleName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LoweredRoleName</c> column value.
		/// </summary>
		/// <value>The <c>LoweredRoleName</c> column value.</value>
		public string LoweredRoleName
		{
			get { return _loweredRoleName; }
			set { _loweredRoleName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Description</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Description</c> column value.</value>
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  ApplicationId=");
			dynStr.Append(ApplicationId);
			dynStr.Append("  RoleId=");
			dynStr.Append(RoleId);
			dynStr.Append("  RoleName=");
			dynStr.Append(RoleName);
			dynStr.Append("  LoweredRoleName=");
			dynStr.Append(LoweredRoleName);
			dynStr.Append("  Description=");
			dynStr.Append(Description);
			return dynStr.ToString();
		}
	} // End of aspnet_RolesRow_Base class
} // End of namespace
