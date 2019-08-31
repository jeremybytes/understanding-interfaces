using Common;
using People.Library;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people;

            var repository = new PersonRepository();
            people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> people;

            var repository = new PersonRepository();
            people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
        }
    }
}
