using Tasks.Communication.Enums;

namespace Tasks.Communication.Requests;
public class RequestRegisterTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityType Priority { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatus Status { get; set; }
}
