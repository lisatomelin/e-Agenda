namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioEmMemoriaBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmMemoria(List<Despesa> despesas)
        {
            this.listaRegistros = despesas;
        }
    }
}
