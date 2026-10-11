namespace SignalRWebUI.Dtos.RapidApiDtos
{
    public class RootTastApiDto
    {
        public List<ResultTastApiDto> Results {  get; set; }
    }

    public class ResultTastApiDto
    {
        public string name { get; set; }
        public string original_video_url { get; set; }
        public int total_time_minutes { get; set; }
        public string thumbnail_url { get; set; }
    }
}
