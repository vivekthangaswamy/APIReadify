using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIReadify.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")] ///[controller]
    public class ReadifyInterviewController : Controller
    {
        
        // GET: api/Token
        [Route("/api/Token")]
        public Guid GetToken()
        {
            return Guid.Parse("eb65085d-699c-4c69-ab0e-6c8d38160997");
        }

        [Route("/api/")]
        public string Get()
        {
            return "Interview with Readify";
        }

        [Produces("application/json")]
        [Route("/api/ReverseWords")]
        public string ReverseWords(string sentence)
        {
            
            if (sentence == null)
                throw new ArgumentNullException();

            var result = "";
            var ipWord = "";

            foreach (var c in sentence)
            {
                if (c != ' ')
                    ipWord += c;
                else
                {
                    for (int j = ipWord.Length - 1; j >= 0; j--)
                        result += ipWord[j];

                    result += " ";
                    ipWord = "";
                }
            }

            for (int j = ipWord.Length - 1; j >= 0; j--)
                result += ipWord[j];

            return result;
        }

        [Route("/api/Fibonacci")]
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
