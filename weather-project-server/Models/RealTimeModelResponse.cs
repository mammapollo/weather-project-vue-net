using weather_project_server.Models.SubModels;

namespace weather_project_server.Models
{
    public class RealTimeModelResponse
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
    }
}
