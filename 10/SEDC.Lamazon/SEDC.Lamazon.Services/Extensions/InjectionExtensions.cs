﻿using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SEDC.Lamazon.DataAccess;
using SEDC.Lamazon.DataAccess.DataContext;
using SEDC.Lamazon.DataAccess.Implementations;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Enitities;
using SEDC.Lamazon.Services.Implementations;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.Services.ViewModelValidators;
using System;

namespace SEDC.Lamazon.Services.Extensions
{
    public static class InjectionExtensions
    {
        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IInvoicesRepository, InvoicesRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            services.AddScoped<IProductCategoriesRepository, ProductCategoriesRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();            
            services.AddScoped<IDashboardRepository, DashboardRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoicesService, InvoicesService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IProductCategoriesService, ProductCategoriesService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddHttpClient<IGeoTrackerService, GeoTrackerService>();
            services.AddSingleton<ILocalizationService, LocalizationService>();
        }

        public static void InjectAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void InjectDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));
        }

        public static void InjectFluentValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(s =>
            {
                s.DisableDataAnnotationsValidation = true;
            });
            services.AddValidatorsFromAssemblyContaining<ProductCategoryViewModelValidator>();            
        }

        public static void InjectLog4Net(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddLog4Net();
        }
    }
}
