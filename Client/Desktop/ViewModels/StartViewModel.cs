using Domain.API;
using Domain.Configuration;
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

        public IGitFacade GitFacade { get; set; }

        public StartViewModel(IScreen screen)
        {
            HostScreen = screen;

            OpenRepositoryCommand = ReactiveCommand.CreateFromObservable(
                () => HostScreen.Router.Navigate.Execute(new RepositoryViewModel(HostScreen, GitFacade.GetRepository(new GitParameters())))
            );
        }
    }
}
