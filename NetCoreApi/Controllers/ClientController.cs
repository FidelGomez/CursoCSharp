using Microsoft.AspNetCore.Mvc;
using NetCoreApi.Models;

namespace NetCoreApi.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listClients()
        {
            List<Client> clients = new List<Client>
            {
                new Client { Id = 1, Name = "Fidel", Age = 21, Email = "fgomez@yopmail.com" },
                new Client { Id = 2, Name = "Mario", Age = 23, Email = "mlopez@yopmail.com" }

            };
            return clients;
        }

        [HttpPost]
        [Route("listarid")]
        public dynamic listIdClients(int _id)
        {
            List<Client> clients = new List<Client>
            {
                new Client { Id = _id, Name = "Fidel", Age = 21, Email = "fgomez@yopmail.com" },                
            };
            return clients;
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic saveClients(Client client)
        {
            client.Id = 3;
            return new { success=true, message="Saved customer", result = client };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic deleteClients(Client client) {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            if (token != "token123")
            {
                return new
                {
                    success = false,
                    message = "Se requiere de autorizacion para eliminar",
                };
            }
            return new
            {
                success = true,
                message = "Cliente eliminado con exito",
                result = client
            };
        }
    }
}
