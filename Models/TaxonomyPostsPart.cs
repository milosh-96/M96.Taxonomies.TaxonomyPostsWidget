using OrchardCore.ContentManagement;

namespace M96.Taxonomies.TaxonomyPostsWidget.Models
{
    public class TaxonomyPostsPart : ContentPart
    {
        // this is id of content type that is as a taxonomy - category, tag...
        public string TaxonomyId { get; set; }

        // from what item to query, for example:"'query from 'travel'" tag
        public string TaxonomyItemId { get; set; }

        public int MaxItems { get; set; }
    }
}
