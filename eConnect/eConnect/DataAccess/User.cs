//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eConnect.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
