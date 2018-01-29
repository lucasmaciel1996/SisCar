using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class LoginBLL
    {
        public bool verificarLogin(Usuario usuario)
        {
            if(usuario.Login.Trim().Length == 0){
                throw new Exception("Por favor, informe um usuário!");
            }
            if (usuario.Senha.Trim().Length == 0)
            {
                throw new Exception("Por favor, informe sua senha!");
            }
            usuario.Login = usuario.Login.ToUpper();

            LoginDAL usuariodal = new LoginDAL();
            return usuariodal.verificarLogin(usuario);
        }
    }
}
