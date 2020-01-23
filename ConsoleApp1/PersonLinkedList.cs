using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PersonLinkedList
    {
        PersonNode first;
        public PersonLinkedList()
        {
            first = new PersonNode();
        }
        public PersonLinkedList(person p)
        {
            first = new PersonNode(p);
        }
        public void add(person p)
        {
            if (first.p.name== null)
                first = new PersonNode(p);
            else
            {
                PersonNode curr = first;
                while (curr.hasNext())
                {
                    curr = curr.next;
                }
                curr.next = new PersonNode(p);
            }
        }
        public void getPerson(String name)
        {
            PersonNode curr = first;
           
        }
    }
    class PersonNode
    {

        public PersonNode next { get; set; }
        public PersonNode prev { get; set; }
        public person p { get; set; }
        public PersonNode()
        {
            p = new person(null, 0);
            prev = null;
            next = null;
        }
        public PersonNode(person p)
        {
            this.p = p;
            next = null;
            prev = null;
        }
        public PersonNode(String name, int age)
        {
            p = new person(name, age);
            next = null;
            prev = null;
        }
        public bool hasNext()
        {
            if (next == null)
                return false;
            else
                return true;
        }

    }
}
