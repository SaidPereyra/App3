using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App3.ViewModels
{
    class MainPageViewModel: ViewModelBase 
    {


        private string _nombre;
        private string _apPaterno;
        private string _apMaterno;

        public MainPageViewModel()
        {
            _nombre = "Nombre";
            _apPaterno = "Apellido Paterno";
            _apMaterno = "Apellido Materno";
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }
        public string Paterno
        {
            get => _apPaterno;
            set
            {
                if (string.Equals(_apPaterno, value)) return;
                _apPaterno = value;
                RaisePropertyChanged(nameof(Paterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }
        public string Materno
        {
            get => _apMaterno;
            set
            {
                if (string.Equals(_apMaterno, value)) return;
                _apMaterno = value;
                RaisePropertyChanged(nameof(Materno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }
        public string NombreCompleto
        {
            get => string.Format("Bienvenido, {0} {1} {2}", Nombre, Paterno, Materno);
        }
    }
}

