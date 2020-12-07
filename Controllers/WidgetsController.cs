using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Commands.Command;
using WebAPI_CQRS.Domain.Commands.Handler;
using WebAPI_CQRS.Domain.Entity;
using WebAPI_CQRS.Domain.Queries.Handler;
using WebAPI_CQRS.Domain.Queries.Query;

namespace WebAPI_CQRS.Controllers
{
    [Route("[controller]")]
    public class WidgetsController : ControllerBase
    {
        [HttpGet]
        [Route("v1/widgets")]
        public List<WidgetDTO> GetAll()
        {
            var query = new AllWidgetsQuery();
            var handler = WidgetQueryHandlerFactory.Build(query);
            return (List<WidgetDTO>) handler.Get();
        }

        [HttpGet]
        [Route("v1/widgets/{id}")]
        public WidgetDTO GetWidget(int id)
        {
            var query = new OneWidgetQuery(id);
            var handler = WidgetQueryHandlerFactory.Build(query);
            return handler.Get();
        }

        [HttpPost]
        [Route("v1/widgets")]
        public IActionResult Post(Widget item)
        {
            var command = new SaveWidgetCommand(item);
            var handler = WidgetCommandHandlerFactory.Build(command);
            var response = handler.Execute();
            if (response.Success)
            {
                item.ID = response.ID;
                return Ok(item);
            }
            // an example of what might have gone wrong
            var message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(response.Message),
                ReasonPhrase = "InternalServerError"
            };
            throw new Exception(message.ToString());
        }
    }
}
