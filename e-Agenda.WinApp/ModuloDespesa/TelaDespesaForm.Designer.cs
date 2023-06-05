namespace e_Agenda.WinApp.ModuloDespesa
{
    partial class TelaDespesaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtData = new DateTimePicker();
            cbbFormaPgto = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 118);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 27;
            label6.Text = "Forma de Pgto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 147);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 26;
            label5.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 94);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 24;
            label3.Text = "Data:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(105, 144);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(149, 23);
            txtValor.TabIndex = 23;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(102, 57);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(395, 23);
            txtDescricao.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 18;
            label2.Text = "Descrição:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 36);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(426, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(345, 180);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(104, 86);
            txtData.Name = "txtData";
            txtData.Size = new Size(149, 23);
            txtData.TabIndex = 28;
            // 
            // cbbFormaPgto
            // 
            cbbFormaPgto.FormattingEnabled = true;
            cbbFormaPgto.Location = new Point(104, 115);
            cbbFormaPgto.Name = "cbbFormaPgto";
            cbbFormaPgto.Size = new Size(150, 23);
            cbbFormaPgto.TabIndex = 29;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 233);
            Controls.Add(cbbFormaPgto);
            Controls.Add(txtData);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaDespesaForm";
            ShowIcon = false;
            Text = "Cadastro de Despesas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private DateTimePicker txtData;
        private ComboBox cbbFormaPgto;
    }
}