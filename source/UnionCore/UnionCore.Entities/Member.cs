using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UnionCore.Entities
{
    /// <summary>
    /// Represents a member entity with a username, full name, job title, and a list of permissions.
    /// </summary>
    public class Member : IdentityUser
    {
        #region Fields

        private Guid memberId;
        private string fullName;
        private string jobTitle;
        private List<Permission> permissions;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the member id.
        /// </summary>
        public Guid MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

        /// <summary>
        /// Gets or sets the full name of the member.
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        /// <summary>
        /// Gets or sets the job title of the member.
        /// </summary>
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        /// <summary>
        /// Gets or sets the list of permissions assigned to the member.
        /// </summary>
        public List<Permission> Permissions
        {
            get { return permissions; }
            set { permissions = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        public Member()
        {
            MemberId = Guid.NewGuid();
            Permissions = [];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified username, full name, and job title.
        /// </summary>
        /// <param name="userName">The username of the member.</param>
        /// <param name="fullName">The full name of the member.</param>
        /// <param name="jobTitle">The job title of the member.</param>
        public Member(string userName, string fullName, string jobTitle)
            : this()
        {
            MemberId = Guid.NewGuid();
            UserName = userName;
            FullName = fullName;
            JobTitle = jobTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified username, full name, and job title.
        /// </summary>
        /// <param name="userName">The username of the member.</param>
        /// <param name="fullName">The full name of the member.</param>
        /// <param name="jobTitle">The job title of the member.</param>
        public Member(Guid memberId, string userName, string fullName, string jobTitle)
            : this()
        {
            MemberId = memberId;
            UserName = userName;
            FullName = fullName;
            JobTitle = jobTitle;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines whether the member has a specific permission by name.
        /// </summary>
        /// <param name="permissionName">The name of the permission.</param>
        /// <returns><c>true</c> if the member has the specified permission; otherwise, <c>false</c>.</returns>
        public bool HasPermission(string permissionName)
        {
            return Permissions.Any(p => p.Name == permissionName);
        }

        /// <summary>
        /// Determines whether the member has a specific permission.
        /// </summary>
        /// <param name="permission">The permission to check.</param>
        /// <returns><c>true</c> if the member has the specified permission; otherwise, <c>false</c>.</returns>
        public bool HasPermission(Permission permission)
        {
            return Permissions.Contains(permission);
        }

        #endregion
    }
}
