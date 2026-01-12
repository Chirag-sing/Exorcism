class Lasagna
{
     public int ExpectedMinutesInOven(){
       return 40;  
     } 

    public int RemainingMinutesInOven(int MinutesInOven){
        return ExpectedMinutesInOven() - MinutesInOven;
    }

    public int PreparationTimeInMinutes(int numberofLayers){
        return numberofLayers * 2;
    }

    public int ElapsedTimeInMinutes(int numberofLayers, int MinutesInOven){
        return PreparationTimeInMinutes(numberofLayers) + MinutesInOven;
    }
}
