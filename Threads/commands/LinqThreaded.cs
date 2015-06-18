using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.commands
{
    public class LinqThreaded
    {
        #region Members

        protected IDictionary<string, int> _results = null;

#if DEBUG 
        protected int _maxParalellism = 1;
#else
        protected int _maxParalellism = 4;
#endif

        #endregion

        #region Thead Interface

        public IDictionary<string, int> Results { get { return _results; } }

        public TimeSpan process(int maxPar = 1)
        {
            //setup the timing
            TimeSpan ret = new TimeSpan(0);
            DateTime start = DateTime.Now;

            //set up the data
            DataPacket dp = new DataPacket();
            dp.reset();

            //set the up the loop and walk the text
            ConcurrentDictionary<string, int> counts = new ConcurrentDictionary<string, int>();

            dp.LotsOfText
                .AsParallel()
                .WithDegreeOfParallelism(maxPar)
                .ForAll(
                    sentence => {
                        //split the sentence down and walk the words
                        string[] words = sentence.Split(DataPacket.Delimiters, StringSplitOptions.RemoveEmptyEntries);

                        words
                        .AsParallel()
                        .WithDegreeOfParallelism(maxPar)
                        .ForAll(
                            word =>
                            {
                                //update the counts in the hashtable
                                counts.AddOrUpdate(word, 1, (wrd, oldVal) => oldVal + 1);
                                Thread.Sleep(10);
                            });
                    });

            //get the end time and return the processing time
            DateTime end = DateTime.Now;
            ret = end - start;

            return ret;
        }

        #endregion
    }
}