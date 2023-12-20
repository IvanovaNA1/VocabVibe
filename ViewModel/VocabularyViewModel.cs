using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabVibe.Model;
using System.IO;

namespace VocabVibe.ViewModel
{
    public class VocabularyViewModel : Notify
    {
        public ObservableCollection<VocabWords> Words { get; set; }
        public ObservableCollection<VocabWords> WordsK { get; set; }
        public VocabularyViewModel()
        {
            Words = new ObservableCollection<VocabWords>();
            WordsK = new ObservableCollection<VocabWords>();
            try
            {
                string[] lines = File.ReadAllLines("C:\\Users\\Надежда\\Source\\Repos\\VocabVibe\\Files\\Vocab.txt");

                foreach (string line in lines)
                {
                    var tempArr = line.Split(':');
                    if (tempArr.Length >= 2)
                    {
                        Words.Add(new VocabWords { Word = tempArr[0], Definition = tempArr[1] });
                    }
                }

                string[] linesK = File.ReadAllLines("C:\\Users\\Надежда\\Source\\Repos\\VocabVibe\\Files\\VocabTrue.txt");
                foreach (string line in linesK)
                {
                    var tempArr = line.Split(':');
                    if (tempArr.Length >= 2)
                    {
                        WordsK.Add(new VocabWords { Word = tempArr[0], Definition = tempArr[1] });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}

