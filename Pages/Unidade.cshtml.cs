using Microsoft.AspNetCore.Mvc.RazorPages;

namespace escola.Pages
{
    public class UnidadesModel : PageModel
    {
        public List<Unidade> Unidades { get; set; } = new List<Unidade>();

        public void OnGet()
        {
            // Simulação de dados. Substitua pelos dados reais.
            Unidades = new List<Unidade>
            {
                new Unidade
                {
                    Nome = "Unidade Arena Olímpica",
                    Descricao = "Localização estratégica no Parque Olímpico do Rio de Janeiro.",
                    Localizacao = "Rio de Janeiro, Brasil",
                    ImagemUrl = "/images/unidade arena.webp",
                    InformacoesAdicionais = "Área de 1,1 milhão de metros quadrados com diversas instalações."
                },
                // Adicione mais unidades conforme necessário
            };
        }
    }
}
