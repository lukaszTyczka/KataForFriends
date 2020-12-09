using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataForFirends
{
    /// <summary>
    /// Tutaj mozemy zaczac! 
    /// </summary>
    public class simple
    {
        // Testowa metoda czy wszystko u Ciebie działa. Test powinnien przechodzic!
        public bool Test()
        {
            return true;
        }

        // tak wyrzucamy wyjatki 
        public void ThrowExcpetion()
        {
            throw new Exception();
        }

        /// <summary>
        /// Pierwsze zadanie dla ciebie stworz metoda ktora dzieli dwie liczby ;)
        /// Tak aby wszystkie testy przeszly :)  
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public double Divaded(double number1, double number2)
        {
            return 0;
        }

        /// <summary>
        /// Wylicza roznice miedzy dwoma datami, metoda ma byc naprzemienna czyli nie ma znaczenia czy pierwsza data bedzie
        /// wieksza od drugiej czy odwrotnie.
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public int CalculateDays(DateTime date1, DateTime date2)
        {
            return 0;
        }
        /// <summary>
        /// Sumuje liczby w tablicy. Jezeli brak wartosci w tablicy zwracaj 0;
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public double SumNumbers(double[] numbers)
        {
            return 0;
        }
    }
}

// Ponizej masz rozwiazania jak to zrobic. Nie zagladaj dopoki nie zazielenisz wszystkich testow ;)












































//public double Divaded(double number1, double number2)
//{
//    if (number2 == 0)
//    {
//        throw new ArgumentException("Nie dziel cholero przez 0!");
//    }
//    return number1 / number2;
//}
//public int CalculateDays(DateTime date1, DateTime date2)
//{
//    return Math.Abs((date1 - date2).Days);
//}

//public double SumNumbers(double[] numbers)
//{
//    return numbers.Sum();
//}