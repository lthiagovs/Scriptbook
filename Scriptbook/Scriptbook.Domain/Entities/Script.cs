namespace Scriptbook.Domain.Entities
{
    public class Script
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Code { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
