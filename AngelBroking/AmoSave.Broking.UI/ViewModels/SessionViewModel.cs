namespace AmoSave.Broking.UI.ViewModels
{
    public class SessionViewModel
    {
        public string ClientCode { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }
        public bool IsLoading { get; set; }
        public bool IsLoggedIn { get; set; }
        public string? JwtToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
