using Exámen2.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Exámen2.ViewModels
{
    public class CompararNumerosViewModel : INotifyPropertyChanged
    {
        private double _numero1;
        private double _numero2;
        private string _resultado;

        public double Numero1
        {
            get => _numero1;
            set
            {
                if (_numero1 != value)
                {
                    _numero1 = value;
                    OnPropertyChanged(nameof(Numero1));
                }
            }
        }

        public double Numero2
        {
            get => _numero2;
            set
            {
                if (_numero2 != value)
                {
                    _numero2 = value;
                    OnPropertyChanged(nameof(Numero2));
                }
            }
        }

        public string Resultado
        {
            get => _resultado;
            private set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public ICommand ValidarCommand => new Command(Validar);

        private void Validar()
        {
            if (Numero1 > Numero2)
            {
                Resultado = $"{Numero1} es mayor que {Numero2}";
            }
            else if (Numero2 > Numero1)
            {
                Resultado = $"{Numero2} es mayor que {Numero1}";
            }
            else
            {
                Resultado = "Ambos números son iguales";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}




