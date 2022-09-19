using System;

namespace Lesson_9
{
    internal class Program
    {
        public struct BibliotekosKnyga
        {
            public int Id;
            public string Title;
            public string ReaderName;
            public DateTime TakenAt;

            public BibliotekosKnyga(int id, string title, string readerName, DateTime takenAt)
            {
                Id = id;
                Title = title;
                ReaderName = readerName;
                TakenAt = takenAt;
            }
           public int HowLongBookIsTaken()
            {
                DateTime todaysDate = DateTime.Today;
                int daysTaken = (todaysDate - TakenAt).Days;
                    return daysTaken;

            }


        }
        static void Main(string[] args)
        {
            BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(2, "Harry Potter", "Justas", new DateTime(2022, 06, 26));
            int daysTaken = bibliotekosKnyga.HowLongBookIsTaken();
            Console.WriteLine($"Days taken: {daysTaken}");

        }


    }
}
