using System;

using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace BasicDemo
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        public event PropertyChangedEventHandler PropertyChanged;

        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public string Name 
        {
            get { return _person.Name; }
            set
            {
                _person.Name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public int Age 
        {
            get { return _person.Age; }
            set
            {
                _person.Age = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        public string ImageUrl
        {
            get { return _person.ImageUrl; }
            set
            {
                _person.ImageUrl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ImageUrl"));
                }
            }
        }

        public string Notes
        {
            get { return _person.Notes; }
            set
            {
                _person.Notes = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Notes"));
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static ObservableCollection<PersonViewModel> GetSome()
        {
            var result = new ObservableCollection<PersonViewModel>();
            var people = Person.GetSome();
            foreach (var person in people)
            {
                result.Add(new PersonViewModel(person));
            }
            return result;
        }           
    }
}


