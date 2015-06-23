namespace Repository.Pattern.Infrastructure
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IObjectState
    {
        Guid Id { get; set; }

        [NotMapped]
        ObjectState ObjectState { get; set; }

        byte[] RowVersion { get; set; }
    }
}
