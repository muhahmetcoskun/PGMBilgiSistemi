using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;


namespace Services
{
    public class ServiceManager : IServiceManager
    {
        
        private readonly IAuthenticationService _authencationService;

        public ServiceManager(
            IAuthenticationService authencationService)
        {
         
            _authencationService = authencationService;
        }

   

        public IAuthenticationService AuthenticationService => _authencationService;

       
    }
}
