namespace CharityGateServiceDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CharityGateServiceModel : DbContext
    {
        public CharityGateServiceModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<OrganizationsFunctionality> OrganizationsFunctionalities { get; set; }
        public virtual DbSet<OrganizationsItem> OrganizationsItems { get; set; }
        public virtual DbSet<OrganizationsType> OrganizationsTypes { get; set; }
        public virtual DbSet<PaymentStatu> PaymentStatus { get; set; }
        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasMany(e => e.Memberships)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Roles)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Membership)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Profile)
                .WithRequired(e => e.User);
        }
    }
}
