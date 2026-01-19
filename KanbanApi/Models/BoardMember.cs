using System;
using Kanban.Models.Enums;

namespace KanbanApi.Models
{
    public class BoardMember
    {
        public Guid BoardId { get; set; }
        public Board Board { get; set; } = null!;

        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        public BoardRole Role { get; set; }
    }
}