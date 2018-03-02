using System.Web.Mvc;

namespace Intinsync.MvcForms.Areas.IntinsyncMcd100
{
    public class IntinsyncMcd100AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "IntinsyncMcd100";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "IntinsyncMcd100_default",
                "IntinsyncMcd100/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}