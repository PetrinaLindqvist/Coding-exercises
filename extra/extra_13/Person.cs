namespace extra_13 
{
    public class Person 
    {

        public string name;
        public int age;
        

        public Person (string initialName) 
        {
            this.name = initialName;
            this.age = 0;
            
        }

        public int GrowOlder(int howMuch)
        {
              return this.age = this.age + howMuch;    
        }       
   
       
        public override string ToString () 
        {
            return this.name + ", " + "age " + this.age;
        }
    }
}
