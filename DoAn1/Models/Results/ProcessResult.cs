namespace DoAn1.Models.Results;

public class ProcessResult<T>
{
    public bool IsSuccess { get; set; }

    public string Message { get; set; }

    public T? Data { get; set; }
}