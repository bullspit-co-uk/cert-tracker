namespace Bullspit.CertTracker.Web.Models;

public class ErrorPageVM : BasePageVM
{
    public ErrorPageVM() : base("Error")
    { }

    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
