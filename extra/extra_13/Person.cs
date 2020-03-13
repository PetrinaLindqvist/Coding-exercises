namespace extra_13 
{
    public class Person 
    {

        public string name;
        public int age;
        public string child;

        public Person (string initialName) 
        {
            this.name = initialName;
            this.age = 0;
            this.child = initialName;
        }

        public int GrowOlder(int howMuch)
        {
              return this.age = this.age + howMuch;    
        }       
   

       public string Person (child in kindergarten)
       {
           return this.child;
        
       }
       
        public override string ToString () 
        {
            return this.name + ", " + "age " + this.age;
        }
    }
}
