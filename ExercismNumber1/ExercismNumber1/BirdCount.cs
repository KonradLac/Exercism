using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismNumber1
{
    internal class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }
        public static int[] LastWeek()
        {
            return [0, 2, 5, 3, 7, 8, 4];
        }
        public int Today()
        {
            return birdsPerDay[^1];
        }
        public void IncrementTodaysCount()
        {
            birdsPerDay[^1]++;
        }
        public bool HasDayWithoutBirds()
        {
            return birdsPerDay.Contains(0);
        }
        public int CountForFirstDays(int numberOfDays)
        {
            int sum = default;
            foreach (int day in birdsPerDay[0..numberOfDays])
            {
                sum += day;
            }
            return sum;
        }
        public int BusyDays()
        {
            int count = default;
            foreach (int day in birdsPerDay)
            {
                if (day >= 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
