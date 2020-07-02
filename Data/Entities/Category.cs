using Data.Enums;

namespace Data.Entities {

    public class Category {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShow { get; set; }
        public int ParentId { get; set; }
        public Status Status { get; set; }
    }
}