﻿using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using static System.Net.WebRequestMethods;


namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// RonVsKanye
            
            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.Kanye();
                RonVSKanyeAPI.Ron();
                Console.WriteLine("------");

            }

            //------------------------------------------------------------------
            
            //OpenWeatherMap

            OpenWeatherMapAPI.Weather();
            
        }
    }
}
