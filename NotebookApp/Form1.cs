using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookApp {

    public partial class MainForm : Form {

        // View

        private Presenter presenter;

        public MainForm() {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        public Control FirstName { get => firstNameTextBox; }
        public string FirstNameValue {
            get => FirstName.Text;
            set => FirstName.Text = value;
        }

        public Control SecondName { get => secondNameTextBox; }
        public string SecondNameValue {
            get => SecondName.Text;
            set => SecondName.Text = value;
        }

        public Control FathersName { get => fathersNameTextBox; }
        public string FathersNameValue {
            get => FathersName.Text;
            set => FathersName.Text = value;
        }

        public DateTimePicker BirthDayDTPicker { get => birthbayDTPicker; }
        public DateTime BirthDayDTPickerValue {
            get => BirthDayDTPicker.Value.Date;
            set => BirthDayDTPicker.Value = value;
        }

        public Control GroupComboBox { get => groupComboBox; }
        public string GroupComboBoxValue {
            get => groupComboBox.Text;
            set => groupComboBox.Text = value;
        }

        public Control CommentsRichTB { get => commentsRichTextBox; }
        public string CommentsRichTBValue {
            get => CommentsRichTB.Text;
            set => CommentsRichTB.Text = value;
        }

        public Control PrimaryPhoneNumber { get => mainPhoneNumTextBox; }
        public string PrimaryPhoneNumberValue {
            get => PrimaryPhoneNumber.Text;
            set => PrimaryPhoneNumber.Text = value;
        }

        public Control SecondaryPhoneNumber { get => secondPhoneNumTextBox; }
        public string SecondaryPhoneNumberValue {
            get => SecondaryPhoneNumber.Text;
            set => SecondaryPhoneNumber.Text = value;
        }

        public DataGridView DataGridView { get => dataGridView; }

        public void AddDGViewColumn(string dataPropertyName, string headerText) {
            var newColumn = new DataGridViewTextBoxColumn {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText
            };
            newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridView.Columns.Add(newColumn);
        }

        public void ClearAllFields() {
            foreach (Control topControl in Controls) {

                if (topControl.GetType() != typeof(GroupBox) || !topControl.HasChildren)
                    continue;

                foreach (Control childControl in topControl.Controls) {
                    var childControlType = childControl.GetType();

                    Type[] controlTypesToBeCleared = {typeof(TextBox), typeof(RichTextBox),
                        typeof(ComboBox), typeof(DateTimePicker)};
                    if (!Array.Exists(controlTypesToBeCleared, element => element == childControlType))
                        continue;

                    if (childControl is DateTimePicker childDTPicker) childDTPicker.Value = DateTime.Today;
                    childControl.Text = String.Empty;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            presenter.SaveData();
        }

        public void ToggleSaveButton(bool flag) {
            saveButton.Enabled = flag;
        }

        public void ToggleDeleteButton(bool flag) {
            deleteButton.Enabled = flag;
        }

        private void DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            presenter.EditData();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            presenter.DeleteData();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            presenter.CancelEditing();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "Обязательные поля — \"Имя\" и \"Оснонвной тел. №\". \nПосле сохранения данных при выборе элемента в таблице все " +
                    "изменения сохраняются автоматически.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

    }

}
