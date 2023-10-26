namespace CustomCookieBased.Models
{
    public class UserSignInModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool RememberMe { get; set;}
    }
}
