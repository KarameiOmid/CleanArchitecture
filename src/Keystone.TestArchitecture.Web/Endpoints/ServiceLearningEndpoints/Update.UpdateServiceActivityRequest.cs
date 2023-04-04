using System.ComponentModel.DataAnnotations;

namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class UpdateServiceActivityRequest
{
  public int ID { get; set; }
  public const string Route = "/ServiceActivity";
  [Required]
  public int OrganizationID { get; set; }
  [Required]
  public string AgreedCommitment { get; set; } = string.Empty;
  [Required]
  public string DayOfWeek { get; set; } = string.Empty;
  [Required]
  public TimeSpan StartTime { get; set; }
  [Required]
  public TimeSpan EndTime { get; set; }
  [Required]
  public string ActivityDescription { get; set; } = string.Empty;
  [Required]
  public string Question1 { get; set; } = string.Empty;
  [Required]
  public string Question2 { get; set; } = string.Empty;
  [Required]
  public string Question3 { get; set; } = string.Empty;
  [Required]
  public bool IsAgreementAccepted { get; set; }
  [Required]
  public int Status { get; set; }
  [Required]
  public int ApprovalLevel { get; set; }
  public bool? IsDeleted { get; set; }
  public DateTime CreatedTime { get; set; }
  public int StudentID { get; set; }
  public Guid CreatedBy { get; set; }
  public DateTime? ModifiedTime { get; set; }
  public Guid? ModifiedBy { get; set; }
  public DateTime? OneOffActivityDate { get; set; }
}
