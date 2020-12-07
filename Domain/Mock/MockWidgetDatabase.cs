using System;
using System.Collections;
using System.Collections.Generic;
using WebAPI_CQRS.Domain.Entity;

namespace WebAPI_CQRS.Domain
{
    public static class MockWidgetDatabase
    {
        public static IList<Widget> Widgets { get; }
        public static int UniqueWidgetId = 4;
        static MockWidgetDatabase()
        {
            Widgets = new List<Widget>()
            {
                new Widget {ID = 1, Name = "Widget 1", Shape = "Shape 1"},
                new Widget {ID = 2, Name = "Widget 2", Shape = "Shape 2"},
                new Widget {ID = 3, Name = "Widget 3", Shape = "Shape 3"}
            };
        }
    }
}
