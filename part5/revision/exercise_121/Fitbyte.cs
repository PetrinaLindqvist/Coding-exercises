namespace exercise_121
{
    public class Fitbyte
    {
        private int age { get; set; }
        private int restingHeartRate { get; set; }
        
        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
        
        public double TargetHeartRate(double percentageOfMaximum)
        {
             double maxHeartRate = 206.3 - (0.711 * this.age);
             return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate; 
        }
        
        
        }
    }