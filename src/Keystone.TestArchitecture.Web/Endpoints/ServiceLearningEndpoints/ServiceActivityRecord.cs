namespace Keystone.TestArchitecture.Web.Endpoints.ServiceLearningEndpoints;

public record ServiceActivityRecord(
   int OrganizationID,
   string AgreedCommitment,
   string DayOfWeek,
   TimeSpan StartTime,
   TimeSpan EndTime,
   string ActivityDescription,
   string Question1,
   string Question2,
   string Question3,
   bool IsAgreementAccepted,
   int Status,
   int ApprovalLevel,
   bool? IsDeleted,
   DateTime CreatedTime,
   int StudentID,
   Guid CreatedBy,
   DateTime? ModifiedTime,
   Guid? ModifiedBy,
   DateTime? OneOffActivityDate
  );
