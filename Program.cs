using System;
using System.Diagnostics;
using static Laba5.laba5;
using LB6 = Laba5.Laba6.LB6;
using static Laba5.laba7;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checkbox checkbox1 = new Checkbox(10, 8, "blue", true);
            //checkbox1.Show();
            //checkbox1.Input(5);
            //checkbox1.Show();
            //((IControl)checkbox1).Show();
            //Console.WriteLine($"Ширина: {checkbox1.Width}, высота: {checkbox1.Height}");
            //Checkbox checkbox2 = new Checkbox(10, 10, "darkblue", true);
            //checkbox2.Show();

            //Console.WriteLine("----------------------------------------------------\n");

            //Radiobutton radiobutton1 = new Radiobutton(10, "blue", true);
            //radiobutton1.Input(14);
            //radiobutton1.Diameter = 15;
            //radiobutton1.Show();

            //Console.WriteLine("----------------------------------------------------\n");

            //Button button1 = new Button(false);
            //button1.Show();
            

            //Console.WriteLine("----------------------------------------------------\n");

            //Checkbox checkbox3 = new Checkbox(4, 4, "red", false);
            //Button button_ch3 = checkbox3 as Button; // Апкастим/работаем со ссылкой
            //Control_Element cont_el1 = new Button(true);
            //cont_el1.Show();
            //if (cont_el1 is IControl)
            //{
            //    IControl cont_el2 = cont_el1;
            //    cont_el2.Show();
            //}

            //Console.WriteLine("----------------------------------------------------\n");

            //Control_Element[] arr = { checkbox1, checkbox2, radiobutton1, button1, cont_el1 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Printer.iAmPrinting(arr[i]);
            //}

            //Console.WriteLine("------------------------Laba6------------------------\n");

            //UI array = new UI(10);
            //array.Add(checkbox1);
            //array.Add(radiobutton1);
            //array.Add(checkbox2);
            //array.Add(button1);
            //array.Add(cont_el1);
            //array.Show();

            //Controller.Show(array);

            //Console.WriteLine($"Площадь, занимаемая кнопками: {Controller.Get_Area(array)}");
            //Console.WriteLine($"И если проверить, то 8*10 + 10*10 + 7*7*pi = {8 * 10 + 10 * 10 + 7 * 7 * Math.PI}");


            //Console.WriteLine("----------------------------------------------------\n");

            //LB6.Structure VicktorSilin;

            //VicktorSilin.num = 1;
            //VicktorSilin.str = "samiy silniy";

            //Console.WriteLine($"Виктор Силин номер {VicktorSilin.num}, Виктор Силин {VicktorSilin.str}");
            //Console.WriteLine($"Он родился не {LB6.Enumeration.one} числа, не {LB6.Enumeration.two} числа, не {(int)(LB6.Enumeration.three)} числа, не {(int)(LB6.Enumeration.five)} числа, не {(int)(LB6.Enumeration.six)} числа, а 31");

            Console.WriteLine("------------------------Laba7------------------------\n");

            try
            {
                Checkbox checkbox_exception1 = new Checkbox(1000, 8, "blue", true);
            }
            catch (CheckboxHeightExemption ex)
            {
                Console.WriteLine($"Ошибка высоты чекбокса:  {ex.Message}");
                Console.WriteLine($"Ошибочное значение:  {ex.Value}\n");
            }

            try
            {
                Checkbox checkbox_exception2 = new Checkbox(6, 900, "green", true);
            }
            catch (CheckboxWidthExemption ex)
            {
                Console.WriteLine($"Ошибка ширины чекбокса:  {ex.Message}");
                Console.WriteLine($"Ошибочное значение:  {ex.Value}\n");
            }

            try
            {
                Radiobutton radiobutton_exeption = new Radiobutton(0, "blue", true);
            }
            catch (RadiobuttonDiameterExemption ex)
            {
                Console.WriteLine($"Ошибка радиобаттона:  {ex.Message}");
                Console.WriteLine($"Ошибочное значение:  {ex.Value}\n");
            }
            try
            {
                Button button_exeption = new Button(false);
            }
            catch (NotClickableButton ex)
            {
                Console.WriteLine($"Ошибка кнопки:  {ex.Message}\n");
            }
            try
            {
                int a = 10;
                int b = a / 0;
            }
            catch
            {
                Console.WriteLine($"Тут ващет деление на ноль\n");
            }

            try
            {
                int i = -1;
                Debug.Assert(i > 0, "Отрицательное число. Перехвачено при помощи Assert");
                Checkbox checkbox_exception1 = new Checkbox(1000, 8, "blue", true);
                Checkbox checkbox_exception2 = new Checkbox(6, 900, "green", true);
                Radiobutton radiobutton_exeption = new Radiobutton(0, "blue", true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Первое попавшееся исключение: {ex.Message}\n");
            }
            finally
            {
                Console.WriteLine($"В любом случае это будт видно, а зачем?");
            }
        }                    
    }
}
