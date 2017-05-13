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
    class EmployeeFluent : EntityTypeConfiguration<Employee>
    {

        public EmployeeFluent()
        {
            ToTable("Employee");
            HasKey(emp => emp.Id);

            Property(emp => emp.Id).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(emp => emp.Name).HasColumnName("EMP_NAME").IsRequired();
            Property(emp => emp.Biography).HasColumnName("EMP_BIOGRAPHY").IsRequired();
            Property(emp => emp.BirthDate).HasColumnName("EMP_BIRTHDATE").IsRequired();
            Property(emp => emp.Seniority).HasColumnName("EMP_SENIORITY").IsRequired();
            Property(emp => emp.FirstName).HasColumnName("EMP_FIRSTNAME").IsRequired();

            HasMany(emp => emp.Experiences).WithRequired(exp => exp.Employee).HasForeignKey(exp => exp.EmployeeId);
        }

    }
}
