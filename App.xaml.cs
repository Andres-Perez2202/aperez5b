
using aperez5b.Utils;

namespace aperez5b
{
    public partial class App : Application
    {
        public static PersonRepository personRepo;
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Views.Principal();
            personRepo = personRepository;
        }
    }
}
