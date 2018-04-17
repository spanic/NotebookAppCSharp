using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookApp {

    class Presenter {

        // Presenter

        private MainForm view;
        private Model model;

        public Presenter(MainForm view) {
            this.view = view;
            model = new Model();
            ConfigureDataGridView();
            ConfigureListToFieldsBinding();
        }

        private void ConfigureDataGridView() {
            view.DataGridView.AutoGenerateColumns = false;
            view.AddDGViewColumn("SecondName", "Фамилия");
            view.AddDGViewColumn("FirstName", "Имя");
            view.AddDGViewColumn("Birthday", "День рождения");
            view.AddDGViewColumn("PrimaryPhoneNumber", "Осн. тел. №");

            view.DataGridView.DataSource = model.BindingSourceForDGView;
        }

        private void ConfigureListToFieldsBinding() {
            model.BindingSourceForFields.DataSource = typeof(Person);

            view.FirstName.DataBindings.Add("Text", model.BindingSourceForFields, "FirstName");
            view.SecondName.DataBindings.Add("Text", model.BindingSourceForFields, "SecondName");
            view.FathersName.DataBindings.Add("Text", model.BindingSourceForFields, "FathersName");
            view.BirthDayDTPicker.DataBindings.Add("Text", model.BindingSourceForFields, "Birthday");
            view.GroupComboBox.DataBindings.Add("Text", model.BindingSourceForFields, "Group");
            view.CommentsRichTB.DataBindings.Add("Text", model.BindingSourceForFields, "Comments");
            view.PrimaryPhoneNumber.DataBindings.Add("Text", model.BindingSourceForFields, "PrimaryPhoneNumber");
            view.SecondaryPhoneNumber.DataBindings.Add("Text", model.BindingSourceForFields, "SecondaryPhoneNumber");
        }

        public void SaveData() {
            try {
                var addedPerson = model.AddNewPerson(view.FirstNameValue, view.SecondNameValue, view.FathersNameValue, 
                    view.BirthDayDTPickerValue, view.GroupComboBoxValue, view.CommentsRichTBValue, view.PrimaryPhoneNumberValue, 
                        view.SecondaryPhoneNumberValue);

                view.DataGridView.Refresh();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditData() {
            Person selectedPerson = view.DataGridView.CurrentRow.DataBoundItem as Person;
            Console.WriteLine($"Выбрана запись: {selectedPerson}");

            model.CurrentState = Model.State.Editing;
            model.CurrentPerson = selectedPerson;

            view.ToggleDeleteButton(true);
            view.ToggleSaveButton(false);
        }

        public void DeleteData() {
            model.DeleteSelectedPerson();
            view.ToggleDeleteButton(false);
            view.ToggleSaveButton(true);

            model.CurrentState = Model.State.New;
            model.CurrentPerson = null;
        }

        public void CancelEditing() {
            if (model.CurrentState == Model.State.Editing) {
                view.ToggleSaveButton(true);
                view.ToggleDeleteButton(false);
                
                view.DataGridView.ClearSelection();

                model.CurrentState = Model.State.New;
                model.CurrentPerson = null;
            } else {
                view.ClearAllFields();
            }
        }

    }

}
