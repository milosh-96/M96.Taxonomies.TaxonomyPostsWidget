using Fluid;
using M96.Taxonomies.TaxonomyPostsWidget.Drivers;
using M96.Taxonomies.TaxonomyPostsWidget.Handlers;
using M96.Taxonomies.TaxonomyPostsWidget.Migrations;
using M96.Taxonomies.TaxonomyPostsWidget.Models;
using M96.Taxonomies.TaxonomyPostsWidget.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace M96.Taxonomies.TaxonomyPostsWidget
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.Configure<TemplateOptions>(o =>
            {
                o.MemberAccessStrategy.Register<TaxonomyPostsPartViewModel>();
            });

            services.AddContentPart<TaxonomyPostsPart>()
                .UseDisplayDriver<TaxonomyPostsPartDisplayDriver>()
                .AddHandler<TaxonomyPostsPartHandler>();      
            services.AddDataMigration<TaxonomyPostsMigrations>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
           
        }
    }
}
