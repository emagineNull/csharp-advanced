using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemon;

        public Trainer(string name, int badges, List<Pokemon> pokemon)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemons = pokemon;
        }

        public string Name { get; private set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; private set; } = new List<Pokemon>();
    }
}
