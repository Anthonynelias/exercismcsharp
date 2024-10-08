using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCougitnt(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdPerDay in this.birdsPerDay){
            if(birdPerDay == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays ; i++){
            count += this.birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int birdPerDay in this.birdsPerDay){
            if(birdPerDay >= 5){
                busyDays++;
            }
        }
        return busyDays;
    }
}