public class Todo {
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int Id { get; set; }

    public void ToggleCompleted () {
        this.Completed = !this.Completed;
    }
}