namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            gridDespesas.ConfigurarGridSomenteLeitura();

            gridDespesas.ConfigurarGridZebrado();

            ConfigurarColunas();

        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn[] colunas = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "Id",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "descricao",
                    HeaderText = "Descrição",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "data",
                    HeaderText = "Data",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "valor",
                    HeaderText = "Valor",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "formaPgto",
                    HeaderText = "Forma de Pagamento",
                },


            };
            gridDespesas.Columns.AddRange(colunas);
        }

        public void AtualizarDespesas(List<Despesa> despesas)
        {
            gridDespesas.Rows.Clear();

            foreach (Despesa despesa in despesas)
            {
                gridDespesas.Rows.Add(despesa.id, despesa.descricao, despesa.data.ToShortTimeString(), despesa.valor, despesa.formaPgto);
            }
        }

        public int ObterIdSelecionada()
        {
            if (gridDespesas.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridDespesas.SelectedRows[0].Cells["id"].Value);

            return id;
        }

     
    }
}
