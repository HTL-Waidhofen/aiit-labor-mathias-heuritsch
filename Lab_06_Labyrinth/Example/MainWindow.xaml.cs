using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Example
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Figur figur; 

        public MainWindow()
        {
            InitializeComponent();
            
            this.Spielfeld.Background = Brushes.Black;
            Canvas c; 

            StreamReader reader =new StreamReader("maze_6x6.txt");
            string inhalt =reader.ReadToEnd();
            string[] zeilen = inhalt.Split('\n');

            for (int i = 0; i < zeilen.Length; i++)
            {
                for (int j = 0; j < zeilen[i].Length;j++)
                {
                    if( zeilen[i][j] =='#')
                    {
                        c = new Canvas();
                        c.Background = Brushes.Yellow;
                        c.Width = 20;
                        c.Height = 20;
                        Canvas.SetTop(c, i * 20);
                        Canvas.SetLeft(c, j * 20);
                        Spielfeld.Children.Add(c);
                    }
                    else if (zeilen[i][j]=='X')
                    {
                        figur = new Figur(j*20, i*20, 20, 20);
                        Spielfeld.Children.Add(figur.Ellipse);
                    }
                    
                }
                

            }



        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.S)
            {
                if (notWall(0, 20))
                    figur.Move(0, 20);
            }

            if (e.Key == Key.W)
            {
                if (notWall(0, -20))
                    figur.Move(0, -20);
            }
            if (e.Key == Key.A)
            {
                if (notWall(-20, 0))
                    figur.Move(-20, 0);
            }
            if (e.Key == Key.D)
            {
                if (notWall(20, 0))
                    figur.Move(20, 0);
            }
            /*
            if (e.Key == Key.S)
            {
                bool movedown=false;
                float newposy = figur.Posy + 20;

                for (int i = 0; i < Spielfeld.Children.Count; i++)
                {
                    if (Spielfeld.Children[i] is Canvas feld)
                    {
                        if (Canvas.GetTop(feld) == newposy &&
                            Canvas.GetLeft(feld) == figur.Posx)
                        {
                            // 🔎 Prüfen ob das Feld gelb ist
                            if (feld.Background is SolidColorBrush brush &&
                                brush.Color == Colors.Yellow)
                            {
                                movedown = false;
                                break;
                            }
                                 else
                                 {
                                 movedown = true;
                                break;
                                 }
                        }
                    }
                }

                if(movedown)
                {
                    figur.Posy = newposy;
                    
                }
            }
            */

        }
        public bool notWall(float x, float y)
        {
            float newx = figur.Posx + x;
            float newy = figur.Posy + y;

            bool notWall = true;
                       for (int i = 0; i < Spielfeld.Children.Count; i++)
            {
                if (Spielfeld.Children[i] is Canvas feld)
                {
                    if (Canvas.GetTop(feld) == newy &&
                        Canvas.GetLeft(feld) == newx)
                    {
                        // 🔎 Prüfen ob das Feld gelb ist
                        if (feld.Background is SolidColorBrush brush &&
                            brush.Color == Colors.Yellow)
                        {
                            notWall = false;
                        }
                        else if(notWall==true) notWall = true;
                    }
                }
            }
            return notWall;
        }
    }
}
