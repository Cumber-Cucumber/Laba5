using System;
using static Laba5.laba5;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkbox checkbox1 = new Checkbox(10, 8, "blue", true);
            checkbox1.Show();
            checkbox1.Input(5);
            checkbox1.Show();
            Console.WriteLine($"Ширина: {checkbox1.Width}, высота: {checkbox1.Height}");
            Checkbox checkbox2 = new Checkbox(10, 10, "darkblue", true);
            checkbox2.Show();

            Console.WriteLine("----------------------------------------------------\n");

            Radiobutton radiobutton1 = new Radiobutton(10, "blue", true);
            radiobutton1.Input(15);
            radiobutton1.Diameter = 15;
            radiobutton1.Show();

            Console.WriteLine("----------------------------------------------------\n");

            Button button1 = new Button(false);
            button1.Show();

            Console.WriteLine("----------------------------------------------------\n");

            Checkbox checkbox3 = new Checkbox(4, 4, "red", false);
            Button button_ch3 = checkbox3 as Button; // Апкастим/работаем со ссылкой
            Control_Element cont_el1 = new Button(true);
            cont_el1.Show();
            if (cont_el1 is IControl)
            {
                IControl cont_el2 = cont_el1;
                cont_el2.Show();
            }

            Console.WriteLine("----------------------------------------------------\n");

            Control_Element[] arr = { checkbox1, checkbox2, radiobutton1, button1, cont_el1 };

            for (int i = 0; i < arr.Length; i++)
            {
                Printer.iAmPrinting(arr[i]);
            }
        }
    }
}
