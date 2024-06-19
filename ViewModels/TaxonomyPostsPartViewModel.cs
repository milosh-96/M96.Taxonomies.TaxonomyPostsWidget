using M96Dev.TaxonomyPosts.Models;
using M96Dev.TaxonomyPosts.Settings;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;

namespace M96Dev.TaxonomyPosts.ViewModels
{
    public class TaxonomyPostsPartViewModel
    {
        public string TaxonomyId { get; set; }

        public string TaxonomyItemId { get; set; }

        public int MaxItems { get; set; }

        [BindNever]
        public ContentItem ContentItem { get; set; }

        [BindNever]
        public TaxonomyPostsPart TaxonomyPostsPart { get; set; }

        [BindNever]
        public TaxonomyPostsPartSettings Settings { get; set; }
    }
}
