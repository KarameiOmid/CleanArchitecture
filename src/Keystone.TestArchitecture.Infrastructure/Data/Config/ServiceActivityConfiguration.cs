using System.Reflection.Emit;
using Keystone.TestArchitecture.Core.ServiceLearningAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Keystone.TestArchitecture.Infrastructure.Data.Config;

public class ServiceActivityConfiguration : IEntityTypeConfiguration<ServiceActivity>
{
  public void Configure(EntityTypeBuilder<ServiceActivity> builder)
  {
    builder.ToTable("ServiceActivity", "ServiceLearning")
                .HasKey(t => t.Id);

    //builder.Property(p => p.ActivityDescription)
    //    .HasMaxLength(4000)
    //    .IsRequired();
  }
}
