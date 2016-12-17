using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Taareas
{
    public class tabletareas
    {
        string id;
        string titulo;
        string descripcion;
        string persona;
        string prioridad;
        string depend;
        string status;
        int status_user;
        string ID_tarea;

        [JsonProperty(PropertyName = "id_tareas")]

        public string id_tarea
        {
            get { return ID_tarea; }
            set { ID_tarea = value; }
        }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "title")]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [JsonProperty(PropertyName = "person")]
        public string Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        [JsonProperty(PropertyName = "priority")]
        public string Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }

        [JsonProperty(PropertyName = "date")]
        public DateTime Fecha
        {
            get; set;
        }

        [JsonProperty(PropertyName = "dependencia")]
        public string Dependencia
        {
            get { return depend; }
            set { depend = value; }
        }

        [JsonProperty(PropertyName = "status")]
        public string Estatus
        {
            get { return status; }
            set { status = value; }
        }

        [JsonProperty(PropertyName = "status_usuario")]
        public int Estatus_user
        {
            get { return status_user; }
            set { status_user = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
