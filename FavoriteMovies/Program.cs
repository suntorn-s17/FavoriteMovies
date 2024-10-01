namespace FavoriteMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();
            movies.Add("Inception");
            movies.Add("Interstellar");
            movies.Add("Spider-Man: Across the Spider-Verse");

            while (true)
            {
                Console.WriteLine("My Favorite Movies : ");
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie);
                }

                Console.WriteLine("\n(1) Add movie");
                Console.WriteLine("(2) Delete movie");
                Console.WriteLine("(3) Exit");
                Console.Write("Select an option : ");
                int select;

                if (!int.TryParse(Console.ReadLine(), out select) || select < 1 || select > 3)
                {
                    Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
                    continue;
                }

                if (select == 1)
                {
                    Console.Write("Name of movie : ");
                    string newMovie = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newMovie))
                    {
                        movies.Add(newMovie);
                        Console.WriteLine($"Added : {newMovie}");
                    }
                    else
                    {
                        Console.WriteLine("Movie name cannot be empty.");
                    }
                }
                else if (select == 2)
                {
                    Console.Write("Name of movie : ");
                    string removeMoive = Console.ReadLine();
                    if (movies.Remove(removeMoive))
                    {
                        Console.WriteLine($"Removed : {removeMoive}");
                    }
                    else
                    {
                        Console.WriteLine($"Moive '{removeMoive}' not found.");
                    }
                }
                else if (select == 3)
                {
                    Console.WriteLine("Exit Program.");
                    break;
                }
            }
        }
    }
}
