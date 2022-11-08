using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day_planner
{
    class start
    {
        public void begin()
        {
            Title = "Мой ежедневник";
            RunmainMenu();
            ReadKey(true);
        }
        private void RunmainMenu()
        {
            while (true)
            {
                //здесь объявление той самой переключаемой между днями
                //А здесь у нас условие
                /// if (perecl == 0) 
                /// {
                /// string start = "Напоминание на 07.11";
                /// string[] options = { "1. Сделать практические", "2. Дочитать книгу 'Возвышение Хоруса'" };
                /// Menu mainMenu = new Menu(start, options);
                /// int Index = mainMenu.strelocki();
                ///switch (Index)
                ///{
                ///    case 0:
                ///        Opisanie1();
                ///        break;
                ///    case 1:
                ///        Opisanie2();
                ///        break;
                ///    default:
                ///        break;
                /// }
                /// }
                /// else if (perecl == 1)
                /// {
                /// string start = "Напоминание на 08.11";
                /// string[] options = { "1. Сделать другое то", "2. Хочу выполнить" };
                /// Menu mainMenu = new Menu(start, options);
                ///switch (Index)
                ///{
                ///    case 0:
                ///        Opisanie3();
                ///        break;
                ///    case 1:
                ///        Opisanie4();
                ///        break;
                ///    default:
                ///        break;
                /// }
                /// и так далее
                string start = "Напоминание на 07.11";
                string[] options = { "1. Сделать практические", "2. Дочитать книгу 'Возвышение Хоруса'" };
                Menu mainMenu = new Menu(start, options);
                int Index = mainMenu.strelocki();
                switch (Index)
                {
                    case 0:
                        Opisanie1();
                        break;
                    case 1:
                        Opisanie2();
                        break;
                        default:
                        break;
                }
            }
            
        }
        private void Opisanie1()
        {
            Clear();
            string start = "Напоминание на 07.11.22 по поводу практических работ";
            string[] options = { "Выполнить практические по: Программированию(((, Дис.математике, Выс.математике", "Сделать до 09.11.22" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
            
        }
        private void Opisanie2()
        {
            string start = "Напоминание на 07.21.22 по поводу практических работ";
            string[] options = { "Выполнить практические по: Программированию(((, Дис.математике, Выс.математике", "Сделать до 09.11.22" };
            Menu opis1 = new Menu(start, options);
            int index = opis1.strelocki();
        }
    }
}
