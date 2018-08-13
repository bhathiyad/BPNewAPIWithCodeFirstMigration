Alter Procedure [dbo].[sp_GetAccessibleMeetingsNew]
(
@customuserId int,
@action varchar(Max),
@GetCloseMeetings bit,
@MeetingAllowedFrom DateTime
)
as
BEGIN
print 1;
SELECT M.MeetingId, M.SubCategoryId,  S.SubCategoryRole , S.CategoryId, C.Name as CategoryName
		, S.Name as SubCategoryName, M.Date as MeetingDate, M.Subject, M.Description, M.Status
		, M.StartTime, M.EndTime, M.IsTentative, M.MeetingType, M.Info1, CONVERT(int, M.TimeStamp) as TimeStamp
		, M.Longitude, M.Latitude, M.Venue, M.Address, M.OrganizerId, M.DocumentsDeadline

FROM dbo.Meetings as M
	inner join dbo.fn_GetAuthorizedSubCategories(@customuserId, @action) as S on M.SubCategoryId = S.SubCategoryId
	inner join dbo.Categories as C on S.CategoryId = C.CategoryId

WHERE S.Status = 1 and C.Status = 1 AND ((@GetCloseMeetings = 0 AND M.Status IN (0,1,4,5)) OR (@GetCloseMeetings = 1 AND M.Status = 2 AND M.Date >= @MeetingAllowedFrom))

END