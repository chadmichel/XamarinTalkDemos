using System;
using Xamarin.Forms;

namespace BasicDemo
{
    public class HomePage : ContentPage
    {
        Person[] people = new Person[]
            {
                new Person()
                {
                    Name = "Norm",
                    Age = 28
                },
                new Person()
                {
                    Name = "Todd",
                    Age = 3500
                }
            };

        public HomePage()
        {
            var listView = new ListView();

            listView.ItemsSource = people;
           
            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => 
                {
                    var person = e.SelectedItem as Person;
                    if (person != null)
                    {
                        Navigation.PushAsync(new PersonEdit(person));
                        listView.SelectedItem = null;
                    }
                };

            Content = listView;
        }
    }
}

