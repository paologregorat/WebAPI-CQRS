using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Commands.Abstract;
using WebAPI_CQRS.Domain.Entity;

namespace WebAPI_CQRS.Domain.Commands.Command
{
    public class SaveWidgetCommand : ICommand<CommandResponse>
    {
        public Widget Widget { get; private set; }
        public SaveWidgetCommand(Widget item)
        {
            Widget = item;
        }
    }
}
