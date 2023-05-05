using eshop.Application;
using eshop.Data.Data;
using eshop.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eshop.API.Extension
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddIoCDetails(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));
            return services;

        }
    }
}
