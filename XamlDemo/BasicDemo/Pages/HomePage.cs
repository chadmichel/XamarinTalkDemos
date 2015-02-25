using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace BasicDemo
{
    public class HomePage : ContentPage
    {
        ListView listView;
        ObservableCollection<PersonViewModel> people = PersonViewModel.GetSome();

        public HomePage()
        {
            Title = "List";

            listView = new ListView();

            listView.ItemsSource = people;
            listView.ItemTemplate = new DataTemplate(typeof(ListItemTemplate));

            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => 
                {
                    var person = e.SelectedItem as PersonViewModel;
                    if (person != null)
                    {
                        Navigation.PushAsync(new PersonEdit(person));
                        //Navigation.PushAsync(new PersonEdit2(person));
                        listView.SelectedItem = null;
                    }
                };

            Content = listView;
        }
    }
}

