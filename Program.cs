using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the simple C# puzzles!");
            System.Console.WriteLine("========");
            RandomArray();
            System.Console.WriteLine("========");
            TossCoin();
            System.Console.WriteLine("========");
            System.Console.WriteLine(TossMultipleCoins(5));
            System.Console.WriteLine("========");
            NamesList();
            System.Console.WriteLine("========");

            



        }


        public static void RandomArray(){
            System.Console.WriteLine("***************** Random Array ********************");
            int[] nums = new int[10];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(5,25);
            }
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            foreach (int num in nums) 
            {
                if( max < num){
                    max = num;
                }
                if(min > num) {
                    min = num;
                }
                sum += num;
            }
            System.Console.WriteLine($"Max: {max} -- Min: {min} -- Sum: {sum}");
            foreach (int num in nums) {
                System.Console.WriteLine(num);
            }
            System.Console.WriteLine("*************************************");
        }



        public static string TossCoin(){
            string result;

            System.Console.WriteLine("Tossing Coin!");
            Random rand = new Random();
            int randNum = rand.Next(2);
            System.Console.WriteLine(randNum);
            if(randNum == 1) {
                result = "Heads";
            } else {
                result = "Tails";
            }
            System.Console.WriteLine(result);
            return result;
        }


        public static double TossMultipleCoins(int num){
            System.Console.WriteLine("************* multiple coins****************");
            double total = 0.0;

            for (int i = 0; i < num; i++)
            {
                string result = TossCoin();
                if(result == "Heads"){
                    total = total + 1;
                }
            }

            System.Console.WriteLine("************* multiple coins****************");
            return (total / num);
        }


        public static List<string> NamesList() {
            List<string> newNameList = new List<string>() {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            List<string> returnNameList = new List<string>();
            Random rand = new Random();
            var randomized = newNameList.OrderBy(item => rand.Next());
            foreach (var item in randomized)
            {
                System.Console.WriteLine(item);
                if(item.Length > 6) {
                    returnNameList.Add(item);
                }
            }
            System.Console.WriteLine("&&&&& returnNameList&&&&&");
            foreach (var item in returnNameList) {
                System.Console.WriteLine(item);
            }
            {
                
            }
            return returnNameList;

        }
    }
}
