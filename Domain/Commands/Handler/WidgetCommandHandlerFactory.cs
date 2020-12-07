using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Business.Widget;
using WebAPI_CQRS.Domain.Commands.Abstract;
using WebAPI_CQRS.Domain.Commands.Command;
using WebAPI_CQRS.Domain.Entity;

namespace WebAPI_CQRS.Domain.Commands.Handler
{
    public static class WidgetCommandHandlerFactory
    {
        public static ICommandHandler<SaveWidgetCommand, CommandResponse> Build(SaveWidgetCommand command, WidgetBusiness widgetBusiness)
        {
            return new SaveWidgetCommandHandler(command, widgetBusiness);
        }
    }
}
