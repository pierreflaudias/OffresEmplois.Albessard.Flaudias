using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FluentEntities
{
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("Postulation");
            HasKey(pos => new { pos.EmployeeId, pos.OfferId });

            Property(pos => pos.OfferId).HasColumnName("POS_OFFERID").IsRequired();
            Property(pos => pos.EmployeeId).HasColumnName("POS_EMPLOYEEID").IsRequired();

            Property(pos => pos.Date).HasColumnName("POS_DATE").IsRequired();
            Property(pos => pos.Status).HasColumnName("POS_STATUS").IsRequired();

            HasRequired(pos => pos.Offer).WithMany(off => off.Postulations).HasForeignKey(pos => pos.OfferId);
            HasRequired(pos => pos.Employee).WithMany(emp => emp.Postulations).HasForeignKey(pos => pos.EmployeeId);
        }
    }
}
