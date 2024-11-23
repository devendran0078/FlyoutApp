using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlyOutApp.Services
{
    /*
    public class LocalizationResourceManager
    {

        private static LocalizationResourceManager _instance;

        public static LocalizationResourceManager Instance => _instance ??= new LocalizationResourceManager();

        private ResourceManager _resourceManager;

        public void Init(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public string this[string key]
        {
            get
            {
                return _resourceManager?.GetString(key, CultureInfo.CurrentUICulture) ?? string.Empty;
            }
        }

        public void ChangeCulture(CultureInfo culture)
        {
            CultureInfo.CurrentUICulture = culture;
        }

    }
    */
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        private readonly ResourceManager _resourceManager;
        private static LocalizationResourceManager _instance;

        public static LocalizationResourceManager Instance => _instance ??= new LocalizationResourceManager();

        public LocalizationResourceManager()
        {
            // Point to the correct resource file location and namespace
            _resourceManager = new ResourceManager("FlyOutApp.Resources.Strings.LangResource", typeof(LocalizationResourceManager).Assembly);
        }

        public string this[string key]
        {
            get
            {
                Debug.Write($"************************{key}*************************");
               var val= _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? string.Empty;
                Debug.Write($"************************{key}***{val}**********************");
                return _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? string.Empty;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
