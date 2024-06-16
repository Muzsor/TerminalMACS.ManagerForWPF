﻿using TerminalMACS.Home.I18nResources;
using TerminalMACS.Home.Views;
using TerminalMACS.Infrastructure.UI;
using TerminalMACS.Infrastructure.UI.Modularity;
using WpfExtensions.Xaml;

namespace TerminalMACS.Home;

[Module(ModuleName = ModuleNames.HOME)]
public class HomeModule : ModuleBase
{
    private readonly IRegionManager _regionManager;

    public HomeModule(IUnityContainer container, IRegionManager regionManager) : base(container)
    {
        I18nManager.Instance.Add(UiResource.ResourceManager);
        _regionManager = regionManager;
    }

    public override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        _regionManager.RegisterViewWithRegion(RegionNames.MainTabRegion, typeof(MainTabItem));
        _regionManager.RegisterViewWithRegion(RegionNames.SettingsTabRegion, typeof(SettingsTabItem));
    }
}