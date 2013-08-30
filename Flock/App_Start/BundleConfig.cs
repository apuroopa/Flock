﻿using System.Web;
using System.Web.Optimization;

namespace Flock
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/underScorejs").Include(
                "~/Scripts/underscore.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/bundles/JSApplication").Include(
                "~/JSApplication/main.js",
                "~/JSApplication/Services/messageService.js",
                "~/JSApplication/Services/loginService.js",
                "~/JSApplication/Controllers/registrationController.js",
                "~/JSApplication/Controllers/messageController.js",
                "~/JSApplication/Services/messageService.js",
                "~/JSApplication/Services/registrationService.js",
                "~/JSApplication/Directives/onEnter.js",
                 "~/JSApplication/Directives/setTitle.js",
                "~/JSApplication/Controllers/loginController.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css", "~/Content/FlockApplication.css"));            

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.css",
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}