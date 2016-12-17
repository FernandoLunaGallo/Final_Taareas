using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Final_Taareas
{
    public interface loguin
    {
        Task<MobileServiceUser> Autentication();
    }

    public partial class Diseño : MasterDetailPage

    {
        public static loguin Autenticator { get; private set; }
        public static void Init(loguin autenticator)
        {
            Autenticator = autenticator;
        }

        public static MobileServiceClient client = new MobileServiceClient(Conexion.con);
        public static IMobileServiceTable<tabletareas> tabla = client.GetTable<tabletareas>();
        public static MobileServiceUser autheticated;

        public Diseño()
        {
            InitializeComponent();



            List.IsVisible = false;
            Lista1.IsVisible = false;
            Lista2.IsVisible = false;

            search.IsVisible = false;
            search1.IsVisible = false;
            search2.IsVisible = false;

            refresh.IsVisible = false;

            name1.IsVisible = false;
            name2.IsVisible = false;
            name3.IsVisible = false;

            btnsalir.IsVisible = false;
            lb1.IsVisible = false;
            lb2.IsVisible = false;
            lb3.IsVisible = false;
            lb4.IsVisible = false;
            lb5.IsVisible = false;
            lb6.IsVisible = false;
            lb7.IsVisible = false;
            titulotxt.IsVisible = false;
            descritxt.IsVisible = false;
            personapic.IsVisible = false;
            prioripic.IsVisible = false;
            fechapick.IsVisible = false;
            depentxt.IsVisible = false;
            statuspic.IsVisible = false;
            save.IsVisible = false;
            update.IsVisible = false;
            delete.IsVisible = false;
          
        }


        //llenar la lista
        public async void lista2(Object sender, object EventArgs)
        {
            IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

            string[] arreglo1 = new string[items.Count()];

            int i = 0;

            foreach (var x in items)
            {
                arreglo1[i] = x.Titulo;
                i++;

            }

            Lista2.ItemsSource = arreglo1;
        }
        public async void lista1(Object sender, object EventArgs)
        {
            try
            {
                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                var datos = items.Where(a => a.Persona == "mali@hector26941live.onmicrosoft.com");

                string[] arreglos1 = new string[datos.Count()];

                int i = 0;

                foreach (var x in datos)
                {
                    arreglos1[i] = x.Titulo;
                    i++;
                }
                Lista1.ItemsSource = arreglos1;
            }
            catch (Exception e)
            {
                await DisplayAlert("Alerta", "ERROR ", "OK");
            }
        }
        public async void lista(Object sender, object EventArgs)
        {
            try
            {
                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                var datos = items.Where(a => a.Persona == "mariano@hector26941live.onmicrosoft.com");

                string[] arreglos1 = new string[datos.Count()];

                int i = 0;

                foreach (var x in datos)
                {
                    arreglos1[i] = x.Titulo;
                    i++;
                }
                List.ItemsSource = arreglos1;
            }
            catch (Exception e)
            {
                await DisplayAlert("Alerta", "ERROR ", "OK");
            }
        }
        //cerrar sesion
        public async void logout(Object sender, EventArgs e)
        {
            await client.LogoutAsync();
            await client.LogoutAsync();

            List.ItemsSource = null;
            Lista1.ItemsSource = null;
            Lista2.ItemsSource = null;

            List.IsVisible = false;
            Lista1.IsVisible = false;
            Lista2.IsVisible = false;
            search.IsVisible = false;
            search1.IsVisible = false;
            search2.IsVisible = false;
            refresh.IsVisible = false;
            name1.IsVisible = false;
            name2.IsVisible = false;
            name3.IsVisible = false;
            btnsalir.IsVisible = false;
            lb1.IsVisible = false;
            lb2.IsVisible = false;
            lb3.IsVisible = false;
            lb4.IsVisible = false;
            lb5.IsVisible = false;
            lb6.IsVisible = false;
            lb7.IsVisible = false;
            titulotxt.IsVisible = false;
            descritxt.IsVisible = false;
            personapic.IsVisible = false;
            prioripic.IsVisible = false;
            fechapick.IsVisible = false;
            depentxt.IsVisible = false;
            statuspic.IsVisible = false;
            save.IsVisible = false;
            update.IsVisible = false;
            delete.IsVisible = false;
            btnacceder.IsVisible = true;
           ima.IsVisible = true;

        }
        //inicio sesion
        public async void log(Object sender, EventArgs e)
        {
            //bool b = false;
            autheticated = await Autenticator.Autentication();
            if (Diseño.autheticated != null)
            {
                search1.Text = "";
                titulotxt.Text = "";
                descritxt.Text = "";
                depentxt.Text = "";
                statuspic.Text = "";
                personapic.Text = "";
                prioripic.Text = "";
                search.Text = "";
                search2.Text = "";

                if (autheticated.UserId == "sid:ff2cf521acf44ea78d1fda8433d4a535" || autheticated.UserId == "sid:9818dd8989b4816a91107bb65896d3c3")
                {
                    if (autheticated.UserId == "sid:ff2cf521acf44ea78d1fda8433d4a535")//lalo
                    {
                        name2.IsVisible = true;
                        lista(true, true);
                        List.IsVisible = true;
                        lista1(false, false);
                        Lista1.IsVisible = false;
                        lista2(false, false);
                        Lista2.IsVisible = false;
                        search2.IsVisible = false;
                        btnacceder.IsVisible = false;
                        search.IsVisible = false;
                        refresh.IsVisible = true;
                        btnsalir.IsVisible = true;

                        lb1.IsVisible = true;
                        lb2.IsVisible = true;
                        lb3.IsVisible = true;
                        lb4.IsVisible = true;
                        lb5.IsVisible = true;
                        lb6.IsVisible = true;
                        lb7.IsVisible = true;
                        ima.IsVisible = false;
                        titulotxt.IsVisible = true;
                        descritxt.IsVisible = true;
                        personapic.IsVisible = true;
                        prioripic.IsVisible = true;
                        fechapick.IsVisible = true;
                        statuspic.IsVisible = true;
                        depentxt.IsVisible = true;

                        titulotxt.IsEnabled = false;
                        descritxt.IsEnabled = false;
                        personapic.IsEnabled = false;
                        prioripic.IsEnabled = false;
                        fechapick.IsEnabled = false;
                        depentxt.IsEnabled = false;


                        save.IsVisible = false;
                        update.IsVisible = true;
                        delete.IsVisible = false;

                    }
                    else if (autheticated.UserId == "sid:9818dd8989b4816a91107bb65896d3c3")//maliachi
                    {
                        name3.IsVisible = true;
                        lista1(true, true);
                        Lista1.IsVisible = true;
                        lista2(false, false);
                        Lista2.IsVisible = false;
                        lista(false, false);
                        List.IsVisible = false;
                        search2.IsVisible = false;
                        btnacceder.IsVisible = false;
                        search.IsVisible =false;
                        search1.IsVisible = true;
                        refresh.IsVisible = true;
                        btnsalir.IsVisible = true;

                        lb1.IsVisible = true;
                        lb2.IsVisible = true;
                        lb3.IsVisible = true;
                        lb4.IsVisible = true;
                        lb5.IsVisible = true;
                        lb6.IsVisible = true;
                        lb7.IsVisible = true;
                        ima.IsVisible = false;
                        titulotxt.IsVisible = true;
                        descritxt.IsVisible = true;
                        personapic.IsVisible = true;
                        prioripic.IsVisible = true;
                        fechapick.IsVisible = true;
                        statuspic.IsVisible = true;
                        depentxt.IsVisible = true;

                        titulotxt.IsEnabled = false;
                        descritxt.IsEnabled = false;
                        personapic.IsEnabled = false;
                        prioripic.IsEnabled = false;
                        fechapick.IsEnabled = false;
                        depentxt.IsEnabled = false;


                        save.IsVisible = false;
                        update.IsVisible = true;
                        delete.IsVisible = false;
                    }
                }
                else
                {
                    name1.IsVisible = true;
                    lista2(true, true);
                    Lista2.IsVisible = true;
                    lista(false,false);
                    List.IsVisible = false;
                    lista1(false, false);
                    Lista1.IsVisible = false;

                    search2.IsVisible = true;                 
                   refresh.IsVisible = true;
                    ima.IsVisible = false;
                    btnacceder.IsVisible = false;
                    btnsalir.IsVisible = true;
                    lb1.IsVisible = true;
                    lb2.IsVisible = true;
                    lb3.IsVisible = true;
                    lb4.IsVisible = true;
                    lb5.IsVisible = true;
                    lb6.IsVisible = true;
                    lb7.IsVisible = true;
                    titulotxt.IsVisible = true;
                    descritxt.IsVisible = true;
                    personapic.IsVisible = true;
                    prioripic.IsVisible = true;
                    fechapick.IsVisible = true;
                    depentxt.IsVisible = true;
                    statuspic.IsVisible = true;
                    save.IsVisible = true;
                    update.IsVisible = true;
                    delete.IsVisible = true;
                    btnacceder.IsVisible = false;
                }
            }
        }

        //buscar un contacto
        public async void buscar(Object sender, EventArgs e)
        {
            try
            {
                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                string[] arreglos1 = new string[items.Count()];
                string[] arreglo2 = new string[items.Count()];
                string[] arreglo3 = new string[items.Count()];
                string[] arreglo4 = new string[items.Count()];
                string[] arreglo5 = new string[items.Count()];
                string[] arreglo6 = new string[items.Count()];
                DateTime[] arreglo7 = new DateTime[items.Count()];

                int i = 0;

                foreach (var a in items.Where(a => a.Persona == "mariano@hector26941live.onmicrosoft.com")) {

                    foreach (var x in items)
                    {
                        arreglos1[i] = x.Titulo;
                        arreglo2[i] = x.Description;
                        arreglo3[i] = x.Persona;
                        arreglo4[i] = x.Prioridad;
                        arreglo7[i] = x.Fecha;
                        arreglo5[i] = x.Dependencia;
                        arreglo6[i] = x.Estatus;
                        i++;

                        if (x.Titulo == search.Text)
                        {
                            titulotxt.Text = x.Titulo;
                            descritxt.Text = x.Description;
                            depentxt.Text = x.Dependencia;
                            fechapick.Date = x.Fecha;
                            personapic.Text = x.Persona;
                            prioripic.Text = x.Prioridad;
                            statuspic.Text = x.Estatus;
                         }
                    }
                }
                List.ItemsSource = from a in arreglos1
                                   where a.StartsWith("" + search.Text)
                                   select a;
            }
            catch (Exception )
            {

               // await DisplayAlert("Alerta", "no existe el contacto ", "OK");
                //search.Text = "";

            }
        }
        public async void buscar2(Object sender, EventArgs ex)
        {
            try
            {
                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                string[] arreglo1 = new string[items.Count()];
                string[] arreglo2 = new string[items.Count()];
                string[] arreglo3 = new string[items.Count()];
                string[] arreglo4 = new string[items.Count()];
                string[] arreglo5 = new string[items.Count()];
                string[] arreglo6 = new string[items.Count()];
                DateTime[] arreglo7 = new DateTime[items.Count()];

                int i = 0;

                foreach (var x in items)
                {
                    arreglo1[i] = x.Titulo;
                    arreglo2[i] = x.Description;
                    arreglo3[i] = x.Persona;
                    arreglo4[i] = x.Prioridad;
                    arreglo7[i] = x.Fecha;
                    arreglo5[i] = x.Dependencia;
                    arreglo6[i] = x.Estatus;
                    i++;

                    if (x.Titulo == search2.Text)
                    {

                        titulotxt.Text = x.Titulo;
                        descritxt.Text = x.Description;
                        depentxt.Text = x.Dependencia;
                        fechapick.Date = x.Fecha;
                        personapic.Text = x.Persona;
                        prioripic.Text = x.Prioridad;
                        statuspic.Text = x.Estatus;
                    }
                }
                Lista2.ItemsSource = from nombre in arreglo1
                                     where nombre.StartsWith("" + search2.Text)
                                     select nombre;
            }
            catch (Exception e)
            {
                await DisplayAlert("Alerta", "no existe el contacto ", "OK");
                search2.Text = "";
            }
        }
        public async void buscar1(Object sender, EventArgs e)
        {
            try
            {

                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();


                //string[] arreglo_1 = new string[datos.Count()];
                string[] arreglos1 = new string[items.Count()];
                string[] arreglo2 = new string[items.Count()];
                string[] arreglo3 = new string[items.Count()];
                string[] arreglo4 = new string[items.Count()];
                string[] arreglo5 = new string[items.Count()];
                string[] arreglo6 = new string[items.Count()];
                DateTime[] arreglo7 = new DateTime[items.Count()];


                int i = 0;

                foreach (var a in items.Where(a => a.Persona == "mali@hector26941live.onmicrosoft.com"))
                {

                    foreach (var x in items)
                    {
                        arreglos1[i] = x.Titulo;
                        arreglo2[i] = x.Description;
                        arreglo3[i] = x.Persona;
                        arreglo4[i] = x.Prioridad;
                        arreglo7[i] = x.Fecha;
                        arreglo5[i] = x.Dependencia;
                        arreglo6[i] = x.Estatus;
                        i++;

                        if (x.Titulo == search1.Text)
                        {
                            titulotxt.Text = x.Titulo;
                            descritxt.Text = x.Description;
                            depentxt.Text = x.Dependencia;
                            fechapick.Date = x.Fecha;
                            personapic.Text = x.Persona;
                            prioripic.Text = x.Prioridad;
                            statuspic.Text = x.Estatus;
                        }
                    }
                }
                Lista1.ItemsSource = from a in arreglos1
                                   where a.StartsWith("" + search1.Text)
                                   select a;
            }
            catch (Exception)
            {

                // await DisplayAlert("Alerta", "no existe el contacto ", "OK");
                //search.Text = "";

            }
        }
        //seleccion de tarea
        private void selecciona(object sender, SelectedItemChangedEventArgs e)
        {
            search.Text = "" + e.SelectedItem;
        }
        private void selecciona1(object sender, SelectedItemChangedEventArgs e)
        {
            search1.Text = "" + e.SelectedItem;
        }
        private void selecciona2(object sender, SelectedItemChangedEventArgs ex)
        {
            search2.Text = "" + ex.SelectedItem;
        }
        //insert
        public async void inserta(object sender, object args)
        {

            if (titulotxt.Text == null || descritxt.Text == null || personapic.Text == null || prioripic.Text == null
                || fechapick.Date == null || depentxt.Text == null || statuspic.Text == null)
            {
                await DisplayAlert("Alerta", "Te falta llenar algun campo para poder insertar el contacto ", "OK");
            }
            else
            {
                try
                {

                    var datos = new tabletareas { Titulo = titulotxt.Text, Description = descritxt.Text, Persona = personapic.Text, Prioridad = prioripic.Text, Fecha = fechapick.Date, Dependencia = depentxt.Text, Estatus = statuspic.Text };

                    IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                    if (datos.Id == null)
                    {
                        await tabla.InsertAsync(datos);
                    }

                   
                    search.Text = "";
                    search2.Text = "";


                } catch (Exception e)
                {
                          await DisplayAlert("Alerta", "Tu contacto ha sido guardado con exito ", "OK");

                }
            }
        }
        //update
        public async void actualizar(object sender, object args)
        {
            if (titulotxt.Text == null || descritxt.Text == null || personapic.Text == null || prioripic.Text == null
    || fechapick.Date == null || depentxt.Text == null || statuspic.Text == null)
            {
                await DisplayAlert("Alerta", "Te falta llenar algun campo para poder insertar el contacto ", "OK");
            }
            else
            {
                var datos = new tabletareas
                {
                    Titulo = titulotxt.Text,
                    Description = descritxt.Text,
                    Persona = personapic.Text,
                    Prioridad = prioripic.Text,
                    Fecha = fechapick.Date,
                    Dependencia = depentxt.Text,
                    Estatus = statuspic.Text
                };


                IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

                string[] arreglo1 = new string[items.Count()];
                string[] arreglo2 = new string[items.Count()];
                string[] arreglo3 = new string[items.Count()];
                string[] arreglo4 = new string[items.Count()];
                string[] arreglo6 = new string[items.Count()];
                DateTime[] arreglo5 = new DateTime[items.Count()];


                int i = 0;

                foreach (var x in items)
                {
                    arreglo1[i] = x.Titulo;
                    arreglo2[i] = x.Persona;
                    arreglo3[i] = x.Estatus;
                    arreglo4[i] = x.Prioridad;
                    arreglo5[i] = x.Fecha;
                    arreglo6[i] = x.Description;


                    if (x.Titulo == titulotxt.Text)
                    {
                        if (x.Persona != personapic.Text)
                        {
                            x.Persona = personapic.Text;
                        }
                        if (x.Description != descritxt.Text)
                        {
                            x.Description = descritxt.Text;
                        }
                        if (x.Estatus != statuspic.Text)
                        {
                            x.Estatus = statuspic.Text;
                        }
                        if (x.Prioridad != prioripic.Text)
                        {
                            x.Prioridad = prioripic.Text;
                        }
                        if (x.Fecha != fechapick.Date)
                        {
                            x.Fecha = fechapick.Date;
                        }

                        await tabla.UpdateAsync(x);

                        await DisplayAlert("Alerta", "Tu contacto ha sido actualizado con exito ", "OK");
                    }
                }
            }
        }
        //eliminar
        public async void borrar(object sender, object args)
        {
            if (titulotxt.Text == null)
            {
                await DisplayAlert("Alerta", "Te falta llenar un campo ", "OK");
            }
            else
            {
                var datos = new tabletareas
            {
                Titulo = titulotxt.Text,
                Description = descritxt.Text,
                Persona = personapic.Text,
                Prioridad = prioripic.Text,
                Fecha = fechapick.Date,
                Dependencia = depentxt.Text,
                Estatus = statuspic.Text
            };

            IEnumerable<tabletareas> items = await tabla.ToEnumerableAsync();

            string[] arreglo1 = new string[items.Count()];
            string[] arreglo2 = new string[items.Count()];
            string[] arreglo3 = new string[items.Count()];
            string[] arreglo4 = new string[items.Count()];
            DateTime[] arreglo5 = new DateTime[items.Count()];


            int i = 0;

            foreach (var x in items)
            {
                arreglo1[i] = x.Titulo;
                arreglo2[i] = x.Persona;
                arreglo3[i] = x.Estatus;
                arreglo4[i] = x.Prioridad;
                arreglo5[i] = x.Fecha;


                if (x.Titulo == titulotxt.Text)
                {
                    if (x.Persona != personapic.Text)
                    {
                        x.Persona = personapic.Text;
                    }
                    if (x.Estatus != statuspic.Text)
                    {
                        x.Estatus = statuspic.Text;
                    }
                    if (x.Prioridad != prioripic.Text)
                    {
                        x.Prioridad = prioripic.Text;
                    }
                    if (x.Fecha != fechapick.Date)
                    {
                        x.Fecha = fechapick.Date;
                    }

                    await tabla.DeleteAsync(x);
                    await DisplayAlert("Alerta", "Tu contacto ha sido borrado con exito ", "OK");
                        search.Text = "";
                        titulotxt.Text = "";
                        descritxt.Text = "";
                        depentxt.Text = "";
                        statuspic.Text = "";
                        personapic.Text = "";
                        prioripic.Text = "";
                        search.Text = "";
                        search2.Text = "";

                    }
            }
        }
    }
        public async void nuevo(object sender, object args)
        {
            
            search1.Text = "";
            titulotxt.Text = "";
            descritxt.Text = "";
            depentxt.Text = "";
            statuspic.Text = "";
            personapic.Text = "";
            prioripic.Text = "";
            search.Text = "";
            search2.Text = "";
        }
    }
}