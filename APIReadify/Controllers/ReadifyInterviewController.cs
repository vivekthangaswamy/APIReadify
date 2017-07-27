﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Runtime.Serialization;

namespace APIReadify.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")] ///[controller]
    public class ReadifyInterviewController : Controller
    {

        [Produces("application/json")]
        [HttpGet]
        // GET: api/Token
        [Route("/api/Token")]
        public Guid GetToken()
        {
            return Guid.Parse("eb65085d-699c-4c69-ab0e-6c8d38160997");
        }

        [Produces("application/json")]
        [HttpGet]
        [Route("/api/")]
        public string Get()
        {
            return "Interview with Readify";
        }

        [Produces("application/json")]
        [HttpGet]
        //[Produces("application/json")]
        [Route("/api/ReverseWords")]
        public string ReverseWords(string sentence)
        {

            string temp = "", result = "";
            for (int i = 0; i < sentence.Length; i++)
                if (sentence[i] != ' ')

                    temp = sentence[i] + temp;
                else
                {
                    result += temp + sentence[i];
                    temp = "";
                }

            result += temp;

            return result;
        }


        [Produces("application/json")]
        [HttpGet]
        [Route("/api/Fibonacci")]
        //[FormatFilter]
        public long Fibonacci(long n)
        {
            long counter = n;
            var fibona = new List<long>();

            if (n == 0)
            {
                return 0;
            }
            //check for negative value, 
            //if it is negative convert to positive by multiplying by -1
            if (n < 0)
            {
                counter = counter * -1;
            }


            fibona.Add(0);
            fibona.Add(1);

            for (int i = 2; i <= counter; i++)
            {
                fibona.Add(fibona[i - 1] + fibona[i - 2]);
            }

            var result = fibona[fibona.Count - 1];

            if (n < -1)
            {
                result = result * -1;
            }
            return result;
        }


        private long FibonacciPositive(long X, long Y, long Z)
        {
            long data = Y;
            for (int i = 0; i < X; i++)
            {
                long temp = data;
                data = Z;
                Z = temp + Z;
            }
            return data;
        }

        [Produces("application/json")]
        [HttpGet]
        [Route("/api/TriangleType")]
        public string TriangleShape(int a, int b, int c)
        {
            if ((a + b > c && a + c > b && b + c > a) && (a > 0 && b > 0 && c > 0))
            {
                if (a == b && b == c)
                {
                    return "Equilateral";
                }
                else if (a == b || b == c || a == c)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                return "Error";
            }
        }

       



    }
}
