using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            service = new PersonenService();
            GetPeopleCommand = new Command(GetPeople);
        }

        private void GetPeople()
        {
            Personenliste = service.GetAllPeople();
        }

        private PersonenService service;

        public List<Person> Personenliste { get; set; }
        public ICommand GetPeopleCommand { get; set; }
    }
}
