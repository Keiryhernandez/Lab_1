namespace Lab_1.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? EditedBy { get; set; }
        public DateTime? edited { get; set; }

    }
}
