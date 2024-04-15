namespace AgendamentoView
{
    partial class JanelaFechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaFechamento));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEquipamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.textProfessor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listaFechamento = new System.Windows.Forms.ListBox();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "Caixa de grupo para filtragem por item";
            this.groupBox2.AccessibleName = "GrupoFiltragemItem";
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox2.Controls.Add(this.textEquipamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por Item";
            // 
            // textEquipamento
            // 
            this.textEquipamento.AccessibleDescription = "Campo de texto para inserir item do equipamento";
            this.textEquipamento.AccessibleName = "CampoTextoItem";
            this.textEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textEquipamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEquipamento.Location = new System.Drawing.Point(55, 25);
            this.textEquipamento.Name = "textEquipamento";
            this.textEquipamento.Size = new System.Drawing.Size(155, 25);
            this.textEquipamento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Texto de label para Item";
            this.label1.AccessibleName = "LabelDeItem";
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item:";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Caixa de grupo para filtragem por nome";
            this.groupBox1.AccessibleName = "GrupoFiltragemNome";
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.labelProfessor);
            this.groupBox1.Controls.Add(this.textProfessor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Nome";
            // 
            // labelProfessor
            // 
            this.labelProfessor.AccessibleDescription = "Texto de label para Nome";
            this.labelProfessor.AccessibleName = "LabelDeNome";
            this.labelProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelProfessor.Location = new System.Drawing.Point(8, 28);
            this.labelProfessor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(60, 19);
            this.labelProfessor.TabIndex = 1;
            this.labelProfessor.Text = "Nome:";
            // 
            // textProfessor
            // 
            this.textProfessor.AccessibleDescription = "Campo de texto para inserir nome do professor";
            this.textProfessor.AccessibleName = "CampoTextoNome";
            this.textProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textProfessor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfessor.Location = new System.Drawing.Point(69, 25);
            this.textProfessor.Name = "textProfessor";
            this.textProfessor.Size = new System.Drawing.Size(161, 25);
            this.textProfessor.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = "Caixa de grupo para agendamentos encontrados";
            this.groupBox3.AccessibleName = "GrupoAgendamentoEncontrados";
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.listaFechamento);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 212);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agendamentos Encontrados";
            // 
            // listaFechamento
            // 
            this.listaFechamento.AccessibleDescription = "Caixa de listagem para listar itens a fechar";
            this.listaFechamento.AccessibleName = "CaixaListagemItemFechar";
            this.listaFechamento.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listaFechamento.BackColor = System.Drawing.Color.Azure;
            this.listaFechamento.FormattingEnabled = true;
            this.listaFechamento.ItemHeight = 20;
            this.listaFechamento.Location = new System.Drawing.Point(7, 23);
            this.listaFechamento.Name = "listaFechamento";
            this.listaFechamento.Size = new System.Drawing.Size(446, 144);
            this.listaFechamento.TabIndex = 1;
            // 
            // botaoFechar
            // 
            this.botaoFechar.AccessibleDescription = "Botão para Fechar o Empréstimo";
            this.botaoFechar.AccessibleName = "BotãoDeFechamento";
            this.botaoFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoFechar.BackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFechar.BackgroundImage")));
            this.botaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFechar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.botaoFechar.Location = new System.Drawing.Point(332, 261);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(132, 33);
            this.botaoFechar.TabIndex = 15;
            this.botaoFechar.Text = "Fechar";
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.Click += new System.EventHandler(this.BotaoFechar_ClickEvent);
            // 
            // JanelaFechamento
            // 
            this.AccessibleDescription = "Janela para fechar agendamentos/Dar Baixa no sistema";
            this.AccessibleName = "JanelaDeFechamento";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 301);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(501, 340);
            this.MinimumSize = new System.Drawing.Size(501, 340);
            this.Name = "JanelaFechamento";
            this.Text = "Vencer Sempre - Fechar/Baixa de Empréstimos";
            this.Load += new System.EventHandler(this.JanelaFechamento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.TextBox textProfessor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listaFechamento;
        private System.Windows.Forms.Button botaoFechar;
    }
}