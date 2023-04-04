using System.ComponentModel.DataAnnotations;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class CreateServiceActivityRequest
{
  public const string Route = "/ServiceActivity";

  public int OrganizationID { get; set; }
  public string AgreedCommitment { get; set; } = string.Empty;
  public string DayOfWeek { get; set; } = string.Empty;
  public TimeSpan StartTime { get; set; }
  public TimeSpan EndTime { get; set; }
  public string ActivityDescription { get; set; } = string.Empty;
  public string Question1 { get; set; } = string.Empty;
  public string Question2 { get; set; } = string.Empty;
  public string Question3 { get; set; } = string.Empty;
  public bool IsAgreementAccepted { get; set; }
  public int Status { get; set; }
  public int ApprovalLevel { get; set; }
  public bool? IsDeleted { get; set; }
  public DateTime CreatedTime { get; set; }
  public int StudentID { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime? ModifiedTime { get; set; }
  public Guid? ModifiedBy { get; set; }
  public DateTime? OneOffActivityDate { get; set; }

}
