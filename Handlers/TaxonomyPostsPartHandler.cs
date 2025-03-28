using M96.Taxonomies.TaxonomyPostsWidget.Models;
using OrchardCore.ContentManagement.Handlers;

namespace M96.Taxonomies.TaxonomyPostsWidget.Handlers
{
    public class TaxonomyPostsPartHandler : ContentPartHandler<TaxonomyPostsPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, TaxonomyPostsPart part)
        {
            part.TaxonomyId = "";
            part.TaxonomyItemId = "";
            part.MaxItems = 5;

            return Task.CompletedTask;
        }
    }
}
