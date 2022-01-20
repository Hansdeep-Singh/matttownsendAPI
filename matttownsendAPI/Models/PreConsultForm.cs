using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace matttownsendAPI.Models
{
    sealed public class PreConsultForm
    {
        public Guid PreConsultFormId { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public UInt32 Phone { get; set; }
        public string Email { get; set; }
        public FitnessGoalsClass FitnessGoals { get; set; }
        public string Occupation { get; set; }
        public string ActivityLevel { get; set; }
        public bool Smoke { get; set; }
        public bool Drink { get; set; }
        public string Injuries { get; set; }
        public string Medical { get; set; }
        public bool GymMember { get; set; }
        public string HowLong { get; set; }
        public bool PersonalTraining { get; set; }
        public string PersonalTrainingExperience { get; set; }
        public bool TrainingSession { get; set; }
        public byte Stress { get; set; }
        public byte Sleep { get; set; }
        public byte Energy { get; set; }
        public byte Motivation { get; set; }
        public CurrentExerciseClass CurrentExercise { get; set; }
        

        public class CurrentExerciseClass
        {
            public MondayClass Monday { get; set; }
            public TuesdayClass Tuesday { get; set; }
            public WednesdayClass Wednesday { get; set; }
            public ThursdayClass Thursday { get; set; }
            public FridayClass Friday { get; set; }
            public SaturdayClass Saturday { get; set; }
            public SundayClass Sunday { get; set; }
        }

       


    }

    public class FitnessGoalsClass
    {
        public bool WeightLoss { get; set; }
        public bool Strength { get; set; }
        public bool BodyShape { get; set; }
        public bool Sports { get; set; }
        public bool Health { get; set; }
        public bool InjuryRecovery { get; set; }

    }

    public class MondayClass
    {
        public string MondayActivities { get; set; }
        public string MondayEffort { get; set; }
    }

    public class TuesdayClass
    {
        public string TuesdayActivities { get; set; }
        public string TuesdayEffort { get; set; }
    }

    public class WednesdayClass
    {
        public string WednesdayActivities { get; set; }
        public string WednesdayEffort { get; set; }
    }

    public class ThursdayClass
    {
        public string ThursdayActivities { get; set; }
        public string ThursdayEffort { get; set; }
    }

    public class FridayClass
    {
        public string FridayActivities { get; set; }
        public string FridayEffort { get; set; }
    }

    public class SaturdayClass
    {
        public string SaturdayActivities { get; set; }
        public string SaturdayEffort { get; set; }
    }

    public class SundayClass
    {
        public string SundayActivities { get; set; }
        public string SundayEffort { get; set; }
    }





}
