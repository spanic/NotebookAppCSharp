using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookApp {

    class Model {

        public enum State {
            New, Editing, Changed
        }
        public State CurrentState { get; set; } = Model.State.New;

        public SortedSet<Person> People { get; } = new SortedSet<Person>();

        private BindingList<Person> BindingListForGridView { get; }
        public BindingSource BindingSourceForDGView { get; } = new BindingSource();

        public BindingSource BindingSourceForFields { get; } = new BindingSource();

        private Person linkToCurrentPerson;
        public Person CurrentPerson {
            get => linkToCurrentPerson;
            set {
                linkToCurrentPerson = value;
                BindingSourceForFields.DataSource = value != null ? (object)CurrentPerson : typeof(Person);
            }
        }

        public Model() {
            BindingListForGridView = new BindingList<Person>(People.ToList());
            BindingSourceForDGView.DataSource = BindingListForGridView;
        }

        public Person AddNewPerson(string firstName, string secondName, string fathersName, DateTime birthday,
                string group, string comments, string primaryPhoneNumber, string secondaryPhoneNumber) {

            Person newPerson = new Person(firstName, primaryPhoneNumber);
            newPerson.FillAdditionalData(secondName, fathersName, birthday, group, comments, secondaryPhoneNumber);

            // Как иначе можно связать исходный Set и DataGridView с поддержкой автоматического обновления и сортировки?
            bool isInsertSuccessful = People.Add(newPerson);
            if (isInsertSuccessful) {
                BindingSourceForDGView.Add(newPerson);
            }

            Console.WriteLine("Добавлена новая запись: " + newPerson);
            Console.WriteLine("Длина коллекции People: " + People.Count);

            return newPerson;
        }

        public void DeleteSelectedPerson() {
            bool isDeleteSuccessful = People.Remove(CurrentPerson);
            if (isDeleteSuccessful) {
                BindingSourceForDGView.Remove(CurrentPerson);
            }
        }

    }

}
