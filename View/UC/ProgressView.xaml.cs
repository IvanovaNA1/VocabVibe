using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace VocabVibe.View
{
    public partial class ProgressView : UserControl
    {
        public ProgressView()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("C:\\Users\\Надежда\\Source\\Repos\\VocabVibe\\Files\\VocabTrue.txt");
            int numberOfLines = lines.Length;
            CountK.Text = (numberOfLines/2).ToString();

            string[] Dlines = File.ReadAllLines("C:\\Users\\Надежда\\Source\\Repos\\VocabVibe\\Files\\Vocab.txt");
            int numberOfDLines = Dlines.Length;
            CountDK.Text = (numberOfDLines/2).ToString();
        }
    }
}
