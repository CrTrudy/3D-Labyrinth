using System.Drawing;

namespace ConsoleFPSMaze2
{
    public class ScreenPoints
    {
        float _pxW;         //Pixel x       werden im konstruktor festgelegt
        float _pxH;         //Pixel y

        readonly PointF _point1;        //Alle relevanten Punkte
        readonly PointF _point2;
        readonly PointF _point3;
        readonly PointF _point4;
        readonly PointF _point5;
        readonly PointF _point6;
        readonly PointF _point7;
        readonly PointF _point8;
        readonly PointF _point9;
        readonly PointF _point10;
        readonly PointF _point11;
        readonly PointF _point12;
        readonly PointF _point13;
        readonly PointF _point14;
        readonly PointF _point15;
        readonly PointF _point16;
        readonly PointF _point17;
        readonly PointF _point18;
        readonly PointF _point19;
        readonly PointF _point20;
        readonly PointF _point21;
        readonly PointF _point22;
        readonly PointF _point23;
        readonly PointF _point24;
        readonly PointF _point25;
        readonly PointF _point26;
        readonly PointF _point27;
        readonly PointF _point28;
        readonly PointF _point29;
        readonly PointF _point30;
        readonly PointF _point31;
        readonly PointF _point32;
        readonly PointF _point33;
        readonly PointF _point34;
        readonly PointF _point35;
        readonly PointF _point36;
        readonly PointF _point37;
        readonly PointF _point38;
        readonly PointF _point39;
        readonly PointF _point40;

        //Point Array zur übergabe an graphics.drawpolygon(p[])

        public readonly PointF[] DeckeHindergrund;

        public readonly PointF[] Boden1;
        public readonly PointF[] Boden2;
        public readonly PointF[] Boden3;
        public readonly PointF[] Boden4;
        public readonly PointF[] Boden5;
        public readonly PointF[] Boden6;
        public readonly PointF[] Boden7;

        public readonly PointF[] WandLinks1;
        public readonly PointF[] WandLinks2;
        public readonly PointF[] WandLinks3;
        public readonly PointF[] WandRechts1;
        public readonly PointF[] WandRechts2;
        public readonly PointF[] WandRechts3;

        public readonly PointF[] WandMitte3Links1;
        public readonly PointF[] WandMitte3Links2;
        public readonly PointF[] WandMitte3;
        public readonly PointF[] WandMitte3Rechts1;
        public readonly PointF[] WandMitte3Rechts2;

        public readonly PointF[] WandMitte2Links1;
        public readonly PointF[] WandMitte2Links2;
        public readonly PointF[] WandMitte2;
        public readonly PointF[] WandMitte2Rechts1;
        public readonly PointF[] WandMitte2Rechts2;

        public readonly PointF[] WandMitte1Links1;
        public readonly PointF[] WandMitte1;
        public readonly PointF[] WandMitte1Rechts1;

        public readonly PointF[] Wand1Links1;
        public readonly PointF[] Wand1Links2;
        public readonly PointF[] Wand1Rechts1;
        public readonly PointF[] Wand1Rechts2;


