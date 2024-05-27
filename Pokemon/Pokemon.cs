using System.Reflection.Metadata.Ecma335;

namespace Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Pokemon pokemon &&
                   Id == pokemon.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Type} - {Level}"; 
        }
    }
}
