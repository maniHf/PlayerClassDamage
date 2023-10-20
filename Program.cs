
/* Manihf Govnokod
 * s_ свойства данных 
 * m_ метод 
 * с_ класс 
 * 
 * 
 * 
 * 
 */
 
using System;
using PlayerClass;

namespace Manihf
{
    class Program
    {
        public static Player player = new Player();
        static void Main(string[] args)
        {

            Console.WriteLine("Hit-Health");
            player.m_Hit(23);
            Console.WriteLine(player.s_Health);
            Console.ReadKey();
        }
    }
}


// РЕШИТЬ ПРОБЛЕМУ С ЗДОРОВЬЕМ 