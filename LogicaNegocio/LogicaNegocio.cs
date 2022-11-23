using PruebaPresencial.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPresencial.LogicaNegocio
{
    public class LogicaNegocio
    {
        public ObservableCollection<Trabajador> listaTrabajadores { get ; set; }
        public LogicaNegocio() { 
            listaTrabajadores = new ObservableCollection<Trabajador>();
            listaTrabajadores.Add(new Trabajador("Trabajador", "De Prueba",40,new DateTime(2022,09,01),"DAM","Alumno 2º",20000));
        }
        public void addTrabajador(Trabajador trabajador)
        {
            listaTrabajadores.Add(trabajador);
        }
        public void modificarTrabajador(Trabajador trabajador, int posicion)
        {
            listaTrabajadores[posicion] = trabajador;
        }
        public void eliminarTrabajador(int posicion)
        {
            listaTrabajadores.RemoveAt(posicion);
        }
    }
}
