using System;

namespace exercise_97
{
    public class Whistle 
    {
        private string sound;
       
        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }

        public void Sound()
        {
            Console.WriteLine(this.sound);
        }
    
    }


}