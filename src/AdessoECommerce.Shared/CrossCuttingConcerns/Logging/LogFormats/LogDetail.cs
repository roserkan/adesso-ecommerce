namespace AdessoECommerce.Shared.CrossCuttingConcerns.Logging.LogFormats;

public class LogDetail
{
    public string TraceId { get; set; }

    // User info
    public string? UserId { get; set; }
    public string? IpAddress { get; set; }

    // Request info
    public object? RequestBody { get; set; }
    public string? Url { get; set; }
    public string? HttpMethod { get; set; }
    
    // Response info
    public int StatusCode { get; set; }
    public object? ResponseBody { get; set; }
    public long ElapsedTime { get; set; }
    
    //Process and Method info
    public string? ClassName { get; set; }
    public string? MethodName { get; set; }
    public string? ProcessId { get; set; }
    public string? ThreadId { get; set; }
    
    
    // Exception info
    public string? ExceptionMessage { get; set; }
    public string? StackTrace { get; set; }
    public string? InnerExceptionMessage { get; set; }
    public string? ExceptionType { get; set; }
    public string? CustomMessage { get; set; }
}