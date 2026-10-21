using SegundaMano.Models.Maps;
using SegundaMano.Models.Tables;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SegundaMano.Models.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SegundaManoContext : DbContext
    {
        // 1. Static constructor to stop Entity Framework from creating or changing database tables automatically
        static SegundaManoContext()
        {
            Database.SetInitializer<SegundaManoContext>(null);
        }

        // 2. Public constructor referencing the connection string name in your web.config file
        public SegundaManoContext() : base("name=SegundaManoDB")
        {
        }

        // 3. Virtual DbSets representing all 19 database tables
        public virtual DbSet<TblRolesModel> tblRoles { get; set; }
        public virtual DbSet<TblCategoriesModel> tblCategories { get; set; }
        public virtual DbSet<TblConditionsModel> tblConditions { get; set; }
        public virtual DbSet<TblMeasurementTypesModel> tblMeasurementTypes { get; set; }
        public virtual DbSet<TblOrderStatusesModel> tblOrderStatuses { get; set; }
        public virtual DbSet<TblFulfillmentMethodsModel> tblFulfillmentMethods { get; set; }
        public virtual DbSet<TblPaymentMethodsModel> tblPaymentMethods { get; set; }
        public virtual DbSet<TblPaymentStatusesModel> tblPaymentStatuses { get; set; }
        public virtual DbSet<TblUsersModel> tblUsers { get; set; }
        public virtual DbSet<TblAddressesModel> tblAddresses { get; set; }
        public virtual DbSet<TblProductsModel> tblProducts { get; set; }
        public virtual DbSet<TblProductMeasurementsModel> tblProductMeasurements { get; set; }
        public virtual DbSet<TblProductImagesModel> tblProductImages { get; set; }
        public virtual DbSet<TblCartsModel> tblCarts { get; set; }
        public virtual DbSet<TblCartItemsModel> tblCartItems { get; set; }
        public virtual DbSet<TblOrdersModel> tblOrders { get; set; }
        public virtual DbSet<TblOrderAddressesModel> tblOrderAddresses { get; set; }
        public virtual DbSet<TblOrderItemsModel> tblOrderItems { get; set; }
        public virtual DbSet<TblPaymentsModel> tblPayments { get; set; }

        // 4. Overriding OnModelCreating to add all 19 map classes
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TblRolesMap());
            modelBuilder.Configurations.Add(new TblCategoriesMap());
            modelBuilder.Configurations.Add(new TblConditionsMap());
            modelBuilder.Configurations.Add(new TblMeasurementTypesMap());
            modelBuilder.Configurations.Add(new TblOrderStatusesMap());
            modelBuilder.Configurations.Add(new TblFulfillmentMethodsMap());
            modelBuilder.Configurations.Add(new TblPaymentMethodsMap());
            modelBuilder.Configurations.Add(new TblPaymentStatusesMap());
            modelBuilder.Configurations.Add(new TblUsersMap());
            modelBuilder.Configurations.Add(new TblAddressesMap());
            modelBuilder.Configurations.Add(new TblProductsMap());
            modelBuilder.Configurations.Add(new TblProductMeasurementsMap());
            modelBuilder.Configurations.Add(new TblProductImagesMap());
            modelBuilder.Configurations.Add(new TblCartsMap());
            modelBuilder.Configurations.Add(new TblCartItemsMap());
            modelBuilder.Configurations.Add(new TblOrdersMap());
            modelBuilder.Configurations.Add(new TblOrderAddressesMap());
            modelBuilder.Configurations.Add(new TblOrderItemsMap());
            modelBuilder.Configurations.Add(new TblPaymentsMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}