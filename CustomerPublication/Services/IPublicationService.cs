using System.Collections.Generic;

namespace CustomerPublication.Services
{
    public interface IPublicationService
    {
        Result<string> SavePublication(IEnumerable<Publication> publications);
    }
}