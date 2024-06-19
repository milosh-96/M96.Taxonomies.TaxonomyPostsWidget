using M96Dev.TaxonomyPosts.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace M96Dev.TaxonomyPosts
{
    public class Migrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public Migrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinition(nameof(TaxonomyPostsPart), builder => builder
               .WithDescription("Provides a TaxonomyPosts part for your content item."));

            // add a widget //
            _contentDefinitionManager.AlterTypeDefinition(nameof(TaxonomyPostsPart),
                    builder =>
                    {
                        builder.WithPart(nameof(TaxonomyPostsPart))
                        .Stereotype("Widget");
                    }
                );
            _contentDefinitionManager.DeleteTypeDefinition("TaxonomyPostsWidget");

            return 1;
        }

        

        public int UpdateFrom5()
        {
            _contentDefinitionManager.AlterPartDefinition(nameof(TaxonomyPostsPart), builder => builder
                .WithDescription("Provides a TaxonomyPosts part for your content item."));

            // add a widget //
            _contentDefinitionManager.AlterTypeDefinition("TaxonomyPostsWidget",
                    builder =>
                    {
                        builder.WithPart(nameof(TaxonomyPostsPart))
                        .Stereotype("Widget");
                    }
                );

            return 6;
        }

        public int UpdateFrom6()
        {
            _contentDefinitionManager.AlterPartDefinition(nameof(TaxonomyPostsPart), builder => builder
                .WithDescription("Provides a TaxonomyPosts part for your content item."));

            // add a widget //
            _contentDefinitionManager.AlterTypeDefinition(nameof(TaxonomyPostsPart),
                    builder =>
                    {
                        builder.WithPart(nameof(TaxonomyPostsPart))
                        .Stereotype("Widget");
                    }
                );
            _contentDefinitionManager.DeleteTypeDefinition("TaxonomyPostsWidget");


            return 7;
        }
        public int UpdateFrom7()
        {
            _contentDefinitionManager.AlterPartDefinition(nameof(TaxonomyPostsPart), builder => builder
                .WithDescription("Provides a TaxonomyPosts part for your content item."));

            // add a widget //
            _contentDefinitionManager.AlterTypeDefinition(nameof(TaxonomyPostsPart),
                    builder =>
                    {
                        builder.WithPart(nameof(TaxonomyPostsPart))
                        .Stereotype("Widget");
                    }
                );
            _contentDefinitionManager.DeleteTypeDefinition("TaxonomyPostsWidget");


            return 8;
        }

        public void Uninstall()
        {
            _contentDefinitionManager.DeletePartDefinition(nameof(TaxonomyPostsPart));
            _contentDefinitionManager.DeleteTypeDefinition("TaxonomyPostsWidget");
        }
    }
}
