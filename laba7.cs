using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    class laba7
    {
        public class NotClickableButton : Exception
        {
            public NotClickableButton(string message) : base(message) { }
        }
        public class CheckboxHeightExemption : Exception
        {
            public int Value { get; }
            public CheckboxHeightExemption(string message, int val) : base(message) 
            {
                Value = val;
            }
        }
        public class CheckboxWidthExemption : Exception
        {
            public int Value { get; }
            public CheckboxWidthExemption(string message, int val) : base(message)
            {
                Value = val;
            }
        }
        public class RadiobuttonDiameterExemption : Exception
        {
            public int Value { get; }
            public RadiobuttonDiameterExemption(string message, int val) : base(message)
            {
                Value = val;
            }
        }
    }
}
