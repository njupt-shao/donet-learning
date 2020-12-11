using System;

namespace PrototypePattern
{
    public class Attachment
    {
        public string Name { get; set; }
        public void Download()
        {
            Console.WriteLine("downloading file {0}", this.Name);
        }
    }
}