using System.Windows;
using System.Windows.Markup;

namespace MaterialDesignTreeViewBug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        private readonly XmlLanguage de = XmlLanguage.GetLanguage("de-at");
        private readonly XmlLanguage en = XmlLanguage.GetLanguage("en-us");

        #endregion Fields

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Language == de)
            {
                Language = en;
            }
            else
            {
                Language = de;
            }
        }

        #endregion Methods
    }
}
