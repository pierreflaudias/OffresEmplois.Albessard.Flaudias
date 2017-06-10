using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FluentEntities
{
    public class StatusFluent : EntityTypeConfiguration<Status>
    {

        public StatusFluent()
        {
            ToTable("Status");
            HasKey(sta => sta.Id);

            Property(sta => sta.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(sta => sta.Label).HasColumnName("STA_LABEL").IsRequired();
            
        }
    }
}
