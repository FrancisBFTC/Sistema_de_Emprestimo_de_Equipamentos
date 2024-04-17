using System.Windows.Forms;

namespace AgendamentoView
{
    partial class JanelaProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaProfessor));
            this.botaoProfessor = new System.Windows.Forms.Button();
            this.textTurmas = new System.Windows.Forms.TextBox();
            this.textDisciplina = new System.Windows.Forms.TextBox();
            this.textProfessor = new System.Windows.Forms.TextBox();
            this.labelTurmas = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoProfessor
            // 
            this.botaoProfessor.AccessibleDescription = "Botão para Cadastrar o professor";
            this.botaoProfessor.AccessibleName = "BotãoDeCadastroProfessor";
            this.botaoProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoProfessor.BackColor = System.Drawing.Color.Transparent;
            this.botaoProfessor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoProfessor.BackgroundImage")));
            this.botaoProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoProfessor.FlatAppearance.BorderSize = 0;
            this.botaoProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProfessor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.botaoProfessor.Location = new System.Drawing.Point(291, 182);
            this.botaoProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.botaoProfessor.Name = "botaoProfessor";
            this.botaoProfessor.Size = new System.Drawing.Size(130, 48);
            this.botaoProfessor.TabIndex = 19;
            this.botaoProfessor.Text = "Cadastrar";
            this.botaoProfessor.UseVisualStyleBackColor = false;
            this.botaoProfessor.Click += new System.EventHandler(this.BotaoProfessor_Event);
            // 
            // textTurmas
            // 
            this.textTurmas.AccessibleDescription = "Campo de texto para turmas do professor";
            this.textTurmas.AccessibleName = "CampoDeTurmas";
            this.textTurmas.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textTurmas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurmas.Location = new System.Drawing.Point(132, 130);
            this.textTurmas.Margin = new System.Windows.Forms.Padding(4);
            this.textTurmas.MaxLength = 100;
            this.textTurmas.Name = "textTurmas";
            this.textTurmas.Size = new System.Drawing.Size(289, 25);
            this.textTurmas.TabIndex = 18;
            // 
            // textDisciplina
            // 
            this.textDisciplina.AccessibleDescription = "Campo de Texto para Entrar com a disciplina do professor";
            this.textDisciplina.AccessibleName = "CampoDeDisciplina";
            this.textDisciplina.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textDisciplina.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisciplina.Location = new System.Drawing.Point(132, 88);
            this.textDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.textDisciplina.Name = "textDisciplina";
            this.textDisciplina.Size = new System.Drawing.Size(289, 25);
            this.textDisciplina.TabIndex = 17;
            // 
            // textProfessor
            // 
            this.textProfessor.AccessibleDescription = "Campo de Texto para entrar com o nome do professor";
            this.textProfessor.AccessibleName = "CampoDeProfessor";
            this.textProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textProfessor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfessor.Location = new System.Drawing.Point(132, 45);
            this.textProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.textProfessor.Name = "textProfessor";
            this.textProfessor.Size = new System.Drawing.Size(289, 25);
            this.textProfessor.TabIndex = 16;
            // 
            // labelTurmas
            // 
            this.labelTurmas.AccessibleDescription = "Texto de Label das turmas do professor";
            this.labelTurmas.AccessibleName = "LabelDeTurmas";
            this.labelTurmas.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelTurmas.AutoSize = true;
            this.labelTurmas.BackColor = System.Drawing.Color.Transparent;
            this.labelTurmas.Location = new System.Drawing.Point(30, 132);
            this.labelTurmas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTurmas.Name = "labelTurmas";
            this.labelTurmas.Size = new System.Drawing.Size(72, 19);
            this.labelTurmas.TabIndex = 15;
            this.labelTurmas.Text = "Turmas:";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AccessibleDescription = "Texto de Label da Disciplina do professor";
            this.labelDisciplina.AccessibleName = "LabelDeDisciplina";
            this.labelDisciplina.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.BackColor = System.Drawing.Color.Transparent;
            this.labelDisciplina.Location = new System.Drawing.Point(30, 90);
            this.labelDisciplina.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(90, 19);
            this.labelDisciplina.TabIndex = 14;
            this.labelDisciplina.Text = "Disciplina:";
            // 
            // labelProfessor
            // 
            this.labelProfessor.AccessibleDescription = "Texto de Label de Professor";
            this.labelProfessor.AccessibleName = "LabelDeProfessor";
            this.labelProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.BackColor = System.Drawing.Color.Transparent;
            this.labelProfessor.Location = new System.Drawing.Point(30, 47);
            this.labelProfessor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(90, 19);
            this.labelProfessor.TabIndex = 13;
            this.labelProfessor.Text = "Professor:";
            // 
            // JanelaProfessor
            // 
            this.AccessibleDescription = "Janela para cadastro do professor";
            this.AccessibleName = "CadastroProfessor";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 256);
            this.Controls.Add(this.botaoProfessor);
            this.Controls.Add(this.textTurmas);
            this.Controls.Add(this.textDisciplina);
            this.Controls.Add(this.textProfessor);
            this.Controls.Add(this.labelTurmas);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelProfessor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 295);
            this.MinimumSize = new System.Drawing.Size(501, 295);
            this.Name = "JanelaProfessor";
            this.Text = "Vencer Sempre - Cadastro do Professor";
            this.Load += new System.EventHandler(this.JanelaProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoProfessor;
        private System.Windows.Forms.TextBox textTurmas;
        private System.Windows.Forms.TextBox textDisciplina;
        private System.Windows.Forms.TextBox textProfessor;
        private System.Windows.Forms.Label labelTurmas;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelProfessor;
    }
}