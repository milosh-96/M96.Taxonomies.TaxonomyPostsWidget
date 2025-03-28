using M96.Taxonomies.TaxonomyPostsWidget.Constants;
using M96.Taxonomies.TaxonomyPostsWidget.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace M96.Taxonomies.TaxonomyPostsWidget.Migrations
{
    public class TaxonomyPostsMigrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public TaxonomyPostsMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public async Task<int> CreateAsync()
        {
            await _contentDefinitionManager.AlterPartDefinitionAsync(nameof(TaxonomyPostsPart), builder => builder
               .WithDescription("Provides a TaxonomyPosts part for your content item."));

            // add a widget //
            await _contentDefinitionManager.AlterTypeDefinitionAsync(ContentTypes.TaxonomyPostsWidget,
                    builder =>
                    {
                        builder.WithPart(nameof(TaxonomyPostsPart))
                        .Stereotype("Widget");
                    }
                );
            return 1;
        }

        public async Task Uninstall()
        {
            await _contentDefinitionManager.DeletePartDefinitionAsync(nameof(TaxonomyPostsPart));
            await _contentDefinitionManager.DeleteTypeDefinitionAsync(ContentTypes.TaxonomyPostsWidget);
        }
    }
}
