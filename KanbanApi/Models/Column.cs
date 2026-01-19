using System;
using System.Collections.Generic;

namespace KanbanApi.Models
{
    public class Column
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public Guid BoardId { get; set; }

        public Board Board { get; set; } = null!;
        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}