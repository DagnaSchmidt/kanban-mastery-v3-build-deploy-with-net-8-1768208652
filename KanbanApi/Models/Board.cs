using System;
using System.Collections.Generic;

namespace KanbanApi.Models {
    public class Board {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Column> Columns { get; set; } = new List<Column>();
        public ICollection<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();
    }
}