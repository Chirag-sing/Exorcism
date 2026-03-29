static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0){
            return 0.0;
        }
        else if(speed >= 1 && speed <= 4){
            return 1.0;
        }
        else if(speed >= 5 && speed <= 8){
            return 0.9;
        }
        else if(speed == 9){
            return 0.8;
        }
        return 0.77; 
    }
    
    public static double ProductionRatePerHour(int speed)
    {
      double rate = speed* 221 * SuccessRate(speed) ;
        return rate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
       int item = (int)(ProductionRatePerHour(speed) / 60);
        return item;
    }
}
