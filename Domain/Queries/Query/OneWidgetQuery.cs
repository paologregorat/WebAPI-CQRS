using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Entity;

namespace WebAPI_CQRS.Domain.Queries.Query
{
    public class OneWidgetQuery : IQuery<WidgetDTO>
    {
        public int ID { get; private set; }
        public OneWidgetQuery(int id)
        {
            ID = id;
        }
    }
}
