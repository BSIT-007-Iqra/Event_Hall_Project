using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Event_Hall_Project.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AccessLevel_> AccessLevel_ { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventOrganizer> EventOrganizers { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel_>()
                .HasMany(e => e.Admins)
                .WithOptional(e => e.AccessLevel_)
                .HasForeignKey(e => e.AccessLevel_FID);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.BookingDetails)
                .WithOptional(e => e.Booking)
                .HasForeignKey(e => e.Booking_FID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Packages)
                .WithOptional(e => e.Event)
                .HasForeignKey(e => e.Event_FID);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Package)
                .HasForeignKey(e => e.Package_FID);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Packages)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.Service_FID);

            modelBuilder.Entity<ServiceCategory>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.ServiceCategory)
                .HasForeignKey(e => e.ServiceCategory_FID);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Venue)
                .HasForeignKey(e => e.Venue_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.Packages)
                .WithOptional(e => e.Venue)
                .HasForeignKey(e => e.Venue_FID);
        }
    }
}
