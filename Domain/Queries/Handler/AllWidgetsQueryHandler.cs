using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Query;
using WebAPI_CQRS.Domain.Queries.Serializer;

namespace WebAPI_CQRS.Domain.Queries.Handler
{
    public class AllWidgetsQueryHandler : IQueryHandler<AllWidgetsQuery, IEnumerable<WidgetDTO>>
    {
        public IEnumerable<WidgetDTO> Get()
        {
            return WidgetSerializer.SerializeList(MockWidgetDatabase.Widgets.ToList());
        }
    }
}
