using System.Collections.Generic;

namespace PlacesBeen.Models
{
    public class Place
    {
        private string _location;
        private int _id;

        private static List<Place> _placeInstances = new List<Place> {};

        public Place(string location = "")
        {
            _location = location;
            _placeInstances.Add(this);
            _id = _placeInstances.Count;
        }

        // Get Setters

        public string GetLocation()
        {
            return _location;
        }
        public void SetLocation(string newLocation)
        {
            _location = newLocation;
        }
        public int GetId()
        {
            return _id;
        }
        public static List<Place> GetAll()
        {
            return _placeInstances;
        }
        public static Place Find(int searchId)
        {
            return _placeInstances[searchId - 1];
        }
    }
}
