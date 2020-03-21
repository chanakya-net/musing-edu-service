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
            builder.ToTable("User_Login_Information");
        }
    }

    public class UserRoleConfigration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.ToTable("User_Roles");
        }
    }

    public class UserInformationConfigration : IEntityTypeConfiguration<UserDetailInformation>
    {
        public void Configure(EntityTypeBuilder<UserDetailInformation> builder)
        {
            builder.ToTable("User_information");
        }
    }
}
