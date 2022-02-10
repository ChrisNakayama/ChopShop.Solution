using System;
using System.Collections.Generic;

namespace ChopShop.Models
{
  public class Service
  {
    public int Haircut { get; set; }
    public int MoustacheShampoo { get; set; }

    public Service(int haircut, int moustacheShampoo)
    {
      Haircut = haircut;
      MoustacheShampoo = moustacheShampoo;
    }
  }
}