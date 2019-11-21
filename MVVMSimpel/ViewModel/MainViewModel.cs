using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            service = new PersonenService();
            GetPeopleCommand = new Command(GetPeople);
        }

        private void GetPeople()
        {
            //Personenliste = service.GetAllPeople();
            Personenliste = service.CreatePeople(1_000);
            if(PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Personenliste")); // Sagt dem UI "Hey, Personenliste hat sich verändert -> Aktualisiere das Binding !!!!"
        }

        private PersonenService service;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Person> Personenliste { get; set; }
        public ICommand GetPeopleCommand { get; set; }
    }
}
