namespace exercise_123
{
    public class Counter
    {
        public int value { get; set; }

        public Counter(int startValue)
        {
            this.value = startValue;
        }
        public Counter()
        {
            this.value = 0;
        }
        public void Increase()
        {
            this.value++;
        }

        public void Decrease()
        {
            this.value--;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                this.value = this.value + increaseBy;
            }

        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value = this.value - decreaseBy;
            }
        }
        public override string ToString() { return  " " + this.value + " "; }
    }
}
