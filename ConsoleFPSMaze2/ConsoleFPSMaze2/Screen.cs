using System.Drawing;
using System.Runtime.InteropServices;

namespace ConsoleFPSMaze2
{
    class Screen
    {
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow", SetLastError = true)]
        static extern IntPtr GetConsoleHandle();
        IntPtr _handler = GetConsoleHandle();
        Graphics _graphics;
        Brush _brushW;
        Brush _brushB;
        Pen _penW;
        Pen _penB;
        ScreenPoints _gameScreen;
        List<Action> ts = new List<Action>();
        
        public Screen()
        {
            _gameScreen = new ScreenPoints(768, 432); //Pixel Anzahl muss durch 4 teilbar sein!!!
            _brushW = new SolidBrush(Color.White);
            _brushB = new SolidBrush(Color.Black);
            _penW = new Pen(Color.White);
            _penB = new Pen(Color.Black);
            _graphics = Graphics.FromHwnd(_handler);
            Console.CursorVisible = false;

            ts.Add(D5); ts.Add(D4); ts.Add(D3); ts.Add(D2); ts.Add(D1);
            ts.Add(C5); ts.Add(C4); ts.Add(C3); ts.Add(C2); ts.Add(C1);
            ts.Add(B5); ts.Add(B4); ts.Add(B3); ts.Add(B2); ts.Add(B1);
            ts.Add(A0); ts.Add(A3); ts.Add(A0); ts.Add(A1); ts.Add(A0);
        }
        public void Display(bool[,] sichtfeld)
        {
            _graphics.FillPolygon(_brushW, _gameScreen.DeckeHindergrund);
            Boden();

            //wenn sichtfeld[] == true => ts[a()] ausführen (polygon zeichnen)
            int a = 0;
            for(var i = sichtfeld.GetLength(0) - 1; i >= 0; i--)
            {
                for (var j = sichtfeld.GetLength(1) - 1; j >= 0; j--)
                {
                    if (sichtfeld[i,j]) 
                    { 
                        ts[a]();
                    }
                    a++;

                }
            }
        }
        void Boden()
        {
            _graphics.DrawPolygon(_penB, _gameScreen.Boden1);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden2);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden3);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden4);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden5);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden6);
            _graphics.DrawPolygon(_penB, _gameScreen.Boden7);

        }
        void D5()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte3Rechts2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte3Rechts2);
        }
        void D4()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte3Rechts1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte3Rechts1);
        }
        void D3()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte3);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte3);
        }
        void D2()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte3Links1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte3Links1);
        }
        void D1()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte3Links2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte3Links2);
        }
        void C5()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte2Rechts2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte2Rechts2);
            _graphics.FillPolygon(_brushB, _gameScreen.Wand1Rechts2);
            _graphics.DrawPolygon(_penW, _gameScreen.Wand1Rechts2);
        }
        void C1()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte2Links2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte2Links2);
            _graphics.FillPolygon(_brushB, _gameScreen.Wand1Links2);
            _graphics.DrawPolygon(_penW, _gameScreen.Wand1Links2);
        }
        void C4()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte2Rechts1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte2Rechts1);
            _graphics.FillPolygon(_brushB, _gameScreen.WandRechts3);
            _graphics.DrawPolygon(_penW, _gameScreen.WandRechts3);
        }
        void C3()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte2);
        }
        void C2()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte2Links1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte2Links1);
            _graphics.FillPolygon(_brushB, _gameScreen.WandLinks3);
            _graphics.DrawPolygon(_penW, _gameScreen.WandLinks3);
        }
        void B1()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.Wand1Links1);
            _graphics.DrawPolygon(_penW, _gameScreen.Wand1Links1);
        }
        void B2()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte1Links1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte1Links1);
            _graphics.FillPolygon(_brushB, _gameScreen.WandLinks2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandLinks2);
        }
        void B5()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.Wand1Rechts1);
            _graphics.DrawPolygon(_penW, _gameScreen.Wand1Rechts1);
        }
        void B4()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte1Rechts1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte1Rechts1);
            _graphics.FillPolygon(_brushB, _gameScreen.WandRechts2);
            _graphics.DrawPolygon(_penW, _gameScreen.WandRechts2);
        }
        
        void B3()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandMitte1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandMitte1);
        }
        void A3()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandRechts1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandRechts1);
        }
        void A1()
        {
            _graphics.FillPolygon(_brushB, _gameScreen.WandLinks1);
            _graphics.DrawPolygon(_penW, _gameScreen.WandLinks1);
        }
        void A0()
        { }
    }
}
