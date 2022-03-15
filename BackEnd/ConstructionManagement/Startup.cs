using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Repository;
using Repository.Service.IService.IClientService;
using Repository.Service.IService.IContractService;
using Repository.Service.IService.IEmployeeService;
using Repository.Service.IService.ILabourService;
using Repository.Service.IService.IMaterialService;
using Repository.Service.IService.IPersonalEquipmentService;
using Repository.Service.IService.IPersonalVehicleService;
using Repository.Service.IService.IRentedEquipmentService;
using Repository.Service.IService.IRentedVehicleService;
using Repository.Service.IService.ISiteService;
using Repository.Service.IService.IUserService;
using Repository.Service.IService.IVendorService;
using Repository.Service.Services.ClientService;
using Repository.Service.Services.ContractService;
using Repository.Service.Services.EmployeeService;
using Repository.Service.Services.LabourService;
using Repository.Service.Services.MaterialService;
using Repository.Service.Services.PersonalEquipmentService;
using Repository.Service.Services.PersonalVehicleService;
using Repository.Service.Services.RentedEquipmentService;
using Repository.Service.Services.RentedVehicleService;
using Repository.Service.Services.SiteService;
using Repository.Service.Services.UserService;
using Repository.Service.Services.VendorService;

namespace ConstructionManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "ConstructionManagement", Version = "v1" });
            });

            
            //Database Configure
            services.AddDbContextPool<ConstructionDbContext>(
                    options => options.
                    UseSqlServer
                    (Configuration.GetConnectionString("ConstructionDbConnection")));

            #region Dependency Injection            //Dependence Injection

            #region Clients
            services.AddScoped <IClientService, ClientService>();
            #endregion

            #region Contracts
            services.AddScoped<IExtendGiveContractService, ExtendGiveContractService>();
            services.AddScoped<IExtendTakeContractService, ExtendTakeContractService>();
            services.AddScoped<IGCPaymentTransactionService, GCPaymentTransactionService>();
            services.AddScoped<IGiveContractService, GiveContractService>();
            services.AddScoped<ITakeContractService, TakeContractService>();
            services.AddScoped<ITCPaymentTransactionService, TCPaymentTransactionService>();
            #endregion

            #region Employees
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeePaymentService, EmployeePaymentService>();
            #endregion

            #region Labour
            services.AddScoped<ILabourService, LabourService>();
            services.AddScoped<ILabourPaymentService, LabourPaymentService>();
            services.AddScoped<ILabourSiteService, LabourSiteService>();
            #endregion

            #region Materials
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialBoughtService, MaterialBoughtService>();
            services.AddScoped<IMaterialSoldService, MaterialSoldService>();
            services.AddScoped<IMaterialStockService, MaterialStockService>();
            services.AddScoped<IMaterialUsedService, MaterialUsedService>();
            services.AddScoped<IMBPaymentTransactionService, MBPaymentTransactionService>();
            services.AddScoped<IMSPaymentTransactionService, MSPaymentTransactionService>();
            #endregion

            #region Personal Equipment
            services.AddScoped<IPEBoughtService, PEBoughtService>();
            services.AddScoped<IPEBPaymentTransactionService, PEBPaymentTransactionService>();
            services.AddScoped<IPEEPaymentTransactionService, PEEPaymentTransactionService>();
            services.AddScoped<IPEExpensesService, PEExpensesService>();
            services.AddScoped<IPEIncomeService, PEIncomeService>();
            services.AddScoped<IPEIPaymentTransactionService, PEIPaymentTransactionService>();
            services.AddScoped<IPersonalEquipmentService, PersonalEquipmentService>();
            #endregion

            #region Personal Vehicle
            services.AddScoped<IPVBoughtService, PVBoughtService>();
            services.AddScoped<IPVBPaymentTransactionService, PVBPaymentTransactionService>();
            services.AddScoped<IPVEPaymentTransactionService, PVEPaymentTransactionService>();
            services.AddScoped<IPVExpensesService, PVExpensesService>();
            services.AddScoped<IPVIncomeService, PVIncomeService>();
            services.AddScoped<IPVIPaymentTransactionService, PVIPaymentTransactionService>();
            services.AddScoped<IPersonalVehicleService, PersonalVehicleService>();
            #endregion

            #region Rented Equipment
            services.AddScoped<IREEPaymentTransactionService, REEPaymentTransactionService>();
            services.AddScoped<IREExpensesService, REExpensesService>();
            services.AddScoped<IREIncomeService, REIncomeService>();
            services.AddScoped<IREIPaymentTransactionService, REIPaymentTransactionService>();
            services.AddScoped<IRentedEquipmentService, RentedEquipmentService>();
            services.AddScoped<IRERentService, RERentService>();
            services.AddScoped<IRERPaymentTransactionService, RERPaymentTransactionService>();
            #endregion

            #region Rented Vehicle
            services.AddScoped<IRentedVehicleService, RentedVehicleService>();
            services.AddScoped<IRVEPaymentTransactionService, RVEPaymentTransactionService>();
            services.AddScoped<IRVExpensesService, RVExpensesService>();
            services.AddScoped<IRVIncomeService, RVIncomeService>();
            services.AddScoped<IRVIPaymentTransactionService, RVIPaymentTransactionService>();
            services.AddScoped<IRVRentService, RVRentService>();
            services.AddScoped<IRVRPaymentTransactionService, RVRPaymentTransactionService>();
            #endregion

            #region Site
            services.AddScoped<ISiteService, SiteService>();
            #endregion

            #region User
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Vendor
            services.AddScoped<IVendorService, VendorService>();
            #endregion

            #endregion
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConstructionManagement"));
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
