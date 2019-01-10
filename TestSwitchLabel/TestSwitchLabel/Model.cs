using System;
using System.Collections.Generic;

namespace MedusaDemo
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

    public class TestData
    {
        public static FunctionGroup GenerateFake()
        {
            return new FunctionGroup
            {
                ButtonGroups = new List<ButtonGroup>
            {
                new ButtonGroup
                {
                    RadioBehavior = false,
                    TriState = false,
                    Captions = new List<string> {"Respiration", "Pulse"}

                },
                new ButtonGroup
                {
                    RadioBehavior = true,
                    TriState = false,
                    Captions = new List<string> {"Low", "Medium", "High"}

                },
                new ButtonGroup
                {
                    RadioBehavior = false,
                    TriState = true,
                    Captions = new List<string> {"Allergic", "Hypotensive", "Shock", "Ambulatory"}

                },
                new ButtonGroup
                {
                    RadioBehavior = true,
                    TriState = false,
                    Captions = new List<string> { "Infant", "Child", "Adult", "Elderly" }

                },
                new ButtonGroup
                {
                    RadioBehavior = false,
                    TriState = false,
                    Captions = new List<string> { "Blood Type", "Height", "Weight", "Category" }

                },
                new ButtonGroup
                {
                    RadioBehavior = true,
                    TriState = false,
                    Captions = new List<string> {"Red", "Yellow", "Green"}

                },

            }
            };
        }
    }
}
