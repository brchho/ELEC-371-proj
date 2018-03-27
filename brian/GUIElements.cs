using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace cam_aforge1
{
    class GUIElements
    {
        //Important Variables: 
        //DO NOT CHANGE UNLESS YOU KNOW WHAT YOU'RE DOING
        GUI gui;
        public Graphics g;

        //This is where you can declare variables that you will be changing as the Run()
        //method executes.

        //Step 0: To try out the sample code, uncomment all the variables from line 21-27
        int circleX1 = 50;
        int circleY1 = 50;
        public int squareX1;
        public int squareY1;
        public int squareX1_2 = 100;
        public int squareY1_2 = 100;
        int speed = 5;
        bool cirDir = true;
        bool sqrDir = true;
        long scansizeincrement = 2;
        long scansizeincrement_2 = 2;
        int range = 15;

        int counter = 0;
        public int start_pixel_flag = 1;
        //End Variable declaration.

        //Main constructor of this class
        public GUIElements(GUI _gui)
        {
            this.gui = _gui;
        }
        
        //This function runs every frame
        public void Run(int r, int G, int b, Bitmap img, int begin_r, int begin_r_2, int begin_G, int begin_G_2, int begin_b, int begin_b_2)
        {
            Square sqr = new Square(Color.Blue, 4, squareX1, squareY1, 100);
            Square sqr_2 = new Square(Color.Red, 4, squareX1_2, squareY1_2, 100);
            

            //Step 6: Now let's display text on the screen. Uncomment lines 115-116.
            Text count = new Text("Count: " + counter.ToString(), Color.Red, 300, 0, 35);
            count.Draw(g);



            // DAG YO

            stayontrack();
            stayontrack_2();

            void stayontrack()
            {
                if ((squareX1) > 5 && (squareY1 + 50) <= 410)
                {
                    if ((change_panel_color(img, 1) > (begin_r+range) || change_panel_color(img, 1) < (begin_r - range)) || (change_panel_color(img, 2) > (begin_G + range) || change_panel_color(img, 2) < (begin_G - range)) || (change_panel_color(img, 3) > (begin_b + range) || change_panel_color(img, 3) < (begin_b - range)))
                    {
                        squareY1 = squareY1 + 2;
                        squareX1 = squareX1 - 2;
                        sqr.x1 = squareX1;
                        sqr.y1 = squareY1;
                        //sqr.Draw(g);
                    }
                    else
                    {
                        scansizeincrement = 2;
                        sqr.Draw(g);
                        return;
                    }
                }

                for (long i = 0; i < scansizeincrement; i++)
                {
                    if ((squareY1) > 5)
                    {
                        if ((change_panel_color(img, 1) > (begin_r + range) || change_panel_color(img, 1) < (begin_r - range)) || (change_panel_color(img, 2) > (begin_G + range) || change_panel_color(img, 2) < (begin_G - range)) || (change_panel_color(img, 3) > (begin_b + range) || change_panel_color(img, 3) < (begin_b - range)))
                        {
                            squareY1 = squareY1 - 3;
                            squareX1 = squareX1;
                            sqr.x1 = squareX1;
                            sqr.y1 = squareY1;
                            //sqr.Draw(g);

                        }
                        else
                        {
                            scansizeincrement = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement; i++)
                {
                    if ((squareX1 + 50) <= 560)
                    {
                        if ((change_panel_color(img, 1) > (begin_r + range) || change_panel_color(img, 1) < (begin_r - range)) || (change_panel_color(img, 2) > (begin_G + range) || change_panel_color(img, 2) < (begin_G - range)) || (change_panel_color(img, 3) > (begin_b + range) || change_panel_color(img, 3) < (begin_b - range)))
                        {
                            squareY1 = squareY1;
                            squareX1 = squareX1 + 3;
                            sqr.x1 = squareX1;
                            sqr.y1 = squareY1;
                            //sqr.Draw(g);
                        }
                        else
                        {
                            scansizeincrement = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement; i++)
                {
                    if ((squareY1 + 50) <= 410)
                    {
                        if ((change_panel_color(img, 1) > (begin_r + range) || change_panel_color(img, 1) < (begin_r - range)) || (change_panel_color(img, 2) > (begin_G + range) || change_panel_color(img, 2) < (begin_G - range)) || (change_panel_color(img, 3) > (begin_b + range) || change_panel_color(img, 3) < (begin_b - range)))
                        {
                            squareY1 = squareY1 + 3;
                            squareX1 = squareX1;
                            sqr.x1 = squareX1;
                            sqr.y1 = squareY1;
                            //sqr.Draw(g);
                        }
                        else
                        {
                            scansizeincrement = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement; i++)
                {
                    if ((squareX1) > 5)
                    {
                        if ((change_panel_color(img, 1) > (begin_r + range) || change_panel_color(img, 1) < (begin_r - range)) || (change_panel_color(img, 2) > (begin_G + range) || change_panel_color(img, 2) < (begin_G - range)) || (change_panel_color(img, 3) > (begin_b + range) || change_panel_color(img, 3) < (begin_b - range)))
                        {
                            squareY1 = squareY1;
                            squareX1 = squareX1 - 3;
                            sqr.x1 = squareX1;
                            sqr.y1 = squareY1;
                            //sqr.Draw(g);
                        }
                        else
                        {
                            scansizeincrement = 2;
                            return;
                        }
                    }
                }
                scansizeincrement = scansizeincrement + 2;
            }

            void stayontrack_2()
            {
                if ((squareX1_2) > 5 && (squareY1_2 + 50) <= 410)
                {
                    if ((change_panel_color_2(img, 1) > (begin_r_2 + range) || change_panel_color_2(img, 1) < (begin_r_2 - range)) || (change_panel_color_2(img, 2) > (begin_G_2 + range) || change_panel_color_2(img, 2) < (begin_G_2 - range)) || (change_panel_color_2(img, 3) > (begin_b_2 + range) || change_panel_color_2(img, 3) < (begin_b_2 - range)))
                    {
                        squareY1_2 = squareY1_2 + 2;
                        squareX1_2 = squareX1_2 - 2;
                        sqr_2.x1 = squareX1_2;
                        sqr_2.y1 = squareY1_2;
                        //sqr_2.Draw(g);
                    }
                    else
                    {
                        scansizeincrement_2 = 2;
                        sqr_2.Draw(g);
                        return;
                    }
                }

                for (long i = 0; i < scansizeincrement_2; i++)
                {
                    if ((squareY1_2) > 5)
                    {
                        if ((change_panel_color_2(img, 1) > (begin_r_2 + range) || change_panel_color_2(img, 1) < (begin_r_2 - range)) || (change_panel_color_2(img, 2) > (begin_G_2 + range) || change_panel_color_2(img, 2) < (begin_G_2 - range)) || (change_panel_color_2(img, 3) > (begin_b_2 + range) || change_panel_color_2(img, 3) < (begin_b_2 - range)))
                        {
                            squareY1_2 = squareY1_2 - 3;
                            squareX1_2 = squareX1_2;
                            sqr_2.x1 = squareX1_2;
                            sqr_2.y1 = squareY1_2;
                            //sqr_2.Draw(g);

                        }
                        else
                        {
                            scansizeincrement_2 = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement_2; i++)
                {
                    if ((squareX1_2 + 50) <= 560)
                    {
                        if ((change_panel_color_2(img, 1) > (begin_r_2 + range) || change_panel_color_2(img, 1) < (begin_r_2 - range)) || (change_panel_color_2(img, 2) > (begin_G_2 + range) || change_panel_color_2(img, 2) < (begin_G_2 - range)) || (change_panel_color_2(img, 3) > (begin_b_2 + range) || change_panel_color_2(img, 3) < (begin_b_2 - range)))
                        {
                            squareY1_2 = squareY1_2;
                            squareX1_2 = squareX1_2 + 3;
                            sqr_2.x1 = squareX1_2;
                            sqr_2.y1 = squareY1_2;
                            //sqr_2.Draw(g);
                        }
                        else
                        {
                            scansizeincrement_2 = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement_2; i++)
                {
                    if ((squareY1_2 + 50) <= 410)
                    {
                        if ((change_panel_color_2(img, 1) > (begin_r_2 + range) || change_panel_color_2(img, 1) < (begin_r_2 - range)) || (change_panel_color_2(img, 2) > (begin_G_2 + range) || change_panel_color_2(img, 2) < (begin_G_2 - range)) || (change_panel_color_2(img, 3) > (begin_b_2 + range) || change_panel_color_2(img, 3) < (begin_b_2 - range)))
                        {
                            squareY1_2 = squareY1_2 + 3;
                            squareX1_2 = squareX1_2;
                            sqr_2.x1 = squareX1_2;
                            sqr_2.y1 = squareY1_2;
                            //sqr_2.Draw(g);
                        }
                        else
                        {
                            scansizeincrement_2 = 2;
                            return;
                        }
                    }
                }
                for (long i = 0; i < scansizeincrement_2; i++)
                {
                    if ((squareX1_2) > 5)
                    {
                        if ((change_panel_color_2(img, 1) > (begin_r_2 + range) || change_panel_color_2(img, 1) < (begin_r_2 - range)) || (change_panel_color_2(img, 2) > (begin_G_2 + range) || change_panel_color_2(img, 2) < (begin_G_2 - range)) || (change_panel_color_2(img, 3) > (begin_b_2 + range) || change_panel_color_2(img, 3) < (begin_b_2 - range)))
                        {
                            squareY1_2 = squareY1_2;
                            squareX1_2 = squareX1_2 - 3;
                            sqr_2.x1 = squareX1_2;
                            sqr_2.y1 = squareY1_2;
                            //sqr_2.Draw(g);
                        }
                        else
                        {
                            scansizeincrement_2 = 2;
                            return;
                        }
                    }
                }
                scansizeincrement_2 = scansizeincrement_2 + 2;
            }

            //Console.WriteLine(change_panel_color_2(img, 1) + " " + change_panel_color_2(img, 2) + " " + change_panel_color_2(img, 3)+ " " + begin_r + " " + begin_G + " " + begin_b + " " + begin_r_2 + " " + begin_G_2 + " " + begin_b_2);
        }
        public int change_panel_color(Bitmap img, int sel)
        {
            int X1 = squareX1;
            int Y1 = squareY1;
            //int square = squareSize;

            //int count = 0;
            int r = 0;
            int G = 0;
            int b = 0;

            Color pixelColor = img.GetPixel(X1+50, Y1+50);
            r += pixelColor.R;
            G += pixelColor.G;
            b += pixelColor.B;
            
            if (sel == 1)
            {
                return r;
            }
            else if (sel == 2)
            {
                return G;
            }
            else if (sel == 3)
            {
                return b;
            }
            else
            {
                return 0;
            }

        }

        public int change_panel_color_2(Bitmap img, int sel)
        {
            int X1_2 = squareX1_2;
            int Y1_2 = squareY1_2;
            //int square = squareSize;

            //int count = 0;
            int r_2 = 0;
            int G_2 = 0;
            int b_2 = 0;

            Color pixelColor = img.GetPixel(X1_2 + 50, Y1_2 + 50);
            r_2 += pixelColor.R;
            G_2 += pixelColor.G;
            b_2 += pixelColor.B;

            if (sel == 1)
            {
                return r_2;
            }
            else if (sel == 2)
            {
                return G_2;
            }
            else if (sel == 3)
            {
                return b_2;
            }
            else
            {
                return 0;
            }

        }

        //Below is Sample Code on how to implement a button
        public void ButtonWasClicked()
        {
            //Step 8 on GUI.cs will enable this code
            counter++;
        }

        
    }

}