using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2
{
    class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var hora = int.Parse(Console.ReadLine());

            var edinDoChetiri = (hora >= 1 && hora <= 4);
            var petDoDevet = (hora >= 5 && hora <= 9);
            var desetDodvadesetichetiri = (hora >= 10 && hora <= 24);
            var dvadesetipetDochetirseidevet = (hora >= 25 && hora <= 49);
            var nadPedeset = (hora >= 50);

            if (edinDoChetiri)
            {
                var transport = budget * 0.75;
                var ostavashti = budget - transport;


                if (category == "Normal")
                {
                    var A = (double)(ostavashti - (249.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
                else
                {
                    var A = (double)(ostavashti - (499.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
            }
            ////////

            if (petDoDevet)
            {
                var transport = budget * 0.6;
                var ostavashti = budget - transport;


                if (category == "Normal")
                {
                    var A = (double)(ostavashti - (249.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
                else
                {
                    var A = (double)(ostavashti - (499.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
            }

            ///////
            else if (desetDodvadesetichetiri)
            {
                var transport = budget * 0.5;
                var ostavashti = budget - transport;


                if (category == "Normal")
                {
                    var A = (double)(ostavashti - (249.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
                else
                {
                    var A = (double)(ostavashti - (499.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
            }

            ///////
            else if (dvadesetipetDochetirseidevet)
            {
                var transport = budget * 0.4;
                var ostavashti = budget - transport;


                if (category == "Normal")
                {
                    var A = (double)(ostavashti - (249.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
                else
                {
                    var A = (double)(ostavashti - (499.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
            }

            ///////
            else if (nadPedeset)
            {
                var transport = budget * 0.25;
                var ostavashti = budget - transport;


                if (category == "Normal")
                {
                    var A = (double)(ostavashti - (249.99 * hora));
                    if (A >= 0)
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (249.99 * hora));
                        var need = Math.Abs(final - budget);
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
                else
                {
                    var A = (double)(ostavashti - (499.99 * hora));
                    if (A >= ostavashti)
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        Console.WriteLine("Yes! You have {0:F2} leva left.", final);
                    }
                    else
                    {
                        var final = (double)(ostavashti - (499.99 * hora));
                        var need = final - ostavashti;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", need);
                    }
                }
            }

        }
    }
}
