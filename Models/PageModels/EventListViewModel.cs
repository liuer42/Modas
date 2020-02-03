using System.Collections.Generic;

namespace Modas.Models.PageModels
{
    public class EventListViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}