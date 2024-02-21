namespace Constructor_DI.Repository
{
    public interface IServiceCollection
    {
        void AddControllersWithViews();
        void AddScoped<T1, T2>();
    }
}