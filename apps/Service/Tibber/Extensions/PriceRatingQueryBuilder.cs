using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tibber.Sdk;

namespace NetDaemonApps.apps.Service.Tibber.Extensions
{
    public class PriceRatingQueryBuilder : GraphQlQueryBuilder<PriceRatingQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
        {
            new FieldMetadata { Name = "thresholdPercentages", IsComplex = true, QueryBuilderType = typeof(PriceQueryBuilder) },
            new FieldMetadata { Name = "hourly", IsComplex = true, QueryBuilderType = typeof(PriceQueryBuilder) },
            new FieldMetadata { Name = "daily", IsComplex = true, QueryBuilderType = typeof(PriceQueryBuilder) },
            new FieldMetadata { Name = "monthly", IsComplex = true, QueryBuilderType = typeof(SubscriptionPriceConnectionQueryBuilder) }
        };
        protected override string TypeName { get; } = "PriceRating";

        protected override IList<FieldMetadata> AllFields { get; } = AllFieldMetadata;
        public PriceRatingQueryBuilder(string alias = null, SkipDirective skip = null, IncludeDirective include = null) : base(alias, new GraphQlDirective[] { skip, include })
        {
        }
    }
}
