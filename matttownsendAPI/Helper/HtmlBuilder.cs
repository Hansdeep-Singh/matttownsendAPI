using matttownsendAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace matttownsendAPI.Helper
{
    public static class HtmlBuilder
    {
        public static string ModelToHtml(PreConsultForm pcf)
        {
            string smoke = pcf.Smoke ? "I smoke" : "I don't smoke";
            string drink = pcf.Drink ? "I drink" : "I don't drink";
            string gymmember = pcf.GymMember ? "Yes" : "No";
            string personalTrainingThought = pcf.TrainingSession? "Yes" : "No";
            string personaltraining = pcf.PersonalTraining ? "Yes" : "No";
            List<string> fitnessGoalsList = new List<string>();
            fitnessGoalsList.Add(pcf.FitnessGoals.Health?"Health":null);
            fitnessGoalsList.Add(pcf.FitnessGoals.InjuryRecovery ? "Injury Recovery" : null);
            fitnessGoalsList.Add(pcf.FitnessGoals.Sports ? "Sports" : null);
            fitnessGoalsList.Add(pcf.FitnessGoals.Strength ? "Strength" : null);
            fitnessGoalsList.Add(pcf.FitnessGoals.WeightLoss ? "Weight Loss" : null);
            string fitnessGoals = string.Join(",", fitnessGoalsList);


            string ifPersonalTrainingHtml = pcf.PersonalTraining ?
                "<tr>" +
                "<td><b>Applicant's experience with a personal trainer before:</b> &nbsp; </td>" +
                $"<td>{pcf.PersonalTrainingExperience}</td>" +
                "</tr>" : "";

            string ifGymMemberHtml = pcf.GymMember ? 
                "<tr>" +
                "<td><b>The applicant was gym member for:</b> &nbsp; </td>" +
                $"<td>{pcf.HowLong}</td>" +
                "</tr>" : "";

            return $"<h1>Pre-consult Form from {pcf.Name}</h1>" +
          "<table>" +
            "<tr>" +
                "<td><h1>GENERAL INFO</h1></td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Name:</b> &nbsp; </td>" +
                $"<td>{pcf.Name}</td>" +
            "</tr>" +
             "<tr>" +
                "<td><b>Phone number:</b> &nbsp; </td>" +
                $"<td>{pcf.Phone}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Date of birth:</b> &nbsp; </td>" +
                $"<td>{pcf.Dob}</td>" +
            "</tr>"+
            "<tr>" +
                "<td><b>Email address:</b> &nbsp; </td>" +
                $"<td>{pcf.Email}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Primary health and fitness goal: </b> &nbsp; </td>" +
                $"<td>{fitnessGoals}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><h1>LIFESTYLE</h1></td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Occupation</b> &nbsp; </td>" +
                $"<td>{pcf.Occupation}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Activity Level</b> &nbsp; </td>" +
                $"<td>{pcf.ActivityLevel}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Smoking</b> &nbsp; </td>" +
                $"<td>{smoke}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Drinking</b> &nbsp; </td>" +
                $"<td>{drink}</td>" +
            "</tr>" +

             "<tr>" +
                "<td><h1>INJURIES / MEDICATIONS</h1></td>" +
            "</tr>" +
           
            "<tr>" +
                "<td><b>Significant medical conditions or injuries:</b> &nbsp; </td>" +
                $"<td>{pcf.Injuries}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Current medical conditions or injuries:</b> &nbsp; </td>" +
                $"<td>{pcf.Medical}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><h1>EXERCISE EXPERIENCE</h1></td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Has the applicant been a member of a gym in the past?:</b> &nbsp; </td>" +
                $"<td>{gymmember}</td>" +
            "</tr>" +
            $"{ifGymMemberHtml}"+
            "<tr>" +
                "<td><b>Has the applicant has personal training before? :</b> &nbsp; </td>" +
                $"<td>{personaltraining}</td>" +
            "</tr>" +
            $"{ifPersonalTrainingHtml}" +
            "<tr>" +
                "<td><b>Has the applicant thought about doing personal training sessions before? :</b> &nbsp; </td>" +
                $"<td>{personalTrainingThought}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Scale 1-10 for Stress:</b> &nbsp; </td>" +
                $"<td>{pcf.Stress}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Scale 1-10 for Sleep:</b> &nbsp; </td>" +
                $"<td>{pcf.Sleep}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Scale 1-10 for EnergyLevel:</b> &nbsp; </td>" +
                $"<td>{pcf.Energy}</td>" +
            "</tr>" +
            "<tr>" +
                "<td><b>Scale 1-10 for Motivation:</b> &nbsp; </td>" +
                $"<td>{pcf.Motivation}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><h2>Describe your current exercise routine:</h2></td>" +
            "</tr>" +
            "<h1></h1>" +
            "<tr>" +
                "<td><b>Monday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Monday.MondayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Monday.MondayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Tuesday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Tuesday.TuesdayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Tuesday.TuesdayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Wednesday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Wednesday.WednesdayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Wednesday.WednesdayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Thursday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Thursday.ThursdayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Thursday.ThursdayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Friday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Friday.FridayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Friday.FridayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Saturday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Saturday.SaturdayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Saturday.SaturdayEffort}</td>" +
            "</tr>" +
              "<tr>" +
                "<td><b>Sunday</b> &nbsp; </td>" +
                $"<td>Activities: {pcf.CurrentExercise.Sunday.SundayActivities}</td>" +
                 $"<td>Efforts: {pcf.CurrentExercise.Sunday.SundayEffort}</td>" +
            "</tr>" +
         "</table>";
        }
    }
}
