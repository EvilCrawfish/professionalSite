using System.Web.Optimization;

namespace DustinCrawford.Web.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
            );
            bundles.Add(new StyleBundle("~/bundles/facss", "//maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/bundles/localstyles")
                .Include("~/Content/business-casual.css")
                .Include("~/Content/linkStyle.css")
                .Include("~/Content/paddingStyle.css")
            );
            bundles.Add(new StyleBundle("~/bundles/fonts", "//fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800"));
            bundles.Add(new StyleBundle("~/bundles/fonts_two", "//fonts.googleapis.com/css?family=Josefin+Slab:100,300,400,600,700,100italic,300italic,400italic,600italic,700italic"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-2.2.0.min.js")
            );
        }
    }
}