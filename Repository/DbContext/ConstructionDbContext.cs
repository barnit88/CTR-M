using Entity.Models.Clients;
using Entity.Models.Contract;
using Entity.Models.Employees;
using Entity.Models.Labour;
using Entity.Models.Material;
using Entity.Models.PersonalEquipment;
using Entity.Models.PersonalVehicle;
using Entity.Models.RentedEquipment;
using Entity.Models.RentedVehicle;
using Entity.Models.Sites;
using Entity.Models.Users;
using Entity.Models.Vendors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Repository
{
    public class ConstructionDbContext : IdentityDbContext<User>
    {

        public ConstructionDbContext
            (DbContextOptions<ConstructionDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
            base.OnModelCreating(builder);
            AdminSeedData(builder);
            foreach(var relationship in builder.Model
                .GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        #region DbSet - Table 


        #region Client
        public DbSet<Client> Clients { get; set; }
        #endregion


        #region Contracts
        public DbSet<ExtendGiveContract> ExtendGiveContracts { get; set; }

        public DbSet<ExtendTakeContract> ExtendTakeContracts { get; set; }

        public DbSet<GCPaymentTransaction> GCPaymentTransactions { get; set; }

        public DbSet<GiveContract> GiveContracts { get; set; }

        public DbSet<TakeContract> TakeContracts { get; set; }

        public DbSet<TCPaymentTransaction> TCPaymentTransactions { get; set; }
        #endregion


        #region Employee
        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<EmployeePayment> EmployeePayments { get; set; }
        #endregion


        #region Labour
        public DbSet<Labour> Labours { get; set; }
        
        public DbSet<LabourPayment> LabourPayments { get; set; }
        
        public DbSet<LabourSite> LabourSites { get; set; }
        #endregion


        #region Material
        public DbSet<Material> Materials { get; set; }
        
        public DbSet<MaterialBought> MaterialBought { get; set; }
        
        public DbSet<MaterialSold> MaterialSold { get; set; }
        
        public DbSet<MaterialStock> MaterialStocks { get; set; }
        
        public DbSet<MaterialUsed> MaterialUsed { get; set; }

        public DbSet<MBPaymentTransaction> MBPaymentTransactions { get; set; }

        public DbSet<MSPaymentTransaction> MSPaymentTransactions { get; set; }
        #endregion


        #region Personal Equipment
        public DbSet<PEBought> PEBought { get; set; }
        
        public DbSet<PEBPaymentTransaction> PEBPaymentTransactions { get; set; }

        public DbSet<PEEPaymentTransaction> PEEPaymentTransactions { get; set; }

        public DbSet<PEExpenses> PEExpenses { get; set; }
        
        public DbSet<PEIncome> PEIncomes { get; set; }
        
        public DbSet<PEIPaymentTransaction> PEIPaymentTransactions { get; set; }
        
        public DbSet<PersonalEquipment> PersonalEquipments { get; set; }
        #endregion

        
        #region Personal Vehicle
        public DbSet<PersonalVehicle> PersonalVehicles { get; set; }
        
        public DbSet<PVBought> PVBought { get; set; }

        public DbSet<PVBPaymentTransaction> PVBPaymentTransactions { get; set; }

        public DbSet<PVEPaymentTransaction> PVEPaymentTransactions { get; set; }

        public DbSet<PVExpenses> PVExpensess { get; set; }
        
        public DbSet<PVIncome> PVIncomeTransactions { get; set; }
        
        public DbSet<PVIPaymentTransaction> PVIPaymentTransactions { get; set; }
        #endregion


        #region Rented Equipment
        public DbSet<REEPaymentTransaction> REEPaymentTransactions { get; set; }

        public DbSet<REExpenses> REExpensess { get; set; }
        
        public DbSet<REIncome> REIncomes { get; set; }
        
        public DbSet<REIPaymentTransaction> REIPaymentTransactions { get; set; }
        
        public DbSet<RentedEquipment> RentedEquipments { get; set; }

        public DbSet<RERent> RERents { get; set; }
        
        public DbSet<RERPaymentTransaction> RERPaymentTransactions { get; set; }
        #endregion


        #region Rented Vehicle
        public DbSet<RentedVehicle> RentedVehicles { get; set; }

        public DbSet<RVEPaymentTransaction> RVEPaymentTransactions { get; set; }
        
        public DbSet<RVExpenses> RVExpensesTransactions { get; set; }

        public DbSet<RVIncome> RVIncomes { get; set; }

        public DbSet<RVIPaymentTransaction> RVIPaymentTransactions { get; set; }
        
        public DbSet<RVRent> RVRents { get; set; }

        public DbSet<RVRPaymentTransaction> RVRPaymentTransactions { get; set; }
        #endregion


        #region Sites
        public DbSet<Site> Sites { get; set; }
        #endregion


        #region Vendor
        public DbSet<Vendor> Vendors { get; set; }
        #endregion



        #endregion


        #region Login Data Seeding
        private void AdminSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "Admin",
                    NormalizedName = "Admin"
                }
              );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com",
                    PasswordHash = GenerateHash("p@ssw0rd")
                }
              );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
              );
        }

        #region PasswordHasher
        private static string GenerateHash(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes
                (password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
        #endregion

        #endregion


    }
}
