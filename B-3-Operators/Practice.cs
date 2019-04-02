using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    
    public partial class Practice
    {
        
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine(z);
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Input your answer");
            int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
            string Answer = correctAnswerInt == z ? Answer = "It is correct" : Answer = "it is not correct";
            Console.WriteLine(Answer);
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Input your answer");
            int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
            

            
            if (correctAnswerInt < z)
            {
                Console.WriteLine("Incorrect. Your answer is less than the correct result");
            }
            else if (correctAnswerInt > z)
            {
                Console.WriteLine("Incorrect. Your answer is more than the correct result");
            }
            else
            {
                Console.WriteLine("Your answer is correct");
            }
            
        }
        
        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input + or -");
            string oper = Console.ReadLine();
            bool validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
            while (validation == false)
            {
                Console.WriteLine("Incorrect operator");
                Console.WriteLine("Input + or -");
                oper = Console.ReadLine();
                validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
                if (validation == true)
                {
                    break;
                }
            }
            int z = oper == "+" && validation == true? x + y : x - y;
            Console.WriteLine("Input your answer");
            int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
            if (correctAnswerInt < z)
            {
                Console.WriteLine("Incorrect. Your answer is less than the correct result");
            }
            else if (correctAnswerInt > z)
            {
                Console.WriteLine("Incorrect. Your answer is more than the correct result");
            }
            else
            {
                Console.WriteLine("Your answer is correct");
            }
        }

        
        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {

            bool flag = true;
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input + or -");
            string oper = Console.ReadLine();
            bool validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
            while (validation == false)
            {
                Console.WriteLine("Incorect operator");
                Console.WriteLine("Input + or -");
                oper = Console.ReadLine();
                validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
                if (validation == true)
                {
                    break;
                }
            }
            int z = oper == "+" && validation == true? x + y : x - y;
            

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"You have {4-i} tries to guess the answer. Input your answer");
                
                int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
                if (correctAnswerInt != z)
                {
                    flag = false;
                    string addInform = correctAnswerInt > z ? addInform = "Incorrect.Your answer is more than the correct result" : addInform = "Incorrect. Your answer is less than the correct result";

                    Console.WriteLine(addInform);
                }
                else if (correctAnswerInt == z)
                {
                    flag = true;
                    Console.WriteLine("You are win!!!");
                    break;
                }
                
            }
            if (flag == false)
            {
                Console.WriteLine("You tries are over");
            }

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            bool flag = true;
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input first number");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input + or -");
            string oper = Console.ReadLine();
            bool validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
            while (validation == false)
            {
                Console.WriteLine("Incorect operator");
                Console.WriteLine("Input + or -");
                oper = Console.ReadLine();
                validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
                if (validation == true)
                {
                    break;
                }
            }
            int z = oper == "+" && validation == true ? x + y + q + w + e: x - y - q - w - e;


            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"You have {4 - i} tries to guess the answer. Input your answer");

                int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
                if (correctAnswerInt != z)
                {
                    flag = false;
                    string addInform = correctAnswerInt > z ? addInform = "Incorrect.Your answer is more than the correct result" : addInform = "Incorrect. Your answer is less than the correct result";

                    Console.WriteLine(addInform);
                }
                else if (correctAnswerInt == z)
                {
                    flag = true;
                    Console.WriteLine("You are win!!!");
                    break;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("You tries are over");
            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            bool flag = true;
            Console.WriteLine("input first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input first number");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input + or -");
            string oper = Console.ReadLine();
            bool validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
            while (validation == false)
            {
                Console.WriteLine("Incorect operator");
                Console.WriteLine("Input + or -");
                oper = Console.ReadLine();
                validation = oper == "+" ^ oper == "-" ? validation = true : validation = false;
                if (validation == true)
                {
                    break;
                }
            }
            int z = oper == "+" && validation == true ? x + y + q + w + e : x - y - q - w - e;


            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"You have {4 - i} tries to guess the answer. Input your answer");

                int correctAnswerInt = Convert.ToInt32(Console.ReadLine());
                if (correctAnswerInt != z)
                {
                    flag = false;
                    string addInform = correctAnswerInt > z ? addInform = "Incorrect.Your answer is more than the correct result" : addInform = "Incorrect. Your answer is less than the correct result";

                    Console.WriteLine(addInform);
                }
                else if (correctAnswerInt == z)
                {
                    flag = true;
                    Console.WriteLine("You are win!!!");
                    break;
                }

            }
            if (flag == false)
            {
                Console.WriteLine("You tries are over. The task have not been solved correctly");
            }
            else if (flag == true)
            {
                Console.WriteLine("The task have  been solved correctly");
            }
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.WriteLine("Input radius in double format.");
            string stringRadius = Console.ReadLine();
            stringRadius.Replace(',', '.');
            double radius = Convert.ToDouble(stringRadius);
            double S = Math.PI * Math.Pow(radius, 2.0);
            Console.WriteLine($"Circlearea is {S}");
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.WriteLine("Input sum of the credit body");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            List<decimal> Conatiner = new List<decimal>();
            decimal rate = 15;
            decimal ratePerMonth = rate / 12;
            decimal mainPart = sum / 12;
            for (int i = 1; i <= 12; i++)
            {
                decimal restPart = sum - mainPart * i;
                decimal procent = restPart * ratePerMonth;
                Conatiner.Add(procent);
            }
            Console.WriteLine("different payment per month");
            foreach (decimal value in Conatiner)
            {
                decimal perMonth = value + mainPart; 
                Console.WriteLine(perMonth);
            }

            decimal annuitet = sum * (ratePerMonth + ratePerMonth / Convert.ToDecimal(Math.Pow(1.0 + Convert.ToDouble(ratePerMonth), 12.0) - 1.0));
            Console.WriteLine("annuitet payment per month");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(annuitet);
            }
        }
    }
}
