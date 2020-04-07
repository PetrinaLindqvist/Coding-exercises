using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> storages;
    
    public StorageFacility()
    {
      this.storages = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
       if (!this.storages.ContainsKey(unit)) 
      {
        this.storages.Add(unit, new List<string>());
      }
      this.storages[unit].Add(item);
    }

    public List<string> Contents(string storageUnit)
    {
      if (!this.storages.ContainsKey(storageUnit))
      {
       this.storages.Add(storageUnit, new List<string>());
      }
      return this.storages[storageUnit];
    }

    public void Remove(string storageUnit, string item)
    {
      this.storages[storageUnit].Remove(item);
      if (this.storages[storageUnit].Count == 0) 
      {
        this.storages.Remove(storageUnit);
      }
    }

    public List<string> StorageUnits()
    {
      List<string> listStorages = new List<string>();
      Dictionary<string, List <string>>.KeyCollection key = this.storages.Keys;
      foreach (string storages in key)
      {
        listStorages.Add(storages);
      }
      return listStorages;
    }
  }
}