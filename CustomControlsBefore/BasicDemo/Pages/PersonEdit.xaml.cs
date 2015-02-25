using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicDemo
{
    public partial class PersonEdit : ContentPage
    {
        public PersonEdit(PersonViewModel person)
        {
            InitializeComponent();
            Person = person;
            BindingContext = Person;
        }

        public PersonViewModel Person { get; set; }
    }
}