        public ScreenPoints(int x, int y)
        {
            _pxW = x;
            _pxH = y;

            _point1 = new PointF(0 * _pxW, 0 * _pxH);
            _point2 = new PointF(1.0f * _pxW, 0 * _pxH);

            _point3 = new PointF(5.0f / 32.0f * _pxW, 4.0f / 24.0f * _pxH);
            _point4 = new PointF(27.0f / 32.0f * _pxW, 4.0f / 24.0f * _pxH);

            _point5 = new PointF(9.0f / 32.0f * _pxW, 7.0f / 24.0f * _pxH);
            _point6 = new PointF(23.0f / 32.0f * _pxW, 7.0f / 24.0f * _pxH);

            _point7 = new PointF(0 * _pxW, 9.0f / 24.0f * _pxH);
            _point8 = new PointF(4.0f / 32.0f * _pxW, 9.0f / 24.0f * _pxH);
            _point9 = new PointF(12.0f / 32.0f * _pxW, 9.0f / 24.0f * _pxH);
            _point10 = new PointF(20.0f / 32.0f * _pxW, 9.0f / 24.0f * _pxH);
            _point11 = new PointF(28.0f / 32.0f * _pxW, 9.0f / 24.0f * _pxH);
            _point12 = new PointF(1 * _pxW, 9.0f / 24.0f * _pxH);

            _point13 = new PointF(0 * _pxW, 15.0f / 24.0f * _pxH);
            _point14 = new PointF(4.0f / 32.0f * _pxW, 15.0f / 24.0f * _pxH);
            _point15 = new PointF(12.0f / 32.0f * _pxW, 15.0f / 24.0f * _pxH);
            _point16 = new PointF(20.0f / 32.0f * _pxW, 15.0f / 24.0f * _pxH);
            _point17 = new PointF(28.0f / 32.0f * _pxW, 15.0f / 24.0f * _pxH);
            _point18 = new PointF(1 * _pxW, 15.0f / 24.0f * _pxH);

            _point19 = new PointF(0 * _pxW, 17.0f / 24.0f * _pxH);
            _point20 = new PointF(1.0f / 32.0f * _pxW, 17.0f / 24.0f * _pxH);
            _point21 = new PointF(9.0f / 32.0f * _pxW, 17.0f / 24.0f * _pxH);
            _point22 = new PointF(23.0f / 32.0f * _pxW, 17.0f / 24.0f * _pxH);
            _point23 = new PointF(31.0f / 32.0f * _pxW, 17.0f / 24.0f * _pxH);
            _point24 = new PointF(1 * _pxW, 17.0f / 24.0f * _pxH);

            _point25 = new PointF(0 * _pxW, 18.0f / 24.0f * _pxH);
            _point26 = new PointF(1 * _pxW, 18.0f / 24.0f * _pxH);

            _point27 = new PointF(0 * _pxW, 20.0f / 24.0f * _pxH);
            _point28 = new PointF(5.0f / 32.0f * _pxW, 20.0f / 24.0f * _pxH);
            _point29 = new PointF(27.0f / 32.0f * _pxW, 20.0f / 24.0f * _pxH);
            _point30 = new PointF(1 * _pxW, 20.0f / 24.0f * _pxH);

            _point31 = new PointF(0 * _pxW, 1.0f * _pxH);
            _point32 = new PointF(1.0f * _pxW, 1.0f * _pxH);

            _point33 = new PointF(0 * _pxW, 7.0f / 24.0f * _pxH);
            _point34 = new PointF(1.0f / 32.0f * _pxW, 7.0f / 24.0f * _pxH);
            _point35 = new PointF(31.0f / 32.0f * _pxW, 7.0f / 24.0f * _pxH);
            _point36 = new PointF(1 * _pxW, 7.0f / 24.0f * _pxH);

            _point37 = new PointF(0 * _pxW, 4.0f / 24.0f * _pxH);
            _point38 = new PointF(1 * _pxW, 4.0f / 24.0f * _pxH);

            _point39 = new PointF(0 * _pxW, 6.0f/24.0f * _pxH);
            _point40 = new PointF(1 * _pxW, 6.0f/24.0f * _pxH);



            DeckeHindergrund = new PointF[4] {
                _point1,
                _point2,
                _point32,
                _point31 };

            Boden1 = new PointF[2] {
                _point27,
                _point30 };

            Boden2 = new PointF[2] {
                _point19,
                _point24 };

            Boden3 = new PointF[2] {
                _point14,
                _point25 };

            Boden4 = new PointF[2] {
                _point15,
                _point31 };

            Boden5 = new PointF[2] {
                _point16,
                _point32 };

            Boden6 = new PointF[2] {
                _point17,
                _point26 };

            Boden7 = new PointF[2] {
                _point24,
                _point19 };

            WandLinks1 = new PointF[4] {
                _point1,
                _point31,
                _point28,
                _point3 };
            WandLinks2 = new PointF[4] {
                _point3,
                _point28,
                _point21,
                _point5 };
            WandLinks3 = new PointF[4] {
                _point5,
                _point21,
                _point15,
                _point9 };
            WandRechts1 = new PointF[4] {
                _point2,
                _point32,
                _point29,
                _point4 };
            WandRechts2 = new PointF[4] {
                _point4,
                _point29,
                _point22,
                _point6 };
            WandRechts3 = new PointF[4] {
                _point22,
                _point6,
                _point10,
                _point16 };

            WandMitte3Links1 = new PointF[4] {
                _point7,
                _point8,
                _point14,
                _point13 };
            WandMitte3Links2 = new PointF[4] {
                _point8,
                _point14,
                _point15,
                _point9 };
            WandMitte3 = new PointF[4] {
                _point9,
                _point15,
                _point16,
                _point10 };
            WandMitte3Rechts1 = new PointF[4] {
                _point16,
                _point10,
                _point11,
                _point17 };
            WandMitte3Rechts2 = new PointF[4] {
                _point11,
                _point17,
                _point18,
                _point12 };

            WandMitte2Links2 = new PointF[4] {
                _point33,
                _point34,
                _point20,
                _point19 };
            WandMitte2Links1 = new PointF[4] {
                _point34,
                _point20,
                _point21,
                _point5 };
            WandMitte2 = new PointF[4] {
                _point5,
                _point21,
                _point22,
                _point6 };
            WandMitte2Rechts1 = new PointF[4] {
                _point22,
                _point6,
                _point35,
                _point23};
            WandMitte2Rechts2 = new PointF[4] {
                _point23,
                _point35,
                _point36,
                _point24 };

            WandMitte1Links1 = new PointF[4] {
                _point37,
                _point3,
                _point28,
                _point27 };
            WandMitte1 = new PointF[4] {
                _point3,
                _point28,
                _point29,
                _point4 };
            WandMitte1Rechts1 = new PointF[4] {
                _point29,
                _point4,
                _point38,
                _point30 };

            Wand1Links1 = new PointF[4] {
                _point39,
                _point34,
                _point20,
                _point25 };
            Wand1Links2 = new PointF[4] {
                _point20,
                _point34,
                _point8,
                _point14 };
            Wand1Rechts1 = new PointF[4] {
                _point40,
                _point26,
                _point23,
                _point35 };
            Wand1Rechts2 = new PointF[4] {
                _point23,
                _point35,
                _point11,
                _point17 };
        }
    }
}