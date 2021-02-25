using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InClassParticipation_Classes3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool infoFilledOut = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid name");
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid name");
            }
            if (string.IsNullOrEmpty(txtMajor.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid major");
            }

            double gpa;

            if (double.TryParse(txtGPA.Text, out gpa) == false)
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid gpa");
            }

            if (string.IsNullOrEmpty(txtStreetName.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid street name");
            }

            int streetNumber;

            if (int.TryParse(txtStreetNumber.Text, out streetNumber) == false)
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid street number");
            }
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid city");
            }
            if (string.IsNullOrEmpty(txtState.Text))
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid state");
            }

            int zipCode;

            if (int.TryParse(txtZipCode.Text, out zipCode) == false)
            {
                infoFilledOut = false;
                MessageBox.Show("You have entered an invalid zip code");
            }

            if (infoFilledOut == false)
            {
                return;
            }

            Student student = new Student()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Major = txtMajor.Text,
                GPA = gpa
            };

            student.SetAddress(streetNumber, txtStreetName.Text, txtState.Text, txtCity.Text, zipCode);

            lstStudents.Items.Add(student);
        }
    }
}
