using System;

namespace Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// An entity can implement this interface if <see cref="LastOpenedTime"/> of this entity must be stored.
    /// <see cref="LastOpenedTime"/> is automatically set when updating <see cref="Entity"/>.
    /// </summary>
    public interface IHasOpenedTime
    {
        /// <summary>
        /// The last modified time for this entity.
        /// </summary>
        DateTime? LastOpenedTime { get; set; }
    }
}