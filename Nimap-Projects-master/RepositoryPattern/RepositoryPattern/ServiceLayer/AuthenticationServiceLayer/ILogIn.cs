﻿using CategoryProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CategoryProduct.RepositoryPattern.ServiceLayer.AuthenticationServiceLayer
{
    public interface ILogIn
    {
        Task<LogInCredential> LogIn(LogInCredential l); 
    }
}