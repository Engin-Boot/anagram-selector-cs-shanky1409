using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            if(word1.Length==word2.Length)
            {
                var word1arr = word1.ToCharArray();
                var word2arr = word2.ToCharArray();
                Array.Sort(word1arr);
                Array.Sort(word2arr);
                if(new String(word1arr)== new String(word2arr))
                    return true;   
            }
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            var anagrams = new List<string>();
            foreach(var word2 in candidates)
            {
                if(WordPairIsAnagram(word, word2))
                    anagrams.Add(word2);
            }
            return anagrams;
        }
    }
}
