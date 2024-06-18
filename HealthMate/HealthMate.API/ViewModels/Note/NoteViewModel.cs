using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Note
{
    public class NoteViewModel(
        string Content,
        DateTime Date
    ) : BaseViewModel;
}
