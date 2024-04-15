namespace AgendamentoView
{
    partial class JanelaDisponibilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaDisponibilidade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listaDisponibilidade = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "Caixa de grupos para Filtragem por Data";
            this.groupBox1.AccessibleName = "GrupoDeFiltragemData";
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.labelProfessor);
            this.groupBox1.Controls.Add(this.textData);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Data";
            // 
            // labelProfessor
            // 
            this.labelProfessor.AccessibleDescription = "Texto de Label Data";
            this.labelProfessor.AccessibleName = "LabelDeData";
            this.labelProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelProfessor.Location = new System.Drawing.Point(8, 28);
            this.labelProfessor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(50, 19);
            this.labelProfessor.TabIndex = 1;
            this.labelProfessor.Text = "Data:";
            // 
            // textData
            // 
            this.textData.AccessibleDescription = "Campo de texto para entrar com a data de filtragem";
            this.textData.AccessibleName = "CampoDeDataFiltragem";
            this.textData.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textData.Location = new System.Drawing.Point(69, 25);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(161, 25);
            this.textData.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "Caixa de grupo para filtragem por horário";
            this.groupBox2.AccessibleName = "GrupoDeFiltragemHorário";
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.textHora);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por Horário";
            // 
            // textHora
            // 
            this.textHora.AccessibleDescription = "Campo de Texto para entrar com a hora de filtragem";
            this.textHora.AccessibleName = "CampoDeHoraFiltragem";
            this.textHora.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textHora.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHora.Location = new System.Drawing.Point(68, 25);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(142, 25);
            this.textHora.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Texto de Label Hora";
            this.label1.AccessibleName = "LabelDeHora";
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora:";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = "Caixa de grupo para a lista de dias disponíveis";
            this.groupBox3.AccessibleName = "GrupoDeListaDisponíveis";
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.listaDisponibilidade);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 212);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Dias Disponíveis";
            // 
            // listaDisponibilidade
            // 
            this.listaDisponibilidade.AccessibleDescription = "Caixa de listagem para listar os dias disponíveis";
            this.listaDisponibilidade.AccessibleName = "CaixaListagemDisponíveis";
            this.listaDisponibilidade.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listaDisponibilidade.BackColor = System.Drawing.Color.Azure;
            this.listaDisponibilidade.FormattingEnabled = true;
            this.listaDisponibilidade.ItemHeight = 20;
            this.listaDisponibilidade.Location = new System.Drawing.Point(7, 23);
            this.listaDisponibilidade.Name = "listaDisponibilidade";
            this.listaDisponibilidade.Size = new System.Drawing.Size(446, 184);
            this.listaDisponibilidade.TabIndex = 1;

            // 
            // JanelaDisponibilidade
            // 
            this.AccessibleDescription = "Janela para listar dias disponíveis para Empréstimos";
            this.AccessibleName = "JanelaDeDisponibilidade";
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
            this.Name = "JanelaDisponibilidade";
            this.Text = "Vencer Sempre - Listar Dias Para Empréstimo";
            this.Load += new System.EventHandler(this.JanelaDisponibilidade_Load);
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
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listaDisponibilidade;
    }
}