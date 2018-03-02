using Intinsync.DAL.DBContexts;
using Intinsync.MvcForms.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Intinsync.MvcForms.Startup))]
namespace Intinsync.MvcForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            IdentityDB context = new IdentityDB();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var Role1 = "SuperAdmin";
            var Role2 = "Admin";
            var Role3 = "Client";

            if (!roleManager.RoleExists(Role1))
            {
                var role = new IdentityRole();
                role.Name = Role1;
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "SuperUser";
                user.Email = "email@superadmin.com";

                string UserPassword = "avaya@1209";

                var chkUser = userManager.Create(user, UserPassword);

                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, Role1);
                }
            }

            if (!roleManager.RoleExists(Role2))
            {
                var role = new IdentityRole();
                role.Name = Role2;
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists(Role3))
            {
                var role = new IdentityRole();
                role.Name = Role3;
                roleManager.Create(role);
            }
        }
    }
}
