using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloContato;
using System.Drawing;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {
        
        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            CarregarCategorias(categorias);



        }

        private void CarregarCategorias(List<Categoria> categorias)
        {
            FormaPgtoDespesaEnum[] formaPgtos = Enum.GetValues<FormaPgtoDespesaEnum>();

            foreach (FormaPgtoDespesaEnum formaPgto in formaPgtos)
            {
                cbbFormaPgto.Items.Add(formaPgto);
            }
        }

        
        public Despesa ObterDespesa()
        {
            int id = Convert.ToInt32(txtId.Text);

            string descricao = txtDescricao.Text;

            DateTime data = txtData.Value;

            decimal valor = Convert.ToDecimal(txtValor.Text);

            FormaPgtoDespesaEnum formaPgto = (FormaPgtoDespesaEnum)cbbFormaPgto.SelectedItem;

            return new Despesa(descricao, data, valor, formaPgto);
        }

        public void ConfigurarTela(Despesa despesaSelecionada)
        {


            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.descricao;
            txtValor.Text = despesaSelecionada.valor.ToString();
            txtData.Value = despesaSelecionada.data;
            cbbFormaPgto.SelectedItem = despesaSelecionada.formaPgto;




        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Despesa despesa = ObterDespesa();

            string[] erros = despesa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
