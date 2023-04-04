using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keystone.TestArchitecture.SharedKernel.Interfaces;
using Keystone.TestArchitecture.SharedKernel;
using Ardalis.GuardClauses;
using System.Xml.Linq;

namespace Keystone.TestArchitecture.Core.ServiceLearningAggregate;
public class ServiceActivity : EntityBase, IAggregateRoot
{
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
  public virtual List<LogService>? LogServices { get; set; }
  public virtual Organization? Organization { get; set; }
  public virtual List<ServiceActivityBlobMap>? ServiceActivityBlobMappings { get; set; }

  public ServiceActivity(
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
      DateTime? oneOffActivityDate
      )
  {
    OrganizationID = organizationID;
    AgreedCommitment = Guard.Against.NullOrEmpty(agreedCommitment, nameof(agreedCommitment));
    DayOfWeek = Guard.Against.NullOrEmpty(dayOfWeek, nameof(dayOfWeek));
    StartTime = startTime;
    EndTime = endTime;
    ActivityDescription = Guard.Against.NullOrEmpty(activityDescription, nameof(activityDescription));
    Question1 = Guard.Against.NullOrEmpty(question1, nameof(question1));
    Question2 = Guard.Against.NullOrEmpty(question2, nameof(question2));
    Question3 = Guard.Against.NullOrEmpty(question3, nameof(question3));
    IsAgreementAccepted = isAgreementAccepted;
    Status = status;
    ApprovalLevel = approvalLevel;
    IsDeleted = isDeleted;
    CreatedTime = createdTime;
    StudentID = studentID;
    CreatedBy = createdBy;
    ModifiedTime = modifiedTime;
    ModifiedBy = modifiedBy;
    OneOffActivityDate = oneOffActivityDate;
  }

  public void UpdateServiceActivity
    (
      int newOrganizationID,
      string newAgreedCommitment,
      string newDayOfWeek,
      TimeSpan newStartTime,
      TimeSpan newEndTime,
      string newActivityDescription,
      string newQuestion1,
      string newQuestion2,
      string newQuestion3,
      bool newIsAgreementAccepted,
      int newStatus,
      int newApprovalLevel,
      bool? newIsDeleted,
      DateTime newCreatedTime,
      int newStudentID,
      Guid newCreatedBy,
      DateTime? newModifiedTime,
      Guid? newModifiedBy,
      DateTime? newOneOffActivityDate
      )
  {
    OrganizationID = newOrganizationID;
    AgreedCommitment = Guard.Against.NullOrEmpty(newAgreedCommitment, nameof(newAgreedCommitment));
    DayOfWeek = newDayOfWeek;
    StartTime = newStartTime;
    EndTime = newEndTime;
    ActivityDescription = Guard.Against.NullOrEmpty(newActivityDescription, nameof(newActivityDescription));
    Question1 = Guard.Against.NullOrEmpty(newQuestion1, nameof(newQuestion1));
    Question2 = Guard.Against.NullOrEmpty(newQuestion2, nameof(newQuestion2));
    Question3 = Guard.Against.NullOrEmpty(newQuestion3, nameof(newQuestion3));
    IsAgreementAccepted = newIsAgreementAccepted;
    Status = newStatus;
    ApprovalLevel = newApprovalLevel;
    IsDeleted = newIsDeleted;
    CreatedTime = newCreatedTime;
    StudentID = newStudentID;
    CreatedBy = newCreatedBy;
    ModifiedTime = newModifiedTime;
    ModifiedBy = newModifiedBy;
    OneOffActivityDate = newOneOffActivityDate;
  }
}
