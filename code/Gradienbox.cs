using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblionela_curs
{
    class Gradienbox : Panel
    {
        private Color _firstFillColor;
        private Color _secondFillColor;
        private LinearGradientMode _gradientDirection;


        [Description("Первый цвет для градиентного заполнения"), DefaultValue(typeof(Color), "")]
        public Color ColorFillFirst
        {
            get => _firstFillColor;
            set => _firstFillColor = value;
        }
        [Description("Второй цвет для градиентного заполнения"), DefaultValue(typeof(Color), "")]
        public Color ColorfilliSecond
        {
            get => _secondFillColor;
            set => _secondFillColor = value;
        }
        [Description("Tun (Hanpabnehne) rpaawehta"), DefaultValue(LinearGradientMode.ForwardDiagonal)]
        public LinearGradientMode GradientDirection
        {
            get => _gradientDirection;
            set => _gradientDirection = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var lgb = new LinearGradientBrush(ClientRectangle, _firstFillColor, _secondFillColor, _gradientDirection);
            var graphics = e.Graphics;
            graphics.FillRectangle(lgb, ClientRectangle);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SetStyle(ControlStyles.ResizeRedraw, true);
            base.OnPaint(e);
        }
    }
}
