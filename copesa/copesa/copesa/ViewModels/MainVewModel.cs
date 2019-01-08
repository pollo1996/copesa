
namespace copesa.ViewModels
{
    public class MainVewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public MainVewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
