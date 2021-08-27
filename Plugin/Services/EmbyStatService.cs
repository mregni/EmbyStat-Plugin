using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Persistence;
using MediaBrowser.Model.Configuration;
using Plugin.Configuration;

namespace Plugin.Services
{
    public class EmbyStatService
    {
        private readonly IConfigurationManager _configurationManager;
        private readonly ILibraryManager _libraryManager;

        public EmbyStatService(IConfigurationManager configurationManager, ILibraryManager libraryManager)
        {
            _configurationManager = configurationManager;
            _libraryManager = libraryManager;
        }

        public void ItemUpdated(object sender, ItemChangeEventArgs e)
        {
            if (e.Item.GetType() == typeof(Movie))
            {
                var library = _libraryManager.GetLibraryOptions(e.Item);
                var configuration = _configurationManager.GetEmbyStatConfiguration();

                if (!configuration.LibraryTypesToScan.Contains(library.ContentType))
                {
                    configuration.LibraryTypesToScan.Add(library.ContentType);
                    _configurationManager.SaveEmbyStatConfiguration(configuration);
                }
            }
        }

        public void ItemRemoved(object sender, ItemChangeEventArgs e)
        {
             if (e.Item.MediaType == "Movies")
            {

            }
        }

        public void ItemAdded(object sender, ItemChangeEventArgs e)
        {
            if (e.Item.GetType() == typeof(Movie))
            {
                var library = _libraryManager.GetLibraryOptions(e.Item);
                var configuration = _configurationManager.GetEmbyStatConfiguration();

                if (!configuration.LibraryTypesToScan.Contains(library.ContentType))
                {
                    configuration.LibraryTypesToScan.Add(library.ContentType);
                    _configurationManager.SaveEmbyStatConfiguration(configuration);
                }
            }
        }
    }
}
