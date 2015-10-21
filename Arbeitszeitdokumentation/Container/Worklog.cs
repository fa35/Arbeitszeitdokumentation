namespace Arbeitszeitdokumentation.Container
{
    public class Worklog
    {
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return string.Format("EmployeeId: {0}, ProjectId: {1}, Start: {2}, End: {3}, Id: {4}", EmployeeId, ProjectId, Start, End, Id);
        }
    }
}