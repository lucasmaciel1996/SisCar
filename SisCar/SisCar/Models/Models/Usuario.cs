﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Usuario
    {
       private String login;
       private String senha;

       public String Login
       {
           get { return login; }
           set { login = value; }
       }

       public string Senha
       {
           get { return senha; }
           set { senha = value; }
       }

    }
}
