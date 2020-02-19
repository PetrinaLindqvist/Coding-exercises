namespace exercise_120
{
    public class Cube
    {
        private int edgeLength { get; set; }
        
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
            
        }
        public int Volume()
        {
            return this.edgeLength = edgeLength * edgeLength * edgeLength;
        }
        
        public override string ToString()
        {
            return"The length of the edge is " + this.edgeLength + " and the volume "  + this.Volume();
        }
    }

}