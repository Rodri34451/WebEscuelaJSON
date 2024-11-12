using System;
using System.Net;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Crud
{
    public class Carrera : IID, IABMC<Carrera>, ICarrera
    {
        private static Datos2 datos = new Datos2();

        #region IDD
        public int ID { get; set; }
        #endregion

        #region IABMC
        
        public void Add() //Para agregar carreras
        {
            datos.Add(this);
        }

        public void Modify() //Para modificar el nombre de las carreras
        {
            datos.Modify(this);
        }

        public void Erase() //Para eliminar carreras
        {
            datos.Erase(this);
        }

        public string Find() //Para encontrar carreras en base a su ID
        {
            return datos.Find(this);
        }
        #endregion

        #region ICarrera
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }

        public Carrera FindBySigla(string sigla) //Para encontrar carreras en base a sus siglas
        {
            throw new Exception("");
        }

        public string List() //Lista que contiene las carreras ingresadas
        {
            throw new Exception("");
        }

        public bool NameExists(string nombre) //Para verificar si el nombre de la carrera ingresada ya existe
        {
            throw new Exception("");
        }

        public bool SiglaExists(string sigla) //Para verificar si las siglas de la carrera ingresada ya existe
        {
            throw new Exception("");
        }
        #endregion
    }
}
