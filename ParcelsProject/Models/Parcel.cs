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

        public void SetLength(int length)
        {
            _length = length;
        }

        public int GetLength()
        {
            return _length;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public void SetTotalVolume(int volume)
        {
            _totalVolume = volume;
        }

        public int GetTotalVolume()
        {
            return _totalVolume;
        }

        public void SetCost(int cost)
        {
            _cost = cost;
        }

        public int GetCost()
        {
            return _cost;
        }

        public void CalculateVolume()
        {
            int volume = this.GetLength() * this.GetWidth() * this.GetHeight();
            this.SetTotalVolume(volume);
        }


    }
}
