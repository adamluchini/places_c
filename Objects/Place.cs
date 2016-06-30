using System;
using System.Collections.Generic;

namespace PlaceApp.Objects
{
  public class Place
  {
    private string _description;
    private int _id;
    private static List<Place> _places = new List<Place> {};

    public Place(string description)
    {
      _description = description;

      _places.Add(this);
      _id = _places.Count;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string description)
    {
      _description = description;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _places;
    }

    
    public static Place Find(int searchId)
    {
      return _places[searchId - 1];
    }

  }
}
