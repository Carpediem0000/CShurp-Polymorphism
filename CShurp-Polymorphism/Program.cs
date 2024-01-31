using Elf;
namespace CShurp_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElvenMystic elvenWizard = new ElvenWizard("ElvenWizard", "Posoh", 5);
            elvenWizard.Atack();
            elvenWizard.Voice();

            ElvenMystic eleventalSummoner = new EleventalSummoner("EleventalSummoner", "Posoh", 15);
            eleventalSummoner.Atack();
            eleventalSummoner.Voice();

            ElvenMystic eleventalMaster = new EleventalMaster("EleventalMaster", "Posoh", 45);
            eleventalMaster.Atack();
            eleventalMaster.Voice();

            ElvenMystic spellsinger = new Spellsinger("Spellsinger", "Posoh", 1);
            spellsinger.Atack();
            spellsinger.Voice();

            ElvenMystic mysticMuse = new MysticMuse("MysticMuse", "Posoh", 7);
            mysticMuse.Atack();
            mysticMuse.Voice();

            ElvenMystic elvenOracle = new ElvenOracle("ElvenOracle", "Posoh", 100);
            elvenOracle.Atack();
            elvenOracle.Voice();

            ElvenMystic elvenElder = new ElvenElder("ElvenElder", "Posoh", 32);
            elvenElder.Atack();
            elvenElder.Voice();

            ElvenMystic euasSaint = new EuasSaint("EuasSaint", "Posoh", 61);
            euasSaint.Atack();
            euasSaint.Voice();
        }
    }
}
