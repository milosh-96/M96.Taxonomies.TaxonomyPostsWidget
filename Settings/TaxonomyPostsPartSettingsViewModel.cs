using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace M96Dev.TaxonomyPosts.Settings
{
    public class TaxonomyPostsPartSettingsViewModel
    {
        public string MySetting { get; set; }

        [BindNever]
        public TaxonomyPostsPartSettings TaxonomyPostsPartSettings { get; set; }
    }
}
