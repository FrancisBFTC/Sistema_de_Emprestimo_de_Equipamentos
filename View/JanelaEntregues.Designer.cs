namespace AgendamentoView
{
    partial class JanelaEntregues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaEntregues));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.textProfessor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEquipamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listaEntregues = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Caixa de grupo para filtragem por nome";
            this.groupBox1.AccessibleName = "GrupoFiltragemNomeEntregues";
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Controls.Add(this.labelProfessor);
            this.groupBox1.Controls.Add(this.textProfessor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Nome";
            // 
            // labelProfessor
            // 
            this.labelProfessor.AccessibleDescription = "Texto de label para Nome do Professor";
            this.labelProfessor.AccessibleName = "LabelDeNomeProfessor";
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
            this.textProfessor.AccessibleDescription = "Campo de texto para entrar com o nome do professor";
            this.textProfessor.AccessibleName = "CampoTextoNomeProfessor";
            this.textProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textProfessor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfessor.Location = new System.Drawing.Point(69, 25);
            this.textProfessor.Name = "textProfessor";
            this.textProfessor.Size = new System.Drawing.Size(161, 25);
            this.textProfessor.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "Caixa de grupo para filtragem por item";
            this.groupBox2.AccessibleName = "GrupoFiltragemItemEntregues";
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox2.Controls.Add(this.textEquipamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por Item";
            // 
            // textEquipamento
            // 
            this.textEquipamento.AccessibleDescription = "Campo de texto para entrar com o Item do Equipamento";
            this.textEquipamento.AccessibleName = "CampoTextoItemEquipamento";
            this.textEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textEquipamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEquipamento.Location = new System.Drawing.Point(55, 25);
            this.textEquipamento.Name = "textEquipamento";
            this.textEquipamento.Size = new System.Drawing.Size(155, 25);
            this.textEquipamento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Texto de Label para Nome do Equipamento";
            this.label1.AccessibleName = "LabelDeEquipamento";
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
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = "Caixa de grupo para listagem de equipamentos";
            this.groupBox3.AccessibleName = "GrupoListagemEquipamentos";
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.listaEntregues);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 211);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Equipamentos Entregues";
            // 
            // listaEntregues
            // 
            this.listaEntregues.AccessibleDescription = "Caixa de listagem para listar equipamentos entregues";
            this.listaEntregues.AccessibleName = "CaixaListagemEntregues";
            this.listaEntregues.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listaEntregues.BackColor = System.Drawing.Color.Azure;
            this.listaEntregues.FormattingEnabled = true;
            this.listaEntregues.ItemHeight = 20;
            this.listaEntregues.Location = new System.Drawing.Point(12, 25);
            this.listaEntregues.MultiColumn = true;
            this.listaEntregues.Name = "listaEntregues";
            this.listaEntregues.Size = new System.Drawing.Size(440, 184);
            this.listaEntregues.TabIndex = 0;
            // 
            // JanelaEntregues
            // 
            this.AccessibleDescription = "Janela para listar equipamentos entregues";
            this.AccessibleName = "JanelaEquipamentosEntregues";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 301);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(501, 340);
            this.MinimumSize = new System.Drawing.Size(501, 340);
            this.Name = "JanelaEntregues";
            this.Text = "Vencer Sempre - Listar Equipamentos Entregues";
            this.Load += new System.EventHandler(this.JanelaEntregues_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.TextBox textProfessor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textEquipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listaEntregues;
    }
}