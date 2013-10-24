using System.ComponentModel;

namespace Recipe_05_04
{
    class Person : INotifyPropertyChanged
    {
        #region Properties

        private string firstName;
        private string lastName;
        private int age;
        private string occupation;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
                this.OnPropertyChanged("FirstName");
                this.OnPropertyChanged("Description");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
                this.OnPropertyChanged("LastName");
                this.OnPropertyChanged("Description");
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
                this.OnPropertyChanged("Age");
                this.OnPropertyChanged("Description");
            }
        }

        public string Occupation
        {
            get
            {
                return occupation;
            }

            set
            {
                occupation = value;
                this.OnPropertyChanged("Occupation");
                this.OnPropertyChanged("Description");
            }
        }

        public string Description
        {
            get
            {
                return string.Format("{0} {1}, {2} years old ({3})",
                    this.firstName, this.lastName, this.age, this.occupation);
            }
        }

        #endregion Properties

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}
