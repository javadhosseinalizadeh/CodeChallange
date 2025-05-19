using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class WordGrouper
    {
        public static void GroupByFirstLetter(List<string> words)
        {
            if (words is null || words.Count == 0)
            {
                Console.WriteLine("No worlds provided.");
                return;
            }

            var grouped = words
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .GroupBy(w => char.ToLower(w[0]))
                .OrderBy(g => g.Key);

            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
            }
        }
    }
}
