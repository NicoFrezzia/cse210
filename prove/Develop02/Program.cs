using System;

// Enhancements: 
// 1. Improved file handling by supporting CSV format for better compatibility with Excel.
// 2. Included an additional field in the journal entry to store mood/emotion.
// 3. Implemented a reminder system to encourage journaling consistency.

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}