using System;

namespace _02_Bottles
{
    internal class Song
    {
        internal string CountBottles(int v)
        {
            string result = "";
            switch (v)
            {
                case 0:result = NoBottles();
                    break;
                case 1:result = CountDownFromOne();
                    break;
                case 2:result = CountDownFromTwo();
                    break;
                case 3:result = CountDownFromThree();
                    break;
            }
            return result;
        }
        private string NoBottles()
        {
            return "No more bottles of beer on the wall.";
        
        }
        private string CountDownFromOne()
        {
            return "1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
        }
        private string CountDownFromTwo()
        {
            return "2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
        
        }
        private string CountDownFromThree()
        {
            return "3 bottles of beer on the wall."
                + " 3 bottles of beer."
                + " Take one down and pass it around."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
        }

    }
}