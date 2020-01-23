using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class people
    {
        private int size;
        private int numberOfPeople;
        private person[] listOfPeople;
        public people()
        {
            listOfPeople = new person[10];
            numberOfPeople = 0;
        }
        
        private void makeArrayLarger()
        {
            int newSize = size * 2;
            person[] largerList = new person[newSize];
            for(int i = 0; i<numberOfPeople; i++)
            {
                largerList[i] = listOfPeople[i];
            }
            listOfPeople = largerList;
            size = newSize;
        }
        public bool add(person p)
        {
            if (numberOfPeople == size - 1)
                makeArrayLarger();
            try 
            {
                listOfPeople[numberOfPeople] = p;
            }
            catch
            {
                Console.WriteLine("failed");
                return false;
            }
            numberOfPeople++;
            return true;
        }
        public person getPerson(string name)
        {
            for(int i = 0; i < numberOfPeople; i++)
            {
                if (listOfPeople[i].name == name)
                    return listOfPeople[i];

            }
            return null;
        }
        public void showEveryone()
        {
            foreach(person p in listOfPeople) // this should be largerList somehow?
            {
                if (p == null)
                    return;

                Console.WriteLine(p.name);
            }
        }
    }
}
