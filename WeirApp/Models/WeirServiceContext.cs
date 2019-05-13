using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeirApp.Models
{
    public class WeirServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WeirServiceContext() : base("name=WeirServiceContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WeirServiceContext>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WearProfileCollateral>()
            .HasRequired<WearProfile>(s => s.WearProfile)
            .WithMany(g => g.Collaterals)
            .HasForeignKey<int>(s => s.ProfileId);

        }

        public System.Data.Entity.DbSet<WeirApp.Models.Lookup> Lookups { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.Impeller> Impellers { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.ServiceRequest> ServiceRequests { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.ServiceRequestStaging> ServiceRequestStaging { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.ServiceRequestSilver> SilverServiceRequests { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.WearProfile> WearProfiles { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.WearProfileCollateral> WearProfileCollaterals { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.Measurement> Measurements { get; set; }

        public System.Data.Entity.DbSet<WeirApp.Models.CaseStudy> CaseStudy { get; set; }
        public System.Data.Entity.DbSet<WeirApp.Models.CaseStudyStaging> CaseStudyStaging { get; set; }
        public System.Data.Entity.DbSet<WeirApp.Models.WearTheory> WearTheory { get; set; }
        public System.Data.Entity.DbSet<WeirApp.Models.SlurryWearTypeMapping> SlurryWearTypeMapping { get; set; }
    }
}
