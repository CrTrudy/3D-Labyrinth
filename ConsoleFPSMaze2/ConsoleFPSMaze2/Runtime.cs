namespace ConsoleFPSMaze2
{
    class Runtime
    {
        Screen _screen;
        Bewegung _bewegung;
        ConsoleKey _key;
        public Runtime()
        {
            _screen = new Screen();
            _bewegung = new Bewegung();
            Start();
        }
        void Start()
        {
            do
            {                                               //game loop
                _key = Console.ReadKey().Key;
                _bewegung.Eingabe(_key);
                _screen.Display(_bewegung.Sichtfeld());
                //Karte();
            } while (_key != ConsoleKey.Escape);
        }


        //mögliche Karte
        void Karte()
        {
            string[,] vs = _bewegung._map;
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                for (int j = 0; j < vs.GetLength(1); j++)
                {
                    Console.SetCursorPosition(100 + j, 0 + i);
                    Console.Write(vs[i,j]);
                }
            }
            bool[,] va = _bewegung.Sichtfeld();
            for (int i = 0; i < va.GetLength(0); i++)
            {
                for (int j = 0; j < va.GetLength(1); j++)
                {
                    Console.SetCursorPosition(100 + j, 16 + i);
                    Console.Write(va[i, j]);
                }
            }
        }
    }
}