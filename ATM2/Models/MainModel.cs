namespace ATM2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainModel : DbContext
    {
        public MainModel()
            : base("name=MainModel")
        {
        }

        public virtual DbSet<ATM> ATMs { get; set; }
        public virtual DbSet<CalendarDimension> CalendarDimensions { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<NN_CarMission> NN_CarMission { get; set; }
        public virtual DbSet<NN_RouteLocation> NN_RouteLocation { get; set; }
        public virtual DbSet<NN_StatusAtm> NN_StatusAtm { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ATM>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ATM>()
                .HasMany(e => e.NN_StatusAtm)
                .WithRequired(e => e.ATM)
                .HasForeignKey(e => e.AtmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ATM>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.ATM)
                .HasForeignKey(e => e.AtmId);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.DaySuffix)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.WeekDayName)
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.HolidayText)
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.MonthName)
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.QuarterName)
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.MMYYYY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .Property(e => e.MonthYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CalendarDimension>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.CalendarDimension)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.AverageSpeed)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.NN_CarMission)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<Location>()
                .Property(e => e.Longitude)
                .HasPrecision(11, 8);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.ATMs)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Maps)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.FromLocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Maps1)
                .WithRequired(e => e.Location1)
                .HasForeignKey(e => e.ToLocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.NN_RouteLocation)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Routes)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.FromLocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Routes1)
                .WithRequired(e => e.Location1)
                .HasForeignKey(e => e.ToLocationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Map>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Map>()
                .Property(e => e.Lenght)
                .HasPrecision(7, 3);

            modelBuilder.Entity<Map>()
                .Property(e => e.AverageSpeed)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Mission>()
                .HasMany(e => e.NN_CarMission)
                .WithRequired(e => e.Mission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NN_StatusAtm>()
                .Property(e => e.AtmId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Route>()
                .HasMany(e => e.Missions)
                .WithRequired(e => e.Route)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>()
                .HasMany(e => e.NN_RouteLocation)
                .WithRequired(e => e.Route)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.NN_StatusAtm)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.AtmId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Packages)
                .WithRequired(e => e.Transaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.Locations)
                .WithRequired(e => e.Zone)
                .WillCascadeOnDelete(false);
        }
    }
}
