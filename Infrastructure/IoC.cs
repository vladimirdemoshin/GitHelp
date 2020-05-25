using Unity;

namespace Infrastructure
{
    public class IoC
    {
        private IoC()
        {

        }

        protected static IUnityContainer _container;
        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();
                }
                return _container;
            }
        }
    }
}
