using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Draw
    {
        static float x, y;
        static Graphics graphics;

        public static void DoInitialization(Graphics newGraphics)
        {
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        { x = x0; y = y0; }

        public static void makeIt(Pen pen, double length, double corner)
        {
            //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(corner));
            var y1 = (float)(y + length * Math.Sin(corner));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double corner)
        {
            x = (float)(x + length * Math.Cos(corner));
            y = (float)(y + length * Math.Sin(corner));
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double ugolPovorota, Graphics grafika)
        {
            // ugolPovorota пока не используется, но будет использоваться в будущем
            RefactorMe.Draw.DoInitialization(grafika);

            var sz = Math.Min(width, height);

            var diagonal_length = Math.Sqrt(2) * (sz * 0.375f + sz * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            RefactorMe.Draw.SetPosition(x0, y0);

            //Рисуем 1-ую сторону
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, 0);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 4);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2);

            RefactorMe.Draw.Change(sz * 0.04f, -Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);

            //Рисуем 2-ую сторону
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2 + Math.PI);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, -Math.PI / 2 + Math.PI / 2);

            RefactorMe.Draw.Change(sz * 0.04f, -Math.PI / 2 - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);

            //Рисуем 3-ю сторону
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, Math.PI + Math.PI);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI + Math.PI / 2);

            RefactorMe.Draw.Change(sz * 0.04f, Math.PI - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);

            //Рисуем 4-ую сторону
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2 + Math.PI);
            RefactorMe.Draw.makeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2 + Math.PI / 2);

            RefactorMe.Draw.Change(sz * 0.04f, Math.PI / 2 - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}