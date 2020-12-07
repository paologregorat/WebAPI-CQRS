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
    public class SaveWidgetCommandHandler : ICommandHandler<SaveWidgetCommand, CommandResponse>
    {
        private readonly SaveWidgetCommand _command;
        private readonly WidgetBusiness _widgetBusiness;
        public SaveWidgetCommandHandler(SaveWidgetCommand command)
        {
            _command = command;
            _widgetBusiness = new WidgetBusiness();
        }
        public CommandResponse Execute()
        {
            return _widgetBusiness.SaveWidget(_command);
        }
    }
}
