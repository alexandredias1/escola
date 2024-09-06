using Microsoft.AspNetCore.Mvc.RazorPages;

namespace escola.Pages
{
    public class UnidadesModel : PageModel
    {
        public List<Unidade> Unidades { get; set; } = new List<Unidade>();

        public void OnGet()
        {
            // Simula��o de dados. Substitua pelos dados reais.
            Unidades = new List<Unidade>
            {
                new Unidade
                {
                    Nome = "Unidade Arena Ol�mpica",
                    Descricao = "Localiza��o estrat�gica no Parque Ol�mpico do Rio de Janeiro.",
                    Localizacao = "Rio de Janeiro, Brasil",
                    ImagemUrl = "/images/unidade arena.webp",
                    InformacoesAdicionais = "�rea de 1,1 milh�o de metros quadrados com diversas instala��es."
                },
                // Adicione mais unidades conforme necess�rio
            };
        }
    }
}
