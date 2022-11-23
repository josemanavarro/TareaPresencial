using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPresencial.dto
{
    public class Trabajador : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        
        private string _apellidos;
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set { 
                _apellidos = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Apellidos"));
            }
        }

        private int _edad;
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Edad"));
            }
        }
        
        private DateTime _contratacion;
        public DateTime Contratacion
        {
            get
            {
                return _contratacion;
            }
            set
            {
                _contratacion = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Contratacion"));
            }
        }
        
        private string _departamento;
        public string Departamento
        {
            get
            {
                return _departamento;
            }
            set
            {
                _departamento = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Departamento"));
            }
        }

        private string _puesto;
        public string Puesto
        {
            get
            {
                return _puesto;
            }
            set
            {
                _puesto = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Puesto"));
            }
        }
        
        private int _salario;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Salario { 
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Salario"));
            }
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(this._nombre))
                        result = "El campo nombre no debe estar vacío";
                }
                if (columnName == "Apellidos")
                {
                    if (string.IsNullOrEmpty(this._apellidos))
                        result = "El campo apellidos no debe estar vacío";
                }
                if (columnName == "Departamento")
                {
                    if (string.IsNullOrEmpty(this._departamento))
                        result = "El campo departamento no debe estar vacío";
                }
                if (columnName == "Edad") {
                    if (_edad <= 17 || _edad > 67)
                        result = "El campo edad debe tener un número entre 18 y 67";
                }
                if (columnName == "Salario")
                {
                    if (_salario < 0)
                        result = "El campo salario debe ser un entero positivo";
                }
                return result;
            }
        }
        public Object Clone()
        {
            return this.MemberwiseClone();
        }
        public Trabajador(string nombre, string apellidos, int edad, DateTime contratacion, string departamento, string puesto, int salario)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Contratacion = contratacion;
            Departamento = departamento;
            Puesto = puesto;
            Salario = salario;
        }
        public Trabajador()
        {
            _contratacion = DateTime.Now;
            _edad = 18;
            _salario = 0;
        }
    }
}
