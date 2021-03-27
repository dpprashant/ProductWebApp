using System.Web;
using System.Web.Optimization;

namespace ProductWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(                        
                        "~/Content/js/move-top.js",
                        "~/Content/js/easing.js",
                        "~/Content/js/easyResponsiveTabs.js",
                        "~/Content/js/tikslus360.min.js",
                        "~/Content/js/rainbow.min.js",
                        "~/Content/unitegallery/js/*.js",
                        "~/Content/unitegallery/themes/default/ug-theme-default.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/style.css",
                "~/Content/css/tikslus360.css",
                "~/Content/unitegallery/css/unite-gallery.css",
                "~/Content/unitegallery/themes/default/ug-theme-default.css"));
        }
    }
}
