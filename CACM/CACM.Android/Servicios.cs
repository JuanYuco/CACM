using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CACM.Model;
using Newtonsoft.Json;
using RestSharp;
using Xamarin.Forms;
using CACM.Droid;
using System.Threading.Tasks;
using static CACM.Model.Login;
using System.Net;
using System.IO;

[assembly: Dependency(typeof(Servicios))]

namespace CACM.Droid
{
    
    public class Servicios : Iservicios
    {
        public void getData()
        {
            
        }

        public Task <string> Login(clsUsuarios clsUsuario)
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Usuarios");
                var Request = new RestRequest("/validarUsuarios", Method.POST)
                {
                    RequestFormat = DataFormat.Json
                };

                //string json_response = JsonConvert.SerializeObject(clsUsuario);
                Request.AddBody(clsUsuario);

                //Request.AddParameter("email",correo);
                //r@r.com
                //Request.AddParameter("password", contraseña);
                //12345

                var response = Cliente.Execute(Request);
                string respuesta = response.Content;
                //ResponseData contenido = JsonConvert.DeserializeObject<ResponseData>(response.Content);

                return Task.FromResult(respuesta);
                
            }
            catch(Exception e) { return null; }
        }


        public List<Model.clsDepartamentos> getDepartamentos()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/TraerDepartamentos", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsDepartamentos> respuesta = JsonConvert.DeserializeObject<List<Model.clsDepartamentos>>(response.Content);
                return respuesta;
            }
            catch(Exception ew)
            {
                return null;
            }
        }

        public List<Model.clsHistoria> getHistoria()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerHistoria", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsHistoria> respuesta = JsonConvert.DeserializeObject<List<Model.clsHistoria>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }


        public List<Model.clsPersonajesHistoricos> getPersonajesHistoricos()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerPersonajesHistoricos", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsPersonajesHistoricos> respuesta = JsonConvert.DeserializeObject<List<Model.clsPersonajesHistoricos>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }

        public List<Model.clsGastronomia> getGastronomia()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerGastronomia", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsGastronomia> respuesta = JsonConvert.DeserializeObject<List<Model.clsGastronomia>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }


        public List<Model.clsMusica> getMusica()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerMusica", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsMusica> respuesta = JsonConvert.DeserializeObject<List<Model.clsMusica>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }



        public List<Model.clsArtistas> getArtistas()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerArtistas", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsArtistas> respuesta = JsonConvert.DeserializeObject<List<Model.clsArtistas>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }

        public List<Model.clsEquipo> getEquipo()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerEquipo", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsEquipo> respuesta = JsonConvert.DeserializeObject<List<Model.clsEquipo>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }


        public List<Model.clsFaunaxDepartamento> getFauna()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerFauna", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsFaunaxDepartamento> respuesta = JsonConvert.DeserializeObject<List<Model.clsFaunaxDepartamento>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }


        public List<Model.clsFlora> getFlora()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerFlora", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsFlora> respuesta = JsonConvert.DeserializeObject<List<Model.clsFlora>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }

        public List<Model.clsCulturas> getCulturas()
        {
            try
            {
                RestClient Cliente = new RestClient("http://192.168.1.71/ApiCAC//api/Mapa");
                var Request = new RestRequest("/traerCulturas", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                var response = Cliente.Execute(Request);
                List<Model.clsCulturas> respuesta = JsonConvert.DeserializeObject<List<Model.clsCulturas>>(response.Content);
                return respuesta;
            }
            catch (Exception ew)
            {
                return null;
            }
        }







        public Task <string> newLogin(string url,object request,Methods method,ContentType contentType)
        {
            try
            {
                HttpWebRequest httpWebRequest;
                httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = method == Methods.POST ? "POST" :
                    method == Methods.GET ? "GET" : string.Empty;
                httpWebRequest.Timeout = 32000;
                httpWebRequest.ContentType = contentType == ContentType.URL_ENCODED ? "application/x-www-form-urlencoded" :
                    contentType == ContentType.JSON ? "application/json" : string.Empty;
                if (request != null)
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(request));
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                HttpWebResponse resp;
                resp = (HttpWebResponse)httpWebRequest.GetResponse();
                string json = string.Empty;
                if(resp.StatusCode.Equals(HttpStatusCode.OK))
                    using (var streamReader= new StreamReader(resp.GetResponseStream()))
                    {
                        json = streamReader.ReadToEnd();
                    }
                return Task.FromResult(json);

            }catch(Exception ew)
            {
                throw ew;
            }
        }
    }
}