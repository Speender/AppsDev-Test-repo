using System;
using System.Windows.Input;
using Avalonia.Controls;
using HospitalApp.Models;

namespace HospitalApp.ViewModels
{
    public class AddDoctorViewModel : ViewModelBase
    {
        private string _doctorName;
        private string _doctorEmail;
        private string _doctorUsername;
        private string _doctorSex;
        private string _doctorContactNumber;
        private string _doctorSpecialization;

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        private Window _addDoctorWindow;

        public string DoctorName
        {
            get => _doctorName;
            set
            {
                _doctorName = value;
                OnPropertyChanged();
            }
        }

        public string DoctorEmail
        {
            get => _doctorEmail;
            set
            {
                _doctorEmail = value;
                OnPropertyChanged();
            }
        }

        public string DoctorUsername
        {
            get => _doctorUsername;
            set
            {
                _doctorUsername = value;
                OnPropertyChanged();
            }
        }

        public string DoctorGender
        {
            get => _doctorSex;
            set
            {
                _doctorSex = value;
                OnPropertyChanged();
            }
        }

        public string DoctorContactNumber
        {
            get => _doctorContactNumber;
            set
            {
                _doctorContactNumber = value;
                OnPropertyChanged();
            }
        }
        
        public string DoctorSpecialization
        {
            get => _doctorSpecialization;
            set
            {
                _doctorSpecialization = value;
                OnPropertyChanged();
            }
        }

        public AddDoctorViewModel()
        {
            SaveCommand = new RelayCommand(_ => Save());
            CancelCommand = new RelayCommand(_ => Cancel());
        }

        public void SetWindow(Window window)
        {
            _addDoctorWindow = window;
        }

        private void Save()
        {
            var newDoctor = new Doctor
            {
                Name = DoctorName,
                Email = DoctorEmail,
                Username = DoctorUsername,
                Sex = DoctorGender,
                ContactNumber = DoctorContactNumber,
                specialization = DoctorSpecialization,
                is_available = 1 // Setting the doctor as available by default
            };

            _addDoctorWindow?.Close(newDoctor);
        }

        private void Cancel()
        {
            _addDoctorWindow?.Close(null);
        }
    }
}