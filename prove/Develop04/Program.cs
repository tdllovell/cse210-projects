using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (menu.GetSelection() != 4)
        {
            menu.SelectActivity();
        }
    }
}