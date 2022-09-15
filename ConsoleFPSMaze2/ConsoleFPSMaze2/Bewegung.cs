namespace ConsoleFPSMaze2
{
    class Bewegung
    {
        Maze _maze = new Maze();
        int[] _position;
        bool[,] _sichtfeld;
        public string[,] _map;
        string _hindernis;
        public Bewegung()
        {
            _hindernis = "-";
            _position = new int[2];
            _sichtfeld = new bool[4, 5];
            _map = _maze.Map;
            StartPosition();
        }
        void StartPosition()
        {
            for (int i = 0; i < _maze.Map.GetLength(0); i++)
            {
                for (int j = 0; j < _maze.Map.GetLength(1); j++)
                {
                    if (_maze.Map[i, j] == "x")
                    {
                        _position[0] = i;
                        _position[1] = j;
                        break;
                    }
                }
            }
        }
        public bool[,] Sichtfeld()
        {
            int tiefe = _position[0];           //Sichtfeld position y
            int breite = _position[1] - 2;      //Sichtfeld position x beginnt 2 felder weiter links


            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 5; x++)
                {                               //wenn tiefe + y innerhalb _map
                    if (tiefe+y < _map.GetLength(0) - 1 && tiefe + y > 0)
                    {                           //wenn breite +x innerhalb _map
                        if (breite + x < _map.GetLength(1) -1 && breite + x > 0)
                        {
                            if (_map[tiefe + y, breite + x] == _hindernis)
                            {
                                _sichtfeld[y, x] = true;    //wenn _hindernis
                            }
                            else
                            {
                                _sichtfeld[y, x] = false;   
                            }
                        }
                        else
                        {
                            _sichtfeld[y, x] = true;        //alles außerhalb _map
                        }
                    }
                    else
                    {
                        _sichtfeld[y, x] = true;
                    }
                }
            }
            return _sichtfeld;
        }
        public void Eingabe(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow) { Gehen(); }
            //if (key == ConsoleKey.DownArrow) { Back(); }
            if (key == ConsoleKey.LeftArrow) { LinksTransformation(); }
            if (key == ConsoleKey.RightArrow) { RechtsTransformation(); }
        }
        void Gehen()
        {
            if (!_sichtfeld[1,2])           //wenn y + 1 kein _hindenis
            {
                if (_position[0] < _map.GetLength(0))
                {
                    _map[_position[0], _position[1]] = " ";     //markierung entfernen
                    _position[0]++;
                    _map[_position[0], _position[1]] = "O";     //neu setzen
                }
            }
        }
        //Fehlerbehaftet
        void Back()
        {
            if (_position[0] > 0)
            {
                if (_position[0] > 0 && _map[_position[0] - 1, _position[1]] != _hindernis)
                {
                    _map[_position[0], _position[1]] = " ";
                    _position[0]--;
                    _map[_position[0], _position[1]] = "O";
                }
            }
        }
        //char[15,15] _map 90° nach links drehen und speichern
        void RechtsTransformation()
        {
            int n = _map.GetLength(0);
            int m = _map.GetLength(1);
            _map[_position[0], _position[1]] = " ";
            for (int i = 0; i < n / 2 ; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {                                                       //Beispiel
                    string temp = _map[i, j];                           //temp 0.0
                    _map[i, j] = _map[n - 1 - j, i];                    //0.0 = 0.5
                    _map[n - 1 - j, i] = _map[n - 1 - i, n - 1 - j];    //0.5 = 5.5 
                    _map[n - 1 - i, n - 1 - j] = _map[j, n - 1 - i];    //5.5 = 5.0
                    _map[j, n - 1 - i] = temp;                          //5.0 = 0.0
                }
            }
            int p = _position[0];                       //Position auf der Karte anpassen
            _position[0] = _position[1];
            _position[1] = n - p -1;
            _map[_position[0], _position[1]] = "O";
        }

        //char[15,15] _map 90° nach rechts drehen und speichern
        void LinksTransformation()
        {
            int n = _map.GetLength(0);
            int m = _map.GetLength(1);
            _map[_position[0], _position[1]] = " ";
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {                                                       //Beispiel
                    string temp = _map[i, j];                           //temp = 0.0
                    _map[i, j] = _map[j, n - 1 - i];                    //0.0 = 5.0
                    _map[j, n - 1 - i] = _map[n - 1 - i, n - 1 - j];    //5.0 = 5.5
                    _map[n - 1 - i, n - 1 - j] = _map[n - 1 - j, i];    //5.5 = 0.5
                    _map[n - 1 - j, i] = temp;                          //0.5 = 0.0

                }
            }
            int p = _position[0];                       //Position auf der Karte anpassen
            _position[0] = n - _position[1] - 1;
            _position[1] = p;
            _map[_position[0], _position[1]] = "O";
        }

    }
}