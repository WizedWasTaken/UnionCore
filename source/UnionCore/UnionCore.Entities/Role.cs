using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionCore.Entities
{
    /// <summary>
    /// Represents a role entity with a list of permissions.
    /// </summary>
    public class Role : IdentityRole
    {
        #region Fields

        private List<Permission> permissions;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the list of permissions assigned to the role.
        /// </summary>
        public List<Permission> Permissions
        {
            get { return permissions; }
            set { permissions = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            Permissions = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class with the specified role name.
        /// </summary>
        /// <param name="roleName">The name of the role.</param>
        public Role(string roleName)
            : base(roleName)
        {
            Permissions = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class with the specified list of permissions.
        /// </summary>
        /// <param name="permissions">The list of permissions assigned to the role.</param>
        public Role(List<Permission> permissions)
            : base()
        {
            Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class with the specified list of permissions and role name.
        /// </summary>
        /// <param name="permissions">The list of permissions assigned to the role.</param>
        /// <param name="roleName">The name of the role.</param>
        public Role(List<Permission> permissions, string roleName)
            : base(roleName)
        {
            Permissions = permissions;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a permission to the role.
        /// </summary>
        /// <param name="permission">The permission to add.</param>
        public void AddPermission(Permission permission)
        {
            Permissions.Add(permission);
        }

        /// <summary>
        /// Removes a permission from the role.
        /// </summary>
        /// <param name="permission">The permission to remove.</param>
        public void RemovePermission(Permission permission)
        {
            Permissions.Remove(permission);
        }

        #endregion 
    }
}
