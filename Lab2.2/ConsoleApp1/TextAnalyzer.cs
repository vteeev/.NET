using System;
using System.Collections.Generic;
using System.Linq;

namespace Consol_APP
{
    public class TextAnalyzer
    {
        public static int LiczbaZnakowZeSpacjami(string text) => text.Length;

        public static int LiczbaZnakowBezSpacji(string text) => text.Count(c => !char.IsWhiteSpace(c));

        public static int LiczbaCyfr(string text) => text.Count(char.IsDigit);

        public static int LiczbaLiter(string text) => text.Count(char.IsLetter);

        public static int LiczbaSlow(string text) => text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

        public static int LiczbaUnikalnychSlow(string text) =>
            text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.ToLower())
                .Distinct()
                .Count();

        public static string NajczesciejWystepujaceSlowo(string text)
        {
            var slowa = text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var grupowanie = slowa.GroupBy(s => s.ToLower()).OrderByDescending(g => g.Count()).FirstOrDefault();

            return grupowanie != null ? $"{grupowanie.Key} ({grupowanie.Count()} razy)" : "Brak słów w tekście";
        }

        public static double SredniaDlugoscSlow(string text)
        {
            var slowa = text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return slowa.Length > 0 ? slowa.Average(s => s.Length) : 0;
        }


        public static (string najkrotsze, string najdluzsze) NajkrotszeNajdluzszeSlowo(string text)
        {
            var slowa = text.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            if (slowa.Length == 0) return ("Brak słów", "Brak słów");

            string najkrotsze = slowa.OrderBy(s => s.Length).First();
            string najdluzsze = slowa.OrderByDescending(s => s.Length).First();

            return (najkrotsze, najdluzsze);
        }

        public static int LiczbaZdan(string text) => text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        public static double SredniaLiczbaSlowNaZdanie(string text)
        {
            var zdania = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return zdania.Length > 0 ? zdania.Average(z => z.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length) : 0;
        }


        public static int NajdluzszeZdanie(string text)
        {
            var zdania = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return zdania.Length > 0 ? zdania.Max(z => z.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length) : 0;
        }


        public static int LiczbaZnakowInterpunkcyjnych(string text) =>
            text.Count(c => char.IsPunctuation(c));
    }
}
