using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_CQRS.Domain.Entity;

namespace WebAPI_CQRS.Domain.Queries.Serializer
{
    public class WidgetSerializer
    {
        public static List<WidgetDTO> SerializeList(List<Widget> toSerialize)
        {
            var result = new List<WidgetDTO>();
            foreach (var elem in toSerialize)
            {
                var serialized = new WidgetDTO()
                {
                    ID = elem.ID,
                    DateResponse = DateTime.Now,
                    Name = elem.Name,
                    Shape = elem.Shape
                };
                result.Add(serialized);
            }
            return result;
        }

        public static WidgetDTO SerializeSingle(Widget toSerialize)
        {
            var result = new WidgetDTO()
            {
                ID = toSerialize.ID,
                DateResponse = DateTime.Now,
                Name = toSerialize.Name,
                Shape = toSerialize.Shape
            };
            return result;
        }
    }
}
