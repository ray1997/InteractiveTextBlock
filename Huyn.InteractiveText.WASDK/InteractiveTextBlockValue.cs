using CommunityToolkit.Mvvm.ComponentModel;

namespace Huyn.InteractiveText;

public partial class InteractiveTextBlockValue : ObservableObject
{

    #region Text
    [ObservableProperty]
    private string _text;

    #endregion

    #region Action
    public string Action { get; set; }

    #endregion

}
