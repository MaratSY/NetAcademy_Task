
using System.Collections.Generic;


namespace NetAcademy_Task
{
    /// <summary>
    /// Участники встречи
    /// </summary>
    class Participant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        
        public List<float> Grades { get; set; } //список оценок за пройденные задания
        public float AverageGrade { get; private set; } //средний балл

        /// <summary>
        /// метод передает значение в AverageGrade
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        private float GetAverageGrade(List<float> grades)
        {
            if (grades !=null)
            {
                float sum = 0;
                float result = 0;
                foreach (var grade in grades)
                {                 
                    sum+= grade;
                }
                result = sum / grades.Count;
                return result;
            }
            else
            {
                return 0;
            }
            

        }
        public Participant(string lastName, string firstName, List<float> grades)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Grades = grades;
            this.AverageGrade = GetAverageGrade(Grades);
        }
    }
}
