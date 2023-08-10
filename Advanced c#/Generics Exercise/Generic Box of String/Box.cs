namespace Generic_Box_of_String
{
    public class Box<T>
    {
        public T Input { get; set; }

        public Box(T element)
        {
            Input = element;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Input}";
        }
    }
}
