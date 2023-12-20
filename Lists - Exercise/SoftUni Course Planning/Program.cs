namespace SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                List<string> commands = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] == "Add")
                {
                    string lesson = commands[1];
                    AddLesson(schedule, lesson);
                }
                else if (commands[0] == "Insert")
                {
                    string lesson = commands[1];
                    int index = int.Parse(commands[2]);
                    InsertLesson(schedule, lesson, index);
                }
                else if (commands[0] == "Remove")
                {
                    string lesson = commands[1];
                    RemoveLesson(schedule, lesson);

                }
                else if (commands[0] == "Swap")
                {
                    string lesson1 = commands[1];
                    string lesson2 = commands[2];
                    SwapLessons(schedule, lesson1, lesson2);
                }
                else if (commands[0] == "Exercise")
                {
                    string lesson = commands[1];
                    AddLesson(schedule, lesson);
                    AddExercise(schedule, lesson);
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
        static void AddExercise(List<string> schedule, string lesson)
        {
            int lessonIndex = schedule.IndexOf(lesson);

            string exercise = $"{lesson}-Exercise";

            if (lessonIndex == schedule.Count - 1)
            {
                schedule.Add(exercise);
                return;
            }
            else
            {
                if (schedule[lessonIndex + 1] != exercise)
                {
                    schedule.Insert(lessonIndex + 1, exercise);
                    return;
                }
            }
        }
        static void SwapLessons(List<string> schedule, string lesson1, string lesson2)
        {
            if (schedule.Contains(lesson1) && schedule.Contains(lesson2))
            {
                int lesson1Index = schedule.IndexOf(lesson1);
                bool lesson1HaveExercise = lesson1Index < schedule.Count - 1 && schedule[lesson1Index + 1] == $"{lesson1}-Exercise";

                int lesson2Index = schedule.IndexOf(lesson2);
                bool lesson2HaveExercise = lesson2Index < schedule.Count - 1 && schedule[lesson2Index + 1] == $"{lesson2}-Exercise";

                string temp = schedule[lesson1Index];
                schedule[lesson1Index] = schedule[lesson2Index];
                schedule[lesson2Index] = temp;

                if (lesson1HaveExercise && lesson2HaveExercise)
                {
                    string ExerciseTemp = schedule[lesson1Index + 1];
                    schedule[lesson1Index + 1] = schedule[lesson2Index + 1];
                    schedule[lesson2Index + 1] = ExerciseTemp;
                    return;
                }

                else if (lesson1HaveExercise && !lesson2HaveExercise)
                {
                    if (lesson2Index == schedule.Count - 1)
                    {
                        schedule.Add(schedule[lesson1Index + 1]);
                        schedule.RemoveAt(lesson1Index + 1);
                        return;
                    }
                    else
                    {
                        schedule.Insert(lesson2Index + 1, schedule[lesson1Index + 1]);
                        if (lesson2Index < lesson1Index)
                        {
                            schedule.RemoveAt(lesson1Index + 2);
                            return;
                        }
                        else
                        {
                            schedule.RemoveAt(lesson1Index + 1);
                            return;
                        }
                    }
                }
                else if (!lesson1HaveExercise && lesson2HaveExercise)
                {
                    if (lesson1Index == schedule.Count - 1)
                    {
                        schedule.Add(schedule[lesson2Index + 1]);
                        schedule.RemoveAt(lesson2Index + 1);
                        return;
                    }
                    else
                    {
                        schedule.Insert(lesson1Index + 1, schedule[lesson2Index + 1]);
                        if (lesson1Index < lesson2Index)
                        {
                            schedule.RemoveAt(lesson2Index + 2);
                            return;
                        }
                        else
                        {
                            schedule.RemoveAt(lesson2Index + 1);
                            return;
                        }
                    }
                }
            }
        }
        static void RemoveLesson(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                string exercise = $"Exercise:{lesson}";
                schedule.Remove(lesson);
                schedule.Remove(exercise);
            }

        }
        static void InsertLesson(List<string> schedule, string lesson, int index)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Insert(index, lesson);
            }
        }
        static void AddLesson(List<string> schedule, string lesson)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
            }
        }
    }
}