namespace ToDoAPI.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? NomeItem { get; set; }
        public bool IsComplete { get; set; }
    }
}
