using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using RZRV.Queries.Container;
using System;

namespace RZRV.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}