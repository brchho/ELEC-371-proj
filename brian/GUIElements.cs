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
        public int squareX1 ;
        public int squareY1;
        int speed = 5;
        bool cirDir = true;
        bool sqrDir = true;
        long scansizeincrement = 2;
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
        public void Run(int r, int G, int b, Bitmap img, int begin_r, int begin_G, int begin_b)
        {
            //Step 1: Let's draw a basic Square. Uncomment Lines 43-45 to draw a blue square. Then, press start.
            //if (start_pixel_color_flag == 0 && start_pixel_flag == 1)
            //{
            //    squareX1 = start_x_coord;
            //    squareY1 = start_y_coord;
            //    start_pixel_flag = 0;

            //}

            //Console.WriteLine(begin_r + " " + begin_G + " " + begin_b);
            Square sqr = new Square(Color.Blue, 4, squareX1, squareY1, 100);
            //sqr.Draw(g);
            

            //Step 2: Now let's draw a filled circle. Uncomment Lines 47-50 to draw a purple
            //circle in the centre of the square we drew in step 1
            //Circle cir = new Circle(Color.Purple, 4, circleX1, circleY1, 50);
            //cir.isFill = true;
            //cir.Draw(g);

            //Step 3: It's time to animate! The following chunk of code
            //moves the circle side-to-side within the square. Uncomment lines 55-74 and comment out
            //the cir.Draw(g) in line 45.

            //if (cir.x1 + 25 >= sqr.size || cir.x1 - 25 <= sqr.x1)
            //{
            //    cirDir = !cirDir;
            //}

            //if (cirDir)
            //{
            //    circleX1 = circleX1 + speed;
            //    cir.x1 = circleX1;
            //}

            //else
            //{
            //    circleX1 = circleX1 - speed;
            //    cir.x1 = circleX1;
            //}

            //cir.Draw(g);


            //Step 4: Let's animate the square this time. The following chunk of code
            //moves the square up and down the screen. Uncomment lines 79-98 and comment out
            //the sqr.Draw(g) in line 44.

            //if (sqr.y1 >= 300 || sqr.y1 < 0)
            //{
            //    sqrDir = !sqrDir;
            //}

            //if (sqrDir)
            //{
            //    squareY1 = squareY1 + speed;
            //    sqr.y1 = squareY1;
            //}

            //else
            //{
            //    squareY1 = squareY1 - speed;
            //    sqr.y1 = squareY1;
            //}



            //sqr.Draw(g);


            //Step 5: Now let's try syncing the movement of the 2 primitives we created. Uncomment
            //lines 99-102 to group the 2 primitives into a single Shape. Make sure to comment out
            //the cir.Draw(); and the sqr.Draw(); in lines 73 and 97, respectively.

            Shape shape = new Shape();
            shape.Add(sqr);
            //shape.Add(cir);
            //shape.Draw(g);


            //Note that the FIRST primitive added with the shape.Add method is ALWAYS the root shape.
            //This means that the succeeding primitives are always positioned with respect to the x1 and y1
            //of the first primitive added.

            //Step 6: Now let's display text on the screen. Uncomment lines 115-116.
            Text count = new Text("Count: " + counter.ToString(), Color.Red, 300, 0, 35);
            count.Draw(g);

            //It's time to add user interactivity. Go to the GUI.cs form designer by double clicking beginner>GUI.cs
            //on the Solution Explorer to the right of your Visual Studio window. On the Form Designer, double click the
            //Tick button to proceed to step 7


            // DAG YO

            stayontrack();

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

            Console.WriteLine(change_panel_color(img, 1) + " " + change_panel_color(img, 2) + " " + change_panel_color(img, 3)+ " " + begin_r + " " + begin_G + " " + begin_b);


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

        //Below is Sample Code on how to implement a button
        public void ButtonWasClicked()
        {
            //Step 8 on GUI.cs will enable this code
            counter++;
        }
    }

}