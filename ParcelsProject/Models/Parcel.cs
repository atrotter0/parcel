using System;
using System.Collections.Generic;

namespace ParcelsProject.Models
{
    public class Parcel
    {
        private string _sender;
        private int _length;
        private int _width;
        private int _height;
        private int _weight;
        private int _totalVolume;
        private int _cost;

        public void SetSender(string name)
        {
            _sender = name;
        }

        public string GetSender()
        {
            return _sender;
        }
    }
}
