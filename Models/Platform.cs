namespace RedisAPI.Models;

public class Platform
{
    public string Id { get; set; } = $"platform:{Guid.NewGuid().ToString()}";
    
    public string Name { get; set; } = string.Empty;
}
