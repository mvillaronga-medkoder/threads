using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.commands
{
    public class LinearProcess
    {
        #region Members

        protected IDictionary<string, int> _results = null;

        #endregion


        #region Thead Interface

        public IDictionary<string, int> Results { get {return _results;} }

        public TimeSpan process(int sleep = 0)
        {
            //setup the timing
            TimeSpan ret = new TimeSpan(0);
            DateTime start = DateTime.Now;

            //set up the data
            DataPacket dp = new DataPacket();
            dp.reset();

            //set the up the loop and walk the text
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach(string sentence in dp.LotsOfText)
            {
                //split the sentence down and walk the words
                string[] words = sentence.Split(DataPacket.Delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    //update the counts in the hashtable
                    if (counts.ContainsKey(word))
                    {
                        int curCount = counts[word];
                        curCount++;
                        counts[word] = curCount;
                    }
                    else
                    {
                        counts.Add(word, 1);
                    }
                    Thread.Sleep(sleep);
                }
            }

            //get the end time and return the processing time
            DateTime end = DateTime.Now;
            ret = end - start;

            return ret;
        }

        #endregion

    }
}
