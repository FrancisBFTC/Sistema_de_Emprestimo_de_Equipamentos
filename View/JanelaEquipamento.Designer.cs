using System.Windows.Forms;

namespace AgendamentoView
{
    partial class JanelaEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaEquipamento));
            this.botaoEquipamento = new System.Windows.Forms.Button();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textEquipamento = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoEquipamento
            // 
            this.botaoEquipamento.AccessibleDescription = "Botão para cadastrar o equipamento";
            this.botaoEquipamento.AccessibleName = "BotãoDeCadastroEquipamento";
            this.botaoEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.botaoEquipamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEquipamento.BackgroundImage")));
            this.botaoEquipamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEquipamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEquipamento.FlatAppearance.BorderSize = 0;
            this.botaoEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEquipamento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.botaoEquipamento.Location = new System.Drawing.Point(308, 132);
            this.botaoEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.botaoEquipamento.Name = "botaoEquipamento";
            this.botaoEquipamento.Size = new System.Drawing.Size(130, 48);
            this.botaoEquipamento.TabIndex = 26;
            this.botaoEquipamento.Text = "Cadastrar";
            this.botaoEquipamento.UseVisualStyleBackColor = false;
            this.botaoEquipamento.Click += new System.EventHandler(this.BotaoEquipamento_Event);
            // 
            // textTipo
            // 
            this.textTipo.AccessibleDescription = "Campo de Texto para entrar com o tipo de equipamento";
            this.textTipo.AccessibleName = "CampoDeTipoEquipamento";
            this.textTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipo.Location = new System.Drawing.Point(149, 88);
            this.textTipo.Margin = new System.Windows.Forms.Padding(4);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(289, 25);
            this.textTipo.TabIndex = 24;
            // 
            // textEquipamento
            // 
            this.textEquipamento.AccessibleDescription = "Campo de Texto para nome do equipamento";
            this.textEquipamento.AccessibleName = "CampoDeEquipamento";
            this.textEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textEquipamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEquipamento.Location = new System.Drawing.Point(149, 45);
            this.textEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.textEquipamento.Name = "textEquipamento";
            this.textEquipamento.Size = new System.Drawing.Size(289, 25);
            this.textEquipamento.TabIndex = 23;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AccessibleDescription = "Texto de Label para quantidade desse equipamento";
            this.labelQuantidade.AccessibleName = "LabelDeQuantidade";
            this.labelQuantidade.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantidade.Location = new System.Drawing.Point(30, 132);
            this.labelQuantidade.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(103, 19);
            this.labelQuantidade.TabIndex = 22;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // labelTipo
            // 
            this.labelTipo.AccessibleDescription = "Texto de Label de Tipo de Equipamento";
            this.labelTipo.AccessibleName = "LabelDeTipoEquipamento";
            this.labelTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelTipo.AutoSize = true;
            this.labelTipo.BackColor = System.Drawing.Color.Transparent;
            this.labelTipo.Location = new System.Drawing.Point(30, 90);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(49, 19);
            this.labelTipo.TabIndex = 21;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AccessibleDescription = "Texto de Label de Equipamento";
            this.labelEquipamento.AccessibleName = "LabelDeEquipamento";
            this.labelEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipamento.Location = new System.Drawing.Point(30, 47);
            this.labelEquipamento.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(117, 19);
            this.labelEquipamento.TabIndex = 20;
            this.labelEquipamento.Text = "Equipamento:";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(149, 132);
            this.textQuantidade.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.textQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(106, 26);
            this.textQuantidade.TabIndex = 27;
            this.textQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JanelaEquipamento
            // 
            this.AccessibleDescription = "Janela para cadastro do equipamento";
            this.AccessibleName = "CadastroEquipamento";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 256);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.botaoEquipamento);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textEquipamento);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelEquipamento);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(501, 295);
            this.MinimumSize = new System.Drawing.Size(501, 295);
            this.Name = "JanelaEquipamento";
            this.Text = "Vencer Sempre - Cadastro do Equipamento";
            this.Load += new System.EventHandler(this.JanelaEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoEquipamento;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textEquipamento;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelEquipamento;
        private NumericUpDown textQuantidade;
    }
}