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

    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("Experience");
            HasKey(exp => exp.Id);

            Property(exp => exp.Id).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(exp => exp.Date).HasColumnName("EXP_DATE").IsRequired();
            Property(exp => exp.Title).HasColumnName("EXP_TITLE").IsRequired();

            HasRequired(exp => exp.Employee).WithMany(emp => emp.Experiences).HasForeignKey(exp => exp.EmployeeId);
        }
    }
}
