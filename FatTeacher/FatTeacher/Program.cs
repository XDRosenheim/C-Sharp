using System;

namespace FatTeacher
{
    class Program
    {

        private static void Main()
        {
            Teacher teacher = new Teacher("Jan", 50);

            Console.WriteLine(teacher.ToString());

            while (teacher.IsAwake)
            {
                teacher.FeedTeacher(5); // If awake, feed it...
            }
            // Du skrev ikke hvad der skulle ske når timeren gik igang... Bare at den skulle startes...
            Console.WriteLine("{0} is sleeping...", teacher.Name);
            Console.ReadKey();
        }
    }
}
