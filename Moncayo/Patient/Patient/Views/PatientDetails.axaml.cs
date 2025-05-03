using Avalonia.Controls;

namespace Patient.Views
{
    public partial class PatientDetails : Window
    {
        public PatientDetails()
        {
            InitializeComponent();
            DataContext = new ViewModels.PatientDetailsViewModel();
        }
    }
}