using System;
using System.Collections.Generic;

namespace NetAcademy_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant participant = new Participant("Sharipov", "Marat", new List<float> { 5, 5, 4 });
            Participant participant1 = new Participant("Ivanov", "Ivan", new List<float> { 4, 3, 3 });
            Participant participant2 = new Participant("Petrov", "Serghei", new List<float> { 5, 3, 3 });
            Participant participant3 = new Participant("Josan", "Jane", new List<float> { 4, 5, 3 });
            

            Repository repository = new Repository();
            repository.AddParticipant(participant);
            repository.AddParticipant(participant1);
            repository.AddParticipant(participant2);
            repository.AddParticipant(participant3);

            repository.PrintMessage();
            Console.ReadKey();

        }
    }
}
