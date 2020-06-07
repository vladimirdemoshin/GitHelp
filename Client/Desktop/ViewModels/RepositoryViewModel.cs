using Desktop.Models.Data;
using Domain.Data;
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
        public ObservableCollection<CommitModel> CurrentBranchCommits { get; protected set; }

        public RepositoryViewModel(IScreen screen, Repository repository)
        {
            HostScreen = screen;

            LocalBranches = new ObservableCollection<BranchModel>();

            var branchModelCollection = repository.LocalBranches.Select(x => new BranchModel { Name = x.Name });
            LocalBranches = new ObservableCollection<BranchModel>(branchModelCollection);

            var defaultBranch = repository.LocalBranches.First();
            var currentBranchCommitsCollection = defaultBranch.Commits.Select(x => new CommitModel { Message = x.Message });
            CurrentBranchCommits = new ObservableCollection<CommitModel>(currentBranchCommitsCollection);
        }
    }
}
