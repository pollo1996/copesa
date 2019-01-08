
namespace copesa.Infraestructura
{
    using ViewModels;
  
    class InstanceLocator
    {
        #region Properties
        public MainVewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainVewModel();
        }
        #endregion
    }
}
