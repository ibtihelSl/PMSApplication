using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class User : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {

        //[Key]
        //[Required]
        //public String Matricule { get; set; }

        [StringLength(25)]
        [Required]
        public string Nom { get; set; }

        [StringLength(25)]
        [Required]
        public string Prenom { get; set; }

        [RegularExpression("#^[0-9]{8}$#", ErrorMessage = "Le numéro de CIN est incorrect")]
        [Required]
        public int Cin { get; set; }

        [RegularExpression("#^[2-9][0-9]{8}$#", ErrorMessage = "Le numéro de téléphone est incorrect")]
        [Required]
        public int NumTel { get; set; }

        [StringLength(25)]
        [Required]
        public string Service { get; set; }

        [StringLength(25)]
        [Required]
        public string Role { get; set; }

        public float Nbrconge { get; set; }

        public float Salaire { get; set; }

        public String Password { get; set; }
        public override String Email { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        {
            // Note the authenticationType must match the one defined in
            // CookieAuthenticationOptions.AuthenticationType 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 
            return userIdentity;
        }

    }
public class CustomUserLogin : IdentityUserLogin<int>
{
    public int Id { get; set; }

}

public class CustomUserRole : IdentityUserRole<int>
{
    public int Id { get; set; }
}

public class CustomUserClaim : IdentityUserClaim<int>
{

}

public class CustomRole : IdentityRole<int, CustomUserRole>
{
    public CustomRole() { }
    public CustomRole(string name) { Name = name; }
}
}
