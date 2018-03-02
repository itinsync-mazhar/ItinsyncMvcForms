using System.Web.Mvc;

namespace Intinsync.MvcForms.Areas.IntinsyncMcd200
{
    public class IntinsyncMcd200AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "IntinsyncMcd200";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "IntinsyncMcd200_default",
                "IntinsyncMcd200/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}