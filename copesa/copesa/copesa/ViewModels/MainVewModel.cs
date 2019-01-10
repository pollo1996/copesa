
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

        public CopesaViewModel Copesa
            {
            get;
            set;
             }
        #endregion

        #region Constructor
        public MainVewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainVewModel instance;

        public static MainVewModel GetInstance()
        {
            if(instance==null)
            {
                return new MainVewModel();
            }
            return instance;
        }
        #endregion
    }
}
