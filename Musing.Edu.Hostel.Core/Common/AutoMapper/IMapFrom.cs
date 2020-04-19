using AutoMapper;

namespace Musing.Edu.Hostel.Core.Common.AutoMapper
{

    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile?.CreateMap(typeof(T), GetType());
    }
}
