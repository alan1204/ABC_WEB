//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual ROLES ROLES { get; set; }
    }
}