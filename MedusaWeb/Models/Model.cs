using System;
using System.Collections.Generic;

namespace MedusaWeb
{
    public class FunctionGroup
    {
        public List<ButtonGroup> ButtonGroups { get; set; }
    }
    public class ButtonGroup
    {
        public ButtonGroup()
        {
        }
        public bool RadioBehavior { get; set; }
        public bool TriState { get; set; }
        public List<string> Captions { get; set; }
    }
}
