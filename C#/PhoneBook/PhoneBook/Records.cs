using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{


    public struct SItem
    {
        public string LName;  //фамилия
        public string FName;  //имя
        public ulong Phone; //номер телефона
        public string Email; //эл. почта
    }
    internal class Records 
    {
        private static SItem[] notes = new SItem[0];

        public static void AddItem(SItem item)
        {
            int len = notes.Length;
            Array.Resize(ref notes, len + 1);
            notes[len] = item;
        }

        public static bool GetItem(int index, out SItem item)
        {
            if (index >= 0 && index < notes.Length)
            {
                item = notes[index];
                return true;
            }
            else 
            {
                item = new SItem();
                return false;
            }
        }

        public static int GetLength() 
        {
            return notes.Length;
        }

    }
}
