using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static Laba5.laba7;

namespace Laba5
{
    class laba5
    {
        sealed class NONONO
        {

        }
        interface IGeometric_Figure
        {
            string Color { get; }
        }
        interface ICircle : IGeometric_Figure
        {
            int Diameter { get; set; }
        }
        interface IRectangle : IGeometric_Figure
        {
            int Height { get; set; }
            int Width { get; set; }
        }
        public interface IControl
        {
            void Show();
            void Input(int size);
            void Resize(int size);
        }

        public abstract class Control_Element : IControl
        {
            protected int size;

            public virtual void Show()
            {
                Console.WriteLine("Если это сообщение видно, значит в дочернем классе не реализован метод Scow() или метод вызывается из базового (этого) класса");
            }
            public void Input(int _size)
            {
                size += _size;
            }
            public void Resize(int _size)
            {
                size = _size;
            }

        }
        public partial class Button : Control_Element
        {
            public bool Clickable { get; set; }

            public Button(bool _clicable)
            {
                if (_clicable == false)
                {
                    throw new NotClickableButton("Создаваемые кнопки должны быть кликабельны! Этож кнопки, але"); // Искючение в конструкторе
                }
                Clickable = _clicable;
            }
            new public void Show()
            {
                Console.WriteLine("Сведения о button:");
                Console.WriteLine($"Изменяемый параметр: {size}, кликабельность: {Clickable}");
            }

            public override bool Equals(object obj) // Переопределение
            {
                if (obj.GetType() == this.GetType()) // Преколы с получением типа объекта и сравнения его с типом проверяемого объекта (текущего)
                    return true;
                else
                    return false;
            }
            public override string ToString() // Переопределение
            {
                Console.WriteLine("Сведения о button:");
                Console.WriteLine($"Изменяемый параметр: {size}, кликабельность: {Clickable}");
                return "";
            }
            public int gethashcode_class_parameter;
            public override int GetHashCode() // Переопределение
            {
                return gethashcode_class_parameter * gethashcode_class_parameter / 8;
            }
        }
        public class Checkbox : Button, IRectangle, IControl
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public string Color { get; }

            public Checkbox(int _height, int _width, string _color, bool __clicable) : base(__clicable)
            {
                if (_height < 3 || _height > 400)
                {
                    throw new CheckboxHeightExemption("Высота чекбокса не может принимать данное значение!", _height); // Искючение в конструкторе
                }
                if (_width < 3 || _width > 400)
                {
                    throw new CheckboxWidthExemption("Ширина чекбокса не может принимать данное значение!", _width);
                }
                Height = _height;
                Width = _width;
                Color = _color;
            }

            new public void Show()
            {
                Console.WriteLine("Сведения о checkbox:");
                Console.WriteLine($"Изменяемый параметр: {size}, цвет: {Color}, величины: {Width}x{Height}");
            }

            void IControl.Show()
            {
                Console.WriteLine("Этот метод переопределён от интерфеса. Сведения о checkbox:");
                Console.WriteLine($"Изменяемый параметр: {size}, цвет: {Color}, величины: {Width}x{Height}");
            }

            public override string ToString() // Переопределение
            {
                Console.WriteLine("Сведения о checkbox:");
                Console.WriteLine($"Изменяемый параметр: {size}, цвет: {Color}, величины: {Width}x{Height}");
                return "";
            }
        }
        public class Radiobutton : Button, ICircle, IControl
        {
            private int diam;
            public int Diameter
            {
                get { return diam; }
                set
                {
                    if (value < 4 || value > 400)
                    {
                        throw new RadiobuttonDiameterExemption("Диаметр радиобаттона не может принимать данное значение!", value); // Искючение в свойстве
                    }
                    else
                        diam = value;
                }
            }
            public string Color { get; }

            public Radiobutton(int _diameter, string _color, bool __clicable) : base(__clicable)
            {
                Diameter = _diameter;
                Color = _color;
            }

            new public void Show()
            {
                Console.WriteLine("Сведения о radiobutton:");
                Console.WriteLine($"Изменяемый параметр: {size}, цвет: {Color}, диаметр: {Diameter}");
            }

            public override string ToString() // Переопределение
            {
                Console.WriteLine("Сведения о radiobutton:");
                Console.WriteLine($"Изменяемый параметр: {size}, цвет: {Color}, диаметр: {Diameter}");
                return "";
            }
        }


        public class Printer
        {
            public static void iAmPrinting(Control_Element someobj)
            {
                Console.WriteLine(someobj.GetType());
                Console.WriteLine(someobj.ToString());
            }
        }

        public partial class LB6
        {

        }








        public class UI
        {
            public static Control_Element[] array;
            public int count = 0;
            public static int size;


            public UI(int a)
            {
                size = a;
                array = new Control_Element[a];
            }

            public bool Check_Full()
            {
                return (count == size);
            }

            public bool Check_Empty()
            {
                return (count == 0);
            }

            public void Add(Control_Element el)
            {
                if (Check_Full())
                    return;
                array[count++] = el;
            }

            public void Del(Control_Element el)
            {
                int num = 0;
                if (Check_Empty())
                    return;
                for (int i = 0; i < count; i++)
                {
                    if (array[i].Equals(el))
                        num = i;
                }
                for (int i = num; i < count; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }

            public void Show()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
                Console.WriteLine();
            }
        }


        public static class Controller
        {


            public static void Show(UI arr)
            {
                string[] elements = new string[10];
                int[] count = new int[10];
                int allcount = 0;
                int position = 0;
                bool mark = true;  

                for (int j = 0; j < arr.count; j++)
                {
                    for (int i = 0; i < position; i++)
                    {
                        if (elements[i] == (UI.array[j].GetType()).Name)
                        {
                            mark = false;
                            count[i]++;
                            allcount++;
                            break;
                        }
                    }
                    if (mark)
                    {
                        elements[position] = UI.array[j].GetType().Name;
                        count[position]++;
                        allcount++;
                        position++;
                    }
                    mark = true;
                }

                Console.WriteLine("Типы элементов массива объектов: ");
                for (int i = 0; i < position; i++)
                {
                    Console.WriteLine($"{elements[i]} в количестве {count[i]}");
                }
                Console.WriteLine();
                Console.WriteLine($"Общее количество объектов: {allcount}");
                Console.WriteLine();

            }

            public static double Get_Area(UI arr)
            {
                double area = 0;
                for (int j = 0; j < arr.count; j++)
                {
                    if (UI.array[j].GetType().Name == "Button")
                        continue;
                    if (UI.array[j].GetType().Name == "Radiobutton")
                    {
                        area += Math.Pow(((Radiobutton)UI.array[j]).Diameter / 2, 2) * Math.PI;
                        continue;
                    }
                       
                    if (UI.array[j].GetType().Name == "Checkbox")
                    {
                        area += ((Checkbox)UI.array[j]).Width * ((Checkbox)UI.array[j]).Height;
                        continue;
                    }
                }
                return area;
            }
        }
    }
}
