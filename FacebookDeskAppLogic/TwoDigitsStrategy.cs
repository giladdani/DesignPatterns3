namespace FacebookDeskAppLogic
{
    internal class TwoDigitsStrategy : IStrategy
    {
        public bool TestNumber(int i_Num)
        {
            return i_Num >= 10 && i_Num < 100;
        }
    }
}
