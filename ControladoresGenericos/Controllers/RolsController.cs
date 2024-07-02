using ControladoresGenericos.Models;
using ControladoresGenericos.UnitsOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresGenericos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolsController : GenericController<Models.Rol>
    {
        public RolsController(IGenericUnitOfWork<Rol> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
