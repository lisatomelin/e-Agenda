namespace e_Agenda.WinApp.ModuloDespesa
{
    public interface IRepositorioDespesa
    {
        void Editar(int id, Despesa despesaAtualizada);
        void Excluir(Despesa categoria);
        void Inserir(Despesa novaDespesa);
        Despesa SelecionarPorId(int id);
        List<Despesa> SelecionarTodos();

    }
}
