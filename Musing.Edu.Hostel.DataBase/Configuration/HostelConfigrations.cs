using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.DataBase.Configuration
{
   public  class HostelConfiguration: IEntityTypeConfiguration<HostelSetup>
    {
        public void Configure(EntityTypeBuilder<HostelSetup> builder)
        {
            //builder.OwnsOne(h => h.GeneralInformation);
        }
    }
}

