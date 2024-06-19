using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Taxonomy Posts",
    Author = "Miloš Jovanović - M96 Dev",
    Website = "https://dbmilos.com",
    Version = "0.9.0",
    Description = "Provides Taxonomy Posts widget that lists content items attached to a taxonomy item such as category or tag.",
    Dependencies = new[] { "OrchardCore.Contents","OrchardCore.Taxonomies","OrchardCore.Layers" },
    Category = "Content Management"
)]
