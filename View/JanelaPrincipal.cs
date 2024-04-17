using SistemaEmprestimo.Controller;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AgendamentoView
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            this.botaoCriar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoCriar, 30);
            this.botaoCancelar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoCancelar, 30);
            this.botaoFechar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoFechar, 30);
            this.botaoListar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoListar, 30);
            this.botaoDias.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoDias, 30);
            this.botaoEntregues.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoEntregues, 30);
            this.botaoRegProfessor.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoRegProfessor, 30);
            this.botaoRegEquipamento.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoRegEquipamento, 30);

            Agendamento.AtribuirDisponibilidade();
        }

        /// <summary>
        /// Evento de click do mouse para botão agendar empréstimos
        /// Este método abre um nova janela de formulário para agendamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoCriar_Event(object sender, EventArgs e)
        {
            new JanelaAgendamento().Show();
        }

        /// <summary>
        /// Evento de click do mouse para Cancelar Empréstimos.
        /// Este método abre uma nova janela para cancelamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoCancelar_Event(object sender, EventArgs e)
        {
            new JanelaCancelamento().Show();
        }

        /// <summary>
        /// Evento de click de mouse para fechar agendamentos.
        /// Este método chama a janela para fechamentos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoFechar_Event(object sender, EventArgs e)
        {
            new JanelaFechamento().Show();
        }

        /// <summary>
        /// Evento de click de mouse para listar agendamentos.
        /// Este método chama a janela de listagem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoListar_Event(object sender, EventArgs e)
        {
            new JanelaListagem().Show();
        }

        /// <summary>
        /// Evento de click de mouse para listagem de dias disponíveis.
        /// Este método exibe a janela de listagem destes dias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoDias_Event(object sender, EventArgs e)
        {
            new JanelaDisponibilidade().Show();
        }

        /// <summary>
        /// Evento de click de mouse para listar entregas.
        /// Este método chama a janela de listagem de entregas fechadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoEntregues_Event(object sender, EventArgs e)
        {
            new JanelaEntregues().Show();
        }

        private void BotaoRegEquipamento_Event(object sender, MouseEventArgs e)
        {
            new JanelaEquipamento().Show();
        }

        private void BotaoRegProfessor_Event(object sender, MouseEventArgs e)
        {
            new JanelaProfessor().Show();
        }

    }


    public static class CustomControlExtensions
    {
        public static void RoundBorder(this Control control, int radius = 10)
        {
            control.Paint += (o, e) => OnPaint(control, e, radius);
        }

        public static void SetColor(this Control control, Color bc, Color bg)
        {
            control.Paint += (o, e) => OnPaintColor(e, bc, bg);
        }

        public static void OnPaintColor(PaintEventArgs e, Color bc, Color bg)
        {
            e.Graphics.FillRectangle(new SolidBrush(bg), e.ClipRectangle);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, bc, ButtonBorderStyle.Solid);
        }

        private static void OnPaint(Control control, PaintEventArgs e, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphicsPath.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            graphicsPath.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            graphicsPath.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            graphicsPath.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            graphicsPath.SetMarkers();
            control.Region = new Region(graphicsPath);
        }
    }
}
