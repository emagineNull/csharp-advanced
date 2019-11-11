﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.people
                .OrderByDescending(m => m.Age)
                .FirstOrDefault();
        }

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
    }
}
