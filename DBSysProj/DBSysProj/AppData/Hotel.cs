//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Hotel
    {
        public Hotel()
        {
            this.Room = new HashSet<Room>();
        }
    
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string hotelAddress { get; set; }
    
        public virtual ICollection<Room> Room { get; set; }
    }
}