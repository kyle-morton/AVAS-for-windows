using AVAS.Core.Clients;
using AVAS.Core.Clients.Models.YoutubeDL;
using AVAS.Core.Domain;

namespace AVAS.Core.Services
{

    public interface IDownloadService
    {
        void ProcessVideoRequest(VideoRequest request);
    }

    public class DownloadService : IDownloadService
    {
        private readonly IYoutubeDLClient _youtubeDLClient;

        public DownloadService(IYoutubeDLClient youtubeDLClient)
        {
            _youtubeDLClient = youtubeDLClient;
        }

        public void ProcessVideoRequest(VideoRequest request)
        {
            var youtubeDLReq = YoutubeDLRequest.From(request);

            _youtubeDLClient.DownloadRequestedContent(youtubeDLReq);
        }

    }
}
