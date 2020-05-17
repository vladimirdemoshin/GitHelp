using Desktop.Models.Core;
using Domain.Core;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace Desktop.ViewModels
{
    public class RepositoryViewModel : ViewModelBase, IRoutableViewModel
    {
        public IScreen HostScreen { get; }
        public string UrlPathSegment => throw new System.NotImplementedException();

        public ObservableCollection<BranchModel> LocalBranches { get; protected set; }

        public RepositoryViewModel(IScreen screen, Repository repository)
        {
            HostScreen = screen;

            var branchModelCollection = repository.LocalBranches.Select(x => new BranchModel { Name = x.Name });
            LocalBranches = new ObservableCollection<BranchModel>(branchModelCollection);
        }
    }
}
