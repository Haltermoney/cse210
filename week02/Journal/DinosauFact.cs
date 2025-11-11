public class DinosaurFacts
{
    public List<string> _dinoFacts = new List<string> { "Suchosaurus is technically a prehistoric reptile that can swim in water", "The longest dinosaur is the Diplodocus", "The smallest dinosaur is a Compsognathus \"Compy\"", "The Pterodactyl and Quetzalcoatlus can fly", "The Triceratops is an herbivore but the babies will eat meat to grow strong", "The Dimetrodon is not a dinosaur, it is a prehistoric reptile", "Because the Pterodactyl doesn\'t have teeth it is considered a prehistoric reptile", "The things on the back of a Stegosaurus are called spines" };
    public string GetDinosaurFacts()
    {
        Random random = new Random();
        int randomNumber = random.Next(_dinoFacts.Count);
        return _dinoFacts[randomNumber];
    }
}