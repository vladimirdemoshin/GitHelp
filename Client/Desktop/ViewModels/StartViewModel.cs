using Domain.Data;
using ReactiveUI;
using System.Collections.Generic;
using System.Reactive;

namespace Desktop.ViewModels
{
    public class StartViewModel : ViewModelBase, IRoutableViewModel
    {
        public string UrlPathSegment => throw new System.NotImplementedException();
        public IScreen HostScreen { get; protected set; }

        public ReactiveCommand<Unit, IRoutableViewModel> OpenRepositoryCommand { get; protected set; }

        public StartViewModel(IScreen screen)
        {
            HostScreen = screen;

            var testRepository = _getTestRepository();

            OpenRepositoryCommand = ReactiveCommand.CreateFromObservable(
                () => HostScreen.Router.Navigate.Execute(new RepositoryViewModel(HostScreen, testRepository))
            );
        }

        private Repository _getTestRepository()
        {
            var masterBranch = new Branch("master");
            var devBranch = new Branch("dev");

            var localBranches = new List<Branch> {
                masterBranch,
                devBranch
            };

            var repository = new Repository(localBranches);
            return repository;
        }
    }
}
