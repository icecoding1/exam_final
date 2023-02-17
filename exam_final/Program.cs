using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exam_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            one myObject = new one();
            Two myObject_two = new Two();
            Rectangle myRectangle = new Rectangle();

            //ข้อหนึ่ง
            // Console.Write("number 1\n");
            //Console.Write("Please enter your username: ");
            //string username = Console.ReadLine();
            //myObject.SayHello(username);

            //ข้อสอง
             Console.Write("number 2\n");

            // กำหนดขนาดของ Array
            Console.Write("Input size of Array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];

            // วนลูปเพื่อรับค่ามาเก็บไว้ใน Array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Input value index[" + i + "] : ");
                array[i] = Console.ReadLine().ToString();
            }

           //ส่งค่าarray ที่รับจากเเป้นพิมพ์ ไปยัง show_max เพื่อหาค่า ที่มากที่สุด
            myObject_two.show_max(array);
            //ข้อสอง

            //ข้อสาม
            //Console.Write("number 3\n");
            //Console.Write("Enter a number width : ");
            //string width_text = Console.ReadLine();
            //Console.Write("Enter a number length : ");
            //string length_text = Console.ReadLine();
            //double width = Double.Parse(width_text);
            //double length = Double.Parse(length_text);
            //myRectangle.Width = width;
            //myRectangle.Length = length;
            //double area = myRectangle.calculateArea(); 
            //Console.WriteLine("The area of the rectangle is: " + area);

            //ข้อสี่
            Console.Write("number 4\n");
            Console.Write("Enter a radius : ");
            string radius_text = Console.ReadLine();
            double radius = Double.Parse(radius_text);
            Circle myCircle = new Circle(radius);
            double area = myCircle.CalculateArea();
            Console.WriteLine("The area of the circle is: " + area);
        }
    }

}
