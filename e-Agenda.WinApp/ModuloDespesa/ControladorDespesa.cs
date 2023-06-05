namespace e_Agenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        private TabelaDespesaControl tabelaDespesa;
        private IRepositorioDespesa repositorioDespesa;
        public TelaDespesaForm telaDespesaForm;
        public IRepositorioCategoria repositorioCategoria;


        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }
        public override string ToolTipInserir => "Inserir nova Despesa";

        public override string ToolTipEditar => "Editar Despesa";

        public override string ToolTipExcluir => "Excluir Despesa";

        public override void Inserir()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria.SelecionarTodos());

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa novaDespesa = telaDespesa.ObterDespesa();
                repositorioDespesa.Inserir(novaDespesa);
            }
        }
        public override void Editar()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show(
                    "Selecione uma despesa primeiro",
                    "Edição de Despesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria.SelecionarTodos());

            telaDespesa.ConfigurarTela(despesa);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesaAtualizada = telaDespesa.ObterDespesa();

                repositorioDespesa.Editar(despesaAtualizada.id, despesaAtualizada);
            }

            CarregarDespesas();
        }

        public override void Excluir()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!",
                    "Exclusão de despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa {despesa.descricao}?", "Exclusão de Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }


           
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
        private Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionada();

            return repositorioDespesa.SelecionarPorId(id);
        }
        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarDespesas(despesas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {despesas.Count} despesa(s)");


        }
    }
}
