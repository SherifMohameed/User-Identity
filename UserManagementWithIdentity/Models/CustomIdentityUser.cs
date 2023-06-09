﻿namespace UserManagementWithIdentity.Models
{
    public class ApplicationUsers : IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
