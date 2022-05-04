using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MyWebService myWebService = new localhost.MyWebService();
            myWebService.AddAsync(10,29);

        }
    }
}
