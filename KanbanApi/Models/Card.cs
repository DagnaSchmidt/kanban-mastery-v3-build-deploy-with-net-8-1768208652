using System;

namespace KanbanApi.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int Order { get; set; }

        public Guid ColumnId { get; set; }
        public Column Column { get; set; } = null!;
    }
}