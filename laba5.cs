using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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
            int Height { get; }
            int Width { get; }
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
        public class Button : Control_Element
        {
            public bool Clickable { get; set; }

            public Button(bool _clicable)
            {
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
            public int Height { get; }
            public int Width { get; }
            public string Color { get; }

            public Checkbox(int _height, int _width, string _color, bool __clicable) : base(__clicable)
            {
                Height = _height;
                Width = _width;
                Color = _color;
            }

            new public void Show()
            {
                Console.WriteLine("Сведения о checkbox:");
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
            public int Diameter { get; set; }
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

    }
}
