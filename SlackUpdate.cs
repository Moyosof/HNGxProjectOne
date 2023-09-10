namespace HNGx
{
    public class SlackUpdate
    {
        public string? slack_name { get; set; }
        public DateOnly Date { get; set; }
        public string current_day { get; set; }
        public string track { get; set; }
        public string github_file_url { get; set; }
        public string github_repo_url { get; set; }

    }
}
