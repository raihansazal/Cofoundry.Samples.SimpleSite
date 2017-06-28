﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cofoundry.Samples.SimpleSite
{
    /// <summary>
    /// Each custom entity requires a definition class which provides settings
    /// describing the entity and how it should behave.
    /// </summary>
    public class BlogPostCustomEntityDefinition : ICustomEntityDefinition<BlogPostDataModel>
    {
        /// <summary>
        /// This constant is a convention that allows us to reference this definition code 
        /// in other parts of the application (e.g. querying)
        /// </summary>
        public const string DefinitionCode = "SIMBLP";

        /// <summary>
        /// Unique 6 letter code representing the module (the convention is to use uppercase)
        /// </summary>
        public string CustomEntityDefinitionCode
        {
            get { return DefinitionCode; }
        }

        /// <summary>
        /// Singlar name of the entity
        /// </summary>
        public string Name
        {
            get { return "Blog Post"; }
        }

        /// <summary>
        /// Plural name of the entity
        /// </summary>
        public string NamePlural
        {
            get { return "Blog Posts"; }
        }

        /// <summary>
        /// A short description that shows up as a tooltip for the admin 
        /// module.
        /// </summary>
        public string Description
        {
            get { return "Articles that appear in the blog section of the site."; }
        }

        /// <summary>
        /// Indicates whether the UrlSlug property should be treated
        /// as a unique property and be validated as such.
        /// </summary>
        public bool ForceUrlSlugUniqueness
        {
            get { return false; }
        }

        /// <summary>
        /// Indicates whether the url slug should be autogenerated. If this
        /// is selected then the user will not be shown the UrlSlug property
        /// and it will be auto-generated based on the title.
        /// </summary>
        public bool AutoGenerateUrlSlug
        {
            get { return true; }
        }

        /// <summary>
        /// Indicates whether this custom entity should always be published when 
        /// saved, provided the user has permissions to do so. Useful if this isn't
        /// the sort of entity that needs a draft state workflow
        /// </summary>
        public bool AutoPublish
        {
            get { return false; }
        }

        /// <summary>
        /// Indicates whether the entities are partitioned by locale
        /// </summary>
        public bool HasLocale
        {
            get { return false; }
        }
    }
}