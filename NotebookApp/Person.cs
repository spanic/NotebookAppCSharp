using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {

    class Person : IComparable {

        // Entity

        private const string EMPTY_VALUE = "[Пусто]";

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FathersName { get; set; }

        private DateTime birthday;
        public DateTime Birthday {
            get => birthday;
            set {
                var today = DateTime.Today;
                if (value > today)
                    throw new ArgumentOutOfRangeException("Birthday", "Попытка установить дату больше, чем текущая");
                birthday = value;
                Age = Convert.ToByte(today.Year - value.Year);
            }
        }
        public byte? Age { get; private set; }

        public string Group { get; set; }
        public string Comments { get; set; }

        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }

        public Person(string firstName, string primaryPhoneNumber) {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(primaryPhoneNumber))
                throw new ArgumentNullException(String.Empty, "Невозможно создать запись с пустым именем " +
                    "и/или основным тел. немером");
            FirstName = firstName;
            PrimaryPhoneNumber = primaryPhoneNumber;
        }

        public Person FillAdditionalData(string secondName, string fathersName, DateTime birthday, 
            string group, string comments, string secondaryPhoneNumber) {
            SecondName = secondName;
            FathersName = fathersName;
            Birthday = birthday;
            Group = group;
            Comments = comments;
            SecondaryPhoneNumber = secondaryPhoneNumber;

            return this;
        }

        public override string ToString() {
            return $"Имя: {FirstName} {SecondName??EMPTY_VALUE}, возраст: {(Age == null ? EMPTY_VALUE : Age.ToString())}, " +
                $"группа: {Group??EMPTY_VALUE}, осн. тел. №: {PrimaryPhoneNumber}";
        }

        public override bool Equals(object obj) {
            if ((object)this == obj) return true;
            if (obj == null || this.GetType() != obj.GetType()) return false;

            var opponent = (Person)obj;
            return FirstName == opponent.FirstName && PrimaryPhoneNumber == opponent.PrimaryPhoneNumber;
        }

        public override int GetHashCode() {
            return FirstName.GetHashCode() ^ PrimaryPhoneNumber.GetHashCode(); // XOR
        }

        int IComparable.CompareTo(object obj) {
            if (Equals(obj)) return 0;
            if (obj == null || this.GetType() != obj.GetType())
                throw new InvalidOperationException("Сравнение некорректно из-за неверной переданной ссылки");

            var opponent = (Person)obj;

            var namesComparisonResult = String.Compare(FirstName, opponent.FirstName);
            if (namesComparisonResult != 0) return namesComparisonResult;
            
            var primaryPhonesComparisonResult = String.Compare(PrimaryPhoneNumber, opponent.PrimaryPhoneNumber);

            /* Console.WriteLine($"namesComparisonResult: {namesComparisonResult}, " +
                $"primaryPhonesComparisonResult: {primaryPhonesComparisonResult}"); */

            return primaryPhonesComparisonResult;
        }

    }

}
