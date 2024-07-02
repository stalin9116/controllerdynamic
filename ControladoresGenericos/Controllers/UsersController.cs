using ControladoresGenericos.Models;
using ControladoresGenericos.UnitsOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresGenericos.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : GenericController<Models.User>
    {
        public UsersController(IGenericUnitOfWork<User> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
