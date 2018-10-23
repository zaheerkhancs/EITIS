// <fileinfo name="aspnet_UsersInRolesRow_Base.cs">
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
	/// The base class for <see cref="aspnet_UsersInRolesRow"/> that 
	/// represents a record in the <c>aspnet_UsersInRoles</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_UsersInRolesRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_UsersInRolesRow_Base
	{
		private System.Guid _userId;
		private System.Guid _roleId;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_UsersInRolesRow_Base"/> class.
		/// </summary>
		public aspnet_UsersInRolesRow_Base()
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
		/// Gets or sets the <c>RoleId</c> column value.
		/// </summary>
		/// <value>The <c>RoleId</c> column value.</value>
		public System.Guid RoleId
		{
			get { return _roleId; }
			set { _roleId = value; }
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
			dynStr.Append("  RoleId=");
			dynStr.Append(RoleId);
			return dynStr.ToString();
		}
	} // End of aspnet_UsersInRolesRow_Base class
} // End of namespace
