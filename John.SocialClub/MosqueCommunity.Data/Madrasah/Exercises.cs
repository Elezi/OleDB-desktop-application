using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.Data.Madrasah
{
    enum ExerciseType
    {
        MultipleChoice = 1,
        ShortAnswers,
        Explanations,
        WithSoulutions,
        PracticalExercise
    }
   
    public class Exercise
    {
        ExerciseInfo Info;
        string exerciseQuestion;
        string exerciseSolution;
    }

    public class ExerciseInfo
    {
        LessonUnit lesonUnitExercise;
        ExerciseType type;
    }

}
