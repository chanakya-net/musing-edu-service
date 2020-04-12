using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using musingDayCareDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareDataBase.Configrations
{
    public class UserLoginConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasAlternateKey(s => s.UserName);
        }
    }
}
