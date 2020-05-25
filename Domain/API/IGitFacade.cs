using Domain.Configuration;
using Domain.Data;

namespace Domain.API
{
    public interface IGitFacade
    {
        public Repository GetRepository(GitParameters gitParameters);
    }
}
