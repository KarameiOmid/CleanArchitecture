namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public class CreateServiceActivityResponse
{
  public CreateServiceActivityResponse
    (
      int organizationID,
      string agreedCommitment,
      string dayOfWeek,
      TimeSpan startTime,
      TimeSpan endTime,
      string activityDescription,
      string question1,
      string question2,
      string question3,
      bool isAgreementAccepted,
      int status,
      int approvalLevel,
      bool? isDeleted,
      DateTime createdTime,
      int studentID,
      Guid createdBy,
      DateTime? modifiedTime,
      Guid? modifiedBy,
      DateTime? neOffActivityDate
    )
  {
    OrganizationID = organizationID;
    AgreedCommitment = agreedCommitment;
    DayOfWeek = dayOfWeek;
    StartTime = startTime;
    EndTime = endTime;
    ActivityDescription = activityDescription;
    Question1 = question1;
    Question2 = question2;
    Question3 = question3;
    IsAgreementAccepted = isAgreementAccepted;
    Status = status;
    ApprovalLevel = approvalLevel;
    IsDeleted = isDeleted;
    CreatedTime = createdTime;
    StudentID = studentID;
    CreatedBy = createdBy;
    ModifiedTime = modifiedTime;
    ModifiedBy = modifiedBy;
    OneOffActivityDate = neOffActivityDate;
  }


  public int OrganizationID { get; set; }
  public string AgreedCommitment { get; set; }
  public string DayOfWeek { get; set; }
  public TimeSpan StartTime { get; set; }
  public TimeSpan EndTime { get; set; }
  public string ActivityDescription { get; set; }
  public string Question1 { get; set; }
  public string Question2 { get; set; }
  public string Question3 { get; set; }
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
