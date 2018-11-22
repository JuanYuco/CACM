using CACM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static CACM.Model.Login;

namespace CACM
{
    public interface Iservicios
    {
        Task <string> Login(clsUsuarios clsUsuario);//Logueo
        void getData();//TRAER LA INFORMACION DE LOS ESTUDIANTES
        Task<string> newLogin(string url, object request,Methods method,ContentType contentType);
        List<Model.clsDepartamentos> getDepartamentos();
        List<Model.clsHistoria> getHistoria();
        List<Model.clsPersonajesHistoricos> getPersonajesHistoricos();
        List<Model.clsGastronomia> getGastronomia();
        List<Model.clsMusica> getMusica();
        List<Model.clsArtistas> getArtistas();
        List<Model.clsEquipo> getEquipo();
        List<Model.clsFaunaxDepartamento> getFauna();
        List<Model.clsFlora> getFlora();
        List<Model.clsCulturas> getCulturas();



    }
}
