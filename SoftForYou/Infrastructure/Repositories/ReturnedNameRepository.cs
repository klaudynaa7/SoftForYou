using Domain.ExampleNames;
using Domain.ReturnedNames;

namespace Infrastructure.Repositories
{
    public class ReturnedNameRepository : Repository<ExampleNames>, IReturnedNameRepository
    {
        public ReturnedNameRepository()
        {
            List.Add(new ExampleNames("Stefan", "Maj"));
            List.Add(new ExampleNames("Judyta", "Wilk"));
            List.Add(new ExampleNames("Brajan", "Kozieł"));
            List.Add(new ExampleNames("Michał", "Kowalczyk"));
            List.Add(new ExampleNames("Zenona", "Wrona"));
            List.Add(new ExampleNames("Sergiusz", "Klimek"));
            List.Add(new ExampleNames("Michał", "Bąk"));
            List.Add(new ExampleNames("Stanisław", "Mucha"));
            List.Add(new ExampleNames("Agnieszka", "Michalak"));
            List.Add(new ExampleNames("Waldemar", "Bednarek"));
            List.Add(new ExampleNames("Mykhailo", "Olejnik"));
            List.Add(new ExampleNames("Dagmara", "Michalik"));
            List.Add(new ExampleNames("Albert", "Skiba"));
            List.Add(new ExampleNames("Sylwia", "Duda"));
            List.Add(new ExampleNames("Helena", "Pietrzak"));
            List.Add(new ExampleNames("Kalina", "Urban"));
            List.Add(new ExampleNames("Aleksander", "Szymczak"));
            List.Add(new ExampleNames("Dmytro", "Leśniak"));
            List.Add(new ExampleNames("Nicola", "Polak"));
            List.Add(new ExampleNames("David", "Krawczyk"));
            List.Add(new ExampleNames("Bożena", "Jóźwiak"));
            List.Add(new ExampleNames("Bernard", "Stasiak"));
            List.Add(new ExampleNames("Edward", "Nowak"));
            List.Add(new ExampleNames("Aldona", "Szulc"));
            List.Add(new ExampleNames("Wacława", "Kozioł"));
            List.Add(new ExampleNames("Arleta", "Jarosz"));
            List.Add(new ExampleNames("Lesław", "Olejniczak"));
            List.Add(new ExampleNames("Ivan", "Marciniak"));
            List.Add(new ExampleNames("Vasyl", "Mazur"));
            List.Add(new ExampleNames("Bohdan", "Bednarczyk"));
            List.Add(new ExampleNames("Włodzimierz", "Wieczorek"));
            List.Add(new ExampleNames("Genowefa", "Sikora"));
            List.Add(new ExampleNames("Zygmunt", "Szewczyk"));
            List.Add(new ExampleNames("Natalia", "Kubiak"));
            List.Add(new ExampleNames("Patryk", "Tomczyk"));
            List.Add(new ExampleNames("Sylwester", "Mróz"));
            List.Add(new ExampleNames("Mykola", "Krupa"));
            List.Add(new ExampleNames("Bogdan", "Wawrzyniak"));
            List.Add(new ExampleNames("Damian", "Pawlak"));
            List.Add(new ExampleNames("Wiesława", "Sowa"));
            List.Add(new ExampleNames("Adrianna", "Kołodziejczyk"));
            List.Add(new ExampleNames("Olivier", "Żak"));
            List.Add(new ExampleNames("Maciej", "Zając"));
            List.Add(new ExampleNames("Andrii", "Socha"));
            List.Add(new ExampleNames("Lesław", "Grzelak"));
            List.Add(new ExampleNames("Agnieszka", "Kaczmarczyk"));
            List.Add(new ExampleNames("Aleks", "Walczak"));
            List.Add(new ExampleNames("Lech", "Sobczak"));
            List.Add(new ExampleNames("Leonarda", "Kasprzak"));
        }
        public ValueTask InsertAsync(string name)
        {
            throw new NotImplementedException();
        }

        string IReturnedNameRepository.GenerateName()
        {
            Random random = new Random();

            if (!List.Any())
            {
                throw new Exception();
            }

            int indexOfName = random.Next(List.Count);
            int indexOfLastName;

            do
            {
                indexOfLastName = random.Next(List.Count);
            } while (indexOfLastName == indexOfName);

            ExampleNames randomFirstName = List[indexOfName];
            ExampleNames randomLastName = List[indexOfLastName];

            string result = $"{randomFirstName.FirstName} {randomLastName.LastName}";
            return result;
        }
    }
}
