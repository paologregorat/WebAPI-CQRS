using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Business.Widget;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Query;
using WebAPI_CQRS.Domain.Queries.Serializer;

namespace WebAPI_CQRS.Domain.Queries.Handler
{
    public class OneWidgetQueryHandler : IQueryHandler<OneWidgetQuery, WidgetDTO>
    {
        private readonly OneWidgetQuery _query;
        private readonly WidgetBusiness _widgetBusiness;
        public OneWidgetQueryHandler(OneWidgetQuery query)
        {
            _query = query;
            _widgetBusiness = new WidgetBusiness();
        }
        public WidgetDTO Get()
        {
            //return WidgetSerializer.SerializeSingle(MockWidgetDatabase.Widgets.FirstOrDefault(w => w.ID == _query.ID));
            return _widgetBusiness.GetWidgetById(_query.ID);

        }
    }
}
