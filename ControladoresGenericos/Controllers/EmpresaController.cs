using ControladoresGenericos.Models;
using ControladoresGenericos.UnitsOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresGenericos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : GenericController<Models.Empresa>
    {
        public EmpresaController(IGenericUnitOfWork<Empresa> unitOfWork) : base(unitOfWork)
        {
        }



    }
}
