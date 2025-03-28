using M96.Taxonomies.TaxonomyPostsWidget.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;

namespace M96.Taxonomies.TaxonomyPostsWidget.ViewModels
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
    }
}
