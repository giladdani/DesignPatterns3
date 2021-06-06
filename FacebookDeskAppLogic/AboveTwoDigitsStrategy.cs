namespace FacebookDeskAppLogic
{
    internal class AboveTwoDigitsStrategy : IStrategy
    {
        public bool TestNumber(int i_Num)
        {
            return i_Num >= 100;
        }
    }
}
