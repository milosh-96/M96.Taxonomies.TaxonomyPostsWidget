using M96Dev.TaxonomyPosts.Models;
using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;

namespace M96Dev.TaxonomyPosts.Handlers
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