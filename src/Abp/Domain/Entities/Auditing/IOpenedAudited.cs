namespace Abp.Domain.Entities.Auditing
{
    /// <summary>
    /// This interface is implemented by entities that is wanted to store opened information (who and when opened lastly).
    /// Opened time and open user are automatically set when saving <see cref="Entity"/> to database.
    /// </summary>
    public interface IOpenedAudited : IHasOpenedTime
    {
        /// <summary>
        /// Id of the creator user of this entity.
        /// </summary>
        long? LastOpenedUserId { get; set; }
    }

    /// <summary>
    /// Adds navigation properties to <see cref="IOpenedAudited"/> interface for user.
    /// </summary>
    /// <typeparam name="TUser">Type of the user</typeparam>
    public interface IOpenedAudited<TUser> : IOpenedAudited
        where TUser : IEntity<long>
    {
        /// <summary>
        /// Reference to the creator user of this entity.
        /// </summary>
        TUser LastOpenedUser { get; set; }
    }
}