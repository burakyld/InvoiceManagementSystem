using IMS.Application.Contracts.Persistence.Repositories.Buildings;
using IMS.Application.Contracts.Persistence.Repositories.Commons;
using IMS.Application.Contracts.Persistence.Repositories.Contacts;
using IMS.Application.Contracts.Persistence.Repositories.Invoices;
using IMS.Application.Contracts.Persistence.Repositories.Payments;
using IMS.Infrastructure.Contracts.Persistence;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IMS.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBConnectionString")));

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IApartmentTypeRepository, ApartmentTypeRepository>();
            services.AddScoped<IBlockRepository, BlockRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTypeRepository, InvoiceTypeRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            return services;
        }
    }
}
