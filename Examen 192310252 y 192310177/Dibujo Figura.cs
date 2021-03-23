using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Examen_192310252_y_192310177
{
    class Dibujo_Figura
    {
        int x, y, alto, ancho;
        int mitadAncho, mitadAlto;

        //Metodo que dibuja la figura
        public void DibujarF(ref Graphics papel, int Alto, int Ancho)
        {
            
            alto = Alto;//284
            ancho = Ancho;//462

            mitadAncho = ancho / 2;
            mitadAlto = alto / 2;
            Pen lapiz1 = new Pen(Color.Black,2);
            //Dibuja la Corona
            SolidBrush brocha1 = new SolidBrush(Color.Yellow);
            Point[] Corona = new Point[]
             {
                new Point(mitadAncho-30,120),
                new Point(mitadAncho,50),
                new Point(mitadAncho,50),
                new Point(mitadAncho+30,120),
                new Point(mitadAncho+50,90),
                new Point(mitadAncho+70,120),
                new Point(mitadAncho+120,70),
                new Point(mitadAncho+90,245),
                new Point(mitadAncho-90,245),
                new Point(mitadAncho-120,70),
                new Point(mitadAncho-70,120),
                new Point(mitadAncho-50,90)
             };
            papel.DrawPolygon(lapiz1,Corona);    
            papel.FillPolygon(brocha1, Corona);

            //Lineas de la Corona
            Pen lapiz = new Pen(Color.Black, 5);
            papel.DrawLine(lapiz, 135, mitadAlto + 70, 325, mitadAlto + 70);
            papel.DrawLine(lapiz, 140, mitadAlto + 87, 325, mitadAlto + 87);
           
            //Colorea los circulos de la corona
            SolidBrush brocha2 = new SolidBrush(Color.Black);
            //Circulos de la Corona
            papel.FillEllipse(brocha2,mitadAncho+40,70,20,20 );
            papel.FillEllipse(brocha2, mitadAncho -60, 70, 20, 20);
            papel.FillEllipse(brocha2, mitadAncho + 110, 50, 20, 20);
            papel.FillEllipse(brocha2, mitadAncho - 130, 50, 20, 20);

            //Dibujo de Corazones
            SolidBrush brocha = new SolidBrush(Color.Red);
            //Dibuja Corazon 1
            papel.FillEllipse(brocha, mitadAncho-20, mitadAlto, 20, 20);
            papel.FillEllipse(brocha, mitadAncho,mitadAlto, 20, 20);
            Point[] triangulo1 = new Point[]
            {
                new Point(mitadAncho-21,mitadAlto+10),
                new Point(mitadAncho,mitadAlto+40),
                new Point(mitadAncho+21,mitadAlto+10)
            };
            papel.FillPolygon(brocha, triangulo1);
            
            //Dibuja Corazon 2
            papel.FillEllipse(brocha, mitadAncho - 88, mitadAlto, 20, 20);
            papel.FillEllipse(brocha, mitadAncho-70, mitadAlto, 20, 20);
            Point[] triangulo2 = new Point[]
            {
                new Point(mitadAncho-69,mitadAlto+40),
                new Point(mitadAncho-87,mitadAlto+15),
                new Point(mitadAncho-50,mitadAlto+15)
            };
            papel.FillPolygon(brocha, triangulo2);

            //Dibuja Corazon 3
            papel.FillEllipse(brocha, mitadAncho +68, mitadAlto, 20, 20);
            papel.FillEllipse(brocha, mitadAncho + 50, mitadAlto, 20, 20);
            Point[] triangulo3 = new Point[]
            {
                new Point(mitadAncho+69,mitadAlto+40),
                new Point(mitadAncho+87,mitadAlto+15),
                new Point(mitadAncho+50,mitadAlto+15)
            };
            papel.FillPolygon(brocha, triangulo3);
            
            //Dibuja la estrella Estrella
            Point[] Estrella = new Point[]
            {
            new Point(mitadAncho-15,mitadAlto-110),
            new Point(mitadAncho,mitadAlto-130),
            new Point(mitadAncho+15,mitadAlto-110)
            };
           
            papel.FillPolygon(brocha, Estrella);
            Point[] Estrella1 = new Point[]
            {
            new Point(mitadAncho-15,mitadAlto-120),
            new Point(mitadAncho,mitadAlto-100),
            new Point(mitadAncho+15,mitadAlto-120)
            };
            
            
            papel.FillPolygon(brocha, Estrella1);





        }
    }
}
