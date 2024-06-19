using M96Dev.TaxonomyPosts.Models;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System;
using System.Threading.Tasks;

namespace M96Dev.TaxonomyPosts.Settings
{
    public class TaxonomyPostsPartSettingsDisplayDriver : ContentTypePartDefinitionDisplayDriver
    {
        public override IDisplayResult Edit(ContentTypePartDefinition contentTypePartDefinition, IUpdateModel updater)
        {
            if (!string.Equals(nameof(TaxonomyPostsPart), contentTypePartDefinition.PartDefinition.Name))
            {
                return null;
            }

            return Initialize<TaxonomyPostsPartSettingsViewModel>("TaxonomyPostsPartSettings_Edit", model =>
            {
                var settings = contentTypePartDefinition.GetSettings<TaxonomyPostsPartSettings>();

                model.MySetting = settings.MySetting;
                model.TaxonomyPostsPartSettings = settings;
            }).Location("Content");
        }

        public override async Task<IDisplayResult> UpdateAsync(ContentTypePartDefinition contentTypePartDefinition, UpdateTypePartEditorContext context)
        {
            if (!string.Equals(nameof(TaxonomyPostsPart), contentTypePartDefinition.PartDefinition.Name))
            {
                return null;
            }

            var model = new TaxonomyPostsPartSettingsViewModel();

            if (await context.Updater.TryUpdateModelAsync(model, Prefix, m => m.MySetting))
            {
                context.Builder.WithSettings(new TaxonomyPostsPartSettings { MySetting = model.MySetting });
            }

            return Edit(contentTypePartDefinition, context.Updater);
        }
    }
}
