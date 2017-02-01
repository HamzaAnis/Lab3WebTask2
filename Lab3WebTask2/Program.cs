using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3WebTask2
{
    class Program
    {
        //+Jagged Array
        static void Main(string[] args)
        {
            int[][] student = new int[11][];

            student[0] = new int[5] { 1, 4, 2, 2, 2 };
            student[1] = new int[5] { 3,4,2,0,1 };
            student[2] = new int[3] { 4,4,3 };
            student[3] = new int[6] { 4,3,2,4,1,0};
            student[4] = new int[4] { 4,3,1,4 };
            student[5] = new int[3] { 4, 2, 1 };
            student[6] = new int[2] { 4,4 };
            student[7] = new int[6] { 1,4,3,2,0,1 };
            student[8] = new int[4] { 4,2,4,4 };
            student[9] = new int[4] { 2,3,2,2 };
            student[10] = new int[5] { 2,4,3,3, 1 };


            for (int i = 0; i < student.Length; i++)
            {
                int score = 0;
                float cgpa = 0;
                for (int j = 0; j < student[i].Length; j++)
                {

                    score += student[i][j];
                    cgpa = score / student[i].Length;
                }
                
                //System.Console.WriteLine("The courses are {0}", student[i].Length);
                //System.Console.WriteLine("The score is {0}", student.Length);



                System.Console.WriteLine("Theasd student with roll no {0} has CGPA of {1}", i, cgpa);

            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();






        }
        public void calculateCGPA(int [][] t)
        {
            
        }
    }
}
