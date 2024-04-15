using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace AgendamentoView
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.grupoAgendamento = new System.Windows.Forms.GroupBox();
            this.botaoListar = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoCriar = new System.Windows.Forms.Button();
            this.grupoDisponibilidade = new System.Windows.Forms.GroupBox();
            this.botaoEntregues = new System.Windows.Forms.Button();
            this.botaoDias = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoRegEquipamento = new System.Windows.Forms.Button();
            this.botaoRegProfessor = new System.Windows.Forms.Button();
            this.grupoAgendamento.SuspendLayout();
            this.grupoDisponibilidade.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoAgendamento
            // 
            this.grupoAgendamento.AccessibleDescription = "Caixa de grupo de botões para agendamentos";
            this.grupoAgendamento.AccessibleName = "GrupoDeAgendamentos";
            this.grupoAgendamento.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grupoAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.grupoAgendamento.Controls.Add(this.botaoListar);
            this.grupoAgendamento.Controls.Add(this.botaoFechar);
            this.grupoAgendamento.Controls.Add(this.botaoCancelar);
            this.grupoAgendamento.Controls.Add(this.botaoCriar);
            this.grupoAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupoAgendamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAgendamento.ForeColor = System.Drawing.Color.MediumBlue;
            this.grupoAgendamento.Location = new System.Drawing.Point(12, 12);
            this.grupoAgendamento.Name = "grupoAgendamento";
            this.grupoAgendamento.Size = new System.Drawing.Size(378, 352);
            this.grupoAgendamento.TabIndex = 0;
            this.grupoAgendamento.TabStop = false;
            this.grupoAgendamento.Text = "Agendamentos";
            // 
            // botaoListar
            // 
            this.botaoListar.AccessibleDescription = "Botão para Listar Agendamentos de Empréstimos";
            this.botaoListar.AccessibleName = "BotãoListarAgendamento";
            this.botaoListar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoListar.BackColor = System.Drawing.Color.Transparent;
            this.botaoListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoListar.BackgroundImage")));
            this.botaoListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoListar.FlatAppearance.BorderSize = 0;
            this.botaoListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoListar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoListar.Location = new System.Drawing.Point(88, 262);
            this.botaoListar.Name = "botaoListar";
            this.botaoListar.Size = new System.Drawing.Size(189, 58);
            this.botaoListar.TabIndex = 3;
            this.botaoListar.Text = "Listar Agendamento";
            this.botaoListar.UseVisualStyleBackColor = false;
            this.botaoListar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoListar_Event);
            // 
            // botaoFechar
            // 
            this.botaoFechar.AccessibleDescription = "Botão para fechar ou dar baixa no agendamento de empréstimo";
            this.botaoFechar.AccessibleName = "BotãoFecharAgendamento";
            this.botaoFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoFechar.BackColor = System.Drawing.Color.Transparent;
            this.botaoFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFechar.BackgroundImage")));
            this.botaoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoFechar.Location = new System.Drawing.Point(88, 187);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(189, 59);
            this.botaoFechar.TabIndex = 2;
            this.botaoFechar.Text = "Fechar Agendamento";
            this.botaoFechar.UseVisualStyleBackColor = false;
            this.botaoFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoFechar_Event);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.AccessibleDescription = "Botão para Cancelar Agendamento de Empréstimo";
            this.botaoCancelar.AccessibleName = "BotãoCancelarAgendamento";
            this.botaoCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoCancelar.BackColor = System.Drawing.Color.Transparent;
            this.botaoCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.BackgroundImage")));
            this.botaoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatAppearance.BorderSize = 0;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCancelar.Location = new System.Drawing.Point(88, 113);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(189, 59);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Cancelar Agendamento";
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoCancelar_Event);
            // 
            // botaoCriar
            // 
            this.botaoCriar.AccessibleDescription = "Botão para Criar Agendamento de Empréstimo";
            this.botaoCriar.AccessibleName = "BotãoCriarAgendamento";
            this.botaoCriar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoCriar.BackColor = System.Drawing.Color.Transparent;
            this.botaoCriar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCriar.BackgroundImage")));
            this.botaoCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCriar.FlatAppearance.BorderSize = 0;
            this.botaoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCriar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCriar.Location = new System.Drawing.Point(88, 38);
            this.botaoCriar.Name = "botaoCriar";
            this.botaoCriar.Size = new System.Drawing.Size(189, 60);
            this.botaoCriar.TabIndex = 0;
            this.botaoCriar.Text = "Criar Agendamento";
            this.botaoCriar.UseVisualStyleBackColor = false;
            this.botaoCriar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoCriar_Event);
            // 
            // grupoDisponibilidade
            // 
            this.grupoDisponibilidade.AccessibleDescription = "Caixa de grupo de botões para Disponibilidade dos dados";
            this.grupoDisponibilidade.AccessibleName = "GrupoDeDisponibilidades";
            this.grupoDisponibilidade.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grupoDisponibilidade.BackColor = System.Drawing.Color.Transparent;
            this.grupoDisponibilidade.Controls.Add(this.botaoEntregues);
            this.grupoDisponibilidade.Controls.Add(this.botaoDias);
            this.grupoDisponibilidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDisponibilidade.ForeColor = System.Drawing.Color.MediumBlue;
            this.grupoDisponibilidade.Location = new System.Drawing.Point(410, 12);
            this.grupoDisponibilidade.Name = "grupoDisponibilidade";
            this.grupoDisponibilidade.Size = new System.Drawing.Size(378, 185);
            this.grupoDisponibilidade.TabIndex = 1;
            this.grupoDisponibilidade.TabStop = false;
            this.grupoDisponibilidade.Text = "Disponibilidades";
            // 
            // botaoEntregues
            // 
            this.botaoEntregues.AccessibleDescription = "Botão para listar equipamentos entregues/fechados";
            this.botaoEntregues.AccessibleName = "BotãoEquipamentosEntregues";
            this.botaoEntregues.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoEntregues.BackColor = System.Drawing.Color.Transparent;
            this.botaoEntregues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEntregues.BackgroundImage")));
            this.botaoEntregues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoEntregues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEntregues.FlatAppearance.BorderSize = 0;
            this.botaoEntregues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntregues.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoEntregues.Location = new System.Drawing.Point(98, 113);
            this.botaoEntregues.Name = "botaoEntregues";
            this.botaoEntregues.Size = new System.Drawing.Size(183, 59);
            this.botaoEntregues.TabIndex = 3;
            this.botaoEntregues.Text = "Equipamentos Entregues";
            this.botaoEntregues.UseVisualStyleBackColor = false;
            this.botaoEntregues.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoEntregues_Event);
            // 
            // botaoDias
            // 
            this.botaoDias.AccessibleDescription = "Botão para listar dias disponíveis para agendamento de empréstimo";
            this.botaoDias.AccessibleName = "BotãoListarDiasDisponíveis";
            this.botaoDias.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoDias.BackColor = System.Drawing.Color.Transparent;
            this.botaoDias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoDias.BackgroundImage")));
            this.botaoDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDias.FlatAppearance.BorderSize = 0;
            this.botaoDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDias.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoDias.Location = new System.Drawing.Point(98, 38);
            this.botaoDias.Name = "botaoDias";
            this.botaoDias.Size = new System.Drawing.Size(183, 59);
            this.botaoDias.TabIndex = 2;
            this.botaoDias.Text = "Listar Dias Disponíveis";
            this.botaoDias.UseVisualStyleBackColor = false;
            this.botaoDias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoDias_Event);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Caixa de grupo de botões para Disponibilidade dos dados";
            this.groupBox1.AccessibleName = "GrupoDeDisponibilidades";
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.botaoRegEquipamento);
            this.groupBox1.Controls.Add(this.botaoRegProfessor);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(410, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros";
            // 
            // botaoRegEquipamento
            // 
            this.botaoRegEquipamento.AccessibleDescription = "Botão para cadastrar equipamentos audiovisuais";
            this.botaoRegEquipamento.AccessibleName = "BotãoCadastroEquipamentos";
            this.botaoRegEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoRegEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.botaoRegEquipamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRegEquipamento.BackgroundImage")));
            this.botaoRegEquipamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRegEquipamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRegEquipamento.FlatAppearance.BorderSize = 0;
            this.botaoRegEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRegEquipamento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoRegEquipamento.Location = new System.Drawing.Point(98, 96);
            this.botaoRegEquipamento.Name = "botaoRegEquipamento";
            this.botaoRegEquipamento.Size = new System.Drawing.Size(183, 59);
            this.botaoRegEquipamento.TabIndex = 3;
            this.botaoRegEquipamento.Text = "Cadastrar Equipamentos";
            this.botaoRegEquipamento.UseVisualStyleBackColor = false;
            this.botaoRegEquipamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoRegEquipamento_Event);
            // 
            // botaoRegProfessor
            // 
            this.botaoRegProfessor.AccessibleDescription = "Botão para cadastrar professores no sistema";
            this.botaoRegProfessor.AccessibleName = "BotãoCadastroProfessores";
            this.botaoRegProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoRegProfessor.BackColor = System.Drawing.Color.Transparent;
            this.botaoRegProfessor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRegProfessor.BackgroundImage")));
            this.botaoRegProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRegProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRegProfessor.FlatAppearance.BorderSize = 0;
            this.botaoRegProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRegProfessor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoRegProfessor.Location = new System.Drawing.Point(98, 25);
            this.botaoRegProfessor.Name = "botaoRegProfessor";
            this.botaoRegProfessor.Size = new System.Drawing.Size(183, 59);
            this.botaoRegProfessor.TabIndex = 2;
            this.botaoRegProfessor.Text = "Cadastrar Professores";
            this.botaoRegProfessor.UseVisualStyleBackColor = false;
            this.botaoRegProfessor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoRegProfessor_Event);
            // 
            // JanelaPrincipal
            // 
            this.AccessibleDescription = "Janela principal do sistema de agendamento";
            this.AccessibleName = "JanelaSistemaPrincipal";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoDisponibilidade);
            this.Controls.Add(this.grupoAgendamento);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 415);
            this.MinimumSize = new System.Drawing.Size(816, 415);
            this.Name = "JanelaPrincipal";
            this.Text = "Vencer Sempre - Sistema de Agendamento - Início";
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.grupoAgendamento.ResumeLayout(false);
            this.grupoDisponibilidade.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grupoAgendamento;
        private GroupBox grupoDisponibilidade;
        private Button botaoCriar;
        private Button botaoCancelar;
        private Button botaoFechar;
        private Button botaoListar;
        private Button botaoDias;
        private Button botaoEntregues;
        private GroupBox groupBox1;
        private Button botaoRegEquipamento;
        private Button botaoRegProfessor;
    }
}

