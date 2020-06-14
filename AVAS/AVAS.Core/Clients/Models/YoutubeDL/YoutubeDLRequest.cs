using AVAS.Core.Domain;

namespace AVAS.Core.Clients.Models.YoutubeDL
{
    public class YoutubeDLRequest
    {
        public VideoRequestType Type { get; set; }
        public bool AudioOnly { get; set; }
        public string OutputLocation { get; set; }
        public string ContentID { get; set; }

        public static YoutubeDLRequest From(VideoRequest request)
        {
            return new YoutubeDLRequest
            {
                AudioOnly = request.AudioOnly,
                Type = request.Type,
                OutputLocation = request.OutputLocation,
                ContentID = request.ContentID
            };
        }
    }
}
