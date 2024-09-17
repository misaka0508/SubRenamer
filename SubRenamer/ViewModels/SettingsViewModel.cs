using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using SubRenamer.Services;
using Microsoft.Extensions.DependencyInjection;
using SubRenamer.Helper;
using SubRenamer.Model;

namespace SubRenamer.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    private bool _backupEnabled = Config.Get().Backup;
    private bool _updateCheckEnabled = Config.Get().UpdateCheck;
    private bool _keepLangExt = Config.Get().KeepLangExt;
    private bool _checkAddSubPrefix = Config.Get().CheckAddSubPrefix;
    private string _addSubPrefix = Config.Get().AddSubPrefix;
    private string _videoExtAppend = Config.Get().VideoExtAppend;
    private string _subtitleExtAppend = Config.Get().SubtitleExtAppend;

    public bool BackupEnabled
    {
        get => _backupEnabled;
        set
        {
            Config.Get().Backup = value;
            SetProperty(ref _backupEnabled, value);
        }
    }
    
    public bool UpdateCheckEnabled
    {
        get => _updateCheckEnabled;
        set
        {
            Config.Get().UpdateCheck = value;
            SetProperty(ref _updateCheckEnabled, value);
        }
    }

    public bool KeepLangExt
    {
        get => _keepLangExt;
        set
        {
            Config.Get().KeepLangExt = value;
            SetProperty(ref _keepLangExt, value);
        }
    }

    public bool CheckAddSubPrefix
    {
        get => _checkAddSubPrefix;
        set
        {
            Config.Get().CheckAddSubPrefix = value;
            SetProperty(ref _checkAddSubPrefix, value);
        }
    }

    public string AddSubPrefix
    {
        get => _addSubPrefix;
        set
        {
            Config.Get().AddSubPrefix = value;
            SetProperty(ref _addSubPrefix, value);
        }
    }
    public string VideoExtAppend
    {
        get => _videoExtAppend;
        set
        {
            Config.Get().VideoExtAppend = value;
            SetProperty(ref _videoExtAppend, value);
        }
    }
    
    
    
    public string SubtitleExtAppend
    {
        get => _subtitleExtAppend;
        set
        {
            Config.Get().SubtitleExtAppend = value;
            SetProperty(ref _subtitleExtAppend, value);
        }
    }
    
    [RelayCommand]
    private void OpenLink(string url) => BrowserHelper.OpenBrowserAsync(url);
}