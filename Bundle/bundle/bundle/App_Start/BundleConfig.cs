using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace bundle.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/login/js").Include("~/Content/js/bootstrap.min.js", "~/Content/js/jquery.js"));

        }
    }
}