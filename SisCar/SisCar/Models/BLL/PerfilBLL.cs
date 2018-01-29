using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class PerfilBLL
    {

        public void SalvarCor(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildal = new PerfilDAL();
            perfildal.SalvarCor(perfil);
        

        }
        public void SalvarImagem(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildal = new PerfilDAL();
            perfildal.SalvarImagem(perfil);


        }

        public String VerificarCoreFundo(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildal = new PerfilDAL();
           return perfildal.VerificarCoreFundo(perfil);


        }
        public String RetornaCoreFundo(Perfil perfil)
        {
            perfil.Login = Login.User;
            PerfilDAL perfildal = new PerfilDAL();
            return perfildal.RetornaCorFundo(perfil);


        }





    }
}
