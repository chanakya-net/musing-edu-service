using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.WardenCore.Commands.WardenUpdate
{
    public class UpdateWardenCommand: UpdateWardenVm, IRequest<Warden>
    {
    }
}
