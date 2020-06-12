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

        public CommitModel SelectedCommit { get; protected set; }

        public ObservableCollection<BranchModel> LocalBranches { get; protected set; }
        public ObservableCollection<BranchModel> RemoteBranches { get; protected set; }

        public ObservableCollection<CommitModel> CurrentBranchCommits { get; protected set; }

        public RepositoryViewModel(IScreen screen, Repository repository)
        {
            HostScreen = screen;

            var branchModelCollection = repository
                .Branches
                .Where(x => !x.IsRemote)
                .Select(x => new BranchModel { Name = x.Name });
            LocalBranches = new ObservableCollection<BranchModel>(branchModelCollection);

            var remoteBranchModelCollection = repository
                .Branches
                .Where(x => x.IsRemote)
                .Select(x => new BranchModel { Name = x.Name });
            RemoteBranches = new ObservableCollection<BranchModel>(remoteBranchModelCollection);

            var defaultBranch = repository.Branches.First();
            var currentBranchCommitsCollection = defaultBranch.Commits.Select(x => 
                new CommitModel 
                {
                    Sha = x.Sha,
                    Message = x.Message,
                    Author = new SignatureModel { Name = x.Author.Name, When = x.Author.When } 
                });
            CurrentBranchCommits = new ObservableCollection<CommitModel>(currentBranchCommitsCollection);

            SelectedCommit = CurrentBranchCommits[3];
        }
    }
}
