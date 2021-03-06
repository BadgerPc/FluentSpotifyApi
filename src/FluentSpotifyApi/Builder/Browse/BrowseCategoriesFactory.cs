﻿using System.Collections.Generic;

namespace FluentSpotifyApi.Builder.Browse
{
    internal static class BrowseCategoriesFactory
    {
        private const string EndpointName = "categories";

        public static IBrowseCategoryBuilder CreateCategoryBuilder(ContextData contextData, IEnumerable<object> routeValuesPrefix, string id)
        {
            return new BrowseCategoryBuilder(contextData, routeValuesPrefix, EndpointName, id);
        }

        public static IBrowseCategoriesBuilder CreateCategoriesBuilder(ContextData contextData, IEnumerable<object> routeValuesPrefix)
        {
            return new BrowseCategoriesBuilder(contextData, routeValuesPrefix, EndpointName);
        }
    }
}
