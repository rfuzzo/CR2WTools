using System;

namespace RED
{
    /// <summary>
    /// Marks a field as serializable for redengine files.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class REDAttribute : Attribute
    {
        public string Name { get; private set; }
        public int[] Flags { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDAttribute"/> class.
        /// </summary>
        /// <param name="flags">
        /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
        /// </param>
        public REDAttribute(params int[] flags)
        {
            Flags = flags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="REDAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// Custom name to use in place of the default name.
        /// </param>
        /// <param name="flags">
        /// Values needed for types such as <see cref="TDynArray{T}"/>, <see cref="Static{T}"/>, or <see cref="Array"/>.
        /// </param>
        public REDAttribute(string name, params int[] flags)
        {
            Name = name;
            Flags = flags;
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}]", Name, String.Join(",", Flags));
        }
    }
}