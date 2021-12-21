using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            IRacer winner;

            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return $"Race cannot be completed because both racers are not available!";
            }

            if (!racerTwo.IsAvailable())
            {
                winner = racerOne;
                return $"{winner.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else if (!racerOne.IsAvailable())
            {
                winner = racerTwo;
                return $"{winner.Username} wins the race! {racerOne.Username} was not available to race!";
            }
           

            racerOne.Race();
            racerTwo.Race();

            double behaviorMultiplier = 0;
            if (racerOne.RacingBehavior=="strict")
            {
                behaviorMultiplier = 1.2;
            }
            else if (racerOne.RacingBehavior == "aggressive")
            {
                behaviorMultiplier = 1.1;
            }

            var racerOneChanceOfWinning = racerOne.Car.HorsePower * racerOne.DrivingExperience * behaviorMultiplier;
            var racerTwoChanceOfWinning = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * behaviorMultiplier;

            if (racerOneChanceOfWinning>racerTwoChanceOfWinning)
            {
                winner = racerOne;
            }
            else
            {
                winner = racerTwo;
            }

            return $"{racerOne.Username} has just raced against {racerTwo.Username}! {winner.Username} is the winner!";
        }
    }
}
