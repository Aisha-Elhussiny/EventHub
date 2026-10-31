using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BadgeNumber)
                .IsRequired();

            builder.HasIndex(b => b.BadgeNumber)
                .IsUnique();

            builder.Property(b => b.IssueDate)
                .IsRequired();

            builder.Property(b => b.Tier)
                .IsRequired();

            builder.HasOne(b => b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId);
        }

       
    }
}
