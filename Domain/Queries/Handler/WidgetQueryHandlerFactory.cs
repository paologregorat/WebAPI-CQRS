using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Business.Widget;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Query;

namespace WebAPI_CQRS.Domain.Queries.Handler
{
    public static class WidgetQueryHandlerFactory
    {
        public static IQueryHandler<AllWidgetsQuery, IEnumerable<WidgetDTO>> Build(AllWidgetsQuery query, WidgetBusiness widgetBusiness)
        {
            return new AllWidgetsQueryHandler(widgetBusiness);
        }

        public static IQueryHandler<OneWidgetQuery, WidgetDTO> Build(OneWidgetQuery query, WidgetBusiness widgetBusiness)
        {
            return new OneWidgetQueryHandler(query, widgetBusiness);
        }
    }
}
