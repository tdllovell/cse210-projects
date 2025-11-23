using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (menu.GetMenuInput() != 6)
        {
            menu.SelectOption();
        }
    }
}