using Domain.Core;

namespace Utility.Windows
{
    public class RepositoryUtility
    {
        private static RepositoryUtility instance;
        public static RepositoryUtility Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new RepositoryUtility();
                }
                return instance;
            }
        }

        public Repository GetRepository(string path)
        {
            //TODO
            var repository = new Repository();
            return repository;
        }
    }
}
