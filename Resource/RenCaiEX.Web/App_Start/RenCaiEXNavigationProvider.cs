using Abp.Application.Navigation;
using Abp.Localization;

namespace RenCaiEX.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class RenCaiEXNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", RenCaiEXConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Corporation",
                        new LocalizableString("Corporation", RenCaiEXConsts.LocalizationSourceName),
                        url: "#/corporation",
                        icon: "fa fa-university"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Job",
                        new LocalizableString("Job", RenCaiEXConsts.LocalizationSourceName),
                        url: "#/job",
                        icon: "fa fa-envelope"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", RenCaiEXConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
