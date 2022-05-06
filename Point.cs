namespace Course
{
    struct Point 
    {
       public double x;
       public double y;

        public override string ToString()
        {
            return "("+ x + ", " + y + ")";
        }
    }
}