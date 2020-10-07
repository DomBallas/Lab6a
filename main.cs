using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) { 
    Console.WriteLine("Enter how many temps you will be recording");
    int temp = Convert.ToInt32(Console.ReadLine());

    //declare array
    int[] tempc = new int[temp];
    
    
    double[] tempf = new double[temp];
   

    for(int counter=0; counter < temp; counter++){
         Console.WriteLine("Enter temp in Celcius");
         tempc[counter] = Convert.ToInt32(Console.ReadLine());
         
         tempf[counter]=tempc[counter]*(9/5)+32;         
    }
    Console.WriteLine(tempf.Length);

    for(int counter=0;counter < temp; counter++)
    {
      Console.WriteLine("temp in Farenheit "+ (counter+1) +" = " + tempf[counter]);
      

      

    }
   Console.WriteLine(tempf.Sum());
   Console.WriteLine(tempf.Sum()/temp);
       
    

  }

}