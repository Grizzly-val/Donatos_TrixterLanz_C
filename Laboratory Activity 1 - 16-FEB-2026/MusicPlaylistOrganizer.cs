using System;

class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        

        if (Int32.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine();
            Song[] songs = new Song[n];
            double totalDuration = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Song #{i + 1}");
                Console.Write("Title: ");
                string title = Console.ReadLine() ?? "";

                Console.Write("Artist: ");
                string artist = Console.ReadLine() ?? "";

                Console.Write("Duration (minutes): ");

                double duration;
                if (Double.TryParse(Console.ReadLine(), out duration)) { } 
                else { duration = 0.0; };

                Song addSong;
                if (title == "" && artist == "" && duration == 0.0)
                {
                    addSong = new Song();
                }
                else
                {
                    if (title == "") title = "Unknown";
                    if(artist == "") artist = "Unknown";
                    addSong = new Song(title, artist, duration);
                }

                Console.WriteLine();



                totalDuration += addSong.getDuration();

                songs[i] = addSong;
            }

            Console.WriteLine("=== || MY PLAYLIST || ===");
            Console.WriteLine("{0,-20} {1,-20} {2,6}", "Title", "Artist", "Time");
            Console.WriteLine("---------------------------------------------------------");
            foreach (Song s in songs)
            {
                s.DisplaySong();
            }
            Console.WriteLine();

            Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
            double avgDuration = totalDuration / n;
            Console.WriteLine($"Average Duration: {avgDuration:F2} mins");


        } else
        {
            Console.WriteLine("Invalid Input!");
            return;
        }



    }
}


class Song
{
    private string title;
    private string artist;
    private double duration;

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public double getDuration() { return this.duration; }
    public Song(string title, string artist) : this(title, artist, 0.0) { }
    public Song() : this("Unknown", "Unknown", 0.0) { }
    

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-20} {2,6:F2}", this.title, this.artist, this.duration);
    }
}