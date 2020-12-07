using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Business.Abstract;
using WebAPI_CQRS.Domain;
using WebAPI_CQRS.Domain.Commands.Command;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Serializer;

namespace WebAPI_CQRS.Business.Widget
{
    public class WidgetBusiness: IWidgetBusiness
    {
        public List<WidgetDTO> GetAllWidgets()
        {
            return WidgetSerializer.SerializeList(MockWidgetDatabase.Widgets.ToList());
        }

        public WidgetDTO GetWidgetById(int id)
        {
            return WidgetSerializer.SerializeSingle(MockWidgetDatabase.Widgets.FirstOrDefault(w => w.ID == id));
        }

        public CommandResponse SaveWidget(SaveWidgetCommand command)
        {
            var response = new CommandResponse()
            {
                Success = false
            };
            try
            {
                var item = MockWidgetDatabase
                    .Widgets
                    .FirstOrDefault(w => w.ID == command.Widget.ID);
                if (item == null)
                {
                    item.ID = MockWidgetDatabase.UniqueWidgetId;
                    MockWidgetDatabase.UniqueWidgetId++;
                    MockWidgetDatabase.Widgets.Add(item);
                }
                else
                {
                    item.Name = item.Name;
                    item.Shape = item.Shape;
                }
                response.ID = item.ID;
                response.Success = true;
                response.Message = "Saved widget.";
            }
            catch
            {
                // log error
            }
            return response;
        }
    }
}
