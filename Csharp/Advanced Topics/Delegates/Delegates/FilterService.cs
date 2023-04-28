namespace Delegates
{
    public class FilterService
    {

        //public delegate bool Criteria(int number);
        public List<int> Filter(List<int> numbers, Func<int, bool> criteria)
        {
            List<int> result = new();
            foreach (var number in numbers)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

    }
}
