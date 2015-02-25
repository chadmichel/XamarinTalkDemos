using System;

using Xamarin.Forms;

namespace BasicDemo
{
    public class ListItemTemplate : ViewCell
    {
        Image photo;
        Label name;

        public ListItemTemplate()
        {
            photo = new Image
                {
                    HeightRequest = 32,
                    WidthRequest = 32,
                };

            name = new Label()
                {
                    Text = "",                   
                    VerticalOptions = LayoutOptions.Center
                };

            View = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {photo, name},
                };
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var personViewModel = BindingContext as PersonViewModel;
            if (personViewModel != null)
            {
                name.Text = personViewModel.Name;
                photo.Source = personViewModel.ImageUrl;

                personViewModel.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => 
                    {
                        if (e.PropertyName == "Name")
                            name.Text = personViewModel.Name;
                    };

                if (personViewModel.Age > 100)
                    View.BackgroundColor = Color.FromHex("663300"); 
            }
        }
    }
}


