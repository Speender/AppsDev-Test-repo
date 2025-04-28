using System.Collections.ObjectModel;
using ReactiveUI;
using System.Reactive;

namespace Patient.ViewModels
{
    public class PatientDetailsViewModel : ReactiveObject
    {
        private string _searchQuery;
        public string SearchQuery
        {
            get => _searchQuery;
            set => this.RaiseAndSetIfChanged(ref _searchQuery, value);
        }

        private PatientModel _selectedPatient;
        public PatientModel SelectedPatient
        {
            get => _selectedPatient;
            set => this.RaiseAndSetIfChanged(ref _selectedPatient, value);
        }

        public ObservableCollection<PatientModel> Patients { get; }

        public ReactiveCommand<Unit, Unit> AddPatientCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveChangesCommand { get; }
        public ReactiveCommand<Unit, Unit> DeletePatientCommand { get; }

        public PatientDetailsViewModel()
        {
            Patients = new ObservableCollection<PatientModel>
            {
                new PatientModel { Name = "Juan Dela Cruz", Condition = "Hypertension", Age = 22, Address = "Lahug, Cebu City", Contact = "0912 123 5564", BloodPressure="150/95 mmHg", Medication="Amlodipine 5mg", Notes="Maintain low-sodium diet" },
                new PatientModel { Name = "Maria Santos", Condition = "Diabetes", Age = 35, Address = "Mandaue, Cebu City", Contact = "0916 543 1122", BloodPressure="140/90 mmHg", Medication="Metformin", Notes="Monitor blood sugar" }
            };

            SelectedPatient = Patients[0];

            AddPatientCommand = ReactiveCommand.Create(() => { /* add new patient logic */ });
            SaveChangesCommand = ReactiveCommand.Create(() => { /* save changes logic */ });
            DeletePatientCommand = ReactiveCommand.Create(() => { /* delete patient logic */ });
        }
    }

    public class PatientModel : ReactiveObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Condition { get; set; }
        public string BloodPressure { get; set; }
        public string Medication { get; set; }
        public string Notes { get; set; }
    }
}
