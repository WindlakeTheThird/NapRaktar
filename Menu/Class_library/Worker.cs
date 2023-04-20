namespace Class_library
{
    public class Worker
    {
        public int Id { get; set; }
        public string Nev { get; set; }

        public Worker(int id, string nev)
        {
            Id = id;
            Nev = nev;
        }
        public Worker()
        {
        }

    }
}
