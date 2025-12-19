using CommunityToolkit.Mvvm.Input;
using samsung_solve.Models;

namespace samsung_solve.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}