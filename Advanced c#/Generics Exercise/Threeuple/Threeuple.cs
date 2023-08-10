namespace Threeuple
{
    public class Threeuple<TFirstItem, TSecondItem, TThirdItem>
    {
        public TFirstItem FirstElement { get; set; }
        public TSecondItem SecondElement { get; set; }

        public TThirdItem ThirdElement { get; set; }

        public Threeuple(TFirstItem firstItem, TSecondItem secondItem, TThirdItem thirdItem)
        {
            FirstElement = firstItem;
            SecondElement = secondItem;
            ThirdElement = thirdItem;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }

    }
}
