﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace csharp_7._1
{
    public class Program
    {
        static async Task Main(string[] args) // Put async Task
        {
            // Using await on Main
            var length = await AsyncMethodAsync();
            Console.WriteLine($"Length of content: {length}.");            

            Func<string, bool> expressionTest = default; // Put default value to properties, in this case <null, false>
            Console.WriteLine($"Default values of expression: {expressionTest}");
            Console.ReadKey();

        }

        private static async Task<int> AsyncMethodAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com");                
                string urlContents = await getStringTask; 
                return urlContents.Length;
            }
        }
    }
}
