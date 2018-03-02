using System.Web.Mvc;

namespace Intinsync.MvcForms.Areas.IntinsyncMcd300
{
    public class IntinsyncMcd300AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "IntinsyncMcd300";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "IntinsyncMcd300_default",
                "IntinsyncMcd300/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}