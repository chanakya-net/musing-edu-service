using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.WardenCore.Queries.SelectAllWarden
{
    public class SelectAllWardenQuery : IRequest<ICollection<SelectWardenOnlyVm>>
    {
        public bool isActive{get;set;}
    }
}
