namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            var ost100 = count % 100;
            var ost10 = ost100 % 10;

            if (ost10 == 1 && ost100 != 11) return "рубль";
            if (ost10 > 1 && ost10 < 5 && (ost100 < 12 || ost100 > 15)) 
                return "рубля";
            return "рублей";

        }
    }
}