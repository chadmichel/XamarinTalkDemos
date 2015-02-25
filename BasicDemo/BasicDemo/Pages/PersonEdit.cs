using System;
using Xamarin.Forms;

namespace BasicDemo
{
    public class PersonEdit : ContentPage
    {
        Person _person;
        Entry nameEntry = new Entry();
        Stepper ageStepper =new Stepper();
        Label ageLabel = new Label();
        Button saveButton = new Button();

        public PersonEdit(Person person)
        {
            _person = person;

            nameEntry.Text = _person.Name;

            ageStepper.Maximum = 3500.0;
            ageStepper.Value = person.Age;
            ageStepper.ValueChanged += (object sender, ValueChangedEventArgs e) => 
                {
                    ageLabel.Text = Convert.ToInt32(e.NewValue).ToString();
                };

            ageLabel.Text = person.Age.ToString();

            saveButton.Text = "Save";
            saveButton.Clicked += (object sender, EventArgs e) => 
                {
                    _person.Name = nameEntry.Text;
                    _person.Age = Convert.ToInt32(ageStepper.Value);
                };

            Content = new StackLayout()
            {
                Children = 
                {
                    new Label() { Text = "Name" },
                    nameEntry,
                    new Label() { Text = "Age" },
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = 
                            {
                                ageStepper, 
                                ageLabel
                            }
                    },
                    saveButton
                }
            };
        }
    }
}

