using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//          Incapsulation --using setter/getter/-----restricting the component of an objects by using access modifiers(private/public)
namespace OOP_Properties
{
    internal class Box
    {

        // member variable
        private int length = 3;
        private int height;
        //public int width; // instead use default - e.g.- public int Width { get; set; }
        private int volume;

        //PROPERTIES
        public int Width { get; set; } // shorter and same as below(line 22-26) use for no logic in properties
        /*public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }*/
        
        public int Volume
        {
            get
            {
                //return volume; 
                return this.length * this.height * this.Width;
            }
           /* set
            {
                this.volume = value;
            }*/
        }
        //Logic Properties
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)//logic
                {
                    height = -value; ///if less than 0 then multiply by -1
                }
                else
                {
                    height = value;
                }
                
            }

        }

        //constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }


        //setter
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        //getter
        public int GetLength()
        {
            return this.length; // this.length is the member variable length
        }
        /*
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }*/

        public void DisplayInfo()
        {
            // Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
            //  length, height, width, volume = length*height*width);
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, Width, volume = length * height * Width);
        }


    }
}
