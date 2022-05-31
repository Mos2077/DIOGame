namespace DIO.Abstracao.RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack()
        {
            return Name + " Atacou com sua magia!!";
        }
    }
}