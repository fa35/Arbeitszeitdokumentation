namespace Arbeitszeitdokumentation.Container
{
    public class Worklog
    {
        public string EmployeeId { get; set; }

        public string ProjectId { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public override string ToString()
        {
            return string.Format("EmployeeId: {0}, ProjectId: {1}, Start: {2}, End: {3}", EmployeeId, ProjectId, Start, End);
        }
    }
}