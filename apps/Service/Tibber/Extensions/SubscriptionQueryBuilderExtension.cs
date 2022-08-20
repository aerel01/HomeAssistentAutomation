using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Extensions
{
    internal class SubscriptionQueryBuilderExtension : SubscriptionQueryBuilder
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
        {
            new FieldMetadata { Name = "id" },
            new FieldMetadata { Name = "subscriber", IsComplex = true, QueryBuilderType = typeof(LegalEntityQueryBuilder) },
            new FieldMetadata { Name = "validFrom" },
            new FieldMetadata { Name = "validTo" },
            new FieldMetadata { Name = "status" },
            new FieldMetadata { Name = "priceInfo", IsComplex = true, QueryBuilderType = typeof(PriceInfoQueryBuilder) }
        };
        protected override string TypeName { get; } = "Subscription";
        protected override IList<FieldMetadata> AllFields { get; } = AllFieldMetadata;
        public SubscriptionQueryBuilderExtension(string alias = null, SkipDirective skip = null, IncludeDirective include = null) : base(alias, skip, include)
        {
        }

        public SubscriptionQueryBuilder WithPriceRating(PriceRatingQueryBuilder priceRatingQueryBuilder) => WithObjectField("priceRating", priceRatingQueryBuilder);
    }
}
