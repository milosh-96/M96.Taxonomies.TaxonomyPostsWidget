using M96Dev.TaxonomyPosts.Models;
using M96Dev.TaxonomyPosts.Settings;
using M96Dev.TaxonomyPosts.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace M96Dev.TaxonomyPosts.Drivers
{
    public class TaxonomyPostsPartDisplayDriver : ContentPartDisplayDriver<TaxonomyPostsPart>
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public TaxonomyPostsPartDisplayDriver(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public override IDisplayResult Display(TaxonomyPostsPart part, BuildPartDisplayContext context)
        {
            return Initialize<TaxonomyPostsPartViewModel>(GetDisplayShapeType(context), m => BuildViewModel(m, part, context))
                .Location("Detail", "Content:10")
                .Location("Summary", "Content:10")
                ;
        }

        public override IDisplayResult Edit(TaxonomyPostsPart part, BuildPartEditorContext context)
        {
            return Initialize<TaxonomyPostsPartViewModel>(GetEditorShapeType(context), model =>
            {
                model.TaxonomyId = part.TaxonomyId;
                model.TaxonomyItemId = part.TaxonomyItemId;
                model.MaxItems = part.MaxItems;
                model.ContentItem = part.ContentItem;
                model.TaxonomyPostsPart = part;
            });
        }

        public override async Task<IDisplayResult> UpdateAsync(TaxonomyPostsPart model, IUpdateModel updater)
        {
            await updater.TryUpdateModelAsync(model, Prefix);

            return Edit(model);
        }

        private static void BuildViewModel(TaxonomyPostsPartViewModel model, TaxonomyPostsPart part, BuildPartDisplayContext context)
        {
            var settings = context.TypePartDefinition.GetSettings<TaxonomyPostsPartSettings>();

            model.ContentItem = part.ContentItem;
            model.TaxonomyId = part.TaxonomyId;
            model.TaxonomyItemId = part.TaxonomyItemId;
            model.MaxItems = part.MaxItems;
            model.TaxonomyPostsPart = part;
            model.Settings = settings;
        }
    }
}
