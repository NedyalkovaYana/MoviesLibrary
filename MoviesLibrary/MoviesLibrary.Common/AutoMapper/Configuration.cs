namespace MoviesLibrary.Common.AutoMapper
{
    using MoviesLibrary.ViewModels.Account;

    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
                config.CreateMap<UserAccountViewModel, UserAccount>().ReverseMap();
            )
        }
    }
}
