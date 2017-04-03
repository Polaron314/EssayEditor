using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssayEditor
{
    class FileImporter
    {
        public FileImporter()
        {
            
        }

        public String[] readFile(String location)
        {
            return System.IO.File.ReadAllLines(location);
        }

        public String getEssayText()
        {
            return System.IO.File.ReadAllText("out.txt");
        }

        public Verb[] getVerbs()
        {
            String[] verbs = this.readFile("verbs.txt");
            Verb[] locs = new Verb[verbs.Length];
            for(int i = 0; i < verbs.Length; i++)
            {
                String[] split = verbs[i].Split(',');
                int sentence = Int32.Parse(split[0]);
                int start = Int32.Parse(split[1]);
                int end = Int32.Parse(split[2]);
                int length = end - start;
                start += this.sentenceStart(sentence);
                int voice = Int32.Parse(split[3]);
                int tense = Int32.Parse(split[4]);
                locs[i] = new Verb(start, length, voice, tense);
            }
            return locs;
        }

        public Pronoun[] getPronouns()
        {
            String[] prons = this.readFile("pronoun.txt");
            Pronoun[] pro = new Pronoun[prons.Length];
            for (int i = 0; i < prons.Length; i++)
            {
                String[] split = prons[i].Split(',');
                int sentence = Int32.Parse(split[0]);
                int start = Int32.Parse(split[1]);
                int end = Int32.Parse(split[2]);
                int length = end - start;
                start += this.sentenceStart(sentence);
                int person = Int32.Parse(split[3]);
                pro[i] = new Pronoun(start, length, person);
            }
            return pro;
        }

        private int sentenceStart(int sentence)
        {
            String[] verbs = this.readFile("marks.txt");
            return Int32.Parse(verbs[sentence]);
        }
    }
}
