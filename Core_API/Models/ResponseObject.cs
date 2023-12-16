﻿namespace Core_API.Models
{
    /// <summary>
    /// A COmmon Response Objet for All Read/Write OPerations for any ENtity object
    /// TENtity is Constraint to EntityBAse
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ResponseObject<TEntity> where TEntity : EntityBase
    {
       public IEnumerable<TEntity>? Records { get; set; }
       public TEntity? Record { get; set; }
       public string? Message { get; set; }
       public int StatusCode { get; set; }
    }
}
