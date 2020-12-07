using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Query;
using WebAPI_CQRS.Domain.Queries.Serializer;

namespace WebAPI_CQRS.Domain.Queries.Handler
{
    public class OneWidgetQueryHandler : IQueryHandler<OneWidgetQuery, WidgetDTO>
    {
        private readonly OneWidgetQuery _query;
        public OneWidgetQueryHandler(OneWidgetQuery query)
        {
            _query = query;
        }
        public WidgetDTO Get()
        {
            return WidgetSerializer.SerializeSingle(MockWidgetDatabase.Widgets.FirstOrDefault(w => w.ID == _query.ID));
        }
    }
}
