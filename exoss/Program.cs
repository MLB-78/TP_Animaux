using exoss;

class Program
{
    static void Main()
    {
        List<Animal> animaux = new List<Animal>();

        // Instanciation des animaux
        Loup loup = new Loup(25, "Gris");
        Chien chien = new Chien("Marron", 10);
        Lion lion = new Lion(180, "Doré");
        Tigre tigre = new Tigre(200, "Rayé");

        // Ajout des animaux à la liste
        animaux.Add(loup);
        animaux.Add(chien);
        animaux.Add(lion);
        animaux.Add(tigre);

        // Affichage des informations de chaque animal
        foreach (Animal animal in animaux)
        {
            Console.WriteLine(animal);
            Console.WriteLine();
        }
    }
}