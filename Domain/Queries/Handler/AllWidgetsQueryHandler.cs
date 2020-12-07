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
    public class AllWidgetsQueryHandler : IQueryHandler<AllWidgetsQuery, IEnumerable<WidgetDTO>>
    {
        private readonly WidgetBusiness _widgetBusiness;

        public AllWidgetsQueryHandler()
        {
            _widgetBusiness = new WidgetBusiness();
        }
        public IEnumerable<WidgetDTO> Get()
        {
            return _widgetBusiness.GetAllWidgets();
        }
    }
}
