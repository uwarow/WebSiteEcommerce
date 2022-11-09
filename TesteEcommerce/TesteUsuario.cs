using LojaWeb.Controllers;
using LojaWeb.Models;
using LojaWeb.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteEcommerce
{
    public class TesteUsuario 
    {
        

        [Fact]
        public bool ValidaUsuario()
        {
            IdentityUser identityUser = new IdentityUser();
            LoginViewModel login = new LoginViewModel();
           

            if(login.UserName != identityUser.UserName)
            {
                return false;

            }
            if (login.UserName == identityUser.UserName)
            {
                var result = login.Password == identityUser.UserName;
                return false;
            }
            return false;
            
            
            
        }


    }
}
    

