using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;

        public int ID { get; set; } = -1;

        public Repository()
        {
            data = new Dictionary<int, Person>();
        }

        public void Add(Person person)
        {
            data.Add(this.ID + 1, person);
            this.ID += 1;
        }

        public Person Get(int id)
        {
            var kvp = new KeyValuePair<int, Person>();
            foreach (var personAndID in data)
            {
                if (personAndID.Key == id)
                {
                    kvp = personAndID;
                }
            }

            return kvp.Value;
        }

        public bool Update(int id, Person newPerson)
        {
            foreach (var kvp in data)
            {
                if (kvp.Key == id)
                {
                    data[id] = newPerson;
                    return true;
                }
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (data.Any(x => x.Key == id))
            {
                data.Remove(id);
                return true;
            }

            return false;
        }

        public int Count
        {
            get { return data.Count; }
        }
    }
}
