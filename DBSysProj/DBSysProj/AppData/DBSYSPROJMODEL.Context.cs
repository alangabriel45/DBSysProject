﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBSysProj.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSYSPROJEntities : DbContext
    {
        public DBSYSPROJEntities()
            : base("name=DBSYSPROJEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAc> RoomAc { get; set; }
        public DbSet<RoomBed> RoomBed { get; set; }
        public DbSet<RoomMax> RoomMax { get; set; }
        public DbSet<RoomMin> RoomMin { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<vw_RoomTable> vw_RoomTable { get; set; }
    }
}