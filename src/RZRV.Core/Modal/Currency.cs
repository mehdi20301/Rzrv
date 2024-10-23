using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace RZRV.Modal
{
    [Table("Currency")]
    public abstract class CurrencyBase : Entity<Guid>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public virtual string Name { get; set; }

    }
}