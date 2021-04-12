using System;
using System.Collections.Generic;
using System.Linq;


namespace NetAcademy_Task
{
    class Repository
    {
        public List<Participant> participants; //список участников
        
        public Repository()
        {
            this.participants = new List<Participant>();
        }
        public void AddParticipant(Participant participant)
        {
            this.participants.Add(participant);
            
        }
        /// <summary>
        /// выводит сообщение о приглашении участников со средним баллом >=4
        /// </summary>
        public void PrintMessage() 
        {
            var message = from p in participants
                          where p.AverageGrade >= 4
                          select p;
            List<Participant> selectedParticipants = message.ToList();

            Console.Write($"Привет");
                foreach(var p in selectedParticipants)
                Console.Write($", {p.LastName}.{p.FirstName.First()}"); Console.Write("! Приходите к нам на интервью.");
        } 
    }
}
