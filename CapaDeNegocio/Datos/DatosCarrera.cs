using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal partial class Datos2 : IAccesoADatos<Carrera>
    {
        private static List<Carrera> listaCarreras = new List<Carrera>();
        private static int lastId;
        private static void Read()
        {
            try
            {
                string path = "C:\\Users\\Usuario\\source\\repos\\Final Algoritmos 2\\Final Algoritmos 2\\Datos\\carreras.json";
                string json = File.ReadAllText(path);
                listaCarreras = JsonSerializer.Deserialize<List<Carrera>>(json);
            }
            catch (Exception ex)
            {
                throw new Exception("");
            }
        }

        private static void Write()
        {
            try
            {
                string path = "C:\\Users\\Usuario\\source\\repos\\Final Algoritmos 2\\Final Algoritmos 2\\Datos\\carreras.json";
                string json = JsonSerializer.Serialize(listaCarreras);
                File.WriteAllText(path, json);
            }
            catch
            {
                throw new Exception("");
            }
        }

        private static void Clear()
        {
            listaCarreras.Clear();
        }
        public void Add(Carrera data)
        {
            Read();
            string pathID = "C:\\Users\\Usuario\\source\\repos\\Final Algoritmos 2\\Final Algoritmos 2\\Datos\\carreraLastId.txt";
            lastId = int.Parse(File.ReadAllText(pathID));
            data.ID = lastId++;
            File.WriteAllText(pathID, lastId.ToString());
            listaCarreras.Add(data);
            Write();
            Clear();
        }
     
        public void Erase(Carrera data)
        {
            Read();
            foreach (Carrera c in listaCarreras)
            {
                if (data.ID == c.ID)
                {
                    listaCarreras.Remove(c);
                    Write();
                    Clear();
                    return;
                }
            }
        }

        public string Find(Carrera data)
        {
            Read();
            foreach (Carrera c in listaCarreras)
            {
                if (data.ID == c.ID)
                {
                    string json = JsonSerializer.Serialize(c);
                    return json;
                }
            }
            Clear();
            throw new Exception("");
        }

        public void Modify(Carrera data)
        {
            Read();
            for (int i = 0; i < listaCarreras.Count; i++)
            {
                if (listaCarreras[i].ID == data.ID)
                {
                    listaCarreras[i].nombre = data.nombre;
                    Write();
                    Clear();
                    return;
                }
            }
            throw new Exception("");
        }
    }
}
