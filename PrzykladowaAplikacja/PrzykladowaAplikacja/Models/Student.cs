
namespace PrzykladowaAplikacja.Models
{
    public class Student
    {
        //Dane
        //Skrócona właściwość
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string ImieINazwisko { 
            get
            {
                return Imie + " " + Nazwisko;
            } 
        }

    }
}
