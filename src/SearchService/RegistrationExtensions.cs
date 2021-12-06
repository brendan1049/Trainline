﻿using JourneySearchContract;
using Microsoft.Extensions.DependencyInjection;
using SearchService.Service;

namespace SearchService
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection AddSearchServices(this IServiceCollection services)
        {
            services.AddTransient<ISearchOrchestrator, SearchOrchestrator>();
            services.AddTransient<ISearchLocationMapper, SearchLocationMapper>();
            services.AddTransient<IJourneySearchResponseMapper, JourneySearchResponseMapper>();
            
            services.AddJourneySearchService();
            return services;
        }

        public static IServiceCollection AddJourneySearchService(this IServiceCollection services)
        {
            services.AddTransient<IJourneySearchService, UkJourneySearchService.UkJourneySearchService>();
            return services;
        }

    }
}