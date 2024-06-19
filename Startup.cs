using Fluid;
using M96Dev.TaxonomyPosts.Drivers;
using M96Dev.TaxonomyPosts.Handlers;
using M96Dev.TaxonomyPosts.Models;
using M96Dev.TaxonomyPosts.Settings;
using M96Dev.TaxonomyPosts.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace M96Dev.TaxonomyPosts
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

            services.AddScoped<IContentTypePartDefinitionDisplayDriver, TaxonomyPostsPartSettingsDisplayDriver>();
            services.AddDataMigration<Migrations>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
           
        }
    }
}
