using System;
using System.Windows.Forms;

namespace AgendamentoView
{
    partial class JanelaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaAgendamento));
            this.labelProfessor = new System.Windows.Forms.Label();
            this.labelEquipamento = new System.Windows.Forms.Label();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.labelHoraInicial = new System.Windows.Forms.Label();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.labelHoraFinal = new System.Windows.Forms.Label();
            this.textProfessor = new System.Windows.Forms.TextBox();
            this.textEquipamento = new System.Windows.Forms.TextBox();
            this.textDataInicial = new System.Windows.Forms.TextBox();
            this.textHoraInicial = new System.Windows.Forms.TextBox();
            this.textDataFinal = new System.Windows.Forms.TextBox();
            this.textHoraFinal = new System.Windows.Forms.TextBox();
            this.botaoAgendar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProfessor
            // 
            this.labelProfessor.AccessibleDescription = "Texto de Label de Professor";
            this.labelProfessor.AccessibleName = "LabelDeProfessor";
            this.labelProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.BackColor = System.Drawing.Color.Transparent;
            this.labelProfessor.Location = new System.Drawing.Point(34, 44);
            this.labelProfessor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(90, 19);
            this.labelProfessor.TabIndex = 0;
            this.labelProfessor.Text = "Professor:";
            // 
            // labelEquipamento
            // 
            this.labelEquipamento.AccessibleDescription = "Texto de Label de Equipamento";
            this.labelEquipamento.AccessibleName = "LabelDeEquipamento";
            this.labelEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelEquipamento.AutoSize = true;
            this.labelEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipamento.Location = new System.Drawing.Point(34, 82);
            this.labelEquipamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEquipamento.Name = "labelEquipamento";
            this.labelEquipamento.Size = new System.Drawing.Size(117, 19);
            this.labelEquipamento.TabIndex = 1;
            this.labelEquipamento.Text = "Equipamento:";
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AccessibleDescription = "Texto de Label para Data Inicial";
            this.labelDataInicial.AccessibleName = "LabelDeDataInicial";
            this.labelDataInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInicial.Location = new System.Drawing.Point(34, 120);
            this.labelDataInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(98, 19);
            this.labelDataInicial.TabIndex = 2;
            this.labelDataInicial.Text = "Data Inicial:";
            // 
            // labelHoraInicial
            // 
            this.labelHoraInicial.AccessibleDescription = "Texto de Label para Hora Inicial";
            this.labelHoraInicial.AccessibleName = "LabelDeHoraInicial";
            this.labelHoraInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelHoraInicial.AutoSize = true;
            this.labelHoraInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelHoraInicial.Location = new System.Drawing.Point(272, 120);
            this.labelHoraInicial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoraInicial.Name = "labelHoraInicial";
            this.labelHoraInicial.Size = new System.Drawing.Size(100, 19);
            this.labelHoraInicial.TabIndex = 3;
            this.labelHoraInicial.Text = "Hora Inicial:";
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AccessibleDescription = "Texto de Label para Data Final";
            this.labelDataFinal.AccessibleName = "LabelDeDataFinal";
            this.labelDataFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFinal.Location = new System.Drawing.Point(34, 156);
            this.labelDataFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(91, 19);
            this.labelDataFinal.TabIndex = 4;
            this.labelDataFinal.Text = "Data Final:";
            // 
            // labelHoraFinal
            // 
            this.labelHoraFinal.AccessibleDescription = "Texto de Label para Hora Final";
            this.labelHoraFinal.AccessibleName = "LabelDeHoraFinal";
            this.labelHoraFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelHoraFinal.AutoSize = true;
            this.labelHoraFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelHoraFinal.Location = new System.Drawing.Point(272, 156);
            this.labelHoraFinal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoraFinal.Name = "labelHoraFinal";
            this.labelHoraFinal.Size = new System.Drawing.Size(93, 19);
            this.labelHoraFinal.TabIndex = 5;
            this.labelHoraFinal.Text = "Hora Final:";
            // 
            // textProfessor
            // 
            this.textProfessor.AccessibleDescription = "Campo de Texto para entrar com o nome do professor";
            this.textProfessor.AccessibleName = "CampoDeProfessor";
            this.textProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textProfessor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfessor.Location = new System.Drawing.Point(153, 41);
            this.textProfessor.Name = "textProfessor";
            this.textProfessor.Size = new System.Drawing.Size(299, 25);
            this.textProfessor.TabIndex = 6;
            // 
            // textEquipamento
            // 
            this.textEquipamento.AccessibleDescription = "Campo de Texto para Entrar com o nome do equipamento";
            this.textEquipamento.AccessibleName = "CampoDeEquipamento";
            this.textEquipamento.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textEquipamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEquipamento.Location = new System.Drawing.Point(153, 79);
            this.textEquipamento.Name = "textEquipamento";
            this.textEquipamento.Size = new System.Drawing.Size(299, 25);
            this.textEquipamento.TabIndex = 7;
            // 
            // textDataInicial
            // 
            this.textDataInicial.AccessibleDescription = "Campo de texto para entrar com a data inicial";
            this.textDataInicial.AccessibleName = "CampoDeDataInicial";
            this.textDataInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textDataInicial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataInicial.Location = new System.Drawing.Point(153, 117);
            this.textDataInicial.MaxLength = 10;
            this.textDataInicial.Name = "textDataInicial";
            this.textDataInicial.Size = new System.Drawing.Size(103, 25);
            this.textDataInicial.TabIndex = 8;
            this.textDataInicial.TextChanged += new System.EventHandler(this.TextDataInicial_TextChanged);
            // 
            // textHoraInicial
            // 
            this.textHoraInicial.AccessibleDescription = "Campo de texto para entrar com a hora inicial";
            this.textHoraInicial.AccessibleName = "CampoDeHoraInicial";
            this.textHoraInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textHoraInicial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraInicial.Location = new System.Drawing.Point(380, 117);
            this.textHoraInicial.MaxLength = 8;
            this.textHoraInicial.Name = "textHoraInicial";
            this.textHoraInicial.Size = new System.Drawing.Size(72, 25);
            this.textHoraInicial.TabIndex = 9;
            this.textHoraInicial.TextChanged += new System.EventHandler(this.TextHoraInicial_TextChanged);
            // 
            // textDataFinal
            // 
            this.textDataFinal.AccessibleDescription = "Campo de texto para entrar com a data final";
            this.textDataFinal.AccessibleName = "CampoDeDataFinal";
            this.textDataFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textDataFinal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataFinal.Location = new System.Drawing.Point(153, 153);
            this.textDataFinal.MaxLength = 10;
            this.textDataFinal.Name = "textDataFinal";
            this.textDataFinal.Size = new System.Drawing.Size(103, 25);
            this.textDataFinal.TabIndex = 10;
            this.textDataFinal.TextChanged += new System.EventHandler(this.TextDataFinal_TextChanged);
            // 
            // textHoraFinal
            // 
            this.textHoraFinal.AccessibleDescription = "Campo de texto para entrar com a hora final";
            this.textHoraFinal.AccessibleName = "CampoDeHoraFinal";
            this.textHoraFinal.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textHoraFinal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraFinal.Location = new System.Drawing.Point(380, 153);
            this.textHoraFinal.MaxLength = 8;
            this.textHoraFinal.Name = "textHoraFinal";
            this.textHoraFinal.Size = new System.Drawing.Size(72, 25);
            this.textHoraFinal.TabIndex = 11;
            this.textHoraFinal.TextChanged += new System.EventHandler(this.TextHoraFinal_TextChanged);
            // 
            // botaoAgendar
            // 
            this.botaoAgendar.AccessibleDescription = "Botão para Agendar o Empréstimo";
            this.botaoAgendar.AccessibleName = "BotãoDeAgendamento";
            this.botaoAgendar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.botaoAgendar.BackColor = System.Drawing.Color.Transparent;
            this.botaoAgendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAgendar.BackgroundImage")));
            this.botaoAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAgendar.FlatAppearance.BorderSize = 0;
            this.botaoAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAgendar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.botaoAgendar.Location = new System.Drawing.Point(320, 198);
            this.botaoAgendar.Name = "botaoAgendar";
            this.botaoAgendar.Size = new System.Drawing.Size(132, 33);
            this.botaoAgendar.TabIndex = 12;
            this.botaoAgendar.Text = "Agendar";
            this.botaoAgendar.UseVisualStyleBackColor = false;
            this.botaoAgendar.Click += new System.EventHandler(this.BotaoAgendar_Event);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Controls.Add(this.botaoAgendar);
            this.pictureBox1.Controls.Add(this.textHoraFinal);
            this.pictureBox1.Controls.Add(this.textDataFinal);
            this.pictureBox1.Controls.Add(this.textHoraInicial);
            this.pictureBox1.Controls.Add(this.textDataInicial);
            this.pictureBox1.Controls.Add(this.textEquipamento);
            this.pictureBox1.Controls.Add(this.textProfessor);
            this.pictureBox1.Controls.Add(this.labelHoraFinal);
            this.pictureBox1.Controls.Add(this.labelDataFinal);
            this.pictureBox1.Controls.Add(this.labelHoraInicial);
            this.pictureBox1.Controls.Add(this.labelDataInicial);
            this.pictureBox1.Controls.Add(this.labelEquipamento);
            this.pictureBox1.Controls.Add(this.labelProfessor);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // JanelaAgendamento
            // 
            this.AccessibleDescription = "Janela de Agendamento de Empréstimos";
            this.AccessibleName = "JanelaDeAgendamento";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(485, 256);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 295);
            this.MinimumSize = new System.Drawing.Size(501, 295);
            this.Name = "JanelaAgendamento";
            this.Text = "Vencer Sempre - Agendar Empréstimo";
            this.Load += new System.EventHandler(this.JanelaAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            this.pictureBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.Label labelEquipamento;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.Label labelHoraInicial;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.Label labelHoraFinal;
        private System.Windows.Forms.TextBox textProfessor;
        private System.Windows.Forms.TextBox textEquipamento;
        private System.Windows.Forms.TextBox textDataInicial;
        private System.Windows.Forms.TextBox textHoraInicial;
        private System.Windows.Forms.TextBox textDataFinal;
        private System.Windows.Forms.TextBox textHoraFinal;
        private System.Windows.Forms.Button botaoAgendar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}