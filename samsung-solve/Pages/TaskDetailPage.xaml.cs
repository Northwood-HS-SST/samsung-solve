namespace samsung_solve.Pages;

public partial class TaskDetailPage : ContentPage
{
    public TaskDetailPage(TaskDetailPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}