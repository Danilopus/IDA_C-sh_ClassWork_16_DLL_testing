// ClassWork template 1.2 // date: 29.09.2023

using Service;
using System;
using System.Linq.Expressions;
using System.Text;
using ds.test.impl;



// ClassWork 16 : [C sharp] 15.11.2023 --------------------------------

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Task_1();
            // Task_2();
            // Task_3();


             Console.ReadKey();

        }

        public static void Task_1() 
        {
            int input1 = 15; int input2 = 25;
            Console.WriteLine($"input1 = {input1}\ninput2 = {input2}\n\n");
            
            Plugins plugins_1 = new Plugins();

            for (int i = 0; i < plugins_1.PluginsCount; i++)
            {
                Console.WriteLine(plugins_1.GetPluginNames[i] + $" of {input1} and {input2}");
                Console.WriteLine(plugins_1.GetPlugin(plugins_1.GetPluginNames[i]).Run(input1,input2));
            }

        }
        public static void Task_2() { }
        public static void Task_3() { }

    } // class Programm
}// namespace

