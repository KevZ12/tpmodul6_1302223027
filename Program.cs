﻿namespace tpmodul6_1302223027
{
    class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo test = new SayaTubeVideo("Tutorial Design By Contract – Kevin Albany");
            test.IncreasePlayCount(10);
            test.PrintVideoDetail();    
        }
    }
}