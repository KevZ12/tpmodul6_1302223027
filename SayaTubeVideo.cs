using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tpmodul6_1302223027
{
    public class SayaTubeVideo
    {
        private int id;
        private string Title;
        private int playCount;

       

        public SayaTubeVideo(string title)
        {
            Contract.Assert(title.Length < 100);
            Contract.Assert(!string.IsNullOrEmpty(title));
            Random random = new Random();   
            this.Title = title;
            this.playCount = 0; 
            this.id = random.Next(10000, 100000);
        }
        public void  IncreasePlayCount (int playCount)
        {

            Contract.Assert(playCount <= 10_000_000);
           



            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            } catch (Exception ) {
                Console.WriteLine("angka melebihi batas maksimal integer");
            }
            
        }
        public void PrintVideoDetail()
        {
            Console.WriteLine("Id: "+this.id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
