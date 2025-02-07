/*using System.Text;


internal class Program
{
   private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        /*  String? str = "Wirpo";
          str += " Nga Training"; 
          Console.WriteLine(str);



          Console.WriteLine("enter the org name: ");
          StringBuilder sb = new StringBuilder(Console.ReadLine());
          sb.Append(str);
          Console.WriteLine(sb);*/

        /*int[][] arr = new int[4][];

        arr[0] =new int[] { 10,20,30};
        arr[1] =new int[]{ 40,50};
        arr[2] =new int[]{ 60,70};
        arr[3] =new int[]{ 80,90,100};

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"values for arr{i + 1} are: ");
            for (int j = 0; j < arr[i].Length; j++) {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }*/


        //summation of no. of teams playes

        /* Console.Write("enter the size of teams: ");
         int size=Convert.ToInt32(Console.ReadLine());

         int[][] teams = new int[size][];

         for(int i = 0; i < teams.Length; i++)
         {
             Console.Write($"enter the no. of rounds for each team: ");
             int rounds=Convert.ToInt32(Console.ReadLine());
             teams[i]=new int[rounds];
             Console.WriteLine($"enter the scores for team {i+1}: ");
             for(int j=0; j < teams[i].Length; j++)
             {
                 teams[i][j]=Convert.ToInt32(Console.ReadLine());
             }



         }

         //for displaying and summation of scores

         for(int i=0;i < teams.Length; i++)
         {
             int sum = 0;
             for(int j=0;j< teams[i].Length; j++)
             {
                 sum += teams[i][j];
             }
             Console.WriteLine($"total score for team {i + 1}= {sum}");
         }*/

        //multi-dim array

        /* Console.WriteLine("enter the no. of rows: ");
         int rows=Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("enter the no. of cols: ");
         int cols=Convert.ToInt32(Console.ReadLine());

         int[,] matrx=new int[rows, cols];

         for(int i = 0; i < rows; i++)
         {
             for(int j=0;j<cols; j++)
             {
                 Console.WriteLine($" enter the elements for {i},{j}: ");
                 matrx[i,j] = Convert.ToInt32(Console.ReadLine());

             }
         }

         for(int i = 0; i < rows; i++)
         {
             for (int j = 0; j < cols; j++)
             {
                 Console.Write(matrx[i,j]+" ");
             }
             Console.WriteLine();
         }

       


    }
}*/