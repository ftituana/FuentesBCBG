using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",

                      "~/Scripts/xcharts.min.js",
                      "~/Scripts/sparklines.js",
                      "~/Scripts/sparkline-chart.js",
                      "~/Scripts/sliders.js",
                      "~/Scripts/scripts.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/owl.carousel.js",
                      "~/Scripts/morris-script.js",
                      "~/Scripts/morris.min.js",
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/jquery.nicescroll.js",
                      "~/Scripts/jquery.localscroll.js",
                      "~/Scripts/jquery.html5shiv.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/elegant-icons-style.css",
                      "~/Content/font-awesome.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/fullcalendar.css",
                      "~/Content/jquery-jvectormap-1.2.2.css",
                      "~/Content/jquery-ui-1.10.4.min.css",
                      "~/Content/line-icons.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/style.css",
                      "~/Content/style-responsive.css",
                      "~/Content/widgets.css",
                      "~/Content/xcharts.min.css"
                      ));
        }
    }
}
