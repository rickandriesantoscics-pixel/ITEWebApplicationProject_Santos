using System.Web;
using System.Web.Optimization;

namespace ITEWebApplicationProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        // NOTE: The Bootstrap bundle and the Bootstrap-based style bundle were removed.
        // This application uses Materialize CSS + Tailwind CSS instead (Bootstrap is not allowed
        // as the primary CSS framework for this activity).
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}
