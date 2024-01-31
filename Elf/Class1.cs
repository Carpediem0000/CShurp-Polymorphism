namespace Elf
{
    public abstract class Elf
    {
        public string Name;
    }

    public abstract class ElvenMystic : Elf
    {
        public string Weapon;
        public int Health;
        public int Attack;
        public int Lvl;
        virtual public void Atack() { }
        virtual public void Voice() { }
    }

    public class ElvenWizard : ElvenMystic
    {
        public ElvenWizard(string name, string weapon, int lvl)
        {
            Name = name;
            Weapon = weapon;
            Health = lvl*500;
            Attack = lvl*5;
            Lvl = lvl;
        }
        public override void Atack()
        {
            Console.WriteLine("ElvenWizard atack");
        }

        public override void Voice()
        {
            Console.WriteLine("ElvenWizard voice");
        }
    }
    public class EleventalSummoner : ElvenWizard
    {
        public EleventalSummoner(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("EleventalSummoner atack");
        }

        public override void Voice()
        {
            Console.WriteLine("EleventalSummoner voice");
        }
    }
    public class EleventalMaster : EleventalSummoner
    {
        public EleventalMaster(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("EleventalMaster atack");
        }

        public override void Voice()
        {
            Console.WriteLine("EleventalMaster voice");
        }
    }

    public class Spellsinger : ElvenWizard
    {
        public Spellsinger(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("Spellsinger atack");
        }

        public override void Voice()
        {
            Console.WriteLine("Spellsinger voice");
        }
    }
    public class MysticMuse : Spellsinger
    {
        public MysticMuse(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("MysticMuse atack");
        }

        public override void Voice()
        {
            Console.WriteLine("MysticMuse voice");
        }
    }

    public class ElvenOracle : ElvenMystic
    {
        public ElvenOracle(string name, string weapon, int lvl)
        {
            Name = name;
            Weapon = weapon;
            Health = lvl * 350;
            Attack = lvl * 3;
            Lvl = lvl;
        }
        public override void Atack()
        {
            Console.WriteLine("ElvenOracle atack");
        }

        public override void Voice()
        {
            Console.WriteLine("ElvenOracle voice");
        }
    }
    public class ElvenElder : ElvenOracle
    {
        public ElvenElder(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("ElvenElder atack");
        }

        public override void Voice()
        {
            Console.WriteLine("ElvenElder voice");
        }
    }
    public class EuasSaint : ElvenElder
    {
        public EuasSaint(string name, string weapon, int lvl) : base(name, weapon, lvl) { }
        public override void Atack()
        {
            Console.WriteLine("EuasSaint atack");
        }

        public override void Voice()
        {
            Console.WriteLine("EuasSaint voice");
        }
    }
}
