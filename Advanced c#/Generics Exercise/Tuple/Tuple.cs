namespace Tuple
{
    public class Tuple<TFirstItem, TSecondItem>
    {
        public TFirstItem FirstElement { get; set; }
        public TSecondItem SecondElement { get; set; }

        public Tuple(TFirstItem firstItem, TSecondItem secondItem)
        {
            FirstElement = firstItem;
            SecondElement = secondItem;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
