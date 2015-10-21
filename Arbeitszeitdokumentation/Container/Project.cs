
namespace Arbeitszeitdokumentation.Container
{
    public class Project
    {
        public string Title { get; set; }

        public string Location { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return string.Format("Title: {0}, Location: {1}, Start: {2}, End: {3}, Id: {4}", Title, Location, Start, End, Id);
        }
	}
}
