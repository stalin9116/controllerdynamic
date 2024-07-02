namespace ControladoresGenericos.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CompanyNo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string? Telephone { get; set; }
        public string? Email { get; set; }

    }
}
