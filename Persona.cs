using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Personas
{
    public class Persona : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }

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
                NotifyPropertyChanged("Nombre");
            }
        }

        private string _foto;
        public string Foto
        {
            get
            {
                return _foto;
            }
            set
            {
                _foto = value;
                NotifyPropertyChanged("Foto");
            }
        }

        private string _sexo;
        public string Sexo
        {
            get
            {
                return _sexo;
            }
            set
            {
                _sexo = value;
                NotifyPropertyChanged("Sexo");
            }
        }

        public Persona(int id, string nombre, string foto, string sexo)
        {
            _id = id;
            _nombre = nombre;
            _foto = foto;
            _sexo = sexo;
        }

        public static ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>();

            lista.Add(new Persona(1, "Pepe", "1.jpg", "Hombre"));
            lista.Add(new Persona(2, "Antonio", "2.jpg", "Hombre"));
            lista.Add(new Persona(3, "Sara", "3.jpg", "Mujer"));

            return lista;
        }
    }
}