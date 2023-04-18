using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AprelTAskClass
{
    internal class Group
    {
        private static int _id;
        public int Id { get;set; }
        public string GroupName { get; set; }

        public Group(string nameGroup)
        {
            _id++;
            Id = _id;
            GroupName = nameGroup;
        }
    }
}
