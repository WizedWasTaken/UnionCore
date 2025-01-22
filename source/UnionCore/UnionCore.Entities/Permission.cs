using System.Runtime.CompilerServices;

namespace UnionCore.Entities
{
    /// <summary>
    /// Represents a permission entity with an ID, name, and description.
    /// </summary>
    public class Permission
    {
        #region Fields

        private Guid permissionId;
        private string name;
        private string description;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier for the permission.
        /// </summary>
        public Guid PermissionId
        {
            get { return permissionId; }
            set { permissionId = value; }
        }

        /// <summary>
        /// Gets or sets the name of the permission.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the description of the permission.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission"/> class with a new unique identifier.
        /// </summary>
        public Permission()
        {
            PermissionId = Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission"/> class with the specified name and description.
        /// </summary>
        /// <param name="name">The name of the permission.</param>
        /// <param name="description">The description of the permission.</param>
        public Permission(string name, string description)
        {
            PermissionId = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission"/> class with the specified ID, name, and description.
        /// </summary>
        /// <param name="id">The unique identifier of the permission.</param>
        /// <param name="name">The name of the permission.</param>
        /// <param name="description">The description of the permission.</param>
        public Permission(Guid id, string name, string description)
        {
            PermissionId = id;
            Name = name;
            Description = description;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
