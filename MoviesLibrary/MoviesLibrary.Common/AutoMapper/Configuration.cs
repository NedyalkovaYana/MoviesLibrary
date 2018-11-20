using AutoMapper;

namespace MoviesLibrary.Common.AutoMapper
{
    using MoviesLibrary.ViewModels.Account;

    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
               // cfg.CreateMap<RegisterViewModel, Register>()
                  
            });
        }
    }
}
