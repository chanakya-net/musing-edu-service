using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.DataBase.Configuration
{
   public  class HostelConfiguration: IEntityTypeConfiguration<MHostel>
    {
        public void Configure(EntityTypeBuilder<MHostel> builder)
        {
            builder.OwnsOne(h => h.GeneralInformation);
        }
    }
}

