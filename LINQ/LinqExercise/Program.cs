using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeData trainee = new TraineeData();
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            System.Console.WriteLine("Menu:\nPress 1 to Show the list of Trainee Id\nPress 2 to Show the first 3 Trainee Id using Take\nPress 3 to show the last 2 Trainee Id using Skip\nPress 4 to show the count of Trainee\nPress 5 to show the Trainee Name who are all passed out 2019 or later\nPress 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.\nPress 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark\nPress 8 to show the unique passed out year using distinct\nPress 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message\nPress 10 to show the first Trainee Id and Trainee Name\nPress 11 to show the last Trainee Id and Trainee Name\nPress 12 to print the total score of each trainee\nPress 13 to show the maximum total score\nPress 14 to show the minimum total score\nPress 15 to show the average of total score\nPress 16 to show true or false if any one has the more than 40 score using any()\nPress 17 to show true of false if all of them has the more than 20 using all()\nPress 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.");
            string wish = "yes";
            while(wish != "no"){
                System.Console.Write("Enter your option: ");
                string option = Console.ReadLine();
                switch(option){
                    case "1":{
                        IEnumerable<string> traineeDatas = from train in trainee.GetTraineeDetails() select train.TraineeId;
                        System.Console.WriteLine("Trainee IDs are: ");
                        foreach (string trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        // IEnumerable<TraineeData> trainees = from trainee in TraineeData.GetAll
                        break;
                    }
                    case "2":{
                        IEnumerable<string> traineeDatas = (from train in trainee.GetTraineeDetails() select train.TraineeId).Take(3);
                        System.Console.WriteLine("First 3 Trainee IDs are: ");
                        foreach (string trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        break;
                    }
                    case "3":{
                        IEnumerable<string> traineeDatas = (from train in trainee.GetTraineeDetails() select train.TraineeId).Skip((trainee.GetTraineeDetails().Count)-2);
                        System.Console.WriteLine("Last 2 Trainee IDs are: ");
                        foreach (string trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        break;
                    }
                    case "4":{
                        int Count = (from train in trainee.GetTraineeDetails() select train.TraineeId).Count();
                        System.Console.WriteLine("The Count of trainees is: "+Count);
                        break;
                    }
                    case "5":{
                        IEnumerable<string> traineeDatas = from train in trainee.GetTraineeDetails() where train.YearPassedOut>=2019 select train.TraineeName;
                        System.Console.WriteLine("The Trainee Name who are all passed out 2019 or later are: ");
                        foreach (string trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        break;
                    }
                    case "6":{
                        var traineeDatas = from train in trainee.GetTraineeDetails() orderby train.TraineeName select new{train.TraineeId,train.TraineeName};
                        System.Console.WriteLine("The Trainee Name who are all passed out 2019 or later are: ");
                        foreach (var trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        break;
                    }
                    case "7":{
                        var traineeDatas = trainee.GetTraineeDetails().SelectMany(train => train.ScoreDetails.Where(score => score.Mark >= 4).Select(score =>new {train.TraineeId, train.TraineeName, score.TopicName, score.ExerciseName, score.Mark}));
                        System.Console.WriteLine("The Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark are:");
                        foreach(var data in traineeDatas){
                            System.Console.WriteLine($"Trainee ID: {data.TraineeId},   Trainee Name: {data.TraineeName},   Topic Name: {data.TopicName},  Exercise Name: {data.ExerciseName},  Mark: {data.Mark}");
                        }
                        break;
                    }
                    case "8":{
                        IEnumerable<int> traineeDatas = (from train in trainee.GetTraineeDetails() select train.YearPassedOut).Distinct();
                        System.Console.WriteLine("The unique passed out year using distinct are: ");
                        foreach (int trainee1 in traineeDatas)
                        {
                            System.Console.WriteLine(trainee1);
                        }
                        break;
                    }
                    case "9":{
                        System.Console.Write("Enter Trainee ID: ");
                        string id = Console.ReadLine();
                        var traineeDatas = from train in trainee.GetTraineeDetails() where train.TraineeId == id select train.ScoreDetails;
                        if(traineeDatas == null){
                            System.Console.WriteLine("Invalid ID");
                            return;
                        }
                        List<LinqExercise.TraineeScore> value = new List<TraineeScore>();
                        foreach(var score in traineeDatas)
                        {
                            value = score;
                        }
                        int TotalScore = 0;
                        foreach(LinqExercise.TraineeScore i in value){
                            TotalScore+=i.Mark;
                        }
                        System.Console.WriteLine("The Total score of "+id+" is: "+TotalScore);
                        break;
                    }

                    case "10":{
                        var firstID = (from train in trainee.GetTraineeDetails() select new {train.TraineeId, train.TraineeName}).First();
                        System.Console.WriteLine($"The First Trainee ID is {firstID.TraineeId} and name is {firstID.TraineeName}");
                        break;
                    }
                    case "11":{
                        var LastID = (from train in trainee.GetTraineeDetails() select new {train.TraineeId, train.TraineeName}).Last();
                        System.Console.WriteLine($"The Last Trainee ID is {LastID.TraineeId} and name is {LastID.TraineeName}");
                        break;
                    }

                    case "12":{
                        var traineeDatas = from train in trainee.GetTraineeDetails() select new {train.TraineeId,train.ScoreDetails};
                        foreach(var score in traineeDatas){
                            int total = 0;
                            for(int i=0;i<score.ScoreDetails.Count;i++){
                                total+=score.ScoreDetails[i].Mark;
                            }
                            System.Console.WriteLine($"The Score of {score.TraineeId} is {total}");
                        }
                        break;
                    }
                    case "13":{
                        var traineeDatas = from train in trainee.GetTraineeDetails() select new {train.TraineeId,train.ScoreDetails};
                        int  highScore = 0;
                        foreach(var score in traineeDatas){
                            int total = 0;
                            for(int i=0;i<score.ScoreDetails.Count;i++){
                                total+=score.ScoreDetails[i].Mark;
                            }
                            if(total>highScore){
                                highScore = total;
                            }
                        }
                        System.Console.WriteLine($"The Highest Score is {highScore}");
                        break;
                    }

                    case "14":{
                        var traineeDatas = from train in trainee.GetTraineeDetails() select new {train.TraineeId,train.ScoreDetails};
                        int lowScore = 0;
                        bool flag = false;
                        foreach(var score in traineeDatas){
                            int total = 0;
                            for(int i=0;i<score.ScoreDetails.Count;i++){
                                total+=score.ScoreDetails[i].Mark;
                                if(flag == false){
                                    lowScore += score.ScoreDetails[i].Mark;
                                }
                            }
                            flag = true;
                            
                            if(total<lowScore){
                                lowScore = total;
                            }
                        }
                        System.Console.WriteLine($"The Lowest Score is {lowScore}");
                        break;
                    }
                    case "15":{
                        var traineeDatas = trainee.GetTraineeDetails().Average(train => train.ScoreDetails.Sum(score =>score.Mark));
                        System.Console.WriteLine("The Average score is :"+traineeDatas);
                        break;
                    }
                    case "16":{
                        var traineeDatas = trainee.GetTraineeDetails().Any(train => train.ScoreDetails.Sum(score =>score.Mark)>40);
                        System.Console.Write("Any one has the more than 40 score using any(): "); System.Console.Write(traineeDatas);
                        break;
                    }
                    case "17":{
                        var traineeDatas = trainee.GetTraineeDetails().All(train => train.ScoreDetails.Sum(score =>score.Mark)>20);
                        System.Console.WriteLine("All of them has the more than 20 using all(): "); System.Console.Write(traineeDatas);
                        break;
                    }
                    case "18":{
                        var traineeDatas = trainee.GetTraineeDetails().SelectMany(train => train.ScoreDetails.Select(score => new {train.TraineeId, train.TraineeName, score.TopicName, score.ExerciseName, score.Mark})).OrderByDescending(name =>name.TraineeName).ThenByDescending(mark=>mark.Mark);
                        foreach(var item in traineeDatas){
                            System.Console.WriteLine($"Trainee ID: {item.TraineeId},   Trainee Name: {item.TraineeName},    Topic Name: {item.TopicName},    Exercise Name: {item.ExerciseName},    Mark: {item.Mark}");
                        }
                        break;
                    }
                }
                System.Console.Write("Do you want to continue[yes/no]");
                wish = Console.ReadLine().ToLower();
            }
        }
    }
}