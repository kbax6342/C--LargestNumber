using System;
using System.Linq;
//Kevin Baxter
//

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args){
            //Creating variable to store the numbers entered and the biggest number
            int num = 0;
            int biggestNumber =0;
            
            //The for loop is to count through the number of times the user is asked to put in a number
            for(int counter = 0; counter < 10; counter++){
                //The statement to ask the user to put in a number
                Console.WriteLine("Please enter and integer");
                num = int.Parse(Console.ReadLine());

                //This if/esle statement is saving the first number entered to the biggest number
                if( counter == 0){
                    biggestNumber = num;
                }
                else{
                    //This if/else statement is comparing all of the numbers that come after the first entry5
                    if(num > biggestNumber){
                        biggestNumber = num;
                    }
                }
            }
            //Printing out the biggest number
            Console.WriteLine($"The largest number is {biggestNumber}");
           
        }   
                   
    }

}
