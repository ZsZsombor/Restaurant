using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class Menu
    {
        private int _selectedOptionIndex = 0;
        private readonly List<Action> _actions = new List<Action>();
        private readonly List<string> _labels = new List<string>();
        private readonly ConsoleColor _highlightColor = ConsoleColor.Green;

        public void AddOption(string label, Action action)
        {
            _labels.Add(label);
            _actions.Add(action);
        }

        public void Show()
        {
            while (true)
            {
                DisplayMenuOptions();

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    MoveSelectionUp();
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    MoveSelectionDown();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    ExecuteSelectedOption();
                    if (_selectedOptionIndex == _actions.Count - 1)
                    {
                        return;
                    }
                }
            }
        }

        private void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Select an option using Up and Down arrows.");

            for (int i = 0; i < _labels.Count; i++)
            {
                if (i == _selectedOptionIndex)
                {
                    Console.ForegroundColor = _highlightColor;
                    Console.WriteLine($">> {_labels[i]} <<");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"   {_labels[i]}");
                }
            }
        }

        private void MoveSelectionUp()
        {
            _selectedOptionIndex = (_selectedOptionIndex - 1 + _labels.Count) % _labels.Count;
        }

        private void MoveSelectionDown()
        {
            _selectedOptionIndex = (_selectedOptionIndex + 1) % _labels.Count;
        }

        private void ExecuteSelectedOption()
        {
            Console.Clear();
            _actions[_selectedOptionIndex]();
        }
    }
}
