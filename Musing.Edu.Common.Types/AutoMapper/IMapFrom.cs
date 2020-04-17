using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Musing.Edu.Common.Types.AutoMapper
{
  
        public interface IMapFrom<T>
        {
            void Mapping(Profile profile) => profile?.CreateMap(typeof(T), GetType());
        }
}
