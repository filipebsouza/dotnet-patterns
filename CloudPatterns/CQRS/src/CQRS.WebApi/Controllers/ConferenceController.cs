namespace CQRS.WebApi.Controllers
{
    public class ConferenceController : BaseController
    {
        public ActionResult Display(string conferenceCode)
        {
            var conference = this.GetConference(conferenceCode);
            return View(conference);
        }

        private Conference.Web.Public.Models.Conference GetConference(string conferenceCode)
        {
            var repo = this.repositoryFactory();
            using (repo as IDisposable)
            {
                var conference = repo.Query<Conference>()
                .First(c => c.Code == conferenceCode);
                var conferenceModel =
                new Conference.Web.Public.Models.Conference
                {
                    Code = conference.Code,
                    Name = conference.Name,
                    Description = conference.Description
                };

                return conferenceModel;
            }
        }
    }
}