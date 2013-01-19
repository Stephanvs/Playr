using System.Web.Optimization;

namespace Play
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/assets/scripts/bootstrap")
                .IncludeDirectory("~/Scripts", "*.js", searchSubdirectories: false));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/assets/styles/bootstrap")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-responsive.css"));

            var lessBundle = new Bundle("~/assets/styles")
                //.Include("~/Styles/animate.css")
                .IncludeDirectory("~/Styles", "*.less");

            lessBundle.Transforms.Add(new LessTransform());
            lessBundle.Transforms.Add(new CssMinify());
            BundleTable.Bundles.Add(lessBundle);
        }
    }
}