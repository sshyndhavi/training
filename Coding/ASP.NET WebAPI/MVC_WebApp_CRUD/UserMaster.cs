//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_WebApp_CRUD
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMaster
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<System.DateTime> createon { get; set; }
    
        public virtual Rolemaster Rolemaster { get; set; }
    }
}
