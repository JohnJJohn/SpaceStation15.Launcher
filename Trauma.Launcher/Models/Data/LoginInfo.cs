namespace Trauma.Launcher.Models.Data;

public sealed partial class LoginInfo : ReactiveObject
{
    [Reactive] public Guid _userId;
    [Reactive] public string _username = "";
    [Reactive] public LoginToken _token;

    public override string ToString() => $"{Username}/{UserId}";
}
