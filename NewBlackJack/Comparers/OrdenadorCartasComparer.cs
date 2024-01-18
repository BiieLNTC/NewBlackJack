namespace NewBlackJack.Comparers
{
    public class OrdenadorCartasComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            bool xIsNumeric = int.TryParse(x, out int xNumericValue);
            bool yIsNumeric = int.TryParse(y, out int yNumericValue);

            if (xIsNumeric && yIsNumeric)
            {
                // Ambos são numéricos, comparar numericamente de forma decrescente
                return yNumericValue.CompareTo(xNumericValue);
            }
            else if (xIsNumeric)
            {
                // Apenas x é numérico, colocar x antes
                return -1;
            }
            else if (yIsNumeric)
            {
                // Apenas y é numérico, colocar y antes
                return 1;
            }
            else
            {
                // Ambos são não numéricos, comparar lexicalmente de forma decrescente
                return string.Compare(y, x);
            }
        }
    }
}
